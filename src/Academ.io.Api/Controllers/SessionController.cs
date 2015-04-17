using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Academ.io.Models;
using Academ.io.Services;

namespace Academ.io.Api.Controllers
{
    public class SessionController: ApiController
    {
        private readonly ISessionService sessionService;
         
        public SessionController(ISessionService sessionService)
        {
            this.sessionService = sessionService;
        }

        [Authorize]
        public IEnumerable<Discipline> GetSession(string id)
        {
            return sessionService.GetSession(new Guid(id));
        }
    }
}