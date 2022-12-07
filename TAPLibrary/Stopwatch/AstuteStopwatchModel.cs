using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary.Stopwatch
{
    public class AstuteStopwatchModel
    {
        public string ProcessName { get; set; } = string.Empty;
        public string ProcessType { get; set; } = string.Empty;
        public string Guid { get; set; } = string.Empty;
        public DateTime StartStopTime { get; set; }
    }
}
