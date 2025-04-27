using LibraryAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.Infrastructure.Configurators;

internal class TranslatorConfiguration : IEntityTypeConfiguration<Translator>
{
    public void Configure(EntityTypeBuilder<Translator> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id)
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(64);

        builder.Property(t => t.Surname)
            .IsRequired()
            .HasMaxLength(64);

        builder.Property(t => t.BirthDate)
            .IsRequired(false);

        builder.Property(t => t.DeathDate)
            .IsRequired(false);

        builder.HasMany(t => t.Books)
            .WithMany(b => b.Translators)
            .UsingEntity<BooksTranslator>();
    }
}
