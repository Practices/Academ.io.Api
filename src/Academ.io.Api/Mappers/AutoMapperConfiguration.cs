using Academ.io.Services;
using AutoMapper;

namespace Academ.io.Api.Mappers
{
    public class AutoMapperConfiguration
    {
         public static void Configure()
         {
             Mapper.Initialize(mapper =>
             {
                 mapper.AddProfile<ViewModelToDomainMappingProfile>();
                 mapper.AddProfile<DomainToViewModelMappingProfile>();
                 mapper.AddProfile<ServicesMappingProfile>();
             });
         }
    }
}