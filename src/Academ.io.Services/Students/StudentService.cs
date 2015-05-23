using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academ.io.Api.Models.Dto;
using Academ.io.Data.Repositories;
using Academ.io.Models;
using Academ.io.University.Api.Converters;
using Academ.io.University.Api.Models;
using Academ.io.University.Api.Services.Contingents;
using AutoMapper;

namespace Academ.io.Services.Students
{
    public class StudentService: IStudentService
    {
        private IStudentRepository studentRepository;
        private IStudentServiceApi studentServiceApi;

        public StudentService(IStudentRepository studentRepository, IStudentServiceApi studentServiceApi)
        {
            this.studentRepository = studentRepository;
            this.studentServiceApi = studentServiceApi;

            Mapper.CreateMap<string, Guid>().ConvertUsing(new GuidTypeConverter());
            Mapper.CreateMap<StudentModel, Student>();
        }

        public List<Student> GetStudents(Guid userId)
        {
//            return studentRepository.GetStudentsByUserId(userId);
            return null;
        }

        public List<Student> GetStudentsByName(string name)
        {
            var data = studentServiceApi.GetStudentByFamily(name);
            var result = new List<Student>();
            Mapper.Map(result, data);
            return result;
        }

        public Student AddStudent(Guid userId, Student student)
        {
            return studentRepository.AddStudent(userId, student);
        }

        public Student DeleteStudent(Guid userId, string studentId)
        {
            return studentRepository.DeleteStudent(userId, studentId);
        }

        public Student GetStudent(Guid userId, int studentId)
        {
            return studentRepository.GetStudentsById(userId, studentId);
        }
    }
}