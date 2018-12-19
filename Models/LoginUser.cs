using System.ComponentModel.DataAnnotations;

namespace DojoActivity
{
    public class LoginUser
    {
        // No other fields!
        [Required (ErrorMessage="Email is Required.")]
        public string Email {get; set;}
        [Required (ErrorMessage="Password is Required.")]
        public string Password { get; set; }
    }
}