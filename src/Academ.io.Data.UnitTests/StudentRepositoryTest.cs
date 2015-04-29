using System;
using Academ.io.Data.Contexts;
using Academ.io.Data.Repositories;
using Academ.io.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Academ.io.Data.UnitTests
{
    [TestClass]
    public class StudentRepositoryTest
    {
        private IStudentRepository studentRepository;

        [TestInitialize]
        public void SetUp()
        {
            var context = new StudentContext();

            studentRepository = new StudentRepository(context);
        }

        [TestMethod]
        public void ShouldBeAddedStudent()
        {
            var student = new Student
            {
                StudentId = 1,
                StudentIdentity = new Guid("89889959-faa8-4ad1-abab-b63be64d1b6a"),
                Firstname = "Тест",
                Middlename = "Тестович",
                Lastname = "Тестов",
                Birthdate = new DateTime(1992, 2, 22),
                Cardnumber = "09Ц002",
                Group = "ИУ5-122"
            };

            var userId = "88dfee0c-9849-4732-bcb5-4d8f88c47395";

            var result = studentRepository.AddStudent(student, userId);

            Assert.AreEqual(result.StudentId,1);
        }

        [TestMethod]
        public void ShouldBeDeletedStudentInUser()
        {
            //arrange
            var student = new Student
            {
                StudentId = 1,
                StudentIdentity = new Guid("89889959-faa8-4ad1-abab-b63be64d1b6a"),
                Firstname = "Тест",
                Middlename = "Тестович",
                Lastname = "Тестов",
                Birthdate = new DateTime(1992, 2, 22),
                Cardnumber = "09Ц002",
                Group = "ИУ5-122"
            };

            var userId = "88dfee0c-9849-4732-bcb5-4d8f88c47395";
            //act
            var result = studentRepository.DeleteStudent(student, userId);

            //assert
            Assert.AreEqual(result.StudentIdentity,student.StudentIdentity);
        }
    }
}
