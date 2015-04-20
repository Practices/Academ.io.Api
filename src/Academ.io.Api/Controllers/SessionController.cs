using System;
using System.Collections.Generic;
using System.Web.Http;
using Academ.io.Api.Models;
using Academ.io.Models;
using Academ.io.Services;
using AutoMapper;

namespace Academ.io.Api.Controllers
{
    public class SessionController: ApiController
    {
        private readonly ISessionService sessionService;

        public SessionController(ISessionService sessionService)
        {
            this.sessionService = sessionService;

            Mapper.CreateMap<Discipline, DisciplineDto>().ForMember(o => o.TestTypeId, m => m.MapFrom(s => s.TestType.TestTypeId));
        }

        [Authorize]
        public IEnumerable<DisciplineDto> GetSession(string id)
        {
            var disciplines = sessionService.GetSession(new Guid(id));

            var disciplineViewModels = Mapper.Map<IEnumerable<Discipline>, IEnumerable<DisciplineDto>>(disciplines);
            
            return disciplineViewModels;
        }
    }
}