using LibraryAutomation.WinFormsUI.Models;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.Data.Extensions;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.WinForms.Controls;
using System.Data;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class AddOrUpdateBookForm : SfForm
{
    private readonly IEnumerable<WriterModel> _writers;
    private readonly IEnumerable<TranslatorModel> _translators;
    private readonly IEnumerable<PublisherModel> _publishers;

    public AddOrUpdateBookForm()
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);
        _btnSave.MakePrimary();
        _btnCancel.MakeOutline();

        _writers = WriterModel.GetDummyData();
        _translators = TranslatorModel.GetDummyData();
        _publishers = PublisherModel.GetDummmyData();

        _cmbBoxWriter.DataSource = _writers;
        _cmbBoxWriter.DisplayMember = "FullName";
        _cmbBoxWriter.ValueMember = "Id";

        _cmbBoxTranslators.DataSource = _translators;
        _cmbBoxTranslators.DisplayMember = "FullName";
        _cmbBoxTranslators.ValueMember = "Id";

        _cmbBoxPublisher.DataSource = _publishers;
        _cmbBoxPublisher.DisplayMember = "Name";
        _cmbBoxPublisher.ValueMember = "Id";
    }
}
