using System;
using System.Collections.Generic;
using Academ.io.Data.Repositories;
using Academ.io.Models;
using Academ.io.University.Api.Models;
using Academ.io.University.Api.Services.Sessions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Academ.io.Services.Tests
{
    [TestClass]
    public class SessionServiceTest
    {
        private Mock<IMarkRepository> markRepository;
        private SessionService sessionService;
        private Mock<ISessionServiceApi> sessionServiceApi;

        [TestInitialize]
        public void SetUp()
        {
            markRepository = new Mock<IMarkRepository>();
            sessionServiceApi = new Mock<ISessionServiceApi>();
            sessionService = new SessionService(sessionServiceApi.Object, markRepository.Object);
        }

        [TestMethod]
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
            var result = new List<Discipline>(sessionService.GetSession(new Guid()));

            //assert
            Assert.IsInstanceOfType(result[0],typeof(Discipline));
            Assert.AreEqual(result[0].DisciplineId, new Guid("be0483a0-35a9-11e3-830f-005056960017"));
            Assert.AreEqual(result[0].Mark.Grade,5);
            Assert.AreEqual(result[0].TestType.TestTypeId,3);
        }
    }
}