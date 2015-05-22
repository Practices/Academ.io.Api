using System;

namespace Academ.io.Models
{
    public class SessionPoint
    {
        public int SessionPointId { get; set; }
        public int AveragePoint { get; set; }
        public Session Session { get; set; }
        public Student Student { get; set; }
        public DateTime LastPassDate { get; set; }
    }
}