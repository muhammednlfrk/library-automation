using LibraryAutomation.WinFormsUI.Models;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.Data;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;

namespace LibraryAutomation.WinFormsUI.Forms.Member;
public partial class BorrowBookForm : SfForm
{
    private readonly List<BookModel> _books;
    private bool _activateBorrow = false;
    private string _memberNumber = string.Empty;

    public BorrowBookForm()
    {
        InitializeComponent();
        _books = new List<BookModel>(BookModel.GetDummyData());
        _dataGridBook.DataSource = _books;
        _dataGridBook.Columns["Id"].Visible = false;
        _dataGridBook.Columns["Name"].HeaderText = "Kitap Adı";
        _dataGridBook.Columns["Writer"].HeaderText = "Yazar Adı";
        _dataGridBook.Columns["OriginName"].HeaderText = "Orijinal Adı";
        _dataGridBook.Columns["Publisher"].HeaderText = "Yayınevi";
        _dataGridBook.Columns["PublishDate"].HeaderText = "Yayın Tarihi";
        _dataGridBook.Columns["PageCount"].HeaderText = "Sayfa Sayısı";
        _dataGridBook.Columns["ISBN"].HeaderText = "ISBN";
        _dataGridBook.Columns["StockQuantity"].HeaderText = "Stok";
        _dataGridBook.Columns["BorrowQuantity"].HeaderText = "Ödünç Alınan";
    }

    #region Events

    private void BorrowBookForm_Load(object sender, EventArgs e)
    {
        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        this.ApplySkin();

        _btnBorrow.MakePrimary();
        _btnCancel.MakeWarning();
        _txtBoxISBN.SelectAll();
    }

    private void _dataGridBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        BookModel? selectedBook = (BookModel?)_dataGridBook.SelectedItem;

        if (selectedBook != null)
        {
            _txtBoxISBN.Text = selectedBook.ISBN;
            _txtBoxName.Text = selectedBook.Name;
            _txtBoxOriginalName.Text = selectedBook.OriginName;
            _txtBoxPageCount.Text = selectedBook.PageCount.ToString();
            _txtBoxPublishDate.Text = selectedBook.PublishDate.ToString();
            _txtBoxPublisher.Text = selectedBook.Publisher;
            _txtBoxWriter.Text = selectedBook.Writer;
            _btnBorrow.Enabled = _activateBorrow && selectedBook.StockQuantity > selectedBook.BorrowQuantity;
        }
        else
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
        _txtBoxISBN.SelectAll();
    }

    private void _txtBoxISBN_Click(object sender, EventArgs e)
    {
        _txtBoxISBN.SelectAll();
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e)
    {
        _dataGridBook.SearchController.Search(_txtBoxSearch.Text);
    }

    #endregion

    private void _txtBoxNumber_TextChanged(object sender, EventArgs e)
    {
        string memberNumber = _txtBoxNumber.Text;

        if (!string.IsNullOrEmpty(memberNumber) && memberNumber.Length == 9)
        {
            _memberNumber = memberNumber;
            _activateBorrow = true;

            BookModel? selectedBook = (BookModel?)_dataGridBook.SelectedItem;
            if (selectedBook != null)
                _btnBorrow.Enabled = selectedBook.StockQuantity > selectedBook.BorrowQuantity;
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
            _dataGridBook.ClearFilters();
            return;
        }

        _dataGridBook.Columns["ISBN"].FilterPredicates.Add(new FilterPredicate() { FilterType = FilterType.Equals, FilterValue = isbn, PredicateType = PredicateType.Or });
        _dataGridBook.View.RefreshFilter();
    }
}
