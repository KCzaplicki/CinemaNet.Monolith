using CinemaNet.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaNet.Infrastructure.Persistence.Configurations;

public class CinemaHallRowConfiguration : IEntityTypeConfiguration<CinemaHallRow>
{
    public void Configure(EntityTypeBuilder<CinemaHallRow> builder)
    {
        builder.Property(b => b.Id)
            .IsRequired();
        builder.Property(b => b.Letter)
            .IsRequired();
        builder.Property(b => b.Seats)
            .IsRequired();
        builder.Property(b => b.Type)
            .IsRequired();
    }
}