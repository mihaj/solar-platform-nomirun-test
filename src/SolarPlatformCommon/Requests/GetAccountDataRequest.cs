using Nomirun.Sdk.Abstractions.Interfaces;
using SolarPlatformCommon.Responses;

namespace SolarPlatformCommon.Requests
{
    public class GetAccountDataRequest: IRequest<AccountDataResponse>
    {
        public long AccountId { get; set; }
    }
}