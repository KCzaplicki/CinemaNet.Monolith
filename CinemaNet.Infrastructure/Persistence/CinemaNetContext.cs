using CinemaNet.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaNet.Infrastructure.Persistence;

public class CinemaNetContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public DbSet<Media> Medias { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<MovieStaff> MovieStaves { get; set; }

    public DbSet<Staff> Staves { get; set; }

    public DbSet<Screening> Screenings { get; set; }

    public DbSet<CinemaHall> CinemaHalls { get; set; }

    public DbSet<CinemaHallRow> CinemaHallRows { get; set; }

    public CinemaNetContext(DbContextOptions<CinemaNetContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Module).Assembly);
    }
}