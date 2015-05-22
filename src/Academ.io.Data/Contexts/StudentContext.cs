using System.Data.Entity;
using Academ.io.Models;

namespace Academ.io.Data.Contexts
{
    public class StudentContext: DbContext
    {
        protected StudentContext()
                : base("AcademContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<AcademUser> AcademUsers { get; set; }
    }
}