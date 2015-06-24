using Academ.io.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Academ.io.Data.Contexts
{
    public class ApplicationContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext()
            : base("AcademContext")
        {
        }
    }
}