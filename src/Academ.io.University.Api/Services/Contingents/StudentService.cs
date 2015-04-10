using System;
using System.Collections.Generic;
using Academ.io.Models;
using Academ.io.University.Api.Converters;
using Academ.io.University.Api.Models;
using AcademicAnalysis.ElectronicUniversityServices.Models;
using AutoMapper;

namespace Academ.io.University.Api.Services.Contingents
{
    public class StudentService :BaseService, IStudentService
    {
        private const string StudentUrl = "/modules/contingent/service/xml/students/";

        public IEnumerable<Student> GetStudentsByContainer(string value)
        {
            return this.GetStudents("search[container_uuid][]", value);
        }

        public IEnumerable<Student> GetStudentById(string value)
        {
            return this.GetStudents("search[uuid][]", value);
        }

        public IEnumerable<Student> GetStudentByFamily(string value)
        {
            return this.GetStudents("search[fio]", value);
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