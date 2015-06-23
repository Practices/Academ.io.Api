using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Academ.io.Models;

namespace Academ.io.Services.Students
{
    public interface IStudentService
    {
        Group AddGroup(Guid userId, Group group);
        IEnumerable<Student> GetStudents(Guid userId);
        List<Group> GetGroupsByName(string name);
        Group RemoveGroup(Guid userId, int groupId);
        Student GetStudent(Guid userId, int studentId);
    }
}