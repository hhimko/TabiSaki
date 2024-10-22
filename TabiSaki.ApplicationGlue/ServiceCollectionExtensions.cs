using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using TabiSaki.Data;
using TabiSaki.ApplicationGlue.Services;
using TabiSaki.Application.Services;

namespace TabiSaki.ApplicationGlue;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationGlue(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAppDbContext(configuration);
        services.AddAppServices(configuration);

        return services;
    }

    private static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<ILocationService, LocationService>();

        return services;
    }
}