using Academ.io.Api.Models.Dto;
using Academ.io.Models;
using AutoMapper;

namespace Academ.io.Api.Mappers
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<StudentViewModel, Student>().ForMember(d => d.Users, o => o.Ignore());
        }
    }
}