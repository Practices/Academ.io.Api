using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Academ.io.Models
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        private Collection<AcademUser> users;
        public Guid StudentIdentity { get; set; }
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