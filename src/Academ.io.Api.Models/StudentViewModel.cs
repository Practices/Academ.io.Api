using System;

namespace Academ.io.Api.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public Guid StudentIdentity { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Cardnumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string GroupName { get; set; }
    }
}