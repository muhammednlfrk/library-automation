using LibraryAutomation.WinFormsUI.Extensions;
using LibraryAutomation.WinFormsUI.Forms.Employee.Member;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class EmployeeMainForm : SfForm
{
    private bool _isExitConfirmed = false;

    public EmployeeMainForm()
    {
        InitializeComponent();

        // Apply theme for the form.
        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);
        _btnBooks.MakeIcon();
        _btnWriters.MakeIcon();
        _btnTranslators.MakeIcon();
        _btnShelfs.MakeIcon();
        _btnPublishers.MakeIcon();
        _btnBorrows.MakeIcon();
        _btnUsers.MakeIcon();
    }

    #region Events

    private void EmployeeMainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (_isExitConfirmed) return;
        e.Cancel = true;

        MessageBoxAdv.ThemeName = "LibraryTheme";
        DialogResult result = MessageBoxAdv.Show(
            owner: this,
            text: "Çıkış yapmak istediğinizden emin misiniz?",
            caption: "Uyarı",
            buttons: MessageBoxButtons.YesNo,
            icon: MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            _isExitConfirmed = true;
            Application.Exit();
        }
    }

    private void _btnUsers_Click(object sender, EventArgs e) => Program.ServiceProvider.Get<MemberManagementForm>().ShowDialog();

    private void _btnBorrows_Click(object sender, EventArgs e) => Program.ServiceProvider.Get<BorrowsForm>().ShowDialog();

    private void _btnPublishers_Click(object sender, EventArgs e) => Program.ServiceProvider.Get<PublishersForm>().ShowDialog();

    private void _btnShelfs_Click(object sender, EventArgs e) => Program.ServiceProvider.Get<ShelfsForm>().ShowDialog();

    private void _btnTranslators_Click(object sender, EventArgs e) => new TranslatorsOrWritersForm(true).ShowDialog();

    private void _btnWriters_Click(object sender, EventArgs e) => new TranslatorsOrWritersForm(false).ShowDialog();

    private void _btnBooks_Click(object sender, EventArgs e) => Program.ServiceProvider.Get<BooksForm>().ShowDialog();

    #endregion
}
