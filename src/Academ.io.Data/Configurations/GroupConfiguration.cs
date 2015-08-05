using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Academ.io.Models;

namespace Academ.io.Data.Configurations
{
    public class GroupConfiguration:EntityTypeConfiguration<Group>
    {
        public GroupConfiguration()
        {
            HasKey(t => t.GroupId);
            Property(t => t.GroupId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
//            HasMany(t => t.Users);
        }
    }
}