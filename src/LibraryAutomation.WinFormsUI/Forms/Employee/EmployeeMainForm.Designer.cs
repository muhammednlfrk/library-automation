namespace LibraryAutomation.WinFormsUI.Forms.Employee;

partial class EmployeeMainForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMainForm));
        _btnBooks = new Syncfusion.WinForms.Controls.SfButton();
        _btnWriters = new Syncfusion.WinForms.Controls.SfButton();
        _btnTranslators = new Syncfusion.WinForms.Controls.SfButton();
        _btnShelfs = new Syncfusion.WinForms.Controls.SfButton();
        _btnPublishers = new Syncfusion.WinForms.Controls.SfButton();
        _btnBorrows = new Syncfusion.WinForms.Controls.SfButton();
        _btnUsers = new Syncfusion.WinForms.Controls.SfButton();
        _pnlMenu = new Panel();
        _pnlMain = new Panel();
        _pnlMenu.SuspendLayout();
        SuspendLayout();
        // 
        // _btnBooks
        // 
        _btnBooks.FocusRectangleVisible = true;
        _btnBooks.Font = new Font("Segoe UI Semibold", 9F);
        _btnBooks.ImageAlign = ContentAlignment.BottomCenter;
        _btnBooks.ImageMargin = new Padding(1);
        _btnBooks.ImageSize = new Size(80, 80);
        _btnBooks.Location = new Point(0, 0);
        _btnBooks.Name = "_btnBooks";
        _btnBooks.Size = new Size(120, 120);
        _btnBooks.Style.Image = Properties.Resources.book_stack;
        _btnBooks.TabIndex = 0;
        _btnBooks.Text = "Kitaplar";
        _btnBooks.TextImageRelation = TextImageRelation.ImageAboveText;
        _btnBooks.TextMargin = new Padding(1);
        // 
        // _btnWriters
        // 
        _btnWriters.Font = new Font("Segoe UI Semibold", 9F);
        _btnWriters.Location = new Point(0, 126);
        _btnWriters.Name = "_btnWriters";
        _btnWriters.Size = new Size(120, 28);
        _btnWriters.TabIndex = 1;
        _btnWriters.Text = "Yazarlar";
        // 
        // _btnTranslators
        // 
        _btnTranslators.Font = new Font("Segoe UI Semibold", 9F);
        _btnTranslators.Location = new Point(0, 160);
        _btnTranslators.Name = "_btnTranslators";
        _btnTranslators.Size = new Size(120, 28);
        _btnTranslators.TabIndex = 2;
        _btnTranslators.Text = "Çevirmenler";
        // 
        // _btnShelfs
        // 
        _btnShelfs.FocusRectangleVisible = true;
        _btnShelfs.Font = new Font("Segoe UI Semibold", 9F);
        _btnShelfs.ImageAlign = ContentAlignment.BottomCenter;
        _btnShelfs.ImageMargin = new Padding(1);
        _btnShelfs.ImageSize = new Size(40, 40);
        _btnShelfs.Location = new Point(126, 0);
        _btnShelfs.Name = "_btnShelfs";
        _btnShelfs.Size = new Size(91, 91);
        _btnShelfs.Style.Image = Properties.Resources.book_shelf;
        _btnShelfs.TabIndex = 3;
        _btnShelfs.Text = "Raflar";
        _btnShelfs.TextImageRelation = TextImageRelation.ImageAboveText;
        _btnShelfs.TextMargin = new Padding(1);
        // 
        // _btnPublishers
        // 
        _btnPublishers.FocusRectangleVisible = true;
        _btnPublishers.Font = new Font("Segoe UI Semibold", 9F);
        _btnPublishers.ImageAlign = ContentAlignment.BottomCenter;
        _btnPublishers.ImageMargin = new Padding(1);
        _btnPublishers.ImageSize = new Size(40, 40);
        _btnPublishers.Location = new Point(126, 97);
        _btnPublishers.Name = "_btnPublishers";
        _btnPublishers.Size = new Size(91, 91);
        _btnPublishers.Style.Image = Properties.Resources.knowledge_sharing;
        _btnPublishers.TabIndex = 4;
        _btnPublishers.Text = "Yayın Evleri";
        _btnPublishers.TextImageRelation = TextImageRelation.ImageAboveText;
        _btnPublishers.TextMargin = new Padding(1);
        // 
        // _btnBorrows
        // 
        _btnBorrows.FocusRectangleVisible = true;
        _btnBorrows.Font = new Font("Segoe UI Semibold", 9F);
        _btnBorrows.ImageAlign = ContentAlignment.BottomCenter;
        _btnBorrows.ImageMargin = new Padding(1);
        _btnBorrows.ImageSize = new Size(40, 40);
        _btnBorrows.Location = new Point(223, 0);
        _btnBorrows.Name = "_btnBorrows";
        _btnBorrows.Size = new Size(91, 91);
        _btnBorrows.Style.Image = Properties.Resources.booking;
        _btnBorrows.TabIndex = 5;
        _btnBorrows.Text = "Ödünç Almalar";
        _btnBorrows.TextImageRelation = TextImageRelation.ImageAboveText;
        _btnBorrows.TextMargin = new Padding(1);
        _btnBorrows.Click += _btnBorrows_Click;
        // 
        // _btnUsers
        // 
        _btnUsers.Anchor = AnchorStyles.None;
        _btnUsers.FocusRectangleVisible = true;
        _btnUsers.Font = new Font("Segoe UI Semibold", 9F);
        _btnUsers.ImageAlign = ContentAlignment.BottomCenter;
        _btnUsers.ImageMargin = new Padding(1);
        _btnUsers.ImageSize = new Size(40, 40);
        _btnUsers.Location = new Point(223, 97);
        _btnUsers.Name = "_btnUsers";
        _btnUsers.Size = new Size(91, 91);
        _btnUsers.Style.Image = Properties.Resources.user_account_;
        _btnUsers.TabIndex = 6;
        _btnUsers.Text = "Üyeler";
        _btnUsers.TextImageRelation = TextImageRelation.ImageAboveText;
        _btnUsers.TextMargin = new Padding(1);
        _btnUsers.Click += _btnUsers_Click;
        // 
        // _pnlMenu
        // 
        _pnlMenu.Anchor = AnchorStyles.None;
        _pnlMenu.Controls.Add(_btnBooks);
        _pnlMenu.Controls.Add(_btnUsers);
        _pnlMenu.Controls.Add(_btnWriters);
        _pnlMenu.Controls.Add(_btnBorrows);
        _pnlMenu.Controls.Add(_btnTranslators);
        _pnlMenu.Controls.Add(_btnPublishers);
        _pnlMenu.Controls.Add(_btnShelfs);
        _pnlMenu.Location = new Point(192, 128);
        _pnlMenu.Name = "_pnlMenu";
        _pnlMenu.Size = new Size(314, 188);
        _pnlMenu.TabIndex = 7;
        // 
        // _pnlMain
        // 
        _pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _pnlMain.Location = new Point(4, 3);
        _pnlMain.Name = "_pnlMain";
        _pnlMain.Size = new Size(690, 439);
        _pnlMain.TabIndex = 8;
        // 
        // EmployeeMainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(698, 446);
        Controls.Add(_pnlMenu);
        Controls.Add(_pnlMain);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "EmployeeMainForm";
        Padding = new Padding(1, 0, 1, 1);
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Text = "Yönetim Paneli";
        FormClosing += EmployeeMainForm_FormClosing;
        _pnlMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Syncfusion.WinForms.Controls.SfButton _btnBooks;
    private Syncfusion.WinForms.Controls.SfButton _btnWriters;
    private Syncfusion.WinForms.Controls.SfButton _btnTranslators;
    private Syncfusion.WinForms.Controls.SfButton _btnShelfs;
    private Syncfusion.WinForms.Controls.SfButton _btnPublishers;
    private Syncfusion.WinForms.Controls.SfButton _btnBorrows;
    private Syncfusion.WinForms.Controls.SfButton _btnUsers;
    private Panel _pnlMenu;
    private Panel _pnlMain;
}