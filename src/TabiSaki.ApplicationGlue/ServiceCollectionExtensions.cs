using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using TabiSaki.ApplicationGlue.Services;
using TabiSaki.Application.Services;
using TabiSaki.Data;

namespace TabiSaki.ApplicationGlue;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationGlue(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAppDbContext(configuration)
            .AddRepositories(configuration)
            .AddAppServices(configuration);

        return services;
    }

    private static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<ILocationService, LocationService>();

        return services;
    }
}
