using System.Security.Claims;
using System.Threading.Tasks;
using Academ.io.Api.Security.Contexts;
using Academ.io.Api.Security.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.OAuth;

namespace Academ.io.Api.Security.Providers
{
    public class CustomAuthorizationServerProvider: OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin",
                                                     new[]
                                                     {
                                                         "*"
                                                     });

            using(var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationContext())))
            {
                IdentityUser user = await userManager.FindAsync(context.UserName, context.Password);

                if(user == null)
                {
                    context.SetError("invalid_grant", "The user name or password is incorrect.");
                    return;
                }
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("sub", context.UserName));
            identity.AddClaim(new Claim("role", "user"));

            context.Validated(identity);
        }
    }
}