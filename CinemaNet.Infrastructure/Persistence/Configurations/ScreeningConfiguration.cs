using CinemaNet.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaNet.Infrastructure.Persistence.Configurations;

public class ScreeningConfiguration : IEntityTypeConfiguration<Screening>
{
    public void Configure(EntityTypeBuilder<Screening> builder)
    {
        builder.Property(b => b.Id)
            .IsRequired();
        builder.Property(b => b.MovieId)
            .IsRequired();
        // builder.Property(b => b.CinemaHallId)
        //     .IsRequired();
        builder.Property(b => b.StartDate)
            .IsRequired();
        builder.Property(b => b.EndDate)
            .IsRequired();
    }
}