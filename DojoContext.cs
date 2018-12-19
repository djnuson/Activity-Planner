using Microsoft.EntityFrameworkCore;

namespace DojoActivity.Models
{
    public class DojoContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DojoContext(DbContextOptions<DojoContext> options) : base(options) { }

        public DbSet<User> UserTable { get; set; }
        public DbSet<ActivityModel> ActTable {get;set;}
        public DbSet<Participants> Participant { get; set; }
    }
}