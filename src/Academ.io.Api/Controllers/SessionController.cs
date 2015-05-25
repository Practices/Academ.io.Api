using System;
using System.Collections.Generic;
using System.Web.Http;
using Academ.io.Api.Models;
using Academ.io.Models;
using Academ.io.Services.Sessions;
using AutoMapper;

namespace Academ.io.Api.Controllers
{
    [RoutePrefix("api/session")]
    public class SessionController: ApiController
    {
        private readonly ISessionService sessionService;

        public SessionController(ISessionService sessionService)
        {
            this.sessionService = sessionService;

            Mapper.CreateMap<Discipline, DisciplineViewModel>().ForMember(o => o.TestTypeId, m => m.MapFrom(s => s.TestType.TestTypeId));
        }

        [Authorize]
        public IHttpActionResult GetSession(string id)
        {
            var guid = new Guid(id);

            var disciplines = sessionService.GetSession(guid);

            var disciplineViewModels = Mapper.Map<IEnumerable<Discipline>, IEnumerable<DisciplineViewModel>>(disciplines);

            return Ok(disciplineViewModels);
        }

        [Authorize]
        [Route("{id}/progress")]
        public IHttpActionResult GetSessionProgress(int id)
        {
            var data = sessionService.GetProgress(id);
            if(data == null)
            {
                return BadRequest("Not found student");
            }
            return Ok(data);
        }
    }
}