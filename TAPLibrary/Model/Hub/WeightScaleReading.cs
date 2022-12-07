using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary.Model.Hub
{
    public class WeightScaleReading : BaseDeviceReading
    {
        public WeightScaleReading() : base()
        {
            DeviceType = DeviceTypes.WEIGHT;
        }

        public double BodyWeightLb { get; set; }
        public double BodyWeightKg { get; set; }
        public double? BodyFat { get; set; }
        public double? BMI { get; set; }
        public string WeightUOM { get; set; }

    }
}
