using CinemaNet.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaNet.Infrastructure.Persistence.Configurations;

public class MovieStaffConfiguration : IEntityTypeConfiguration<MovieStaff>
{
    public void Configure(EntityTypeBuilder<MovieStaff> builder)
    {
        builder.HasKey(b => new { b.StaffId, b.MovieId });
        builder.Property(b => b.MovieId)
               .IsRequired();
        builder.Property(b => b.StaffId)
               .IsRequired();
    }
}