using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Academ.io.Models;

namespace Academ.io.Services.Students
{
    public interface IStudentService
    {
        Student AddStudent(string userId, string studentId);
        List<Student> GetStudents(string userId);
        List<Student> GetStudentsByName(string name);
        Student DeleteStudent(string userId, string studentId);
    }
}