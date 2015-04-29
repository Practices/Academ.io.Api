using System.Collections.Generic;
using System.Threading.Tasks;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsByUserId();
        Task<List<Student>> GetStudentsByName(string name);
        Student AddStudent(Student student, string userId);
        Student DeleteStudent(Student student, string userId);
    }
}