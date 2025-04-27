using LibraryAutomation.WinFormsUI.Models;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.Data;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;
public partial class BorrowsForm : SfForm
{
    private IEnumerable<BorrowModel> _borrows;

    public BorrowsForm()
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);

        _borrows = BorrowModel.GetDummyData();
        _dataGridBorrows.DataSource = _borrows;
        _dataGridBorrows.Columns["Id"].Visible = false;
        _dataGridBorrows.Columns["BookId"].Visible = false;
        _dataGridBorrows.Columns["IsDelivered"].HeaderText = "İade Durumu";
        _dataGridBorrows.Columns["MemberNumber"].HeaderText = "Üye Numarası";
        _dataGridBorrows.Columns["BorrowDate"].HeaderText = "Ödünç Tarihi";
        _dataGridBorrows.Columns["DeliveryDate"].HeaderText = "İade Tarihi";
        _dataGridBorrows.Columns["BookName"].HeaderText = "Kitap Adı";
        _dataGridBorrows.Columns["BookWriter"].HeaderText = "Yazarı";
        _dataGridBorrows.Columns["BookISBN"].HeaderText = "ISBN";
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridBorrows.SearchController.Search(_txtBoxSearch.Text);

    private void _txtBoxNumber_TextChanged(object sender, EventArgs e)
    {
        string memberNumber = _txtBoxNumber.Text;

        if (string.IsNullOrEmpty(memberNumber) || memberNumber.Length != 9)
        {
            _dataGridBorrows.ClearFilter("MemberNumber");
            return;
        }

        _dataGridBorrows.Columns["MemberNumber"].FilterPredicates.Add(new FilterPredicate() { FilterType = FilterType.Equals, FilterValue = memberNumber, PredicateType = PredicateType.Or });
        _dataGridBorrows.View.RefreshFilter();
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
