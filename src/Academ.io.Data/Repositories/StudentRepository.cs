using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
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

        public List<Student> GetStudentsByUserId(Guid userId)
        {
            var user = GetUser(userId);
            return user.Students.ToList();
        }

        public List<Student> GetStudentsByName(string name)
        {
            return context.Students.Where(x => x.Lastname == name).ToList();
        }

        public Student AddStudent(Guid userId, Student student)
        {
            var user = GetUser(userId);

            if(user.Students.SingleOrDefault(x => x.StudentIdentity == student.StudentIdentity) == null)
            {
                var studentAttach = context.Students.SingleOrDefault(x => x.StudentIdentity == student.StudentIdentity) ?? context.Students.Add(student);
                user.Students.Add(studentAttach);
                context.AcademUsers.AddOrUpdate(user);
                context.SaveChanges();
                return studentAttach;
            }
            return student;
        }

        public Student DeleteStudent(Guid userId, string studentId)
        {
            var user = GetUser(userId);
            var studentGuid = new Guid(studentId);
            var studentAttach = user.Students.SingleOrDefault(x => x.StudentIdentity == studentGuid);
            if(studentAttach != null)
            {
                user.Students.Remove(studentAttach);
                context.SaveChanges();
            }
            return studentAttach;
        }

        public Student GetStudentsById(Guid userId, int studentId)
        {
            var student = context.Students.Include(t => t.Users).SingleOrDefault(x => x.StudentId == studentId);
            if(student != null)
            {
                if(student.Users.FirstOrDefault(x => x.UserId == userId) != null)
                {
                    return student;
                }
            }
            return null;
        }

        private AcademUser GetUser(Guid userId)
        {
            return context.AcademUsers.Include(x => x.Students).SingleOrDefault(x => x.UserId == userId) ?? context.AcademUsers.Add(new AcademUser
            {
                UserId = userId
            });
        }
    }
}