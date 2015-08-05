using System.Collections.Generic;
using AcademicAnalysis.ElectronicUniversityServices.Models;

namespace Academ.io.University.Api.Models
{
    public class FacultyModel
    {
        public List<DepartmentModel> Departments { get; set; }
    }
}