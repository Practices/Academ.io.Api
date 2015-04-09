using System.Collections.ObjectModel;

namespace Academ.io.Models
{
    public class Faculty
    {
        public Collection<Department> Departments { get; set; }
    }
}