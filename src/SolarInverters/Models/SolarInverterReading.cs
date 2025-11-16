namespace SolarInverters.Models
{
    public class SolarInverterReading
    {
        public double CurrentAcOutputPowerKw { get; set; }
        public double CurrentAcVoltageV { get; set; }
        public double CurrentAcCurrentA { get; set; }
        public long Timestamp { get; set; }
    }
}