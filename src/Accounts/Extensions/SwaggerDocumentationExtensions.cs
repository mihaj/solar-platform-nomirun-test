using Microsoft.Extensions.DependencyInjection;
using Nomirun.Sdk.Extensions;

namespace Accounts.Extensions;

public static class SwaggerDocumentationExtensions
{
    public static void ConfigureSwaggerDocs(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            // Add other Swagger options.
            options.IncludeSwaggerXmlDocumentation(nameof(Accounts));
        });
    }
}