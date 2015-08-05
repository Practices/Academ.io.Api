using System.ComponentModel;
using System.Data.Entity;
using System.Threading;
using Academ.io.Data.Configurations;
using Academ.io.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Academ.io.Data.Contexts
{
    public class AcademContext: IdentityDbContext<ApplicationUser>
    {
        public AcademContext()
                : base("AcademContext")
        {
//            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<TestType> TestTypes { get; set; }
        public DbSet<SessionPoint> SessionPoints { get; set; }
        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}