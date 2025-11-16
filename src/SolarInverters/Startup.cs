using SolarInverters.Extensions;
using Nomirun.Sdk.Abstractions;
using Nomirun.Sdk.Abstractions.Interfaces;
using Nomirun.Sdk.Infrastructure.HttpClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SolarInverters.Infrastructure.Handlers;
using SolarPlatformCommon.Requests;
using SolarPlatformCommon.Responses;

namespace SolarInverters;

public class Startup: INomirunBootstrapable
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    private IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        //Add customer service registration

        //Registration of Nomirun HTTP Client
        services.AddScoped<IHttpClientService, HttpClientService>();

        //Register Swagger documentation
        services.ConfigureSwaggerDocs();

        services.AddTransient<IRequestHandler<GetSolarInverterMonthlyPowerReportRequest, SolarInvereterMonthyDataResponse>, SolarInverterMonthlyReportHandler>();
    }
}