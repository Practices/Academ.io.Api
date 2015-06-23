using System;
using System.Collections.Generic;
using System.Linq;
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
            Mapper.CreateMap<StudentModel, Student>().ForMember(d=>d.Group,o=>o.Ignore());
            Mapper.CreateMap<GroupModel, Group>().ForMember(d => d.Students, o => o.Ignore());
        }

        public IEnumerable<Student> GetStudents(Guid userId)
        {
            var groups = studentRepository.GetGroupsByUserId(userId);
            var students = new List<Student>();
            foreach(Group item in groups)
            {
                students.AddRange(item.Students);
            }
            return students;
        }

        public Student GetStudent(Guid userId, int studentId)
        {
            return studentRepository.GetStudentsById(userId, studentId);
        }

        public List<Group> GetGroupsByName(string name)
        {
            var data = studentServiceApi.GetGroupsByName(name);
            var result = new List<Group>();
            Mapper.Map(data, result);
            return result;
        }

        public Group AddGroup(Guid userId, Group group)
        {
            var groupAttach = studentRepository.AddGroup(userId, group);
            if(groupAttach.GroupId > 0)
            {
                if(!groupAttach.Students.Any())
                {
                    var data = studentServiceApi.GetStudentsByContainer(groupAttach.GroupGuid.ToString());
                    var result = new List<Student>();
                    Mapper.Map(data, result);
                    studentRepository.AddStudents(result, groupAttach);
                }
            }

            return groupAttach;
        }

        public Group RemoveGroup(Guid userId, int groupId)
        {
            return studentRepository.RemoveGroup(userId, groupId);
        }
    }
}