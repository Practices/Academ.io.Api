using Academ.io.Api.Security.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Academ.io.Api.Security.Contexts
{
    public class ApplicationContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext()
                : base("ApplicationContext")
        {
        }
    }
}