using System;
using System.Collections.Generic;
using System.Web.Http;
using Academ.io.Api.Models;
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
            IList<StudentViewModel> studentsViewModels = new List<StudentViewModel>();
            Mapper.Map(students, studentsViewModels);
            return Ok(studentsViewModels);
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
        public IHttpActionResult GetGroupByName(string name)
        {
            var groups = studentService.GetGroupsByName(name);
            IList<GroupViewModel> groupViewModels = new List<GroupViewModel>();
            Mapper.Map(groups, groupViewModels);
            return Ok(groupViewModels);
        }

        [Authorize]
        public IHttpActionResult Post(GroupViewModel groupViewModel)
        {
            var userId = GetUserId();
            var group = new Group();
            Mapper.Map(groupViewModel, group);
            group = studentService.AddGroup(userId, group);
            Mapper.Map(group, groupViewModel);
            return Ok(groupViewModel);
        }

        
        //        [Authorize]
        //        public IHttpActionResult DeleteStudent(string id)
        //        {
        //            var userId = GetUserId();
        //            var student = studentService.DeleteStudent(userId, id);
        //            //            StudentViewModel studentViewModel = new StudentViewModel();
        //            //            Mapper.Map(student, studentViewModel);
        //            return Ok();
        //        }

        private Guid GetUserId()
        {
            return new Guid(User.Identity.GetUserId());
        }
    }
}