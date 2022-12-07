using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary.Model.Hub
{
    public class BPDeviceReading : BaseDeviceReading
    {
        public BPDeviceReading() : base()
        {
            DeviceType = DeviceTypes.BP;
        }
        public int? HeartRate;
        public int? Systolic;
        public int? Diastolic;
        public int? ArterialPressure;
        public int? UserId;
        public bool HeartRateAvailable;
        public bool TimeStampAvailable;
        public bool UserIdAvailable;
        public bool UnitskPa;
        public bool MeasurementStatusFlagsAvailable;
        public bool? BodyMovementDetected;
        public bool? CuffTooLoose;
        public bool? IrregularPulseDetected;
        public bool? ImproperMeasurementDetected;
        public bool? PulseRateInRange;
        public bool? PulseRateExceedsUpperLimit;
        public bool? PulseRateBelowLowerLimit;
        public string BPUOM;
    }
}
