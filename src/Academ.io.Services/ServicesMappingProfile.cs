using System;
using Academ.io.Models;
using Academ.io.University.Api.Converters;
using Academ.io.University.Api.Models;
using AutoMapper;

namespace Academ.io.Services
{
    public class ServicesMappingProfile: Profile
    {
        public override string ProfileName
        {
            get { return "ServicesMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<DisciplineModel, Discipline>().ForMember(dest => dest.Mark, opt => opt.Ignore()).ForMember(dest => dest.TestType, opt => opt.Ignore());

            Mapper.CreateMap<string, Guid>().ConvertUsing(new GuidTypeConverter());
            Mapper.CreateMap<StudentModel, Student>().ForMember(d => d.Group, o => o.Ignore());
            Mapper.CreateMap<GroupModel, Group>().ForMember(d => d.Students, o => o.Ignore());
        }
    }
}