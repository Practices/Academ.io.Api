using Academ.io.Data.Repositories;
using Academ.io.Services.Sessions;
using Academ.io.Services.Students;
using Academ.io.University.Api.Fakes;
using Academ.io.University.Api.Services.Sessions;
using Autofac;

namespace Academ.io.Services
{
    public class ServiceModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterType<StudentService>().As<IStudentService>().InstancePerRequest();
            builder.RegisterType<SessionService>().As<ISessionService>().InstancePerRequest();
        }
    }
}