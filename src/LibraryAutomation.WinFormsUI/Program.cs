using LibraryAutomation.WinFormsUI.Forms;
using Syncfusion.Licensing;
using Syncfusion.WinForms.Controls;
using System.Reflection;

namespace LibraryAutomation.WinFormsUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Apply Syncfusion license.
            SyncfusionLicenseProvider.RegisterLicense("MzgxOTQ3MUAzMjM5MmUzMDJlMzAzYjMyMzkzYlFSaVpaT1hieHJBK2hXK3NZWTR3SnNEWDAxanJWRERjL1A3QW5na0lHcXM9");

            // Initialize the application.
            ApplicationConfiguration.Initialize();

            // Apply the Syncfusion theme.
            string themeDllPath = Path.Combine(Application.StartupPath, "LibraryTheme.dll");
            Assembly themeAssembly= Assembly.LoadFrom(themeDllPath);
            SfSkinManager.LoadAssembly(themeAssembly);

            // Run the application.
            Application.Run(new SelectLoginTypeForm());
        }
    }
}