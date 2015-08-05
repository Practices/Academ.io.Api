using Academ.io.Services.Sessions;
using Academ.io.Services.Students;
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