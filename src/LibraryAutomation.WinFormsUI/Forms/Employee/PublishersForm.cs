using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Extensions;
using LibraryAutomation.WinFormsUI.Theme;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class PublishersForm : SfForm
{
    private readonly IRepository<Publisher> _publisherRepository;
    private readonly IMemoryCache _memoryCache;

    private ICollection<Publisher> _publishers = null!;
    private Publisher? _selectedPublisher;

    public PublishersForm(IRepository<Publisher> publisherRepository, IMemoryCache memoryCache)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);

        _btnAdd.MakeOutline();
        _btnUpdate.MakeOutline();
        _btnDelete.MakeOutline();

        _publisherRepository = publisherRepository;
        _memoryCache = memoryCache;

        loadPublishers();
    }

    #region Events

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridPublishers.SearchController.Search(_txtBoxSearch.Text);

    private void _dataGridPublishers_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        object sPublisherObj = _dataGridPublishers.SelectedItem;

        if (sPublisherObj is Publisher selectedPublisher && selectedPublisher != null)
        {
            _selectedPublisher = selectedPublisher;
            _btnUpdate.Enabled = true;
            _btnDelete.Enabled = true;
        }
        else
        {
            clearSelectedPublisher();
        }
    }

    private void _btnAdd_Click(object sender, EventArgs e)
    {
        Program.ServiceProvider.Get<AddOrUpdatePublisherForm>().ShowDialog();
        loadPublishers();
        _memoryCache.GetPublishers(true);
    }

    private void _btnUpdate_Click(object sender, EventArgs e)
    {
        if (_selectedPublisher == null)
        {
            MessageBox.Show("Lütfen güncellemek istediğiniz yayınevini seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        AddOrUpdatePublisherForm form = Program.ServiceProvider.Get<AddOrUpdatePublisherForm>();
        form.IsUpdate = true;
        form.PublisherToUpdate = _selectedPublisher;
        form.ShowDialog();
        loadPublishers();
        _memoryCache.GetPublishers(true);
    }

    private void _btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedPublisher == null)
        {
            MessageBox.Show("Lütfen silmek istediğiniz yayınevini seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        DialogResult result = MessageBox.Show($"Yayınevi: {_selectedPublisher.Name} silinecek. Onaylıyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
            _publisherRepository.Delete(_selectedPublisher.Id);
            loadPublishers();
            _memoryCache.GetPublishers(true);
        }
    }

    #endregion

    #region Private Methods

    private void loadPublishers()
    {
        clearSelectedPublisher();
        _publisherRepository.DbContext.ChangeTracker.Clear();
        _publishers = _publisherRepository.DbSet.AsNoTracking().ToList();
        _dataGridPublishers.DataSource = _publishers;
        _dataGridPublishers.Columns["Id"].Visible = false;
        _dataGridPublishers.Columns["Name"].HeaderText = "Yayınevi Adı";
    }

    private void clearSelectedPublisher()
    {
        _selectedPublisher = null;
        _btnUpdate.Enabled = false;
        _btnDelete.Enabled = false;
    }

    #endregion
}
