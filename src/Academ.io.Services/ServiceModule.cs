using Academ.io.Data.Repositories;
using Autofac;

namespace Academ.io.Services
{
    public class ServiceModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>().As<IStudentRepository>();
            builder.RegisterType<MarkRepository>().As<IMarkRepository>();
            builder.RegisterType<SessionRepository>().As<ISessionRepository>();
        }
    }
}