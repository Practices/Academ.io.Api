using System.Collections.Generic;
using System.Threading.Tasks;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudents();
    }
}