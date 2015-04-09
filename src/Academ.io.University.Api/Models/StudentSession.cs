using System;
using System.Collections.Generic;
using RestSharp.Deserializers;

namespace AcademicAnalysis.ElectronicUniversityServices.Models
{
    [DeserializeAs(Name = "student")]
    public class StudentSession
    {
        [DeserializeAs(Name = "student_uuid")]
        public Guid StudentId { get; set; }
        [DeserializeAs(Name = "fio")]
        public string Fullname { get; set; }
        [DeserializeAs(Name = "realgroup_name")]
        public string Group { get; set; }
        [DeserializeAs(Name = "group_uuid")]
        public Guid GroupId { get; set; }

        public List<DisciplineModel> Disciplines { get; set; }
    }
}