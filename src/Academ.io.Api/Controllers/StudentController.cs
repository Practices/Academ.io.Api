using System.Collections.Generic;
using System.Web.Http;
using Academ.io.Api.Models.Dto;
using Academ.io.Services.Students;
using AutoMapper;
using Microsoft.AspNet.Identity;

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
        public IHttpActionResult Get()
        {
            string userId = User.Identity.GetUserId();
            var students = studentService.GetStudents(userId);
            IList<StudentViewModel> studentsViewModel = new List<StudentViewModel>();
            Mapper.Map(students, studentsViewModel);
            return Ok(studentsViewModel);
        }

        [Authorize]
        public IHttpActionResult GetStudentByName(string name)
        {
            var students = studentService.GetStudentsByName(name);
            IList<StudentViewModel> studentsViewModel = new List<StudentViewModel>();
            Mapper.Map(students, studentsViewModel);
            return Ok(studentsViewModel);
        }

        [Authorize]
        public IHttpActionResult Post(string id)
        {
            var userId = User.Identity.GetUserId();
            var student = studentService.AddStudent(userId, id);
            StudentViewModel studentViewModel = new StudentViewModel();
            Mapper.Map(student, studentViewModel);
            return Ok(studentViewModel);
        }

        [Authorize]
        public IHttpActionResult DeleteStudent(string id)
        {
            var userId = User.Identity.GetUserId();
            var student = studentService.DeleteStudent(userId, id);
//            StudentViewModel studentViewModel = new StudentViewModel();
//            Mapper.Map(student, studentViewModel);
            return Ok();
        }
    }
}