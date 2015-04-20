using System;
using System.Collections.Generic;
using System.Linq;
using Academ.io.Api.Models;
using Academ.io.Models;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Academ.io.Automapper.UnitTests
{
    [TestClass]
    public class AutomapperWithDtoTest
    {
        [TestMethod]
        public void ShouldBeReturnDtoSingleAfterMapping()
        {
            //arrange
            Mapper.CreateMap<Discipline, DisciplineDto>().ForMember(o => o.TestTypeId, m => m.MapFrom(s => s.TestType.TestTypeId));
            Mapper.AssertConfigurationIsValid();

            var dicipline = new Discipline
            {
                DisciplineId = new Guid("bde12af4-35a9-11e3-a7ef-005056960017"),
                DisciplineName = "Курсовая работа -Эргономический анализ систем обработки и отображеия информации",
                DisciplineDepartment = "ИУ5",
                Term = 11,
                Audlek = 51,
                TestDate = new DateTime(2015, 2, 2),
                Mark = new Mark
                {
                    MarkId = 9,
                    Grade = 3,
                    Name = "Удовлетворительно",
                    ShortName = "Удов"
                },
                TestType = new TestType
                {
                    TestTypeId = 3,
                    Name = "Курсовой проект",
                    ShortName = "Кур"
                }
            };

            //act
            var result = Mapper.Map<Discipline, DisciplineDto>(dicipline);

            //assert
            Assert.AreEqual(dicipline.DisciplineName, result.DisciplineName);
            Assert.AreEqual(dicipline.DisciplineDepartment, result.DisciplineDepartment);
            Assert.AreEqual(dicipline.TestDate, result.TestDate);
            Assert.AreEqual(dicipline.Mark.Grade, result.MarkGrade);
            Assert.AreEqual(dicipline.Mark.ShortName, result.MarkShortName);
            Assert.AreEqual(dicipline.TestType.TestTypeId, result.TestTypeId);
            Assert.AreEqual(dicipline.TestType.Name, result.TestTypeName);
        }

        [TestMethod]
        public void ShouldBeReturnDtoListAfterMapping()
        {
            //arrange
            Mapper.CreateMap<Discipline, DisciplineDto>().ForMember(o => o.TestTypeId, m => m.MapFrom(s => s.TestType.TestTypeId));
            Mapper.AssertConfigurationIsValid();

            var diciplines = new List<Discipline>
            {
                new Discipline
                {
                    DisciplineId = new Guid("bde12af4-35a9-11e3-a7ef-005056960017"),
                    DisciplineName = "Курсовая работа -Эргономический анализ систем обработки и отображеия информации",
                    DisciplineDepartment = "ИУ5",
                    Term = 11,
                    Audlek = 51,
                    TestDate = new DateTime(2015, 2, 2),
                    Mark = new Mark
                    {
                        MarkId = 9,
                        Grade = 3,
                        Name = "Удовлетворительно",
                        ShortName = "Удов"
                    },
                    TestType = new TestType
                    {
                        TestTypeId = 3,
                        Name = "Курсовой проект",
                        ShortName = "Кур"
                    }
                },
                new Discipline
                {
                    DisciplineId = new Guid("be0483a0-35a9-11e3-830f-005056960017"),
                    DisciplineName = "Курсовая работа - Надежность и достоверность",
                    DisciplineDepartment = "ИУ5",
                    Term = 11,
                    Audlek = 51,
                    TestDate = new DateTime(2014, 12, 22),
                    Mark = new Mark
                    {
                        MarkId = 1,
                        Grade = 5,
                        Name = "Отлично",
                        ShortName = "Отл"
                    },
                    TestType = new TestType
                    {
                        TestTypeId = 3,
                        Name = "Курсовой проект",
                        ShortName = "Кур"
                    }
                }
            };

            //act
            var result = Mapper.Map<List<Discipline>, List<DisciplineDto>>(diciplines);

            //assert
            Assert.IsInstanceOfType(result, typeof(List<DisciplineDto>));
            Assert.IsTrue(result.Any());
            Assert.AreEqual(diciplines[0].DisciplineName, result[0].DisciplineName);
            //            Assert.AreEqual(dicipline.DisciplineDepartment, result.DisciplineDepartment);
            //            Assert.AreEqual(dicipline.TestDate, result.TestDate);
            //            Assert.AreEqual(dicipline.Mark.Grade, result.MarkGrade);
            //            Assert.AreEqual(dicipline.Mark.ShortName, result.MarkShortName);
            //            Assert.AreEqual(dicipline.TestType.TestTypeId, result.TestTypeId);
            //            Assert.AreEqual(dicipline.TestType.Name, result.TestTypeName);
        }
    }
}