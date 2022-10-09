using CinemaNet.Infrastructure.Persistence;

namespace CinemaNet.Api;

public static class Extensions
{
    public static async Task<WebApplication> CreateDatabaseIfNotExists(this WebApplication webApplication)
    {
        using var scope = webApplication.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<CinemaNetContext>();
        await context.Database.EnsureCreatedAsync();
        await DatabaseInitializer.InitializeAsync(context);

        return webApplication;
    }
}