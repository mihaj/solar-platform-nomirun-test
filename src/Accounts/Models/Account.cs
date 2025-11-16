namespace Accounts.Models
{
    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<long> SolarInverterIds { get; set; }
    }
}