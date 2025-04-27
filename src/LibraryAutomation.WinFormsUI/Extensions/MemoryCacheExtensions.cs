using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryAutomation.WinFormsUI.Extensions;

public static class MemoryCacheExtensions
{
    public const string LANG_LIST = "LanguageList";

    public static ICollection<Language> GetLanguages(this IMemoryCache memoryCache)
    {
        if (memoryCache.TryGetValue(LANG_LIST, out ICollection<Language>? languages) || languages == null)
        {
            IRepository<Language> languageRepository =ServiceProviderServiceExtensions
                .GetRequiredService<IRepository<Language>>(Program.ServiceProvider);

            languages = languageRepository.GetAll();

            memoryCache.Set(LANG_LIST, languages, TimeSpan.FromDays(1));
        }

        return languages;
    }
}
