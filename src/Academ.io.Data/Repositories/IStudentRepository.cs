using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetStudentsByUserId(Guid userId);
        List<Student> GetStudentsByName(string name);
        Student AddStudent(Guid userId, Student student);
        Student DeleteStudent(Guid userId, string student);
        Student GetStudentsById(Guid userId, int studentId);
    }
}