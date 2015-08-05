﻿using Academ.io.Data.Contexts;
using Academ.io.Data.Repositories;
using Academ.io.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Academ.io.Services.Tests
{
    [TestClass]
    public class MarkRepositoryTest
    {
        private IMarkRepository markRepository;

        [TestInitialize]
        public void SetUp()
        {
            markRepository = new MarkRepository(new SessionContext());
        }

        [TestMethod]
        public void ShouldBeGetMarkWithParameters()
        {
            //arrange
            var testType = new TestType
            {
                TestTypeId = 5,
                Name = "Курсовой проект (недиф)",
                ShortName = "Кур"
            };

            var mark = new Mark
            {
                MarkId = 13,
                Name = "Зачтено",
                ShortName = "Зчт",
                Grade = 3,
                TestType = testType
            };

            //act
            var result = this.markRepository.GetMark(3, 5);

            //assert
            Assert.AreEqual(mark.TestType.TestTypeId,result.TestType.TestTypeId);
        }
    }
}