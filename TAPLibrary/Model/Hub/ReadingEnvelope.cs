using System;

namespace TAPLibrary.Model.Hub
{
    public class ReadingEnvelope
    {
        public string EventId;
        public DateTime GatewayTimestamp;
        public int? UtcOffset;
        public string GatewayType;
        public string HubId;
        public string DeviceType;
        public string MacAddress;
        public DateTime ServerTimestamp;
        public object Reading;
        public string[] ParsingErrors;
        public string RawPayload;
        public string PatientToken;
        public string DeviceManufacturer;
        public string DeviceModel;
        public string DeviceSerialNumber;
        public string DeviceHardwareVersion;
        public string DeviceSoftwareVersion;
        public string DeviceFirmwareVersion;
        public string DeviceSpecificInformation;
        public bool? ManualEntry;
        public string ManualEntryAuthorRole; 
        public string ManualEntryAuthorToken;
    }
}
