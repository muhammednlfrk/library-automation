using LibraryAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.Infrastructure.Configurators;

internal class BooksTranslatorConfiguration : IEntityTypeConfiguration<BooksTranslator>
{
    public void Configure(EntityTypeBuilder<BooksTranslator> builder)
    {
        builder.HasKey(x => new { x.BookId, x.TranslatorId });
    }
}
