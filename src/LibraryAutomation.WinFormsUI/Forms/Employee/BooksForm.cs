using LibraryAutomation.WinFormsUI.Models;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class BooksForm : SfForm
{
    private readonly IEnumerable<BookModel> _books;

    public BooksForm()
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);

        _btnAdd.MakeIcon();
        _btnUpdate.MakeIcon();
        _btnDelete.MakeIcon();

        _books = BookModel.GetDummyData();
        _dataGridBooks.DataSource = _books;

        _dataGridBooks.Columns["Id"].Visible = false;
        _dataGridBooks.Columns["Name"].HeaderText = "Kitap Adı";
        _dataGridBooks.Columns["Writer"].HeaderText = "Yazar Adı";
        _dataGridBooks.Columns["OriginName"].HeaderText = "Orijinal Adı";
        _dataGridBooks.Columns["Publisher"].HeaderText = "Yayınevi";
        _dataGridBooks.Columns["PublishDate"].HeaderText = "Yayın Tarihi";
        _dataGridBooks.Columns["PageCount"].HeaderText = "Sayfa Sayısı";
        _dataGridBooks.Columns["ISBN"].HeaderText = "ISBN";
        _dataGridBooks.Columns["StockQuantity"].HeaderText = "Stok";
        _dataGridBooks.Columns["BorrowQuantity"].HeaderText = "Ödünç Alınan";
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e)
    {
        _dataGridBooks.SearchController.Search(_txtBoxSearch.Text);
    }

    private void _dataGridBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        BookModel? selectedBook = (BookModel?)_dataGridBooks.SelectedItem;
        _btnDelete.Enabled = _btnUpdate.Enabled = selectedBook != null;
    }

    private void _btnAdd_Click(object sender, EventArgs e)
    {
        new AddOrUpdateBookForm().ShowDialog();
    }
}
