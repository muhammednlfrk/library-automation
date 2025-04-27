namespace LibraryAutomation.WinFormsUI.Forms;

partial class EmployeeLoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLoginForm));
        _btnLogin = new Syncfusion.WinForms.Controls.SfButton();
        _btnCancel = new Syncfusion.WinForms.Controls.SfButton();
        _txtBoxUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblUsername = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _lblPassword = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _pcBoxAppImage = new PictureBox();
        _lblAttention = new Label();
        ((System.ComponentModel.ISupportInitialize)_txtBoxUsername).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPassword).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_pcBoxAppImage).BeginInit();
        SuspendLayout();
        // 
        // _btnLogin
        // 
        _btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnLogin.Font = new Font("Segoe UI Semibold", 9F);
        _btnLogin.Location = new Point(272, 274);
        _btnLogin.Name = "_btnLogin";
        _btnLogin.Size = new Size(96, 28);
        _btnLogin.TabIndex = 0;
        _btnLogin.Text = "&Giriş";
        _btnLogin.Click += _btnLogin_Click;
        // 
        // _btnCancel
        // 
        _btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnCancel.Font = new Font("Segoe UI Semibold", 9F);
        _btnCancel.Location = new Point(170, 274);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new Size(96, 28);
        _btnCancel.TabIndex = 1;
        _btnCancel.Text = "&İptal";
        _btnCancel.Click += _btnCancel_Click;
        // 
        // _txtBoxUsername
        // 
        _txtBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxUsername.BeforeTouchSize = new Size(363, 23);
        _txtBoxUsername.Location = new Point(5, 200);
        _txtBoxUsername.Name = "_txtBoxUsername";
        _txtBoxUsername.Size = new Size(363, 23);
        _txtBoxUsername.TabIndex = 2;
        // 
        // _lblUsername
        // 
        _lblUsername.DY = -19;
        _lblUsername.LabeledControl = _txtBoxUsername;
        _lblUsername.Location = new Point(5, 181);
        _lblUsername.Name = "_lblUsername";
        _lblUsername.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblUsername.Size = new Size(74, 15);
        _lblUsername.TabIndex = 3;
        _lblUsername.Text = "Kullanıcı adı:";
        // 
        // _lblPassword
        // 
        _lblPassword.DY = -19;
        _lblPassword.LabeledControl = _txtBoxPassword;
        _lblPassword.Location = new Point(5, 226);
        _lblPassword.Name = "_lblPassword";
        _lblPassword.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblPassword.Size = new Size(33, 15);
        _lblPassword.TabIndex = 5;
        _lblPassword.Text = "Şifre:";
        // 
        // _txtBoxPassword
        // 
        _txtBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxPassword.BeforeTouchSize = new Size(363, 23);
        _txtBoxPassword.Location = new Point(5, 245);
        _txtBoxPassword.Name = "_txtBoxPassword";
        _txtBoxPassword.PasswordChar = '●';
        _txtBoxPassword.Size = new Size(363, 23);
        _txtBoxPassword.TabIndex = 4;
        _txtBoxPassword.UseSystemPasswordChar = true;
        // 
        // _pcBoxAppImage
        // 
        _pcBoxAppImage.Anchor = AnchorStyles.Top;
        _pcBoxAppImage.Image = Properties.Resources.AppIcon128;
        _pcBoxAppImage.Location = new Point(120, 5);
        _pcBoxAppImage.Name = "_pcBoxAppImage";
        _pcBoxAppImage.Size = new Size(128, 128);
        _pcBoxAppImage.SizeMode = PictureBoxSizeMode.CenterImage;
        _pcBoxAppImage.TabIndex = 6;
        _pcBoxAppImage.TabStop = false;
        // 
        // _lblAttention
        // 
        _lblAttention.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _lblAttention.Location = new Point(5, 139);
        _lblAttention.Margin = new Padding(3);
        _lblAttention.Name = "_lblAttention";
        _lblAttention.Size = new Size(363, 39);
        _lblAttention.TabIndex = 7;
        _lblAttention.Text = "Kullanıcı adı ve şifrenizi katiyen paylaşmayınız. Eğer şifrenizi unuttuysanız sistem yöneticiniz ile iletişime geçiniz.";
        _lblAttention.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // EmployeeLoginForm
        // 
        AcceptButton = _btnLogin;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = _btnCancel;
        ClientSize = new Size(373, 312);
        Controls.Add(_lblAttention);
        Controls.Add(_pcBoxAppImage);
        Controls.Add(_lblPassword);
        Controls.Add(_txtBoxPassword);
        Controls.Add(_lblUsername);
        Controls.Add(_txtBoxUsername);
        Controls.Add(_btnCancel);
        Controls.Add(_btnLogin);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(389, 351);
        MinimizeBox = false;
        MinimumSize = new Size(389, 351);
        Name = "EmployeeLoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Text = "Giriş";
        Load += LoginForm_Load;
        ((System.ComponentModel.ISupportInitialize)_txtBoxUsername).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPassword).EndInit();
        ((System.ComponentModel.ISupportInitialize)_pcBoxAppImage).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Syncfusion.WinForms.Controls.SfButton _btnLogin;
    private Syncfusion.WinForms.Controls.SfButton _btnCancel;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxUsername;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblUsername;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblPassword;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxPassword;
    private PictureBox _pcBoxAppImage;
    private Label _lblAttention;
}