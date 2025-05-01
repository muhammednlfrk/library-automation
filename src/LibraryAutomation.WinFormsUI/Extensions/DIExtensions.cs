using Microsoft.Extensions.DependencyInjection;

namespace LibraryAutomation.WinFormsUI.Extensions;
public static class DIExtensions
{
    public static T Get<T>(this IServiceProvider serviceProvider) where T : notnull
    {
        return ServiceProviderServiceExtensions.GetRequiredService<T>(serviceProvider);
    }
}
