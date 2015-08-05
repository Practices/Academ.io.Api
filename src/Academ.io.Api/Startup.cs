using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Academ.io.Api.Startup))]
namespace Academ.io.Api
{
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