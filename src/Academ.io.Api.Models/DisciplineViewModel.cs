using System;

namespace Academ.io.Api.Models
{
    public class DisciplineViewModel
    {
        public string DisciplineName { get; set; }
        public string DisciplineDepartment { get; set; }

        //оценка
        public int MarkGrade { get; set; }
        public string MarkShortName { get; set; }
        //тип сдачи
        public int TestTypeId { get; set; }
        public string TestTypeName { get; set; }

        public DateTime TestDate { get; set; }
    }
}