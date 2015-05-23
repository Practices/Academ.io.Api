using System;
using System.Collections.ObjectModel;

namespace Academ.io.Models
{
    public class Group
    {
        private Collection<AcademUser> users;
        public int GroupId { get; set; }
        public Guid GroupGuid { get; set; }
        public string Name { get; set; }
        public Collection<Student> Students { get; set; }

        public Collection<AcademUser> Users
        {
            get { return users ?? (users = new Collection<AcademUser>()); }
            set { users = value; }
        }
    }
}