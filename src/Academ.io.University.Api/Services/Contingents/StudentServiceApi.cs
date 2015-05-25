using System;
using System.Collections.Generic;
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

        public IEnumerable<StudentModel> GetStudentsByContainer(string value)
        {
            return this.GetStudents("search[container_uuid][]", value);
        }

        public IEnumerable<StudentModel> GetStudentById(string value)
        {
            return this.GetStudents("search[uuid][]", value);
        }

        public IEnumerable<StudentModel> GetStudentByFamily(string value)
        {
            return this.GetStudents("search[fio]", value);
        }

        public IEnumerable<StudentModel> GetStudentByCardnumber(string value)
        {
            return this.GetStudents("search[card_number]", value);
        }

        public IEnumerable<GroupModel> GetGroupsByName(string value)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<StudentModel> GetStudents(string parameter, string value)
        {
            var request = GetRequest(StudentUrl);
            request.AddParameter(parameter, value);
            var response = Client.Execute<ContingentModel>(request);

//            Mapper.CreateMap<string, Guid>().ConvertUsing(new GuidTypeConverter());
//            Mapper.CreateMap<StudentModel, Student>();
//
//            var students = Mapper.Map<List<StudentModel>, List<Student>>(response.Data.Students);

            return response.Data.Students;
        }
    }
}