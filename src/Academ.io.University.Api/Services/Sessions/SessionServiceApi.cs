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
                },
                new DisciplineModel
                {
                    DisciplineId = new Guid("bde12af4-35a9-11e3-a7ef-005056960017"),
                    DisciplineName = "Курсовая работа -Эргономический анализ систем обработки и отображеия информации",
                    DisciplineDepartment = "ИУ5",
                    Mark = 3,
                    Audlek = 51,
                    Term = 11,
                    TestDate = new DateTime(2015, 02, 02),
                    TestType = 3
                },
                new DisciplineModel
                {
                    DisciplineId = new Guid("bdf7fcca-35a9-11e3-9abc-005056960017"),
                    DisciplineName = "IT-менеджмент",
                    DisciplineDepartment = "ИУ5",
                    Mark = 3,
                    Audlek = 51,
                    Term = 11,
                    TestDate = new DateTime(2014, 12, 23),
                    TestType = 2
                },
                new DisciplineModel
                {
                    DisciplineId = new Guid("bde12cca-35a9-11e3-9fac-005056960017"),
                    DisciplineName = "Эргономический анализ систем обработки и отображения информации",
                    DisciplineDepartment = "ИУ5",
                    Mark = 3,
                    Audlek = 51,
                    Term = 11,
                    TestDate = new DateTime(2015, 01, 15),
                    TestType = 1
                }
            };
        }
    }
}