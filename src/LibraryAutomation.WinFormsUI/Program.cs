using FluentValidation;
using LibraryAutomation.ApplicationL.Identity;
using LibraryAutomation.ApplicationL.Validation;
using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Extensions;
using LibraryAutomation.WinFormsUI.Forms;
using LibraryAutomation.WinFormsUI.Forms.Employee;
using LibraryAutomation.WinFormsUI.Forms.Employee.Member;
using LibraryAutomation.WinFormsUI.Forms.Member;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Licensing;
using Syncfusion.WinForms.Controls;
using System.Reflection;

namespace LibraryAutomation.WinFormsUI;

internal static class Program
{
    public static User AuthenticatedUser { get; set; } = null!;

    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // Apply Syncfusion license.
        SyncfusionLicenseProvider.RegisterLicense("MzgxOTQ3MUAzMjM5MmUzMDJlMzAzYjMyMzkzYlFSaVpaT1hieHJBK2hXK3NZWTR3SnNEWDAxanJWRERjL1A3QW5na0lHcXM9");

        // Initialize the application.
        ApplicationConfiguration.Initialize();

        // Apply the Syncfusion theme.
        string themeDllPath = Path.Combine(Application.StartupPath, "LibraryTheme.dll");
        Assembly themeAssembly= Assembly.LoadFrom(themeDllPath);
        SfSkinManager.LoadAssembly(themeAssembly);

        // Build service provider.
        IServiceCollection services = new ServiceCollection();
        configureServices(services);
        ServiceProvider = services.BuildServiceProvider();

        // Load cache.
        IMemoryCache memoryCache = ServiceProvider.Get<IMemoryCache>();
        memoryCache.GetLanguages(true);
        memoryCache.GetPublishers(true);
        memoryCache.GetWriters(true);
        memoryCache.GetTranslators(true);
        memoryCache.GetShelfs(true);

        // Run the application.
        IPasswordHashGenerator passwordHashGenerator = ServiceProvider.Get<IPasswordHashGenerator>();
        string password = passwordHashGenerator.HashPassword("123456");
        SelectLoginTypeForm initialForm = ServiceProvider.Get<SelectLoginTypeForm>();
        Application.Run(initialForm);
    }

    private static void configureServices(IServiceCollection services)
    {
        // Add DbContexts.
        services.AddDbContext<LibraryContext>(options =>
        {
            options.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=LibraryDB;User Id=sa;Password=1;TrustServerCertificate=True;");
        });
        services.AddScoped<LibraryContext>();
        // Add mem cache.
        services.AddMemoryCache();

        // Add forms.
        services.AddTransient<SelectLoginTypeForm>();
        services.AddTransient<BorrowBookForm>();
        services.AddTransient<MemberMainForm>();
        services.AddTransient<ReturnBookForm>();
        services.AddTransient<AddOrUpdateBookForm>();
        services.AddTransient<AddOrUpdateMemberForm>();
        services.AddTransient<AddOrUpdatePublisherForm>();
        services.AddTransient<AddOrUpdateShelfForm>();
        services.AddTransient<AddOrUpdateTranslatorOrWriterForm>();
        services.AddTransient<BooksForm>();
        services.AddTransient<BorrowsForm>();
        services.AddTransient<EmployeeLoginForm>();
        services.AddTransient<EmployeeMainForm>();
        services.AddTransient<MemberManagementForm>();
        services.AddTransient<PublishersForm>();
        services.AddTransient<ShelfsForm>();
        services.AddTransient<TranslatorsOrWritersForm>();

        // Add repositories.
        services.AddScoped(typeof(IRepository<>), typeof(GenericReposirtory<>));

        // Add identity services.
        services.AddSingleton<IPasswordHashGenerator, MD5PasswordHashGenerator>();
        services.AddSingleton<IAuthenticator, BasicAuthenticator>();

        // Add validators
        services.AddScoped<IValidator<Book>, BookValidator>();
        services.AddScoped<IValidator<Borrow>, BorrowValidator>();
        services.AddScoped<IValidator<Category>, CategoryValidator>();
        services.AddScoped<IValidator<Publisher>, PublisherValidator>();
        services.AddScoped<IValidator<Shelf>, ShelfValidator>();
        services.AddScoped<IValidator<Translator>, TranslatorValidator>();
        services.AddScoped<IValidator<User>, UserValidator>();
        services.AddScoped<IValidator<Writer>, WriterValidator>();
    }
}