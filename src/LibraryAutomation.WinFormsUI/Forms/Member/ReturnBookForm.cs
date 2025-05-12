using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Theme;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Syncfusion.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms.Member;

public partial class ReturnBookForm : SfForm
{
    private readonly IRepository<Book> _bookRepository;
    private readonly IRepository<Borrow> _borrowRepository;
    private readonly IRepository<User> _userRepository;

    private User? _selectedUser;
    private ICollection<Borrow> _borrows = null!;
    private Borrow? _selectedBorrow;

    public ReturnBookForm(
        IRepository<Book> bookRepository,
        IRepository<Borrow> borrowRepository,
        IRepository<User> userRepository)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);
        _btnReturn.MakePrimary();
        _btnCancel.MakeWarning();

        _bookRepository = bookRepository;
        _borrowRepository = borrowRepository;
        _userRepository = userRepository;
    }

    private void ReturnBookForm_Load(object sender, EventArgs e)
    {
        _txtBoxNumber.SelectAll();
        _txtBoxNumber.Focus();
    }

    private void _txtBoxNumber_Click(object sender, EventArgs e) => _txtBoxNumber.SelectAll();

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridBorrows.SearchController.Search(_txtBoxSearch.Text);

    private void _txtBoxISBN_TextChanged(object sender, EventArgs e)
    {
        string isbn = _txtBoxISBN.Text;

        if (string.IsNullOrEmpty(isbn) || isbn.Length != 13)
        {
            _dataGridBorrows.ClearFilters();
            return;
        }

        _dataGridBorrows.Columns["ISBN"].FilterPredicates.Add(new FilterPredicate() { FilterType = FilterType.Equals, FilterValue = isbn, PredicateType = PredicateType.Or });
        _dataGridBorrows.View.RefreshFilter();
    }

    private void _txtBoxNumber_TextChanged(object sender, EventArgs e)
    {
        string memberNumber = _txtBoxNumber.Text;

        if (string.IsNullOrEmpty(memberNumber) || memberNumber.Length != 9)
        {
            disableControls();
            return;
        }

        _selectedUser = _userRepository.DbSet
            .FirstOrDefault(u => u.Username == memberNumber);

        if (_selectedUser == null)
        {
            disableControls();
        }
        else
        {
            loadData();
            _txtBoxISBN.Enabled = true;
            _txtBoxISBN.Focus();
        }
    }

    private void _dataGridBorrows_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
    {
        object sBorrowObj = _dataGridBorrows.SelectedItem;
        if (sBorrowObj is BorrowViewModel selectedBorrow && selectedBorrow != null)
        {
            _selectedBorrow = _borrows.FirstOrDefault(b => b.Id == selectedBorrow.Id);
            _btnReturn.Enabled = true;
        }
        else
        {
            _btnReturn.Enabled = false;
        }
    }

    private void loadData()
    {
        if (_selectedUser == null)
            return;
        _borrows = _borrowRepository.DbSet
            .Include(b => b.Book)
            .Where(b => b.UserId == _selectedUser.Id && b.IsDelivered == false)
            .AsNoTracking()
            .ToList();
        List<BorrowViewModel> borrowViewModels = _borrows
            .Select(b => new BorrowViewModel(_selectedUser, b))
            .ToList();
        _dataGridBorrows.DataSource = borrowViewModels;
        _dataGridBorrows.Columns["Id"].Visible = false;
        _dataGridBorrows.Columns["ISBN"].HeaderText = "ISBN";
        _dataGridBorrows.Columns["BookName"].HeaderText = "Kitap Adı";
        _dataGridBorrows.Columns["BorrowerName"].HeaderText = "Üye Adı";
        _dataGridBorrows.Columns["BorrowDate"].HeaderText = "Alış Tarihi";
        _dataGridBorrows.Columns["ReturnDate"].HeaderText = "İade Tarihi";
        _dataGridBorrows.Columns["ReturnDate"].Visible = false;
    }

    private void disableControls()
    {
        _dataGridBorrows.DataSource = null;
        _dataGridBorrows.ClearFilters();
        _txtBoxISBN.Text = string.Empty;
        _txtBoxISBN.Enabled = false;
        _btnReturn.Enabled = false;
    }

    private void _btnReturn_Click(object sender, EventArgs e)
    {
        if (_selectedBorrow == null)
            return;

        using IDbContextTransaction transaction = _borrowRepository.DbContext.Database.BeginTransaction();
        try
        {
            Borrow? targetBorrow = _borrowRepository.DbSet.FirstOrDefault(b => b.Id == _selectedBorrow.Id);
            if (targetBorrow == null)
            {
                MessageBoxAdv.Show("İade edilecek kitap bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Book? targetBook = _bookRepository.DbSet.FirstOrDefault(b => b.Id == targetBorrow.BookId);
            if (targetBook == null)
            {
                MessageBoxAdv.Show("İade edilecek kitap bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            targetBorrow.ReturnDate = DateTime.Now;
            targetBorrow.IsDelivered = true;
            targetBook.BorrowQuantity--;
            _borrowRepository.Update(targetBorrow);
            _bookRepository.Update(targetBook);
            _borrowRepository.DbContext.SaveChanges();
            transaction.Commit();
            _borrowRepository.DbContext.Entry(targetBorrow).State = EntityState.Detached;
            _borrowRepository.DbContext.Entry(targetBook).State = EntityState.Detached;
            _borrowRepository.DbContext.ChangeTracker.Clear();
            _bookRepository.DbContext.ChangeTracker.Clear();
            _selectedBorrow = null;
            MessageBox.Show("İade işlemi başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            MessageBox.Show($"İade işlemi başarısız. Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

internal class BorrowViewModel
{
    public BorrowViewModel(User user, Borrow borrow)
    {
        Id = borrow.Id;
        ISBN = borrow.Book?.ISBN ?? string.Empty;
        BookName = borrow.Book?.Name ?? string.Empty;
        BorrowerName = $"{user.Name} {user.Surname}";
        BorrowDate = borrow.BorrowDate;
        ReturnDate = borrow.ReturnDate ?? DateTime.Now;
    }

    public int Id { get; set; }
    public string ISBN { get; set; } = null!;
    public string BookName { get; set; } = null!;
    public string BorrowerName { get; set; } = null!;
    public DateTime BorrowDate { get; set; }
    public DateTime ReturnDate { get; set; }
}