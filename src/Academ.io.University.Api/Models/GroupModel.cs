using System;
using RestSharp.Deserializers;

namespace Academ.io.University.Api.Models
{
    public class GroupModel
    {
        [DeserializeAs(Name = "id")]
        public string GroupGuid { get; set; }

        [DeserializeAs(Name = "abbr")]
        public string Name { get; set; }
    }
}