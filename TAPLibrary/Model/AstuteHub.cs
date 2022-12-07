using System.Collections.Generic;
using TAPLibrary.Logging;

namespace TAPLibrary.Model
{
    public class AstuteMessageLog
    {
        public string EventId { get; set; }
        public string ProcessName { get; set; }
        public string LoggingType { get; set; }
        public string CallingNamespace { get; set; }
        public string CallingProcedure { get; set; }
        public string ClientClient { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string MessageTemplate { get; set; }
        public string Level { get; set; }
        public LogDetail Detail { get; set; }
    }

    public class AstuteHubBase
    {
        public System.DateTime GatewayTimestamp;
        public string GatewayType;
        public string HubId;
        public string DeviceType;
        public string MacAddress;
        public System.DateTime ServerTimestamp;
        public object Reading;
        public List<object> ParsingErrors;
        public string RawPayload;
        public string PatientToken;
        public string DeviceManufacturer;
        public string DeviceModel;
        public string DeviceSerialNumber;
        public string DeviceHardwareVersion;
        public string DeviceSoftwareVersion;
        public string DeviceFirmwareVersion;
        public bool BeenPulled;
    }

    public class AstuteHub : AstuteHubBase
    {
        public string id;
        public string _rid;
        public string _self;
        public string _ts;
        public string _etag;
    }
    public class AstuteHubWithEvent : AstuteHub
    {
        public string EventId;
        public string OriginalMessage;
    }

}
