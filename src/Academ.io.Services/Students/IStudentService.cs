using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Academ.io.Api.Models.Dto;
using Academ.io.Models;

namespace Academ.io.Services.Students
{
    public interface IStudentService
    {
        Student AddStudent(Guid userId, Student student);
        List<Student> GetStudents(Guid userId);
        List<Student> GetStudentsByName(string name);
        Student DeleteStudent(Guid userId, string studentId);
        Student GetStudent(Guid userId, int studentId);
    }
}