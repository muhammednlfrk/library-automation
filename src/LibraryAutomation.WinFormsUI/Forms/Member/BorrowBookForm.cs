using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Forms.Employee;
using LibraryAutomation.WinFormsUI.Models;
using LibraryAutomation.WinFormsUI.Theme;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Syncfusion.Data;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;

namespace LibraryAutomation.WinFormsUI.Forms.Member;

public partial class BorrowBookForm : SfForm
{
    private bool _activateBorrow = false;
    private string _memberNumber = string.Empty;
    private ICollection<Book> _books = null!;
    private Book? _selectedBook = null!;

    private readonly IRepository<Book> _bookRepository;
    private readonly IRepository<User> _userRepository;
    private readonly IRepository<Borrow> _borrowRepository;

    public BorrowBookForm(
        IRepository<Book> bookRepository,
        IRepository<User> userRepository,
        IRepository<Borrow> borrowRepository)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        this.ApplySkin();

        _btnBorrow.MakePrimary();
        _btnCancel.MakeWarning();
        _txtBoxISBN.SelectAll();

        _bookRepository = bookRepository;
        _userRepository = userRepository;
        _borrowRepository = borrowRepository;
    }

    #region Events

    private void BorrowBookForm_Load(object sender, EventArgs e)
    {
        loadBooks();
    }

    private void _dataGridBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        object sBookObj = _dataGridBooks.SelectedItem;

        if (sBookObj is BookViewModel selectedBook && selectedBook != null)
        {
            _selectedBook = _books.FirstOrDefault(b => b.Id == selectedBook.Id);
            _btnBorrow.Enabled = _activateBorrow && _selectedBook!.StockQuantity > _selectedBook.BorrowQuantity;
            _txtBoxISBN.Text = selectedBook.ISBN;
            _txtBoxName.Text = selectedBook.Name;
            _txtBoxOriginalName.Text = selectedBook.OriginName;
            _txtBoxPageCount.Text = selectedBook.PageCount.ToString();
            _txtBoxPublishDate.Text = selectedBook.PublishDate;
            _txtBoxPublisher.Text = selectedBook.PublisherName;
            _txtBoxWriter.Text = string.Join(", ", selectedBook.Writers);
            _pcBoxImage.Image = Image.FromFile(BookImageManager.GetBookImagePath(selectedBook.Id.ToString()));
        }
        else
        {
            clearSelectedBook();
        }
    }

    private void _txtBoxISBN_Click(object sender, EventArgs e)
    {
        _txtBoxISBN.SelectAll();
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridBooks.SearchController.Search(_txtBoxSearch.Text);

    private void _txtBoxNumber_TextChanged(object sender, EventArgs e)
    {
        string memberNumber = _txtBoxNumber.Text;

        if (!string.IsNullOrEmpty(memberNumber) && memberNumber.Length == 9)
        {
            _memberNumber = memberNumber;
            _activateBorrow = true;

            if (_selectedBook != null)
                _btnBorrow.Enabled = _selectedBook.StockQuantity > _selectedBook.BorrowQuantity;
        }
        else
        {
            _memberNumber = string.Empty;
            _activateBorrow = false;
            _btnBorrow.Enabled = false;
        }
    }

    private void _txtBoxISBN_TextChanged(object sender, EventArgs e)
    {
        string isbn = _txtBoxISBN.Text;

        if (string.IsNullOrEmpty(isbn) || isbn.Length != 13)
        {
            _dataGridBooks.ClearFilters();
            return;
        }

        _dataGridBooks.Columns["ISBN"].FilterPredicates.Add(new FilterPredicate() { FilterType = FilterType.Equals, FilterValue = isbn, PredicateType = PredicateType.Or });
        _dataGridBooks.View.RefreshFilter();
    }

    private void _btnBorrow_Click(object sender, EventArgs e)
    {
        if (_selectedBook == null)
        {
            return;
        }
        User? user = _userRepository.DbSet
            .AsNoTracking()
            .Include(u => u.Borrows)
            .FirstOrDefault(u => u.Username == _memberNumber);
        if (_selectedBook.StockQuantity <= _selectedBook.BorrowQuantity)
        {
            MessageBox.Show("Bu kitap ödünç alınamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (user == null)
        {
            MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (user.Borrows!.Where(x => x.IsDelivered == false).Count() >= 3)
        {
            MessageBox.Show("En fazla 3 kitap ödünç alabilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        Borrow borrow = new()
        {
            BookId = _selectedBook.Id,
            UserId = user.Id,
            BorrowDate = DateTime.Now,
            ReturnDate = null,
            IsDelivered = false
        };
        using IDbContextTransaction transaction = _bookRepository.DbContext.Database.BeginTransaction();
        Book targetBook = _bookRepository.DbSet.FirstOrDefault(b => b.Id == _selectedBook.Id)!;
        targetBook.BorrowQuantity++;
        _borrowRepository.Add(borrow);
        _bookRepository.Update(targetBook);
        transaction.Commit();
        MessageBox.Show("Kitap ödünç alındı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        loadBooks();
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
            .Include(b => b.Borrows)
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
        _txtBoxISBN.Clear();
        _txtBoxName.Clear();
        _txtBoxOriginalName.Clear();
        _txtBoxPageCount.Clear();
        _txtBoxPublishDate.Clear();
        _txtBoxPublisher.Clear();
        _txtBoxWriter.Clear();
        _btnBorrow.Enabled = false;
    }

    #endregion
}
