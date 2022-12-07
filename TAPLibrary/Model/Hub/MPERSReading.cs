using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary.Model.Hub
{
    public class MPERSReading : BaseDeviceReading
    {
        public MPERSReading() : base()
        {
            DeviceType = DeviceTypes.MPERS;
        }

        public int? PackLength;
        public int? Gap;
        public int? PacketSequence;
        public int? Version;
        public string ReservedStatus;
        public bool? FallDetected;
        public bool? PanicButtonPressed;
        public bool? BatteryNormal;
        public bool? BatteryLow;
        public bool? BatteryCritical;

        public bool? CompliantLastHour;
        public bool? CompliantTwoHours;
        public bool? CompliantThreeHours;
        public bool? CompliantFourHours;
        public bool? CompliantFiveHours;
        public bool? CompliantSixHours;

        public int? ActivePERSId;
        public int? Reserved;
        public int? TotalSteps;
        public int? OneHour;
        public int? TwoHours;
        public int? ThreeHours;
        public int? FourHours;
        public int? FiveHours;
        public int? SixHours;
    }
}
