using System;

namespace Academ.io.Models
{
    public class Discipline
    {
        public Guid DisciplineId { get; set; }
        public string DisciplineName { get; set; }
        public string DisciplineDepartment { get; set; }
        public int Term { get; set; }
        public int Audlek { get; set; }
        public DateTime TestDate { get; set; }
        public Mark Mark { get; set; }
        public TestType TestType { get; set; }
    }
}