using Microsoft.Extensions.DependencyInjection;
using Nomirun.Sdk.Extensions;

namespace SolarInverters.Extensions;

public static class SwaggerDocumentationExtensions
{
    public static void ConfigureSwaggerDocs(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            // Add other Swagger options.
            options.IncludeSwaggerXmlDocumentation(nameof(SolarInverters));
        });
    }
}