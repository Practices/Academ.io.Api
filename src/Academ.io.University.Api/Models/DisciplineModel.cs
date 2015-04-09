using System;
using RestSharp.Deserializers;

namespace AcademicAnalysis.ElectronicUniversityServices.Models
{
    public class DisciplineModel
    {
        public int Mark { get; set; }
        public int TestType { get; set; }
        [DeserializeAs(Name = "discipline_uuid")]
        public Guid DisciplineId { get; set; }

        public string DisciplineName { get; set; }
        public string DisciplineDepartment { get; set; }
        public int Term { get; set; }
        public int Audlek { get; set; }
        public DateTime TestDate { get; set; }
    }
}