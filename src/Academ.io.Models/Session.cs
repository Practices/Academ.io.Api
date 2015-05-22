using System;
using System.Collections.ObjectModel;

namespace Academ.io.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public string Name { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
    }
}