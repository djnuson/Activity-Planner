using System.ComponentModel.DataAnnotations;

namespace DojoActivity
{
    public class Participants
    {
        [Key]
        public int PartId {get;set;}
        public int UserId {get;set;}
        public int ActId {get;set;}
        public ActivityModel activmodel {get;set;}
        public User User {get;set;}
    }
}