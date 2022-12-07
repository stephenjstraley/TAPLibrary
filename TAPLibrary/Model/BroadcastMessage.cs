using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary.Model
{
    public class BroadcastMessage
    {
        public DateTime DateTimeUTC { get; set; }
        public string Event { get; set; }
        public string HubId { get; set; }
        public string HubTimeStamp { get; set; }
        public string ContextId { get; set; }
        public string DocId { get; set; }
        public string RawPayLoad { get; set; }
        public int Count { get; set; } = 0;
        public string Value { get; set; } = "";
    }
}
