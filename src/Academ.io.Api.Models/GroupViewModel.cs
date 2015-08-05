using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Academ.io.Models;

namespace Academ.io.Api.Models
{
    public class GroupViewModel
    {
        public int GroupId { get; set; }
        public Guid GroupGuid { get; set; }
        public string Name { get; set; }
        public List<StudentViewModel> Students { get; set; }
    }
}