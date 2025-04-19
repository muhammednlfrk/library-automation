using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;
public partial class AddOrUpdateTranslatorOrWriterForm : SfForm
{
    private readonly bool _isTranslatorMode;

    public AddOrUpdateTranslatorOrWriterForm(bool isTranslatorMode)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        _btnSave.MakePrimary();
        _btnCancel.MakeOutline();

        _isTranslatorMode = isTranslatorMode;

        Text = isTranslatorMode ? "Çevirmen Ekle" : "Yazar Ekle";
        LibraryThemeExtensions.ApplySkin(this);
    }
}
