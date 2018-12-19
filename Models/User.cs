using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DojoActivity
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

// FIRST NAME
        [Required (ErrorMessage="First Name is Required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name must contain only letters")]

        public string FirstName {get;set;}

// LAST NAME
        [Required (ErrorMessage="Last Name is Required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name must contain only letters")]

        public string LastName {get;set;}

// EMAIL
        [Required (ErrorMessage="Email is Required")]
        [EmailAddress]
        public string Email {get;set;}

// PASSWORD
        [DataType(DataType.Password)]
        [Required (ErrorMessage="Password is Required")]
        [MinLength (3, ErrorMessage="Password must be at least 3 characters long!")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&./\|'])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage = "Password must contain at least one letter, one special character, and one number.")]
        public string Password {get;set;}

// CONFIRM PASSWORD
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPW {get;set;}

// CREATED/UPDATED
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;


// CONNECTING A LIST OF ALL ACTIVITIES AND PARTICIPANTS
        public List<Participants> participant {get;set;}
    }
}