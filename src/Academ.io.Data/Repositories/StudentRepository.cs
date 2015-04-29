using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using Academ.io.Data.Contexts;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public class StudentRepository: IStudentRepository
    {
        private readonly StudentContext context;

        public StudentRepository(StudentContext context)
        {
            this.context = context;
        }

        public async Task<List<Student>> GetStudentsByUserId()
        {
            return await context.Students.ToListAsync();
        }

        public async Task<List<Student>> GetStudentsByName(string name)
        {
            return await context.Students.Where(x => x.Lastname == name).ToListAsync();
        }

        public Student AddStudent(Student student, string userId)
        {
            var user = GetUser(userId);

            if(user.Students.SingleOrDefault(x => x.StudentIdentity == student.StudentIdentity) == null)
            {
                var studentAttach = context.Students.SingleOrDefault(x => x.StudentIdentity == student.StudentIdentity) ?? context.Students.Add(student);
                user.Students.Add(studentAttach);
                context.Users.AddOrUpdate(user);
                context.SaveChanges();
                return studentAttach;
            }
            return student;
        }

        public Student DeleteStudent(Student student, string userId)
        {
            var user = GetUser(userId);
            var studentAttach = user.Students.SingleOrDefault(x => x.StudentIdentity == student.StudentIdentity);
            if(studentAttach != null)
            {
                user.Students.Remove(studentAttach);
                context.SaveChanges();
            }
            return studentAttach;
        }

        public async Task<List<Student>> GetStudentsByUserId(string userId)
        {
            var user = GetUser(userId);
            return user.Students.ToList();
        }

        private AcademUser GetUser(string id)
        {
            var userId = new Guid(id);
            return context.Users.Include(x => x.Students).SingleOrDefault(x => x.UserId == userId) ?? context.Users.Add(new AcademUser
            {
                UserId = userId
            });
        }
    }
}