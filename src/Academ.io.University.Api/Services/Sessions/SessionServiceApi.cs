using System.Collections.Generic;
using System.Linq;
using Academ.io.Models;
using Academ.io.University.Api.Models;
using AcademicAnalysis.ElectronicUniversityServices.Models;
using AutoMapper;

namespace Academ.io.University.Api.Services.Sessions
{
    public class SessionServiceApi:BaseServiceApi, ISessionServiceApi
    {
        private const string SessionUrl = "/modules/session/service/xml/student-marks/";

        public IEnumerable<Session> GetSessionsByStudent(string id)
        {
            var request = GetRequest(SessionUrl);
            request.AddParameter("student_uuid[]", id);
            var response = Client.Execute<SessionServiceModel>(request);          
            var firstOrDefault = response.Data.Students.FirstOrDefault();
            if(firstOrDefault != null)
            {
                Mapper.CreateMap<DisciplineModel, Session>();
                var sessions = Mapper.Map<IEnumerable<DisciplineModel>, IEnumerable<Session>>(firstOrDefault.Disciplines);
                return sessions;
            }
            else
            {
                return null;
            }
        }
    }
}