using LibraryAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.Infrastructure.Configurators;

internal sealed class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Name)
            .HasMaxLength(532)
            .IsRequired();

        builder.Property(b => b.OriginName)
            .HasMaxLength(532)
            .IsRequired();

        builder.Property(b => b.PublishDate)
            .IsRequired();

        builder.Property(b => b.PageCount)
            .IsRequired();

        builder.Property(b => b.ISBN)
            .HasMaxLength(13)
            .IsRequired();

        builder.Property(b => b.StockQuantity)
            .IsRequired();

        builder.Property(b => b.BorrowQuantity)
            .IsRequired();

        builder.Property(b => b.PublisherId)
            .IsRequired();

        builder.Property(b => b.LanguageId)
            .IsRequired();

        builder.Property(b => b.OriginalLanguageId)
            .IsRequired();

        builder.Property(b => b.ShelfId)
            .IsRequired();

        builder.HasOne(b => b.Publisher)
            .WithMany(p => p.Books)
            .HasForeignKey(b => b.PublisherId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(b => b.Language)
            .WithMany(l => l.Books)
            .HasForeignKey(b => b.LanguageId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(b => b.OriginalLanguage)
            .WithMany(ol => ol.BooksWithOriginalLanguage)
            .HasForeignKey(b => b.OriginalLanguageId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(b => b.Shelf)
            .WithMany(s => s.Books)
            .HasForeignKey(b => b.ShelfId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
