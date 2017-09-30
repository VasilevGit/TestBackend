using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestBackend.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("TestBackendDb")
        {
            Database.SetInitializer(new AppContextInitializer());
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}