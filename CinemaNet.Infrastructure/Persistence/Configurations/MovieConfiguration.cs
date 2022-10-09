using CinemaNet.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaNet.Infrastructure.Persistence.Configurations;

public class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.Property(b => b.Name)
               .IsRequired()
               .HasMaxLength(100);
        builder.Property(b => b.Description)
               .IsRequired()
               .HasMaxLength(4000);
        builder.Property(b => b.Duration)
               .IsRequired();
        builder.Property(b => b.State)
                .IsRequired();
        builder.Property(b => b.ReleaseDate)
                .IsRequired();
        builder.Property(b => b.CreationDate)
               .IsRequired();
    }
}