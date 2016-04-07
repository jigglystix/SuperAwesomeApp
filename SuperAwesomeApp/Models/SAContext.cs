using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SuperAwesomeApp.Models
{
    public class SAContext:DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }

    }
}