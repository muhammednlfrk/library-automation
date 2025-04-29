using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Extensions;
using LibraryAutomation.WinFormsUI.Theme;
using Microsoft.EntityFrameworkCore;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class ShelfsForm : SfForm
{
    private readonly IRepository<Shelf> _shelfRepository;

    private ICollection<Shelf> _shelfs = null!;
    private Shelf? _selectedShelf;

    public ShelfsForm(IRepository<Shelf> shelfRepository)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);

        _btnAdd.MakeOutline();
        _btnUpdate.MakeOutline();
        _btnDelete.MakeOutline();

        _shelfRepository = shelfRepository;
        loadShelfs();
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridShelfs.SearchController.Search(_txtBoxSearch.Text);

    private void _dataGridShelfs_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        object sPublisherObj = _dataGridShelfs.SelectedItem;

        if (sPublisherObj is Shelf selectedShelf && selectedShelf != null)
        {
            _selectedShelf = selectedShelf;
            _btnUpdate.Enabled = true;
            _btnDelete.Enabled = true;
        }
        else
        {
            clearSelectedShelf();
        }
    }

    private void _btnAdd_Click(object sender, EventArgs e)
    {
        Program.ServiceProvider.Get<AddOrUpdateShelfForm>().ShowDialog();
        loadShelfs();
    }

    private void _btnUpdate_Click(object sender, EventArgs e)
    {
        if (_selectedShelf == null)
            return;
        AddOrUpdateShelfForm form = Program.ServiceProvider.Get<AddOrUpdateShelfForm>();
        form.IsUpdate = true;
        form.ShelfToUpdate = _selectedShelf;
        form.ShowDialog();
        loadShelfs();
    }

    private void _btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedShelf == null)
            return;
        DialogResult result = MessageBox.Show("Bu rafı silmek istediğinize emin misiniz?", "Raf Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
            _shelfRepository.Delete(_selectedShelf.Id);
            loadShelfs();
        }
    }

    #region Provate Methods

    private void loadShelfs()
    {
        clearSelectedShelf();
        _shelfRepository.DbContext.ChangeTracker.Clear();
        _shelfs = _shelfRepository.DbSet.AsNoTracking().ToList();
        _dataGridShelfs.DataSource = _shelfs;
        _dataGridShelfs.Columns["Id"].Visible = false;
        _dataGridShelfs.Columns["Name"].HeaderText = "Ad";
        _dataGridShelfs.Columns["Description"].HeaderText = "Açıklama";
    }

    private void clearSelectedShelf()
    {
        _selectedShelf = null;
        _btnUpdate.Enabled = false;
        _btnDelete.Enabled = false;
    }

    #endregion
}
