using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DojoActivity.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DojoActivity.Controllers
{
    public class DojoController : Controller
    {
        // INJECTIONS
        private DojoContext dbContext;

        // here we can "inject" our context service into the constructor
        public DojoController(DojoContext context)
        {
            dbContext = context;
        }
        // inject the active user in session
        public User ActiveUser
        {
            get{return dbContext.UserTable.Where(u => u.UserId == HttpContext.Session.GetInt32("d")).FirstOrDefault();}
        }


// GET: /Register Render/
        [HttpGet]
        [Route("/")]
        public IActionResult RegisterView()
        {
            return View();
        }


// POST: /Register Process/
        [HttpPost]
        [Route("/registerprocess")]
        public IActionResult RegisterProcess(User user)
        {
            if (ModelState.IsValid)
            {
                var dbuser = dbContext.UserTable.FirstOrDefault(u => u.Email == user.Email);
                if(dbContext.UserTable.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");    
                    return View("RegisterView");                
                }
                // password hasher
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                // saving in db
                
                dbContext.Add(user);
                dbContext.SaveChanges();
                // setting stuff in session
                HttpContext.Session.SetInt32("UserID", user.UserId);
                // 
                HttpContext.Session.SetString("Firstname", user.FirstName);
                HttpContext.Session.SetString("Lastname", user.LastName);
                
                return RedirectToAction("Dashboard");
            }
            return View("RegisterView");
        }


// GET: /Login Render/
        [HttpGet]
        [Route("/login")]
        public IActionResult LoginView()
        {
            return View();
        }


// POST: /Login Process/
        [HttpPost]
        [Route("/loginprocess")]
        public IActionResult LoginProcess(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                // checks if the email submitted is already registered in DB
                var dbuser = dbContext.UserTable.FirstOrDefault(u => u.Email == user.Email);
                if(dbuser == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password!");    
                    return View("LoginView");                
                }
                // checks if password submitted matches with the DB password
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, dbuser.Password, user.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Email/Password!");
                    return View("LoginView");
                }
                // set id in session
                HttpContext.Session.SetInt32("UserID", dbuser.UserId);
                // set name in session
                HttpContext.Session.SetString("Firstname", dbuser.FirstName);
                HttpContext.Session.SetString("Lastname", dbuser.LastName);
                return RedirectToAction("Dashboard");
            }
            return View("LoginView");
        }


// GET: /Add Activity Render/
        [HttpGet]
        [Route("/addactivity")]
        public IActionResult AddActivity()
        {
            ViewBag.UserID = HttpContext.Session.GetInt32("UserID");
            ViewBag.creator = $"{HttpContext.Session.GetString("FirstName")}{HttpContext.Session.GetString("LastName")}";
            
            return View();
        }


// POST: /Create Activity Process/
        [HttpPost]
        [Route("/createprocess")]
        public IActionResult CreateProcess(ActivityModel actform)

        {
            if (ModelState.IsValid)
            {
                // no past date
                if (actform.Date<=DateTime.Now)
                {
                    ModelState.AddModelError("Date", "Please choose a future date.");
                    return View("AddActivity");
                }
                
                // getting user from session by ID for form submission????
                // actform.UserId = (int)HttpContext.Session.GetInt32("UserID");

                // saving activity in db
                dbContext.Add(actform);
                dbContext.SaveChanges();

                // getting user from session by ID and putting it in the viewbag
                ViewBag.users = dbContext.UserTable;

                return RedirectToAction("Dashboard");
            }
            return View("AddActivity");
        }


// GET: /renders the SHOW Activity page/
        [HttpGet]
        [Route("/activity/{id}")]
        public IActionResult ShowActivity(int id)
        {
            // checks user in session
            if (HttpContext.Session.GetInt32("UserID") == null)
            {
                return RedirectToAction ("Login");
            }

            var currAct = dbContext.ActTable
                .Include(c=>c.Coordinator)
                .Include(w=>w.participant)
                    .ThenInclude(s=>s.User)
                .SingleOrDefault(a => a.ActId == id);
            
            ViewBag.show = currAct;
            return View();
        }


// POST: /Join
        [HttpPost]
        [Route("/join")]
        public IActionResult JOIN(Participants participantform)
        {
            dbContext.Add(participantform);
            dbContext.SaveChanges();
            return RedirectToAction ("Dashboard");
        }


// GET / Un-Join
        [HttpGet]
        [Route("/unjoin/{actId}")]
        public IActionResult UNJOIN(int actId)
        {
            var Actformdb = dbContext.Participant
                .SingleOrDefault(a => a.ActId == actId && a.UserId == HttpContext.Session.GetInt32("UserID"));
            dbContext.Remove(Actformdb);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

// GET / Delete Activity
        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult DeleteActivity(int id)
        {
            // checks user in session
            if(HttpContext.Session.GetInt32("UserID") == null)
            {
                return RedirectToAction("Login");
            }
            ActivityModel deleteact = dbContext.ActTable
                .SingleOrDefault(d => d.ActId == id);
            dbContext.ActTable.Remove(deleteact);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }


// GET: /renders the DASHBOARD page/
        [HttpGet]
        [Route("/dashboard")]
        public IActionResult Dashboard()
        {
            // check user in session
            if(HttpContext.Session.GetInt32("UserID") == null)
            {
                return RedirectToAction("Login");
            }

            // set user in session in the viewbag
            int? UserID = HttpContext.Session.GetInt32("UserID");
            ViewBag.UserID = HttpContext.Session.GetInt32("UserID");

            ViewBag.fname = HttpContext.Session.GetString("Firstname");
            ViewBag.lname = HttpContext.Session.GetString("Lastname");
            

            // make a list of activities with all of each's respective participants
            List<ActivityModel> activitieswithparticipants = dbContext.ActTable
                .Include(i=>i.Coordinator)
                .Include(w => w.participant)
                    .ThenInclude(s=>s.User)
                .ToList();
            // get name from session
            ViewBag.allacts = activitieswithparticipants;
            return View();
        }


// GET: /Logout and clear session/
        [HttpGet]
        [Route("/logout")]
        public IActionResult Logout()
        {
            // clear session
            HttpContext.Session.Clear();
            return View("LoginView");
        }
    }
}
