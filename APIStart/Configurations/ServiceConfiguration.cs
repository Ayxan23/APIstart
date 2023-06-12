using APIStart.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIStart.Configurations;

public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.Property(s => s.Title).IsRequired(true).HasMaxLength(100);
        builder.Property(s => s.Description).IsRequired(true).HasMaxLength(500);
        builder.Property(s => s.Image).IsRequired(true).HasMaxLength(500);
    }
}