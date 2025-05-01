using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Extensions;
using LibraryAutomation.WinFormsUI.Theme;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class TranslatorsOrWritersForm : SfForm
{
    private readonly IRepository<Translator> _translatorRepository;
    private readonly IRepository<Writer> _writerRepository;
    private readonly IMemoryCache _memoryCache;

    private ICollection<Translator> _translators = null!;
    private Translator? _selectedTranslator;
    private ICollection<Writer> _writers = null!;
    private Writer? _selectedWriter;

    public bool IsTranslator { get; set; }

    public TranslatorsOrWritersForm(IRepository<Translator> translatorRepository, IRepository<Writer> writerRepository, IMemoryCache memoryCache)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);

        _btnAdd.MakeOutline();
        _btnUpdate.MakeOutline();
        _btnDelete.MakeOutline();

        _translatorRepository = translatorRepository;
        _writerRepository = writerRepository;
        _memoryCache = memoryCache;
    }

    #region Events

    private void TranslatorsOrWritersForm_Load(object sender, EventArgs e)
    {
        Text = IsTranslator ? "Çevirmenler" : "Yazarlar";
        loadData();
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridPeople.SearchController.Search(_txtBoxSearch.Text);

    private void _dataGridPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        object selectedItem = _dataGridPeople.SelectedItem;

        if (IsTranslator)
        {
            if (selectedItem is Translator translator)
            {
                _selectedTranslator = translator;
                _btnDelete.Enabled = true;
                _btnUpdate.Enabled = true;
            }
            else
            {
                clearSelection();
            }
        }
        else
        {
            if (selectedItem is Writer writer)
            {
                _selectedWriter = writer;
                _btnDelete.Enabled = true;
                _btnUpdate.Enabled = true;
            }
            else
            {
                clearSelection();
            }
        }
    }

    private void _btnAdd_Click(object sender, EventArgs e)
    {
        AddOrUpdateTranslatorOrWriterForm addOrUpdateForm = Program.ServiceProvider.Get<AddOrUpdateTranslatorOrWriterForm>();
        addOrUpdateForm.IsTranslator = IsTranslator;
        addOrUpdateForm.IsUpdate = false;
        addOrUpdateForm.ShowDialog();
        loadData();
        if (IsTranslator)
        {
            _memoryCache.GetTranslators(true);
        }
        else
        {
            _memoryCache.GetWriters(true);
        }
    }

    private void _btnUpdate_Click(object sender, EventArgs e)
    {
        AddOrUpdateTranslatorOrWriterForm addOrUpdateForm = Program.ServiceProvider.Get<AddOrUpdateTranslatorOrWriterForm>();
        addOrUpdateForm.IsTranslator = IsTranslator;
        addOrUpdateForm.IsUpdate = true;
        if (IsTranslator) addOrUpdateForm.TranslatorToUpdate = _selectedTranslator!;
        else addOrUpdateForm.WriterToUpdate = _selectedWriter;
        addOrUpdateForm.ShowDialog();
        loadData();
        if (IsTranslator)
        {
            _memoryCache.GetTranslators(true);
        }
        else
        {
            _memoryCache.GetWriters(true);
        }
    }

    private void _btnDelete_Click(object sender, EventArgs e)
    {
        if (IsTranslator)
        {
            if (_selectedTranslator == null)
            {
                MessageBox.Show("Silinecek çevirmen bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Seçili çevirmeni silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            _translatorRepository.Delete(_selectedTranslator.Id);
            _memoryCache.GetTranslators(true);
        }
        else
        {
            if (_selectedWriter == null)
            {
                MessageBox.Show("Silinecek yazar bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Seçili yazarı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            _writerRepository.Delete(_selectedWriter.Id);
            _memoryCache.GetWriters(true);
        }
        loadData();
    }

    #endregion

    #region Private Methods

    private void loadData()
    {
        clearSelection();
        _translatorRepository.DbContext.ChangeTracker.Clear();
        _writerRepository.DbContext.ChangeTracker.Clear();

        if (IsTranslator)
        {
            _translators = _translatorRepository.DbSet.AsNoTracking().ToList();
            _dataGridPeople.DataSource = _translators;
        }
        else
        {
            _writers = _writerRepository.DbSet.AsNoTracking().ToList();
            _dataGridPeople.DataSource = _writers;
        }

        _dataGridPeople.Columns["Id"].Visible = false;
        _dataGridPeople.Columns["Name"].HeaderText = "İsim";
        _dataGridPeople.Columns["Surname"].HeaderText = "Soyisim";
        _dataGridPeople.Columns["BirthDate"].HeaderText = "Doğum Tarihi";
        _dataGridPeople.Columns["DeathDate"].HeaderText = "Ölüm Tarihi";
    }

    private void clearSelection()
    {
        _selectedTranslator = null;
        _selectedWriter = null;
        _btnDelete.Enabled = false;
        _btnUpdate.Enabled = false;
    }

    #endregion
}
