using System;
using System.Collections.ObjectModel;

namespace Academ.io.Models
{
    public class Student
    {
        private Collection<AcademUser> users;
        public Guid StudentId { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Cardnumber { get; set; }
        public DateTime Birthdate { get; set; }
        public Guid GroupId { get; set; }
        public string Group { get; set; }

        public Collection<AcademUser> Users
        {
            get { return users ?? (users = new Collection<AcademUser>()); }
            set { users = value; }
        }
    }
}