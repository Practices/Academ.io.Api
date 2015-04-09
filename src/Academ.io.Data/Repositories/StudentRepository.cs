using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Academ.io.Data.Contexts;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public class StudentRepository: IStudentRepository
    {
        private readonly StudentContext studentContext;

        public StudentRepository(StudentContext studentContext)
        {
            this.studentContext = studentContext;
        }

        public async Task<List<Student>> GetStudents()
        {
            return await studentContext.Students.ToListAsync();
        }
    }
}