using LibraryAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.Infrastructure.Configurators;
internal class BooksWriterConfiguration : IEntityTypeConfiguration<BooksWriter>
{
    public void Configure(EntityTypeBuilder<BooksWriter> builder)
    {
        builder.HasKey(bw => new { bw.BookId, bw.WriterId });
    }
}
