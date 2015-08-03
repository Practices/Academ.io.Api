using Academ.io.Data.Contexts;
using Academ.io.Data.Repositories;
using Autofac;

namespace Academ.io.Data
{
    public class DataModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AcademContext>().SingleInstance();

            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerRequest();
            builder.RegisterType<StudentRepository>().As<IStudentRepository>().InstancePerRequest();
            builder.RegisterType<MarkRepository>().As<IMarkRepository>().InstancePerRequest();
            builder.RegisterType<SessionRepository>().As<ISessionRepository>().InstancePerRequest();
        }
    }
}