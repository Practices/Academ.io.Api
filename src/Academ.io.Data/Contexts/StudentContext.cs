using System.Data.Entity;
using Academ.io.Models;

namespace Academ.io.Data.Contexts
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}