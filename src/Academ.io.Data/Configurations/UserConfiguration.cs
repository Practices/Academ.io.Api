using System.Data.Entity.ModelConfiguration;
using Academ.io.Models;

namespace Academ.io.Data.Configurations
{
    public class UserConfiguration:EntityTypeConfiguration<ApplicationUser>
    {
        public UserConfiguration()
        {
            HasMany(t => t.Groups).WithMany();
        }
    }
}