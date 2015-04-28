using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public async Task<List<Student>> GetStudentsByUserId(string userId)
        {
            var id = new Guid(userId);
            var user = await context.Users.Include(i => i.Students).SingleOrDefaultAsync(x => x.UserId == id);
            return user.Students.ToList();
        }

        public Student AddStudent(Student student, string userId)
        {
            var id = new Guid(userId);
            var user = context.Users.SingleOrDefault(x => x.UserId == id);
            if(user != null)
            {
                user = new AcademUser{UserId = id};
            }

            user.Students.Add(student);
            context.Users.Add(user);
            context.SaveChanges();

            return student;
        }

        public void DeleteStudent(Student student,string userId )
        {
            var id = new Guid(userId);
            var user = context.Users.SingleOrDefault(x => x.UserId == id);
            user.Students.Remove(student);
            context.SaveChanges();
        }
    }
}