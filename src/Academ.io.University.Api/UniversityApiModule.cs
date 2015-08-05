using Academ.io.University.Api.Fakes;
using Academ.io.University.Api.Services.Contingents;
using Academ.io.University.Api.Services.Sessions;
using Autofac;

namespace Academ.io.University.Api
{
    public class UniversityApiModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentServiceApiFake>().As<IStudentServiceApi>().InstancePerRequest();
            builder.RegisterType<SessionServiceApiFake>().As<ISessionServiceApi>().InstancePerRequest();
        }
    }
}