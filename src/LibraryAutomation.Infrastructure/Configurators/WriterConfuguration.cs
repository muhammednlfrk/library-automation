using LibraryAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.Infrastructure.Configurators;

internal class WriterConfuguration : IEntityTypeConfiguration<Writer>
{
    public void Configure(EntityTypeBuilder<Writer> builder)
    {
        builder.HasKey(w => w.Id);

        builder.Property(w => w.Id)
            .ValueGeneratedOnAdd();

        builder.Property(w => w.Name)
            .IsRequired()
            .HasMaxLength(64);

        builder.Property(w => w.Surname)
            .IsRequired()
            .HasMaxLength(64);

        builder.Property(w => w.BirthDate)
            .IsRequired(false);

        builder.Property(w => w.DeathDate)
            .IsRequired(false);

        builder.HasMany(w => w.Books)
            .WithMany(b => b.Writers)
            .UsingEntity<BooksWriter>();
    }
}
