using APIStart.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIStart.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Name).IsRequired(true).HasMaxLength(200);
        builder.Property(p => p.Price).IsRequired(true).HasColumnType("decimal(18,2)");
        builder.Property(p => p.Description).IsRequired(true).HasMaxLength(500);
        builder.Property(p => p.DiscountPercent).IsRequired(true).HasColumnType("decimal(18,2)");
        builder.Property(p => p.Rating).IsRequired(true);

        builder.HasCheckConstraint("CK_Rating_Value", "Rating BETWEEN 0 AND 10");
        builder.HasCheckConstraint("CK_Price_Value", "Price > 0");
        builder.HasCheckConstraint("CK_DiscountPercent_Value", "DiscountPercent >= 0");
    }
}