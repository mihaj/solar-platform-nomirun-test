using Nomirun.Sdk.Abstractions.Interfaces;
using SolarPlatformCommon.Requests;
using SolarPlatformCommon.Responses;

namespace SolarInverters.Infrastructure.Handlers
{
    public class SolarInverterMonthlyReportHandler: IRequestHandler<GetSolarInverterMonthlyPowerReportRequest, SolarInvereterMonthyDataResponse>
    {
        public Task<SolarInvereterMonthyDataResponse> Handle(GetSolarInverterMonthlyPowerReportRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new SolarInvereterMonthyDataResponse
            {
                SolarInverterId = 100,
                MonthlyPowerKw = 2540
            });
        }
    }
}