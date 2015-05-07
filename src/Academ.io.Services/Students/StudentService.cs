using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academ.io.Api.Security.Repositories;
using Academ.io.Data.Repositories;
using Academ.io.Models;
using Academ.io.University.Api.Services.Contingents;

namespace Academ.io.Services.Students
{
    public class StudentService: IStudentService
    {
        private IStudentRepository studentRepository;
        private IUserRepository userRepository;
        private IStudentServiceApi studentServiceApi;

        public StudentService(IStudentRepository studentRepository, IUserRepository userRepository, IStudentServiceApi studentServiceApi)
        {
            this.studentRepository = studentRepository;
            this.userRepository = userRepository;
            this.studentServiceApi = studentServiceApi;
        }

        public List<Student> GetStudents(string userId)
        {
            return studentRepository.GetStudentsByUserId(new Guid(userId));
        }

        public List<Student> GetStudentsByName(string name)
        {
            return studentServiceApi.GetStudentByFamily(name).ToList();
        }

        public Student AddStudent(string userId, string studentId)
        {
            var student = studentServiceApi.GetStudentById(studentId).FirstOrDefault();
            var result = studentRepository.AddStudent(new Guid(userId), student);

            return result;
        }

        public Student DeleteStudent(string userId, string studentId)
        {
            return studentRepository.DeleteStudent(new Guid(userId), studentId);
        }

        public Student GetStudentByName(string name)
        {
            return null;
        }
    }
}