using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Configurators;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.Infrastructure.Repositories;

public class LibraryContext(DbContextOptions<LibraryContext> options) : DbContext(options)
{
    public DbSet<Language> Languages { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Shelf> Shelfs { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<BooksWriter> BooksWriters { get; set; }
    public DbSet<BooksTranslator> BooksTranslators { get; set; }
    public DbSet<BooksCategories> BooksCategories { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Writer> Writers { get; set; }
    public DbSet<Translator> Translators { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Borrow> Borrows { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Language>().ToTable("Languages");
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<Shelf>().ToTable("Shelfs");
        modelBuilder.Entity<Publisher>().ToTable("Publishers");
        modelBuilder.Entity<BooksWriter>().ToTable("BooksWriters");
        modelBuilder.Entity<BooksTranslator>().ToTable("BooksTranslators");
        modelBuilder.Entity<BooksCategories>().ToTable("BooksCategories");
        modelBuilder.Entity<Book>().ToTable("Books");
        modelBuilder.Entity<Writer>().ToTable("Writers");
        modelBuilder.Entity<Translator>().ToTable("Translators");
        modelBuilder.Entity<Category>().ToTable("Categories");
        modelBuilder.Entity<Borrow>().ToTable("Borrows");

        // Apply configurations for each entity
        modelBuilder.ApplyConfiguration(new LanguageConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new ShelfCofiguration());
        modelBuilder.ApplyConfiguration(new PublisherConfiguration());
        modelBuilder.ApplyConfiguration(new BooksWriterConfiguration());
        modelBuilder.ApplyConfiguration(new BooksTranslatorConfiguration());
        modelBuilder.ApplyConfiguration(new BooksCategoriesCofiguration());
        modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfiguration(new WriterConfuguration());
        modelBuilder.ApplyConfiguration(new TranslatorConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new BorrowConfiguration());
    }
}
