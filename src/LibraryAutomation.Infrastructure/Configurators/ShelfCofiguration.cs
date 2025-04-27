using LibraryAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.Infrastructure.Configurators;

internal class ShelfCofiguration : IEntityTypeConfiguration<Shelf>
{
    public void Configure(EntityTypeBuilder<Shelf> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Id)
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(64);

        builder.Property(s => s.Description)
            .HasMaxLength(500);

        builder.HasMany(s => s.Books)
            .WithOne(b => b.Shelf)
            .HasForeignKey(b => b.ShelfId);
    }
}
