using Academ.io.Api.Models.Dto;
using Academ.io.Models;
using AutoMapper;

namespace Academ.io.Api.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappingProfile";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Student, StudentViewModel>();

        }
    }
}