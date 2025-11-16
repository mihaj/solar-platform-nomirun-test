namespace Reports.Models
{
    public class MonthlyReport
    {
        public string Title { get; set; }
        public string OwnerName { get; set; }
        public long SolarInverterId { get; set; }
        public double MonthlyPowerKwh { get; set; }
    }
}