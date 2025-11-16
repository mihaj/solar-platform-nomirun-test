using Nomirun.Sdk.Abstractions.Interfaces;
using SolarPlatformCommon.Responses;

namespace SolarPlatformCommon.Requests
{
    public class GetSolarInverterMonthlyPowerReportRequest: IRequest<SolarInvereterMonthyDataResponse>
    {
        public long SolarInverterId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}