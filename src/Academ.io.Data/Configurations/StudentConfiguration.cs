using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Security.Cryptography.X509Certificates;
using Academ.io.Models;

namespace Academ.io.Data.Configurations
{
    public class StudentConfiguration: EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            HasKey(t => t.StudentId);
            Property(t => t.StudentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}