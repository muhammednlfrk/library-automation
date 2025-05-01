using LibraryAutomation.WinFormsUI.Extensions;
using LibraryAutomation.WinFormsUI.Forms.Member;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms;

public partial class SelectLoginTypeForm : SfForm
{
    public SelectLoginTypeForm()
    {
        InitializeComponent();
    }

    private void SelectLoginTypeForm_Load(object sender, EventArgs e)
    {
        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        this.ApplySkin();
        _btnLoginAsMember.MakeIcon();
        _btnLoginAsEmployee.MakeIcon();
    }

    private void _btnLoginAsEmployee_Click(object sender, EventArgs e)
    {
        Hide();
        Form loginForm = Program.ServiceProvider.Get<EmployeeLoginForm>();
        loginForm.Show();
    }

    private void _btnLoginAsMember_Click(object sender, EventArgs e)
    {
        Hide();
        Form memberForm = Program.ServiceProvider.Get<MemberMainForm>();
        memberForm.Show();
    }
}
