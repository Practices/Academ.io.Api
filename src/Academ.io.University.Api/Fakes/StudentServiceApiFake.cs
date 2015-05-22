using System.Collections.Generic;
using System.Linq;
using Academ.io.University.Api.Models;
using Academ.io.University.Api.Services.Contingents;

namespace Academ.io.University.Api.Fakes
{
    public class StudentServiceApiFake: IStudentServiceApi
    {
        private List<StudentModel> student = GenerateData.GetStudents();

        public IEnumerable<StudentModel> GetStudentsByContainer(string value)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<StudentModel> GetStudentById(string value)
        {
            return student.Where(x => x.StudentId == value);
        }

        public IEnumerable<StudentModel> GetStudentByFamily(string value)
        {
            return student.Where(x => x.Lastname == value);
        }

        public IEnumerable<StudentModel> GetStudentByCardnumber(string value)
        {
            return student.Where(x => x.CardNumber == value);
        }
    }
}