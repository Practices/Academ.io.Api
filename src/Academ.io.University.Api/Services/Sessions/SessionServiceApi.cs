using System;
using System.Collections.Generic;
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

//        public List<DisciplineModel> GetSessionsByStudent(string id)
//        {
//            var request = GetRequest(SessionUrl);
//            request.AddParameter("student_uuid[]", id);
//            var response = Client.Execute<SessionServiceModel>(request);
//            var studentSession = response.Data.Students.FirstOrDefault();
//            if(studentSession != null)
//            {
//                return studentSession.Disciplines;
//            }
//            return null;
//        }

        public List<DisciplineModel> GetSessionsByStudent(string id)
        {
            return new List<DisciplineModel>
            {
                new DisciplineModel
                {
                    DisciplineId = new Guid("be0483a0-35a9-11e3-830f-005056960017"),
                    DisciplineName = "Курсовая работа - Надежность и достоверность",
                    DisciplineDepartment = "ИУ5",
                    Mark = 5,
                    Audlek = 51,
                    Term = 11,
                    TestDate = new DateTime(2014, 12, 22),
                    TestType = 3
                }
            };
        }
    }
}