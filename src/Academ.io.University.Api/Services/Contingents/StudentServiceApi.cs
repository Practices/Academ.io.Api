using System;
using System.Collections.Generic;
using System.Linq;
using Academ.io.Models;
using Academ.io.University.Api.Converters;
using Academ.io.University.Api.Models;
using AcademicAnalysis.ElectronicUniversityServices.Models;
using AutoMapper;

namespace Academ.io.University.Api.Services.Contingents
{
    public class StudentServiceApi: BaseServiceApi, IStudentServiceApi
    {
        private const string StudentUrl = "/modules/contingent/service/xml/students/";

        public IEnumerable<Student> GetStudentsByContainer(string value)
        {
            return this.GetStudents("search[container_uuid][]", value);

        }

        public IEnumerable<Student> GetStudentById(string value)
        {
//            return this.GetStudents("search[uuid][]", value); 
            var students = new List<Student>
            {
                new Student
                {
                    StudentIdentity = new Guid("81889959-faa8-4ad1-abab-b63be64d1b6a"),
                    Firstname = "Иван",
                    Middlename = "Иванович",
                    Lastname = "Иванов",
                    Birthdate = new DateTime(1995, 5, 25),
                    Cardnumber = "15Ц001",
                    Group = "ИУ5-121"
                }
            };
            return students;
        }

        public IEnumerable<Student> GetStudentByFamily(string value)
        {
            //            return this.GetStudents("search[fio]", value);

            var students = new List<Student>
            {
                new Student
                {
                    StudentIdentity = new Guid("89889959-faa8-4ad1-abab-b63be64d1b6a"),
                    Firstname = "Иван",
                    Middlename = "Иванович",
                    Lastname = "Иванов",
                    Birthdate = new DateTime(1995, 5, 25),
                    Cardnumber = "15Ц001",
                    Group = "ИУ5-121"
                },
                new Student
                {
                    StudentIdentity = new Guid("89889959-faa8-4ad1-abab-b63be64d1b6a"),
                    Firstname = "Тест",
                    Middlename = "Тестович",
                    Lastname = "Тестов",
                    Birthdate = new DateTime(1992, 2, 22),
                    Cardnumber = "09Ц002",
                    Group = "ИУ5-122",
                },
                new Student
                {
                    StudentIdentity = new Guid("be83d0ef-86c0-4e53-aaf4-88e1afb1521e"),
                    Firstname = "Сур",
                    Middlename = "Сурович",
                    Lastname = "Суров",
                    Birthdate = new DateTime(1991, 1, 11),
                    Cardnumber = "09Ц001",
                    Group = "ИУ5-121"
                }
            };

            return students.Where(x => x.Lastname == value);
        }

        public IEnumerable<Student> GetStudentByCardnumber(string value)
        {
            return this.GetStudents("search[card_number]", value);
        }

        private IEnumerable<Student> GetStudents(string parameter, string value)
        {
            var request = GetRequest(StudentUrl);
            request.AddParameter(parameter, value);
            var response = Client.Execute<ContingentModel>(request);

            Mapper.CreateMap<string, Guid>().ConvertUsing(new GuidTypeConverter());
            Mapper.CreateMap<StudentModel, Student>();

            var students = Mapper.Map<List<StudentModel>, List<Student>>(response.Data.Students);

            return students;
        }
    }
}