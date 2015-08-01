using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using Academ.io.Data.Contexts;
using Academ.io.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;

namespace Academ.io.Api.Providers
{
    public class CustomAuthorizationServerProvider: OAuthAuthorizationServerProvider
    {
        private readonly Func<UserManager<ApplicationUser>> userManagerFactory;

        public CustomAuthorizationServerProvider(Func<UserManager<ApplicationUser>> userManagerFactory)
        {
            this.userManagerFactory = userManagerFactory;
        }

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

            using (UserManager<ApplicationUser> userManager = userManagerFactory())
            {
                ApplicationUser user = await userManager.FindAsync(context.UserName, context.Password);

                if(user == null)
                {
                    context.SetError("invalid_grant", "The user name or password is incorrect.");
                    return;
                }

                var identity = await userManager.CreateIdentityAsync(user, context.Options.AuthenticationType);
                AuthenticationProperties properties = CreateProperties(user.UserName);
                AuthenticationTicket ticket = new AuthenticationTicket(identity, properties);

                context.Validated(ticket);
            }
        }

        private AuthenticationProperties CreateProperties(string userName)
        {
            IDictionary<string, string> data = new Dictionary<string, string>
            {
                { "userName", userName }
            };
            return new AuthenticationProperties(data);
        }
    }
}