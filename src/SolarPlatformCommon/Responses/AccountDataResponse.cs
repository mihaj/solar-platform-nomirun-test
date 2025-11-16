namespace SolarPlatformCommon.Responses
{
    public class AccountDataResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<long> SolarInverterIds { get; set; }
    }
}