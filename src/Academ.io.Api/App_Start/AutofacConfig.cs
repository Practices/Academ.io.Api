using System.Reflection;
using System.Web.Http;
using Academ.io.Api.Mappers;
using Academ.io.Api.Security.Contexts;
using Academ.io.Api.Security.Repositories;
using Academ.io.Data.Contexts;
using Academ.io.Data.Repositories;
using Academ.io.Services.Sessions;
using Academ.io.Services.Students;
using Academ.io.University.Api.Fakes;
using Academ.io.University.Api.Services.Contingents;
using Academ.io.University.Api.Services.Sessions;
using Autofac;
using Autofac.Integration.WebApi;
using Owin;

namespace Academ.io.Api
{
    public class AutofacConfig
    {
        public static void Configure(IAppBuilder app, HttpConfiguration config)
        {
            ConfigureAutofacContainer(app, config);
            AutoMapperConfiguration.Configure();
        }

        private static void ConfigureAutofacContainer(IAppBuilder app, HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            RegisterComponents(builder);

            IContainer container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
        }

        private static void RegisterComponents(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationContext>().SingleInstance();
            builder.RegisterType<AcademContext>().SingleInstance();
            builder.RegisterType<UserRepository>().As<IUserRepository>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<SessionRepository>().As<ISessionRepository>().AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterType<StudentService>().As<IStudentService>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<StudentRepository>().As<IStudentRepository>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<SessionService>().As<ISessionService>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<SessionServiceApiFake>().As<ISessionServiceApi>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<MarkRepository>().As<IMarkRepository>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<StudentServiceApiFake>().As<IStudentServiceApi>().AsImplementedInterfaces().InstancePerRequest();

        }
    }
}