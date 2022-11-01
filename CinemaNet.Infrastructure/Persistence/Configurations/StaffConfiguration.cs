using CinemaNet.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaNet.Infrastructure.Persistence.Configurations;

public class StaffConfiguration : IEntityTypeConfiguration<Staff>
{
    public void Configure(EntityTypeBuilder<Staff> builder)
    {
        builder.Property(b => b.FirstName)
               .IsRequired()
               .HasMaxLength(100);
        builder.Property(b => b.LastName)
               .IsRequired()
               .HasMaxLength(100);
    }
}