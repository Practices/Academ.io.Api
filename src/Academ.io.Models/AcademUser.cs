using System;
using System.Collections.ObjectModel;

namespace Academ.io.Models
{
    public class AcademUser
    {
        public int AcademUserId { get; set; }
        public Guid UserId { get; set; }
        public Collection<Student> Students { get; set; }
    }
}