using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Academ.io.Data.Repositories;
using Academ.io.Models;
using Academ.io.Services.Students;

namespace Academ.io.Api.Controllers
{
    [RoutePrefix("api/student")]
    public class StudentController: ApiController
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [Authorize]
        public Task<List<Student>> Get()
        {
            string userEmail = RequestContext.Principal.Identity.Name;

            return null;

        }
        
        [Authorize]
        public IHttpActionResult Get(string name)
        {
            return Ok();
        }
    }
}