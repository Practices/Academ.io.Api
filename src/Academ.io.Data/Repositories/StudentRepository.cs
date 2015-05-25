using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Academ.io.Data.Contexts;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public class StudentRepository: IStudentRepository
    {
        private readonly AcademContext context;

        public StudentRepository(AcademContext context)
        {
            this.context = context;
        }

        public List<Group> GetGroupsByUserId(Guid userId)
        {
            var user = GetUser(userId);
            return user.Groups.ToList();
        }

        public Group AddGroup(Guid userId, Group group)
        {
            var user = GetUser(userId);
            if (user.Groups.SingleOrDefault(x => x.GroupGuid == group.GroupGuid) == null)
            {
                var groupAttach = context.Groups.SingleOrDefault(x => x.GroupGuid == group.GroupGuid) ?? context.Groups.Add(group);
                user.Groups.Add(groupAttach);
                context.AcademUsers.AddOrUpdate(user);
                context.SaveChanges();
                return groupAttach;
            }
            return group;
        }

        public Group RemoveGroup(Guid userId, int studentId)
        {
//            var user = GetUser(userId);
//            var studentGuid = new Guid(studentId);
//            var studentAttach = user.Groups.SingleOrDefault(x => x.StudentIdentity == studentGuid);
//            if(studentAttach != null)
//            {
//                user.Groups.Remove(studentAttach);
//                context.SaveChanges();
//            }
//            return studentAttach;
            return null;
        }

        public Student GetStudentsById(Guid userId, int studentId)
        {
            return context.Students.Include(t=>t.Group).SingleOrDefault(x=>x.StudentId == studentId);
        }

        public void AddStudents(List<Student> students, Group group)
        {
            foreach(Student student in students)
            {
                student.Group = group;
            }

            context.Students.AddRange(students);
            context.SaveChanges();
        }

        public Student GetStudentsById(int studentId)
        {
            return context.Students.Find(studentId);
        }

        private AcademUser GetUser(Guid userId)
        {
            return context.AcademUsers.Include(x => x.Groups.Select(c => c.Students)).SingleOrDefault(x => x.UserId == userId) ?? context.AcademUsers.Add(new AcademUser
            {
                UserId = userId
            });
        }
    }
}