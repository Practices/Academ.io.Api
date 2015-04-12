namespace Academ.io.Models
{
    //оценка
    public class Mark
    {
        public int MarkId { get; set; }
        //сопоставление идентификатор оценки из электронного университета
        public int GradeMark { get; set; }
        public string Title { get; set; }
        public string TitleShort { get; set; }
        public int TestTypeId { get; set; }
        public TestType TestType { get; set; }
    }

    //тип сдачи
    public class TestType
    {
        public int TestTypeId { get; set; }
        public string Title { get; set; }
        public string TitleShort { get; set; }
    }
}