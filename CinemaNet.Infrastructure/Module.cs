using CinemaNet.Abstractions.Repositories;
using CinemaNet.Infrastructure.Mapping.Resolvers;
using CinemaNet.Infrastructure.Persistence;
using CinemaNet.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CinemaNet.Infrastructure;

public static class Module
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(cfg => cfg.AddMaps(typeof(Module).Assembly));
        services.AddTransient<DirectorResolver>();
        services.AddTransient<StaffResolver>();
        
        services.AddDbContext<CinemaNetContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("CinemaNetContext")));
        
        services.AddScoped<IMovieReadOnlyRepository, MovieReadOnlyRepository>();
        
        return services;
    }
}