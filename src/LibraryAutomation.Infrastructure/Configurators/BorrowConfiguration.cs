using LibraryAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.Infrastructure.Configurators;

internal class BorrowConfiguration : IEntityTypeConfiguration<Borrow>
{
    public void Configure(EntityTypeBuilder<Borrow> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id)
            .ValueGeneratedOnAdd();

        builder.Property(b => b.BorrowDate)
            .IsRequired();

        builder.Property(b => b.ReturnDate)
            .IsRequired(false);

        builder.Property(b => b.IsDelivered)
            .IsRequired();

        builder.HasOne(b => b.Book)
            .WithMany(b => b.Borrows)
            .HasForeignKey(b => b.BookId);

        builder.HasOne(b => b.User)
            .WithMany(u => u.Borrows)
            .HasForeignKey(b => b.UserId);
    }
}
