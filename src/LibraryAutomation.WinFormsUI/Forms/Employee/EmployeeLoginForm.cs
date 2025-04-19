using LibraryAutomation.WinFormsUI.Forms.Employee;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms;

public partial class EmployeeLoginForm : SfForm
{
    public EmployeeLoginForm()
    {
        InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        this.ApplySkin();

        _btnLogin.MakePrimary();
        _btnCancel.MakeOutline();
    }

    private void _btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
        Application.Exit();
    }

    private void _btnLogin_Click(object sender, EventArgs e)
    {
        this.Close();
        new EmployeeMainForm().Show();
    }
}
