using System;
using System.Collections.ObjectModel;

namespace Academ.io.Models
{
    public class AcademUser
    {
        private Collection<Student> students;
        public int AcademUserId { get; set; }
        public Guid UserId { get; set; }

        public Collection<Student> Students
        {
            get { return students ?? (students = new Collection<Student>()); }
            set { students = value; }
        }
    }
}