using System;
using RestSharp.Deserializers;

namespace Academ.io.University.Api.Models
{
    public class StudentModel
    {
        [DeserializeAs(Name = "uuid")]
        public string StudentId { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }

        [DeserializeAs(Name = "card_number")]
        public string CardNumber { get; set; }

        public DateTime Birthdate { get; set; }

        [DeserializeAs(Name = "group_uuid")]
        public string GroupId { get; set; }

        public string Group { get; set; }
    }
}