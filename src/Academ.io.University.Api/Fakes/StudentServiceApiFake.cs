using System.Collections.Generic;
using System.Linq;
using Academ.io.University.Api.Models;
using Academ.io.University.Api.Services.Contingents;

namespace Academ.io.University.Api.Fakes
{
    public class StudentServiceApiFake: IStudentServiceApi
    {
        private List<StudentModel> students = GenerateData.GetStudents();
        private List<GroupModel> groups = GenerateData.GetGroups();

        public IEnumerable<StudentModel> GetStudentsByContainer(string value)
        {
            return students.Where(x => x.GroupId == value);
        }

        public IEnumerable<StudentModel> GetStudentById(string value)
        {
            return students.Where(x => x.StudentIdentity == value);
        }

        public IEnumerable<StudentModel> GetStudentByFamily(string value)
        {
            return students.Where(x => x.Lastname == value);
        }

        public IEnumerable<StudentModel> GetStudentByCardnumber(string value)
        {
            return students.Where(x => x.CardNumber == value);
        }

        public IEnumerable<GroupModel> GetGroupsByName(string value)
        {
            return groups.Where(x => x.Name.Contains(value));
        }
    }
}