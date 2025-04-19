using LibraryAutomation.WinFormsUI.Models;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class PublishersForm : SfForm
{
    private readonly IEnumerable<PublisherModel> _publishers;

    public PublishersForm()
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);

        _btnAdd.MakeIcon();
        _btnUpdate.MakeIcon();
        _btnDelete.MakeIcon();

        _publishers = PublisherModel.GetDummmyData();
        _dataGridPublishers.DataSource = _publishers;
        _dataGridPublishers.Columns["Id"].Visible = false;
        _dataGridPublishers.Columns["Name"].HeaderText = "Yayınevi Adı";
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridPublishers.SearchController.Search(_txtBoxSearch.Text);

    private void _dataGridPublishers_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        object sPublisherObj = _dataGridPublishers.SelectedItem;

        if (sPublisherObj is PublisherModel selectedPublisher && selectedPublisher != null)
        {
            _btnUpdate.Enabled = true;
            _btnDelete.Enabled = true;
        }
        else
        {
            _btnUpdate.Enabled = false;
            _btnDelete.Enabled = false;
        }
    }

    private void _btnAdd_Click(object sender, EventArgs e)
    {
        new AddOrUpdatePublisherForm().ShowDialog();
    }
}
