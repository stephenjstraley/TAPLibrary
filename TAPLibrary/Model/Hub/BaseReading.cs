using System;

namespace TAPLibrary.Model.Hub
{
    public class BaseReading
    {
        public DateTime? ReadingTimestamp { get; set; }
        public DateTime? DeviceReportedReadingTimestamp { get; set; }
        public DateTime? ReadingTimestampUtc { get; set; }
        public string ReadingTimestampUtcSource { get; set; }
        public string DeviceType { get; set; }

    }
}
