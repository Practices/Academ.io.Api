using System.Collections.ObjectModel;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Academ.io.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public Collection<Group> Groups { get; set; }
    }
}