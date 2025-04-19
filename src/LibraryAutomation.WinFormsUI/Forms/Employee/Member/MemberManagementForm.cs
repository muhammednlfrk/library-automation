using LibraryAutomation.WinFormsUI.Models;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.Data;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms.Employee.Member;

public partial class MemberManagementForm : SfForm
{
    private readonly IEnumerable<MemberModel> _members;
    private MemberModel? _selectedMember = null;

    public MemberManagementForm()
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);
        _btnAdd.MakeIcon();
        _btnDelete.MakeIcon();
        _btnResetPassword.MakeIcon();

        _members = MemberModel.GetDummyData();
        _dataGridMember.DataSource = _members;
        _dataGridMember.Columns["Id"].Visible = false;
        _dataGridMember.Columns["PasswordHash"].Visible = false;

    }

    private void _dataGridMember_Click(object sender, EventArgs e)
    {
        object memberObject = _dataGridMember.SelectedItem;

        if (memberObject is MemberModel selectedMember && selectedMember != null)
        {
            _selectedMember = selectedMember;
            _btnDelete.Enabled = true;
            _btnResetPassword.Enabled = true;
        }
        else
        {
            _selectedMember = null;
            _btnDelete.Enabled = false;
            _btnResetPassword.Enabled = false;
        }
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridMember.SearchController.Search(_txtBoxSearch.Text);

    private void _txtBoxNumber_TextChanged(object sender, EventArgs e)
    {
        string memberNumber = _txtBoxNumber.Text;

        if (string.IsNullOrEmpty(memberNumber) || memberNumber.Length != 9)
        {
            _dataGridMember.ClearFilter("Number");
            return;
        }

        _dataGridMember.Columns["Number"].FilterPredicates.Add(new FilterPredicate() { FilterType = FilterType.Equals, FilterValue = memberNumber, PredicateType = PredicateType.Or });
        _dataGridMember.View.RefreshFilter();
    }

    private void _btnAdd_Click(object sender, EventArgs e)
    {
        new AddOrUpdateMemberForm().ShowDialog();
    }
}
