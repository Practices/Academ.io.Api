namespace Academ.io.Models
{
    //оценка
    public class Mark
    {
        public int MarkId { get; set; }
        //сопоставление идентификатор оценки из электронного университета
        public int Grade { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public TestType TestType { get; set; }
    }
}