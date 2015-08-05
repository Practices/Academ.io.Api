using System;
using System.Collections.Generic;
using Academ.io.Data.Repositories;
using Academ.io.Models;
using Academ.io.Services.Sessions;
using Academ.io.University.Api.Models;
using Academ.io.University.Api.Services.Sessions;
using Moq;
using Xunit;

namespace Academ.io.Services.Tests
{
    public class SessionServiceTest
    {
        private Mock<IMarkRepository> markRepository;
        private Mock<ISessionRepository> sessionRepository;
        private ISessionService sessionService;
        private Mock<ISessionServiceApi> sessionServiceApi;
        private Mock<IStudentRepository> studentRepository;

        public SessionServiceTest()
        {
            markRepository = new Mock<IMarkRepository>();
            sessionServiceApi = new Mock<ISessionServiceApi>();
            studentRepository = new Mock<IStudentRepository>();
            sessionRepository = new Mock<ISessionRepository>();
            sessionService = new SessionService(sessionServiceApi.Object, markRepository.Object, studentRepository.Object, sessionRepository.Object);
        }

        [Fact]
        public void ShouldBeReturnListDiscipline()
        {
            //arrange
            markRepository.Setup(x => x.GetMark(It.IsAny<int>(), It.IsAny<int>()))
                          .Returns(new Mark
                          {
                              Name = "Отлично",
                              ShortName = "Отл",
                              Grade = 5,
                              TestType = new TestType
                              {
                                  TestTypeId = 3,
                                  Name = "Курсовой проект",
                                  ShortName = "Кур"
                              }
                          });

            sessionServiceApi.Setup(x => x.GetSessionsByStudent(It.IsAny<Guid>()))
                             .Returns(new List<DisciplineModel>
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
                             });
            //act
            var result = new List<Discipline>(sessionService.GetSession(1));

            //assert
            Assert.IsType(typeof(Discipline), result[0]);
            Assert.Equal(result[0].DisciplineId, new Guid("be0483a0-35a9-11e3-830f-005056960017"));
            Assert.Equal(result[0].Mark.Grade, 5);
            Assert.Equal(result[0].TestType.TestTypeId, 3);
        }
    }
}