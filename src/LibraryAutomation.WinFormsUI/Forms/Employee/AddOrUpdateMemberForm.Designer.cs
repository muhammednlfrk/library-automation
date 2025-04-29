namespace LibraryAutomation.WinFormsUI.Forms.Employee.Member;

partial class AddOrUpdateMemberForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateMemberForm));
        _txtBoxFullName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _lblEmail = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblUsername = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblPassword = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblPasswordAgain = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxPasswordAgain = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _btnSave = new Syncfusion.WinForms.Controls.SfButton();
        _btnCancel = new Syncfusion.WinForms.Controls.SfButton();
        ((System.ComponentModel.ISupportInitialize)_txtBoxFullName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxEmail).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxUsername).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPassword).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPasswordAgain).BeginInit();
        SuspendLayout();
        // 
        // _txtBoxFullName
        // 
        _txtBoxFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxFullName.BeforeTouchSize = new Size(324, 23);
        _txtBoxFullName.Location = new Point(5, 66);
        _txtBoxFullName.Name = "_txtBoxFullName";
        _txtBoxFullName.Size = new Size(324, 23);
        _txtBoxFullName.TabIndex = 1;
        // 
        // _lblName
        // 
        _lblName.DY = -19;
        _lblName.LabeledControl = _txtBoxFullName;
        _lblName.Location = new Point(5, 47);
        _lblName.Name = "_lblName";
        _lblName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblName.Size = new Size(75, 15);
        _lblName.TabIndex = 1;
        _lblName.Text = "Ad ve Soyad:";
        // 
        // _lblEmail
        // 
        _lblEmail.DY = -19;
        _lblEmail.LabeledControl = _txtBoxEmail;
        _lblEmail.Location = new Point(5, 92);
        _lblEmail.Name = "_lblEmail";
        _lblEmail.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblEmail.Size = new Size(86, 15);
        _lblEmail.TabIndex = 3;
        _lblEmail.Text = "E-Posta Adresi:";
        // 
        // _txtBoxEmail
        // 
        _txtBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxEmail.BeforeTouchSize = new Size(324, 23);
        _txtBoxEmail.Location = new Point(5, 111);
        _txtBoxEmail.Name = "_txtBoxEmail";
        _txtBoxEmail.Size = new Size(324, 23);
        _txtBoxEmail.TabIndex = 2;
        // 
        // _lblUsername
        // 
        _lblUsername.DY = -19;
        _lblUsername.LabeledControl = _txtBoxUsername;
        _lblUsername.Location = new Point(5, 2);
        _lblUsername.Name = "_lblUsername";
        _lblUsername.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblUsername.Size = new Size(84, 15);
        _lblUsername.TabIndex = 5;
        _lblUsername.Text = "Üye Numarası:";
        // 
        // _txtBoxUsername
        // 
        _txtBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxUsername.BeforeTouchSize = new Size(324, 23);
        _txtBoxUsername.Location = new Point(5, 21);
        _txtBoxUsername.Name = "_txtBoxUsername";
        _txtBoxUsername.Size = new Size(324, 23);
        _txtBoxUsername.TabIndex = 0;
        // 
        // _lblPassword
        // 
        _lblPassword.DY = -19;
        _lblPassword.LabeledControl = _txtBoxPassword;
        _lblPassword.Location = new Point(5, 137);
        _lblPassword.Name = "_lblPassword";
        _lblPassword.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblPassword.Size = new Size(33, 15);
        _lblPassword.TabIndex = 7;
        _lblPassword.Text = "Şifre:";
        // 
        // _txtBoxPassword
        // 
        _txtBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxPassword.BeforeTouchSize = new Size(324, 23);
        _txtBoxPassword.Location = new Point(5, 156);
        _txtBoxPassword.Name = "_txtBoxPassword";
        _txtBoxPassword.PasswordChar = '●';
        _txtBoxPassword.Size = new Size(324, 23);
        _txtBoxPassword.TabIndex = 3;
        _txtBoxPassword.UseSystemPasswordChar = true;
        // 
        // _lblPasswordAgain
        // 
        _lblPasswordAgain.DY = -19;
        _lblPasswordAgain.LabeledControl = _txtBoxPasswordAgain;
        _lblPasswordAgain.Location = new Point(5, 182);
        _lblPasswordAgain.Name = "_lblPasswordAgain";
        _lblPasswordAgain.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblPasswordAgain.Size = new Size(76, 15);
        _lblPasswordAgain.TabIndex = 9;
        _lblPasswordAgain.Text = "Şifre (Tekrar):";
        // 
        // _txtBoxPasswordAgain
        // 
        _txtBoxPasswordAgain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxPasswordAgain.BackColor = Color.FromArgb(234, 242, 251);
        _txtBoxPasswordAgain.BeforeTouchSize = new Size(324, 23);
        _txtBoxPasswordAgain.BorderColor = Color.FromArgb(188, 208, 229);
        _txtBoxPasswordAgain.BorderStyle = BorderStyle.FixedSingle;
        _txtBoxPasswordAgain.Location = new Point(5, 201);
        _txtBoxPasswordAgain.Name = "_txtBoxPasswordAgain";
        _txtBoxPasswordAgain.PasswordChar = '●';
        _txtBoxPasswordAgain.Size = new Size(324, 23);
        _txtBoxPasswordAgain.TabIndex = 4;
        _txtBoxPasswordAgain.UseSystemPasswordChar = true;
        // 
        // _btnSave
        // 
        _btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnSave.Font = new Font("Segoe UI Semibold", 9F);
        _btnSave.Location = new Point(233, 233);
        _btnSave.Name = "_btnSave";
        _btnSave.Size = new Size(96, 28);
        _btnSave.TabIndex = 5;
        _btnSave.Text = "&Kaydet";
        _btnSave.Click += _btnSave_Click;
        // 
        // _btnCancel
        // 
        _btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnCancel.Font = new Font("Segoe UI Semibold", 9F);
        _btnCancel.Location = new Point(131, 233);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new Size(96, 28);
        _btnCancel.TabIndex = 5;
        _btnCancel.Text = "&İptal";
        // 
        // AddOrUpdateMemberForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = _btnCancel;
        ClientSize = new Size(334, 266);
        Controls.Add(_btnCancel);
        Controls.Add(_btnSave);
        Controls.Add(_lblPasswordAgain);
        Controls.Add(_txtBoxPasswordAgain);
        Controls.Add(_lblPassword);
        Controls.Add(_txtBoxPassword);
        Controls.Add(_lblUsername);
        Controls.Add(_txtBoxUsername);
        Controls.Add(_lblEmail);
        Controls.Add(_txtBoxEmail);
        Controls.Add(_lblName);
        Controls.Add(_txtBoxFullName);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(350, 305);
        MinimizeBox = false;
        MinimumSize = new Size(350, 305);
        Name = "AddOrUpdateMemberForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Load += AddOrUpdateMemberForm_Load;
        ((System.ComponentModel.ISupportInitialize)_txtBoxFullName).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxEmail).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxUsername).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPassword).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPasswordAgain).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxFullName;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblName;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblEmail;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxEmail;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblUsername;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxUsername;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblPassword;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxPassword;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblPasswordAgain;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxPasswordAgain;
    private Syncfusion.WinForms.Controls.SfButton _btnSave;
    private Syncfusion.WinForms.Controls.SfButton _btnCancel;
}