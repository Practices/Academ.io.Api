using System.Data.Entity;
using Academ.io.Models;

namespace Academ.io.Data.Contexts
{
    public class AcademContext: DbContext
    {
        public AcademContext()
                : base("AcademContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<AcademUser> AcademUsers { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<TestType> TestTypes { get; set; }
        public DbSet<SessionPoint> SessionPoints { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}