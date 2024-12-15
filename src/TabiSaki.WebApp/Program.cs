using TabiSaki.ApplicationGlue;
using TabiSaki.WebApp.Components;
using TabiSaki.Services.Data;
using TabiSaki.Services.Interfaces.Web;
using TabiSaki.Services.Web;

namespace TabiSaki.WebApp;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.AddTabiSakiServices();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            app.UseHsts();
        }

        if (app.Configuration.GetValue<bool>("UseInMemoryDatabase"))
        {
            await using var scope = app.Services.CreateAsyncScope();

            var seeder = scope.ServiceProvider.GetService<DataSeederService>();
            await seeder!.SeedSampleDataAsync();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        await app.RunAsync();
    }
}

internal static class ProgramExtensions
{
    internal static WebApplicationBuilder AddTabiSakiServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddOptions<AppSettings>()
           .BindConfiguration("Secrets")
           .ValidateDataAnnotations()
           .ValidateOnStart();

        builder.Services.AddApplicationGlue(builder.Configuration);

        builder.Services.AddScoped<IGeolocationService, MockGeolocationService>();
        //builder.Services.AddScoped<IGeolocationService, JsGeolocationService>();

        if (builder.Configuration.GetValue<bool>("UseInMemoryDatabase"))
        {
            builder.Services.AddTransient<DataSeederService>();
        }

        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        return builder;
    }
}