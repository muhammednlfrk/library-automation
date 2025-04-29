using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Extensions;
using LibraryAutomation.WinFormsUI.Theme;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;

namespace LibraryAutomation.WinFormsUI.Forms.Employee.Member;

public partial class MemberManagementForm : SfForm
{
    private ICollection<User> _members = null!;
    private User? _selectedMember;

    private readonly IRepository<User> _userRepository;

    public MemberManagementForm(IRepository<User> userRepository)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);
        _btnAdd.MakeOutline();
        _btnDelete.MakeOutline();
        _btnUpdate.MakeOutline();

        _userRepository = userRepository;

        loadMembers();
    }

    #region Events

    private void _dataGridMember_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        object memberObject = _dataGridMember.SelectedItem;

        if (memberObject is User selectedMember && selectedMember != null)
        {
            _selectedMember = selectedMember;
            _btnDelete.Enabled = true;
            _btnUpdate.Enabled = true;
        }
        else
        {
            clearSelected();
        }
    }

    private void _txtBoxSearch_TextChanged(object sender, EventArgs e) => _dataGridMember.SearchController.Search(_txtBoxSearch.Text);

    private void _txtBoxNumber_TextChanged(object sender, EventArgs e)
    {
        string memberNumber = _txtBoxNumber.Text;

        if (string.IsNullOrEmpty(memberNumber) || memberNumber.Length != 9)
        {
            _dataGridMember.ClearFilters();
            _dataGridMember.View.RefreshFilter();
            return;
        }

        _dataGridMember.Columns["Username"].FilterPredicates.Add(new FilterPredicate() { FilterType = FilterType.Equals, FilterValue = memberNumber, PredicateType = PredicateType.Or });
        _dataGridMember.View.RefreshFilter();
    }

    private void _btnAdd_Click(object sender, EventArgs e)
    {
        Program.ServiceProvider.Get<AddOrUpdateMemberForm>().ShowDialog();
        loadMembers();
    }

    private void _btnUpdate_Click(object sender, EventArgs e)
    {
        if (_selectedMember == null)
            return;
        AddOrUpdateMemberForm form = Program.ServiceProvider.Get<AddOrUpdateMemberForm>();
        form.UserToUpdate = _selectedMember;
        form.IsUpdate = true;
        form.ShowDialog();
        loadMembers();
    }

    private void _btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedMember == null)
            return;

        DialogResult result = MessageBoxAdv.Show($"{_selectedMember.Name} {_selectedMember.Surname} üyesini silmek istediğinizden emin misiniz?", "Üye Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (result == DialogResult.Yes)
        {
            _userRepository.Delete(_selectedMember.Id);
            loadMembers();
        }
    }

    #endregion

    #region Private Methods

    private void loadMembers()
    {
        clearSelected();

        _userRepository.DbContext.ChangeTracker.Clear();

        _members = _userRepository.DbSet
             .Where(x => x.UserGroup == Domain.Enums.UserGroup.StdUser)
             .Select(x => new User
             {
                 Id = x.Id,
                 Name = x.Name,
                 Surname = x.Surname,
                 Email = x.Email,
                 Username = x.Username,
                 UserGroup = x.UserGroup,
                 Password = string.Empty
             })
             .AsNoTracking()
             .ToList();

        _dataGridMember.DataSource = _members;

        _dataGridMember.Columns["Id"].Visible = false;
        _dataGridMember.Columns["Name"].HeaderText = "Ad";
        _dataGridMember.Columns["Surname"].HeaderText = "Soyad";
        _dataGridMember.Columns["Email"].HeaderText = "E-posta";
        _dataGridMember.Columns["Username"].HeaderText = "Kullanıcı Adı";
        _dataGridMember.Columns["UserGroup"].Visible = false;
        _dataGridMember.Columns["Password"].Visible = false;
    }

    private void clearSelected()
    {
        _selectedMember = null;
        _btnDelete.Enabled = false;
        _btnUpdate.Enabled = false;
    }

    #endregion
}
