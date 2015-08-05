using System;
using System.Collections.Generic;
using System.Linq;
using Academ.io.University.Api.Models;

namespace Academ.io.University.Api.Services.Sessions
{
    public class SessionServiceApi: BaseServiceApi, ISessionServiceApi
    {
        private const string SessionUrl = "/modules/session/service/xml/student-marks/";

        public List<DisciplineModel> GetSessionsByStudent(Guid id)
        {
            return this.GetSessionsByStudent(id.ToString());
        }

        public List<DisciplineModel> GetSessionsByStudent(string id)
        {
            var request = GetRequest(SessionUrl);
            request.AddParameter("student_uuid[]", id);
            var response = Client.Execute<SessionServiceModel>(request);
            var studentSession = response.Data.Students.FirstOrDefault();
            if(studentSession != null)
            {
                return studentSession.Disciplines;
            }
            return null;
        }
    }
}