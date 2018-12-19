using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DojoActivity
{
    public class ActivityModel
    {
        [Key]
        public int ActId {get;set;}
        [Required]
        [MinLength (3, ErrorMessage="Title must have at least 3 characters.")]
        public string Title {get;set;}
        [Required]
        public DateTime Time {get;set;}
        [Required]
        public DateTime Date {get;set;}
        [Required]
        [RegularExpression(@"^(?:\d|[,\.])+$", ErrorMessage = "Must choose a positive number.")]
        public string Duration {get;set;}
        [Required]
        public string TimeForm {get;set;}
        
        [Required]
        [MinLength (10, ErrorMessage="Description must have a minimum of 10 cahracters.")]
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserId {get;set;}
        public User Coordinator {get;set;}
        public List<Participants> participant {get;set;}
    }
}