using System.Data.Entity;

namespace SuperAwesomeApp.Models
{
    public class SAContext:DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }

        public SAContext()
            : base("DefaultConnection")
        { }

    }
}