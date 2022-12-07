using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary.Model.Hub
{
    public class PulseOximeterReading : BaseDeviceReading
    {
        public PulseOximeterReading() : base()
        {
            DeviceType = DeviceTypes.OX;
        }

        public int? Length { get; set; }
        public double? BatteryVoltage { get; set; }
        public double? PulseAmplitudeIndex { get; set; }
        public int? Counter { get; set; }
        public double? SpO2 { get; set; }
        public string BloodOxygenUOM { get; set; }
        public double? PulseRate { get; set; }
        public string PulseUOM { get; set; }
        public bool? DisplaySyncIndication { get; set; }
        public bool? LowOrWeakSignal { get; set; }
        public bool? SmartPointAlgorithmSuccessful { get; set; }
        public bool? SearchingForSignal { get; set; }
        public bool? CorrectionCheck { get; set; }
        public bool? LowBattery { get; set; }
        public bool? Encryption { get; set; }
    }

    [Flags]
    public enum PulseOximeterStatus
    {
        Unknown = 0x00,
        DisplaySync = 0x01,
        LowSignal = 0x02,
        SmartPoint = 0x04,
        Searching = 0x08,
        CorrectCheck = 0x10,
        LowBattery = 0x20,
        Encryption = 0x40
    }

}
