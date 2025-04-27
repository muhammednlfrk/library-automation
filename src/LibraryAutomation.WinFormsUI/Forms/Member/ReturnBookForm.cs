using LibraryAutomation.WinFormsUI.Models;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.Data;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms.Member;

public partial class ReturnBookForm : SfForm
{
    private readonly IEnumerable<BorrowModel> _borrows;

    public ReturnBookForm()
    {
        InitializeComponent();
        _borrows = BorrowModel.GetDummyData().Where(x => x.IsDelivered == false).ToList();
    }

    private void ReturnBookForm_Load(object sender, EventArgs e)
    {
        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);
        _btnReturn.MakePrimary();
        _btnCancel.MakeWarning();
    }

    private void _txtBoxNumber_Click(object sender, EventArgs e) => _txtBoxNumber.SelectAll();

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridBorrows.SearchController.Search(_txtBoxSearch.Text);

    private void _txtBoxNumber_TextChanged(object sender, EventArgs e)
    {
        string memberNumber = _txtBoxNumber.Text;

        if (string.IsNullOrEmpty(memberNumber) || memberNumber.Length != 9)
            return;

        _dataGridBorrows.DataSource = _borrows.Where(x => x.MemberNumber == memberNumber).ToList();

        _dataGridBorrows.Columns["Id"].Visible = false;
        _dataGridBorrows.Columns["BookId"].Visible = false;
        _dataGridBorrows.Columns["IsDelivered"].Visible = false;
        _dataGridBorrows.Columns["MemberNumber"].Visible = false;
        _dataGridBorrows.Columns["BorrowDate"].HeaderText = "Tarih";
        _dataGridBorrows.Columns["DeliveryDate"].Visible = false;
        _dataGridBorrows.Columns["BookName"].HeaderText = "Kitap Adı";
        _dataGridBorrows.Columns["BookWriter"].HeaderText = "Yazarı";
        _dataGridBorrows.Columns["BookISBN"].HeaderText = "ISBN";
        _txtBoxISBN.Focus();
    }

    private void _txtBoxISBN_TextChanged(object sender, EventArgs e)
    {
        string isbn = _txtBoxISBN.Text;

        if (string.IsNullOrEmpty(isbn) || isbn.Length != 13)
        {
            _dataGridBorrows.ClearFilter("BookISBN");
            return;
        }

        _dataGridBorrows.Columns["BookISBN"].FilterPredicates.Add(new FilterPredicate() { FilterType = FilterType.Equals, FilterValue = isbn, PredicateType = PredicateType.Or });
        _dataGridBorrows.View.RefreshFilter();
    }
}
