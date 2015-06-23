using Academ.io.Api.Models;
using Academ.io.Models;
using AutoMapper;

namespace Academ.io.Api.Mappers
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<StudentViewModel, Student>().ForMember(d => d.Group, o => o.Ignore());
            Mapper.CreateMap<GroupViewModel, Group>();
        }
    }
}