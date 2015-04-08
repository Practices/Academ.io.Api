using System.Web.Http;
using Microsoft.Owin;
using Owin;

namespace Academ.io.Api
{
    [assembly: OwinStartup(typeof(Startup))]
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AuthConfig.Configure(app);
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            AutofacConfig.Configure(app, config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
        }
    }
}