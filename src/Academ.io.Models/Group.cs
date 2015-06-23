using System;
using System.Collections.ObjectModel;

namespace Academ.io.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public Guid GroupGuid { get; set; }
        public string Name { get; set; }
        public Collection<Student> Students { get; set; }
    }
}