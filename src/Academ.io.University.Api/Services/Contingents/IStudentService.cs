using System.Collections.Generic;
using Academ.io.Models;

namespace Academ.io.University.Api.Services.Contingents
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudentsByContainer(string value);
        IEnumerable<Student> GetStudentById(string value);
        IEnumerable<Student> GetStudentByFamily(string value);
        IEnumerable<Student> GetStudentByCardnumber(string value);
    }
}