using LibraryAutomation.WinFormsUI.Properties;
using System.Reflection;

namespace LibraryAutomation.WinFormsUI;

public static class BookImageManager
{
    private static readonly string _appPhsycalPath;
    private static readonly string _defaultImage = "dune.jpg";
    private static readonly string _defaultImagePath;

    static BookImageManager()
    {
        _appPhsycalPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;

        if (!string.IsNullOrEmpty(_appPhsycalPath))
        {
            _appPhsycalPath = Path.Combine(_appPhsycalPath, "BookImages");
            if (!Directory.Exists(_appPhsycalPath))
            {
                Directory.CreateDirectory(_appPhsycalPath);
                Resources.dune.Save(Path.Combine(_appPhsycalPath, _defaultImage));
            }
        }
        _defaultImagePath = Path.Combine(_appPhsycalPath, _defaultImage);
    }

    public static string GetBookImagePath(string bookId)
    {
        if (string.IsNullOrEmpty(_appPhsycalPath))
            return string.Empty;
        var imagePath = Path.Combine(_appPhsycalPath, $"{bookId}.jpg");
        return File.Exists(imagePath) ? imagePath : _defaultImagePath;
    }

    public static string AddOrUpdteBookImage(string bookId, string imagePath)
    {
        if (string.IsNullOrEmpty(_appPhsycalPath))
            return string.Empty;
        var destinationPath = Path.Combine(_appPhsycalPath, $"{bookId}.jpg");
        if (File.Exists(destinationPath))
        {
            File.Delete(destinationPath);
        }
        File.Copy(imagePath, destinationPath);
        return destinationPath;
    }
}
