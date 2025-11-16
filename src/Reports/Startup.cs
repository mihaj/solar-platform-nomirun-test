using Reports.Extensions;
using Nomirun.Sdk.Abstractions;
using Nomirun.Sdk.Abstractions.Interfaces;
using Nomirun.Sdk.Infrastructure.HttpClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Reports;

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
    }
}