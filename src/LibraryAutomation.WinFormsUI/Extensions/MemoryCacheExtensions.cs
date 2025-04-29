using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryAutomation.WinFormsUI.Extensions;

public static class MemoryCacheExtensions
{
    public const string LANGUAGE_LIST = "LanguageList";
    public const string PUBLISHER_LIST = "PublisherList";
    public const string SHELF_LIST = "ShelfList";
    public const string WRITER_LIST = "WriterList";
    public const string TRANSLATOR_LIST = "TranslatorList";

    public static ICollection<TEntity> GetEntity<TEntity>(this IMemoryCache memoryCache, string key, bool overrideData, TimeSpan expiration) where TEntity : EntityBase
    {
        IRepository<TEntity> repository = ServiceProviderServiceExtensions
                .GetRequiredService<IRepository<TEntity>>(Program.ServiceProvider);

        bool hasKey = memoryCache.TryGetValue(key, out ICollection<TEntity>? entities);

        if ((!hasKey && overrideData) || entities == null)
        {
            memoryCache.Remove(key);
            hasKey = false;
        }

        if (!hasKey)
        {
            entities = repository.DbSet.AsNoTracking().ToList();
            memoryCache.Set(key, entities, expiration);
        }
        return entities!;
    }

    public static ICollection<Language> GetLanguages(this IMemoryCache memoryCache, bool overrideData = false)
    {
        return GetEntity<Language>(memoryCache, LANGUAGE_LIST, overrideData, TimeSpan.FromDays(1));
    }

    public static ICollection<Publisher> GetPublishers(this IMemoryCache memoryCache, bool overrideData = false)
    {
        return GetEntity<Publisher>(memoryCache, PUBLISHER_LIST, overrideData, TimeSpan.FromDays(1));
    }

    public static ICollection<Shelf> GetShelfs(this IMemoryCache memoryCache, bool overrideData = false)
    {
        return GetEntity<Shelf>(memoryCache, SHELF_LIST, overrideData, TimeSpan.FromDays(1));
    }

    public static ICollection<Writer> GetWriters(this IMemoryCache memoryCache, bool overrideData = false)
    {
        return GetEntity<Writer>(memoryCache, WRITER_LIST, overrideData, TimeSpan.FromDays(1));
    }

    public static ICollection<Translator> GetTranslators(this IMemoryCache memoryCache, bool overrideData = false)
    {
        return GetEntity<Translator>(memoryCache, TRANSLATOR_LIST, overrideData, TimeSpan.FromDays(1));
    }
}
