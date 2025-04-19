namespace LibraryAutomation.WinFormsUI.Forms.Employee.Member;

partial class MemberManagementForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberManagementForm));
        _lblNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _txtBoxSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblSearch = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _dataGridMember = new Syncfusion.WinForms.DataGrid.SfDataGrid();
        _btnAdd = new Syncfusion.WinForms.Controls.SfButton();
        _btnDelete = new Syncfusion.WinForms.Controls.SfButton();
        _btnResetPassword = new Syncfusion.WinForms.Controls.SfButton();
        ((System.ComponentModel.ISupportInitialize)_txtBoxNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_dataGridMember).BeginInit();
        SuspendLayout();
        // 
        // _lblNumber
        // 
        _lblNumber.DY = -19;
        _lblNumber.LabeledControl = _txtBoxNumber;
        _lblNumber.Location = new Point(501, 2);
        _lblNumber.Name = "_lblNumber";
        _lblNumber.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblNumber.Size = new Size(84, 15);
        _lblNumber.TabIndex = 26;
        _lblNumber.Text = "Üye Numarası:";
        // 
        // _txtBoxNumber
        // 
        _txtBoxNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxNumber.BeforeTouchSize = new Size(490, 23);
        _txtBoxNumber.Location = new Point(501, 21);
        _txtBoxNumber.MaxLength = 9;
        _txtBoxNumber.Name = "_txtBoxNumber";
        _txtBoxNumber.Size = new Size(196, 23);
        _txtBoxNumber.TabIndex = 25;
        _txtBoxNumber.WordWrap = false;
        _txtBoxNumber.TextChanged += _txtBoxNumber_TextChanged;
        // 
        // _txtBoxSearch
        // 
        _txtBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxSearch.BeforeTouchSize = new Size(490, 23);
        _txtBoxSearch.Location = new Point(5, 21);
        _txtBoxSearch.Name = "_txtBoxSearch";
        _txtBoxSearch.Size = new Size(490, 23);
        _txtBoxSearch.TabIndex = 23;
        _txtBoxSearch.TextChanged += _txtBoxSearch_TextChanged;
        // 
        // _lblSearch
        // 
        _lblSearch.DY = -19;
        _lblSearch.LabeledControl = _txtBoxSearch;
        _lblSearch.Location = new Point(5, 2);
        _lblSearch.Name = "_lblSearch";
        _lblSearch.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblSearch.Size = new Size(28, 15);
        _lblSearch.TabIndex = 24;
        _lblSearch.Text = "Ara:";
        // 
        // _dataGridMember
        // 
        _dataGridMember.AccessibleName = "Table";
        _dataGridMember.AllowEditing = false;
        _dataGridMember.AllowFiltering = true;
        _dataGridMember.AllowResizingColumns = true;
        _dataGridMember.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _dataGridMember.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
        _dataGridMember.Location = new Point(5, 50);
        _dataGridMember.Name = "_dataGridMember";
        _dataGridMember.Size = new Size(794, 456);
        _dataGridMember.Style.BorderColor = Color.FromArgb(100, 100, 100);
        _dataGridMember.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
        _dataGridMember.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridMember.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridMember.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
        _dataGridMember.TabIndex = 22;
        _dataGridMember.Text = "sfDataGrid1";
        _dataGridMember.Click += _dataGridMember_Click;
        // 
        // _btnAdd
        // 
        _btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _btnAdd.Font = new Font("Segoe UI Semibold", 9F);
        _btnAdd.ImageSize = new Size(16, 16);
        _btnAdd.Location = new Point(771, 16);
        _btnAdd.Name = "_btnAdd";
        _btnAdd.Size = new Size(28, 28);
        _btnAdd.Style.Image = Properties.Resources.add;
        _btnAdd.TabIndex = 27;
        _btnAdd.Click += _btnAdd_Click;
        // 
        // _btnDelete
        // 
        _btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _btnDelete.Enabled = false;
        _btnDelete.Font = new Font("Segoe UI Semibold", 9F);
        _btnDelete.ImageSize = new Size(16, 16);
        _btnDelete.Location = new Point(737, 16);
        _btnDelete.Name = "_btnDelete";
        _btnDelete.Size = new Size(28, 28);
        _btnDelete.Style.Image = Properties.Resources.unavailable;
        _btnDelete.TabIndex = 28;
        // 
        // _btnResetPassword
        // 
        _btnResetPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _btnResetPassword.Enabled = false;
        _btnResetPassword.Font = new Font("Segoe UI Semibold", 9F);
        _btnResetPassword.ImageSize = new Size(16, 16);
        _btnResetPassword.Location = new Point(703, 16);
        _btnResetPassword.Name = "_btnResetPassword";
        _btnResetPassword.Size = new Size(28, 28);
        _btnResetPassword.Style.Image = Properties.Resources.password_reset;
        _btnResetPassword.TabIndex = 29;
        // 
        // MemberManagementForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(804, 511);
        Controls.Add(_btnResetPassword);
        Controls.Add(_btnDelete);
        Controls.Add(_btnAdd);
        Controls.Add(_lblNumber);
        Controls.Add(_txtBoxNumber);
        Controls.Add(_txtBoxSearch);
        Controls.Add(_lblSearch);
        Controls.Add(_dataGridMember);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "MemberManagementForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Text = "Üyeler";
        ((System.ComponentModel.ISupportInitialize)_txtBoxNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).EndInit();
        ((System.ComponentModel.ISupportInitialize)_dataGridMember).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblNumber;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxNumber;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxSearch;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblSearch;
    private Syncfusion.WinForms.DataGrid.SfDataGrid _dataGridMember;
    private Syncfusion.WinForms.Controls.SfButton _btnAdd;
    private Syncfusion.WinForms.Controls.SfButton _btnDelete;
    private Syncfusion.WinForms.Controls.SfButton _btnResetPassword;
}