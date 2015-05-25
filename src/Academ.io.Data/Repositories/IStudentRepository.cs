using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public interface IStudentRepository
    {
        List<Group> GetGroupsByUserId(Guid userId);
        Group AddGroup(Guid userId, Group group);
        Group RemoveGroup(Guid userId, int groupId);
        Student GetStudentsById(Guid userId, int studentId);
        void AddStudents(List<Student> students, Group group);
    }
}