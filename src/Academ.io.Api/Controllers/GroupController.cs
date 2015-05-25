using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Academ.io.Api.Models;
using Academ.io.Models;
using Academ.io.Services.Students;
using AutoMapper;
using Microsoft.AspNet.Identity;

namespace Academ.io.Api.Controllers
{
    [RoutePrefix("api/group")]
    public class GroupController : ApiController
    {
//        private readonly IStudentService studentService;
//
//        public GroupController(IStudentService studentService)
//        {
//            this.studentService = studentService;
//        }
//
//        [Authorize]
//        public IHttpActionResult Get()
//        {
//            var userId = GetUserId();
//            var groups = studentService.GetStudents(userId);
//            IList<GroupViewModel> groupViewModels = new List<GroupViewModel>();
//            Mapper.Map(groups, groupViewModels);
//            return Ok(groupViewModels);
//        }

//        [Authorize]
//        [Route("{studentId}")]
//        public IHttpActionResult Get(int studentId)
//        {
//            var userId = GetUserId();
//            var student = studentService.GetStudent(userId, studentId);
//            if(student == null)
//            {
//                return BadRequest("Ошибка, такой студент не существует.");
//            }
//            StudentViewModel studentViewModel = new StudentViewModel();
//            Mapper.Map(student, studentViewModel);
//            return Ok(studentViewModel);
//        }

//        [Authorize]
//        public IHttpActionResult GetGroupByName(string name)
//        {
//            var groups = studentService.GetGroupsByName(name);
//            IList<GroupViewModel> groupViewModels = new List<GroupViewModel>();
//            Mapper.Map(groups, groupViewModels);
//            return Ok(groupViewModels);
//        }
//
//        [Authorize]
//        public IHttpActionResult Post(GroupViewModel groupViewModel)
//        {
//            var userId = GetUserId();
//            var group = new Group();
//            Mapper.Map(groupViewModel, group);
//            group = studentService.AddGroup(userId, group);
//            Mapper.Map(group, groupViewModel);
//            return Ok(groupViewModel);
//        }
//
//        [Authorize]
//        public IHttpActionResult DeleteGroup(string id)
//        {
//            var userId = GetUserId();
////            var student = studentService.DeleteStudent(userId, id);
//            //            StudentViewModel studentViewModel = new StudentViewModel();
//            //            Mapper.Map(student, studentViewModel);
//            return Ok();
//        }
//
//        private Guid GetUserId()
//        {
//            return new Guid(User.Identity.GetUserId());
//        }
    }
}
