using System;
using Academ.io.Api.Providers;
using Academ.io.Data.Contexts;
using Academ.io.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

namespace Academ.io.Api
{
    public class AuthConfig
    {
        public static Func<UserManager<ApplicationUser>> UserManagerFactory { get; set; }

        public static void Configure(IAppBuilder app)
        {
            UserManagerFactory = () => new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationContext()));
            ConfigureOAuth(app);
        }

        private static void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions oAuthAuthorizationServerOptions = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new CustomAuthorizationServerProvider(UserManagerFactory)
            };

            //Token Generation
            app.UseOAuthAuthorizationServer(oAuthAuthorizationServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}