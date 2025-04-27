using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms.Member;

public partial class MemberMainForm : SfForm
{
    private bool _isExitConfirmed = false;

    public MemberMainForm()
    {
        InitializeComponent();
    }

    private void MemberMainForm_Load(object sender, EventArgs e)
    {
        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        this.ApplySkin();
        _btnBorrowBooks.MakeIcon();
        _btnReturnBook.MakeIcon();
    }

    private void MemberMainForm_FormClosing(object sender, FormClosingEventArgs e)
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

    private void _btnBorrowBooks_Click(object sender, EventArgs e)
    {
        new BorrowBookForm().ShowDialog();
    }

    private void _btnReturnBook_Click(object sender, EventArgs e)
    {
        new ReturnBookForm().ShowDialog();
    }
}
