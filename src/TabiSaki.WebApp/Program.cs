using TabiSaki.ApplicationGlue;
using TabiSaki.WebApp.Components;
using TabiSaki.Services.Data;

namespace TabiSaki.WebApp;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddOptions<AppSettings>()
            .BindConfiguration("Secrets")
            .ValidateDataAnnotations()
            .ValidateOnStart();

        builder.Services.AddApplicationGlue(builder.Configuration);
        if (builder.Configuration.GetValue<bool>("UseInMemoryDatabase"))
        {
            builder.Services.AddTransient<DataSeederService>();
        }

        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
