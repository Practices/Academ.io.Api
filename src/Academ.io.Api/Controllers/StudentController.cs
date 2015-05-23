using System;
using System.Collections.Generic;
using System.Web.Http;
using Academ.io.Api.Models.Dto;
using Academ.io.Models;
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
            var userId = GetUserId();
            var students = studentService.GetStudents(userId);
            IList<StudentViewModel> studentsViewModel = new List<StudentViewModel>();
            Mapper.Map(students, studentsViewModel);
            return Ok(studentsViewModel);
        }

        [Authorize]
        [Route("{studentId}")]
        public IHttpActionResult Get(int studentId)
        {
            var userId = GetUserId();
            var student = studentService.GetStudent(userId, studentId);
            if(student == null)
            {
                return BadRequest("Ошибка, такой студент не существует.");
            }
            StudentViewModel studentViewModel = new StudentViewModel();
            Mapper.Map(student, studentViewModel);
            return Ok(studentViewModel);
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
        public IHttpActionResult Post(StudentViewModel studentViewModel)
        {
            var userId = GetUserId();
            var student = new Student();
            Mapper.Map(studentViewModel, student);
            student = studentService.AddStudent(userId, student);
            Mapper.Map(student, studentViewModel);
            return Ok(studentViewModel);
        }

        [Authorize]
        public IHttpActionResult DeleteStudent(string id)
        {
            var userId = GetUserId();
            var student = studentService.DeleteStudent(userId, id);
            //            StudentViewModel studentViewModel = new StudentViewModel();
            //            Mapper.Map(student, studentViewModel);
            return Ok();
        }

        private Guid GetUserId()
        {
            return new Guid(User.Identity.GetUserId());
        }
    }
}