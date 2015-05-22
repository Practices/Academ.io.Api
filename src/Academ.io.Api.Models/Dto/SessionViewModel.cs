using System.Collections.Generic;

namespace Academ.io.Api.Models.Dto
{
    public class SessionViewModel
    {
        public List<DisciplineViewModel> Discipline { get; set; }
        public List<ChartProgressViewModel> ProgressViewModels { get; set; }
    }
}