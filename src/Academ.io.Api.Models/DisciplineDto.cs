using System;

namespace Academ.io.Api.Models
{
    public class DisciplineDto
    {
        public string DisciplineName { get; set; }
        public string DisciplineDepartment { get; set; }

        public int MarkGrade { get; set; }
        public string MarkShortName { get; set; }

        public int TestTypeId { get; set; }
        public string TestTypeName { get; set; }
        public DateTime TestDate { get; set; }
    }
}