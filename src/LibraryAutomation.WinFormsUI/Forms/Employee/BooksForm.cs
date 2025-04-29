using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Extensions;
using LibraryAutomation.WinFormsUI.Theme;
using Microsoft.EntityFrameworkCore;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class BooksForm : SfForm
{
    private readonly IRepository<Book> _bookRepository;

    private ICollection<Book> _books = null!;
    private Book? _selectedBook;

    public BooksForm(IRepository<Book> bookRepository)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);

        _btnAdd.MakeOutline();
        _btnUpdate.MakeOutline();
        _btnDelete.MakeOutline();

        _bookRepository = bookRepository;
    }

    #region Events

    private void BooksForm_Load(object sender, EventArgs e)
    {
        loadBooks();
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridBooks.SearchController.Search(_txtBoxSearch.Text);

    private void _dataGridBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        object sBookObj = _dataGridBooks.SelectedItem;
        if (sBookObj is BookViewModel selectedBook && selectedBook != null)
        {
            _selectedBook = _books.FirstOrDefault(b => b.Id == selectedBook.Id);
            _btnUpdate.Enabled = true;
            _btnDelete.Enabled = true;
        }
        else
        {
            clearSelectedBook();
        }
    }

    private void _btnAdd_Click(object sender, EventArgs e)
    {
        AddOrUpdateBookForm addOrUpdateForm = Program.ServiceProvider.Get<AddOrUpdateBookForm>();
        addOrUpdateForm.IsUpdate = false;
        addOrUpdateForm.ShowDialog();
    }

    private void _btnUpdate_Click(object sender, EventArgs e)
    {
        if (_selectedBook == null)
        {
            return;
        }
        AddOrUpdateBookForm addOrUpdateForm = Program.ServiceProvider.Get<AddOrUpdateBookForm>();
        addOrUpdateForm.IsUpdate = true;
        addOrUpdateForm.BookToUpdate = _selectedBook;
        addOrUpdateForm.ShowDialog();
        loadBooks();
    }

    private void _btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedBook == null)
        {
            return;
        }
        DialogResult result = MessageBox.Show("Seçili kitabı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
            _bookRepository.Delete(_selectedBook.Id);
            loadBooks();
            clearSelectedBook();
        }
    }

    #endregion

    #region Private Methods

    private void loadBooks()
    {
        _bookRepository.DbContext.ChangeTracker.Clear();

        _books = _bookRepository.DbSet
            .Include(b => b.Publisher)
            .Include(b => b.Language)
            .Include(b => b.OriginalLanguage)
            .Include(b => b.Shelf)
            .Include(b => b.Writers)
            .Include(b => b.Translators)
            .Include(b => b.Categories)
            .AsNoTracking()
            .ToList();

        _dataGridBooks.DataSource = _books.Select(b => new BookViewModel(b)).ToList();

        _dataGridBooks.Columns["Id"].Visible = false;
        _dataGridBooks.Columns["ISBN"].HeaderText = "ISBN";
        _dataGridBooks.Columns["Name"].HeaderText = "Kitap Adı";
        _dataGridBooks.Columns["OriginName"].HeaderText = "Orijinal Adı";
        _dataGridBooks.Columns["PublisherName"].HeaderText = "Yayınevi";
        _dataGridBooks.Columns["PublishDate"].HeaderText = "Yayın Tarihi";
        _dataGridBooks.Columns["LanguageName"].HeaderText = "Dil";
        _dataGridBooks.Columns["OriginalLanguageName"].HeaderText = "Orijinal Dil";
        _dataGridBooks.Columns["PageCount"].HeaderText = "Sayfa Sayısı";
        _dataGridBooks.Columns["StockQuantity"].HeaderText = "Stok Miktarı";
        _dataGridBooks.Columns["BorrowQuantity"].HeaderText = "Ödünç Miktarı";
        _dataGridBooks.Columns["ShelfName"].HeaderText = "Raf";
        _dataGridBooks.Columns["Writers"].HeaderText = "Yazarlar";
        _dataGridBooks.Columns["Translators"].HeaderText = "Çevirmenler";
        _dataGridBooks.Columns["Categories"].HeaderText = "Kategoriler";
    }

    private void clearSelectedBook()
    {
        _selectedBook = null;
        _btnUpdate.Enabled = false;
        _btnDelete.Enabled = false;
    }

    #endregion
}

internal class BookViewModel
{
    public BookViewModel(Book book)
    {
        Id = book.Id;
        ISBN = book.ISBN ?? string.Empty;
        Name = book.Name ?? string.Empty;
        OriginName = book.OriginName ?? string.Empty;
        PublisherName = book.Publisher?.Name ?? string.Empty;
        PublishDate = book.PublishDate?.ToString("dd/MM/yyyy") ?? string.Empty;
        LanguageName = book.Language?.NameTR ?? string.Empty;
        OriginalLanguageName = book.OriginalLanguage?.NameTR ?? string.Empty;
        PageCount = book.PageCount;
        StockQuantity = book.StockQuantity;
        BorrowQuantity = book.BorrowQuantity;
        ShelfName = book.Shelf?.Name ?? string.Empty;
        Writers = string.Join(", ", book.Writers?.Select(w => w.FullName) ?? []);
        Translators = string.Join(", ", book.Translators?.Select(t => t.FullName) ?? []);
        Categories = string.Join(", ", book.Categories?.Select(c => c.Name) ?? []);
    }

    public int Id { get; set; }
    public string ISBN { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string OriginName { get; set; } = string.Empty;
    public string PublisherName { get; set; } = string.Empty;
    public string PublishDate { get; set; } = string.Empty;
    public string LanguageName { get; set; } = string.Empty;
    public string OriginalLanguageName { get; set; } = string.Empty;
    public int PageCount { get; set; }
    public int StockQuantity { get; set; }
    public int BorrowQuantity { get; set; }
    public string ShelfName { get; set; } = string.Empty;
    public string Writers { get; set; } = string.Empty;
    public string Translators { get; set; } = string.Empty;
    public string Categories { get; set; } = string.Empty;
}