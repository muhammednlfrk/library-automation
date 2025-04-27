using LibraryAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.Infrastructure.Configurators;

internal class BooksCategoriesCofiguration : IEntityTypeConfiguration<BooksCategories>
{
    public void Configure(EntityTypeBuilder<BooksCategories> builder)
    {
        builder.HasKey(bc => new { bc.BookId, bc.CategoryId });
    }
}