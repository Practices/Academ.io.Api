using System.Collections.Generic;

namespace Academ.io.Api.Models.Dto
{
    public class SessionChartViewModel
    {
        public string Name { get; set; }
        public int TestId { get; set; }
        public int PositiveCount { get; set; }
        public int NegativeCount { get; set; }
    }
}