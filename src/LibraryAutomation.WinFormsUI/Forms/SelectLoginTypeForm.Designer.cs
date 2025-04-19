namespace LibraryAutomation.WinFormsUI.Forms;

partial class SelectLoginTypeForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectLoginTypeForm));
        _pnlBase = new TableLayoutPanel();
        _btnLoginAsEmployee = new Syncfusion.WinForms.Controls.SfButton();
        _btnLoginAsMember = new Syncfusion.WinForms.Controls.SfButton();
        _pnlBase.SuspendLayout();
        SuspendLayout();
        // 
        // _pnlBase
        // 
        _pnlBase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _pnlBase.ColumnCount = 2;
        _pnlBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        _pnlBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        _pnlBase.Controls.Add(_btnLoginAsEmployee, 1, 0);
        _pnlBase.Controls.Add(_btnLoginAsMember, 0, 0);
        _pnlBase.Location = new Point(5, 5);
        _pnlBase.Name = "_pnlBase";
        _pnlBase.RowCount = 1;
        _pnlBase.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        _pnlBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        _pnlBase.Size = new Size(372, 186);
        _pnlBase.TabIndex = 0;
        // 
        // _btnLoginAsEmployee
        // 
        _btnLoginAsEmployee.Dock = DockStyle.Fill;
        _btnLoginAsEmployee.Font = new Font("Segoe UI Semibold", 9F);
        _btnLoginAsEmployee.ImageSize = new Size(80, 80);
        _btnLoginAsEmployee.Location = new Point(189, 3);
        _btnLoginAsEmployee.Name = "_btnLoginAsEmployee";
        _btnLoginAsEmployee.Size = new Size(180, 180);
        _btnLoginAsEmployee.Style.Image = Properties.Resources.employee_illustration;
        _btnLoginAsEmployee.TabIndex = 1;
        _btnLoginAsEmployee.Text = "Personel Girişi";
        _btnLoginAsEmployee.TextAlign = ContentAlignment.BottomCenter;
        _btnLoginAsEmployee.TextImageRelation = TextImageRelation.ImageAboveText;
        _btnLoginAsEmployee.Click += _btnLoginAsEmployee_Click;
        // 
        // _btnLoginAsMember
        // 
        _btnLoginAsMember.Dock = DockStyle.Fill;
        _btnLoginAsMember.Font = new Font("Segoe UI Semibold", 9F);
        _btnLoginAsMember.ImageSize = new Size(80, 80);
        _btnLoginAsMember.Location = new Point(3, 3);
        _btnLoginAsMember.Name = "_btnLoginAsMember";
        _btnLoginAsMember.Size = new Size(180, 180);
        _btnLoginAsMember.Style.Image = Properties.Resources.user_illustration;
        _btnLoginAsMember.TabIndex = 0;
        _btnLoginAsMember.Text = "Üye Girişi";
        _btnLoginAsMember.TextAlign = ContentAlignment.BottomCenter;
        _btnLoginAsMember.TextImageRelation = TextImageRelation.ImageAboveText;
        _btnLoginAsMember.Click += _btnLoginAsMember_Click;
        // 
        // SelectLoginTypeForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(382, 196);
        Controls.Add(_pnlBase);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(398, 235);
        MinimizeBox = false;
        MinimumSize = new Size(398, 235);
        Name = "SelectLoginTypeForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Text = "Giriş";
        Load += SelectLoginTypeForm_Load;
        _pnlBase.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel _pnlBase;
    private Syncfusion.WinForms.Controls.SfButton _btnLoginAsEmployee;
    private Syncfusion.WinForms.Controls.SfButton _btnLoginAsMember;
}