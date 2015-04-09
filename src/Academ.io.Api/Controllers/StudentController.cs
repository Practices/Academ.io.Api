using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Academ.io.Data.Repositories;
using Academ.io.Models;

namespace Academ.io.Api.Controllers
{
    [RoutePrefix("api/student")]
    public class StudentController: ApiController
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [Authorize]
        public Task<List<Student>> Get()
        {
            return studentRepository.GetStudents();
        }
    }
}