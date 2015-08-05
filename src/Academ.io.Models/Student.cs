using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Academ.io.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public Guid StudentIdentity { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Cardnumber { get; set; }
        public DateTime Birthdate { get; set; }
        public Group Group { get; set; }
    }
}