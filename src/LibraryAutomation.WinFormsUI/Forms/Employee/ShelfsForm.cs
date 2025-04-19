using LibraryAutomation.WinFormsUI.Models;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class ShelfsForm : SfForm
{
    private readonly IEnumerable<ShelfModel> _shelfs;

    public ShelfsForm()
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);

        _btnAdd.MakeIcon();
        _btnUpdate.MakeIcon();
        _btnDelete.MakeIcon();

        _shelfs = ShelfModel.GetDummyData();
        _dataGridShelfs.DataSource = _shelfs;

        _dataGridShelfs.Columns["Id"].Visible = false;
        _dataGridShelfs.Columns["Name"].HeaderText = "Ad";
        _dataGridShelfs.Columns["Description"].HeaderText = "Açıklama";
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridShelfs.SearchController.Search(_txtBoxSearch.Text);

    private void _btnAdd_Click(object sender, EventArgs e)
    {
        new AddOrUpdateShelfForm().ShowDialog();
    }

    private void _dataGridShelfs_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
    {
        object sPublisherObj = _dataGridShelfs.SelectedItem;

        if (sPublisherObj is ShelfModel selectedShelf && selectedShelf != null)
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
}
