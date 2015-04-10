namespace Academ.io.Models
{
    public class Mark
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public TestType TestType { get; set; }
    }

    public class TestType   
    {
        public int TestTypeId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}