using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Academ.io.Models;

namespace Academ.io.Services.Students
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudents(Guid userId);
    }
}