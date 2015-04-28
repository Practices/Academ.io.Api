using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Academ.io.Api.Security.Repositories;
using Academ.io.Data.Repositories;
using Academ.io.Models;

namespace Academ.io.Services.Students
{
    public class StudentService: IStudentService
    {
        private IStudentRepository studentRepository;
        private IUserRepository userRepository;

        public StudentService(IStudentRepository studentRepository,IUserRepository userRepository)
        {
            this.studentRepository = studentRepository;
            this.userRepository = userRepository;
        }

        public async Task<List<Student>> GetStudents(Guid userId)
        {
               return null;
        }
    }
}