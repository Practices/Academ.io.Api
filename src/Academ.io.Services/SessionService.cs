using System;
using System.Collections.Generic;
using Academ.io.Data.Repositories;
using Academ.io.Models;
using Academ.io.University.Api.Services.Sessions;

namespace Academ.io.Services
{
    public class SessionService: ISessionService
    {
        private readonly ISessionServiceApi sessionServiceApi;
        private readonly IMarkRepository markRepository;

        public SessionService(ISessionServiceApi sessionServiceApi,IMarkRepository markRepository)
        {
            this.sessionServiceApi = sessionServiceApi;
            this.markRepository = markRepository;
        }

        public IEnumerable<Session> GetSessions(Guid studentId)
        {
            var sessions = this.sessionServiceApi.GetSessionsByStudent(studentId);

            var marks = markRepository.GetMarks();


            return null;
        }
    }
}