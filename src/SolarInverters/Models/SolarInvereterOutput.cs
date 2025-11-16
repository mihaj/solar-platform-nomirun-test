namespace SolarInverters.Models
{
    public class SolarInvereterOutput
    {
        public double AcOutputPowerKw { get; set; }
        public double AcVoltageV { get; set; }
        public double AcCurrentA { get; set; }
        public double EfficiencyPercent { get; set; }
        public double EnergyTodayKwh { get; set; }
        public double TotalEnergyKwh { get; set; }
        public string Status { get; set; }
    }
}