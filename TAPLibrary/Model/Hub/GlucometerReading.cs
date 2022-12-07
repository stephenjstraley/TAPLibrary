
namespace TAPLibrary.Model.Hub
{
    public class GlucometerReadings : BaseDeviceReading
    {
        public object[] readings;
    }
    public class GlucometerReading : BaseDeviceReading
    {
        public GlucometerReading() : base()
        {
            DeviceType = DeviceTypes.GLUCOSE;
        }

        public int? Sequence { get; set; }
        public double GlucoseConcentration { get; set; }                      
        public string GlucoseConcentrationLevel { get; set; } // High/Low
        public bool? IsFasting { get; set; }
        public bool? IsConcentrationMolL { get; set; }
        public int? TimeOffset { get; set; }
        public bool? SensorResultHigherThanDeviceCanProcess { get; set; }
        public bool? SensorResultLowerThanDeviceCanProcess { get; set; }
        public double? AmbientTemperatureCelsius { get; set; }
        public string SampleLocation { get; set; }
        public string SampleType { get; set; }
        public string GlucoseUOM { get; set; }
        public bool? IsCarbIdPresent { get; set; }
        public bool? MealEventTagPresent { get; set; }
        public bool? TesterHealthPresent { get; set; }
        public bool? ExerciseDurationIntensityPresent { get; set; }
        public bool? MedicationIdPresent { get; set; }
        public bool? MedicationUnitsPresent { get; set; }
        public bool? HbA1cPresent { get; set; }
        public bool? ExtendedFlagsPresent { get; set; }
        public bool? PrePrandal { get; set; }
        public bool? PostPrandal { get; set; }

    }
}
