using LibraryAutomation.ApplicationL.Identity;
using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Domain.Enums;
using LibraryAutomation.WinFormsUI.Extensions;
using LibraryAutomation.WinFormsUI.Forms.Employee;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms;

public partial class EmployeeLoginForm : SfForm
{
    private readonly IAuthenticator _authenticator;

    public EmployeeLoginForm(IAuthenticator authenticator)
    {
        InitializeComponent();

        _authenticator = authenticator;
    }

    #region Events

    private void LoginForm_Load(object sender, EventArgs e)
    {
        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        this.ApplySkin();

        _btnLogin.MakePrimary();
        _btnCancel.MakeOutline();
    }

    private void _btnCancel_Click(object sender, EventArgs e)
    {
        Close();
        Application.Exit();
    }

    private void _btnLogin_Click(object sender, EventArgs e)
    {
        string usernameOrEmail = _txtBoxUsername.Text;
        string password = _txtBoxPassword.Text;

        if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
        {
            MessageBoxAdv.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        User? user = _authenticator.Authenticate(usernameOrEmail, password);

        if (user == null || user.UserGroup is not UserGroup.Root or UserGroup.Admin)
        {
            MessageBoxAdv.Show("Kullanıcı adı veya şifre hatalı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _txtBoxPassword.Clear();
            return;
        }

        Program.AuthenticatedUser = user;

        Close();
        Form mainForm = Program.ServiceProvider.Get<EmployeeMainForm>();
        mainForm.Show();
    }

    #endregion
}
