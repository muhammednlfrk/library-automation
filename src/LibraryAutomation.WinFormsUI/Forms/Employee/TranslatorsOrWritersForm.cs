using LibraryAutomation.WinFormsUI.Models;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class TranslatorsOrWritersForm : SfForm
{
    private readonly bool _isTranslatorMode;
    private readonly IEnumerable<PersonBaseModel> _peoples;

    public TranslatorsOrWritersForm(bool isTranslatorMode)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);

        _btnAdd.MakeIcon();
        _btnUpdate.MakeIcon();
        _btnDelete.MakeIcon();

        _isTranslatorMode = isTranslatorMode;

        if (isTranslatorMode)
        {
            Text = "Çevirmenler";
            _peoples = TranslatorModel.GetDummyData();
        }
        else
        {
            Text = "Yazarlar";
            _peoples = WriterModel.GetDummyData();
        }

        _dataGridPeople.DataSource = _peoples;
        _dataGridPeople.Columns["Id"].Visible = false;
        _dataGridPeople.Columns["Name"].HeaderText = "Ad";
        _dataGridPeople.Columns["Surname"].HeaderText = "Soyad";
        _dataGridPeople.Columns["BirthDate"].HeaderText = "Doğum Tarihi";
        _dataGridPeople.Columns["DeathDate"].HeaderText = "Ölüm Tarihi";
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridPeople.SearchController.Search(_txtBoxSearch.Text);

    private void _dataGridPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        object selectedItem = _dataGridPeople.SelectedItem;
        bool isCorrectType = false;
        PersonBaseModel? selectedPerson = null;

        if (_isTranslatorMode && selectedItem is TranslatorModel translator)
        {
            isCorrectType = true;
            selectedPerson = translator;
        }
        else if (!_isTranslatorMode && selectedItem is WriterModel writer)
        {
            isCorrectType = true;
            selectedPerson = writer;
        }

        _btnDelete.Enabled = _btnUpdate.Enabled = isCorrectType && selectedPerson != null;
    }

    private void _btnAdd_Click(object sender, EventArgs e)
    {
        new AddOrUpdateTranslatorOrWriterForm(_isTranslatorMode).ShowDialog();
    }
}
