using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Theme;
using Microsoft.EntityFrameworkCore;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;
public partial class BorrowsForm : SfForm
{
    private readonly IRepository<Borrow> _borrowRepository;

    private IEnumerable<Borrow> _borrows = null!;

    public BorrowsForm(IRepository<Borrow> borrowRepository)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);

        _borrowRepository = borrowRepository;
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridBorrows.SearchController.Search(_txtBoxSearch.Text);

    private void BorrowsForm_Load(object sender, EventArgs e)
    {
        _borrows = _borrowRepository.DbSet
            .Include(b => b.User)
            .Include(b => b.Book)
            .ThenInclude(b => b!.Shelf)
            .AsNoTracking()
            .ToList();

        _dataGridBorrows.DataSource = _borrows.Select(b => new EmployeeBorrowViewModel(b)).ToList();
        _dataGridBorrows.Columns["Id"].Visible = false;
        _dataGridBorrows.Columns["MemberNumber"].HeaderText = "Üye No";
        _dataGridBorrows.Columns["MemberFullName"].HeaderText = "Üye Adı";
        _dataGridBorrows.Columns["BookName"].HeaderText = "Kitap Adı";
        _dataGridBorrows.Columns["BookISBN"].HeaderText = "ISBN";
        _dataGridBorrows.Columns["BookPageCount"].HeaderText = "Sayfa Sayısı";
        _dataGridBorrows.Columns["BookShelf"].HeaderText = "Raf";
        _dataGridBorrows.Columns["BorrowDate"].HeaderText = "Alış Tarihi";
        _dataGridBorrows.Columns["ReturnDate"].HeaderText = "İade Tarihi";
        _dataGridBorrows.Columns["IsDelivered"].HeaderText = "İade Edildi Mi?";
    }
}

internal class EmployeeBorrowViewModel
{
    public EmployeeBorrowViewModel(Borrow borrow)
    {
        Id = borrow.Id;
        BorrowDate = borrow.BorrowDate;
        ReturnDate = borrow.ReturnDate;
        IsDelivered = borrow.IsDelivered;
        MemberNumber = borrow.User!.Username;
        MemberFullName = $"{borrow.User.Name} {borrow.User.Surname}";
        BookName = borrow.Book!.Name ?? string.Empty;
        BookISBN = borrow.Book.ISBN ?? string.Empty;
        BookPageCount = borrow.Book.PageCount.ToString();
        BookShelf = borrow.Book.Shelf!.Name;
    }

    public int Id { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public bool IsDelivered { get; set; }
    public string MemberNumber { get; set; } = string.Empty;
    public string MemberFullName { get; set; } = string.Empty;
    public string BookName { get; set; } = string.Empty;
    public string BookISBN { get; set; } = string.Empty;
    public string BookPageCount { get; set; } = string.Empty;
    public string BookShelf { get; set; } = string.Empty;
}
