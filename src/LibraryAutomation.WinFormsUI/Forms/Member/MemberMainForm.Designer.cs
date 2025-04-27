namespace LibraryAutomation.WinFormsUI.Forms.Member;

partial class MemberMainForm
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberMainForm));
        flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(components);
        _pnlMain = new Panel();
        _pnlButtons = new TableLayoutPanel();
        _btnReturnBook = new Syncfusion.WinForms.Controls.SfButton();
        _btnBorrowBooks = new Syncfusion.WinForms.Controls.SfButton();
        ((System.ComponentModel.ISupportInitialize)flowLayout1).BeginInit();
        _pnlMain.SuspendLayout();
        _pnlButtons.SuspendLayout();
        SuspendLayout();
        // 
        // _pnlMain
        // 
        _pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _pnlMain.Controls.Add(_pnlButtons);
        _pnlMain.Location = new Point(5, 5);
        _pnlMain.Name = "_pnlMain";
        _pnlMain.Size = new Size(524, 451);
        _pnlMain.TabIndex = 0;
        // 
        // _pnlButtons
        // 
        _pnlButtons.Anchor = AnchorStyles.None;
        _pnlButtons.ColumnCount = 2;
        _pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        _pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        _pnlButtons.Controls.Add(_btnReturnBook, 1, 0);
        _pnlButtons.Controls.Add(_btnBorrowBooks, 0, 0);
        _pnlButtons.Location = new Point(81, 137);
        _pnlButtons.Name = "_pnlButtons";
        _pnlButtons.RowCount = 1;
        _pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        _pnlButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        _pnlButtons.Size = new Size(372, 186);
        _pnlButtons.TabIndex = 1;
        // 
        // _btnReturnBook
        // 
        _btnReturnBook.Dock = DockStyle.Fill;
        _btnReturnBook.Font = new Font("Segoe UI Semibold", 9F);
        _btnReturnBook.ImageSize = new Size(80, 80);
        _btnReturnBook.Location = new Point(189, 3);
        _btnReturnBook.Name = "_btnReturnBook";
        _btnReturnBook.Size = new Size(180, 180);
        _btnReturnBook.Style.Image = Properties.Resources.return_book;
        _btnReturnBook.TabIndex = 1;
        _btnReturnBook.Text = "İade Et";
        _btnReturnBook.TextAlign = ContentAlignment.BottomCenter;
        _btnReturnBook.TextImageRelation = TextImageRelation.ImageAboveText;
        _btnReturnBook.Click += _btnReturnBook_Click;
        // 
        // _btnBorrowBooks
        // 
        _btnBorrowBooks.Dock = DockStyle.Fill;
        _btnBorrowBooks.Font = new Font("Segoe UI Semibold", 9F);
        _btnBorrowBooks.ImageSize = new Size(80, 80);
        _btnBorrowBooks.Location = new Point(3, 3);
        _btnBorrowBooks.Name = "_btnBorrowBooks";
        _btnBorrowBooks.Size = new Size(180, 180);
        _btnBorrowBooks.Style.Image = Properties.Resources.borrow_book;
        _btnBorrowBooks.TabIndex = 0;
        _btnBorrowBooks.Text = "Ödünç Al";
        _btnBorrowBooks.TextAlign = ContentAlignment.BottomCenter;
        _btnBorrowBooks.TextImageRelation = TextImageRelation.ImageAboveText;
        _btnBorrowBooks.Click += _btnBorrowBooks_Click;
        // 
        // MemberMainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(534, 461);
        Controls.Add(_pnlMain);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "MemberMainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Text = "Üye Ekranı";
        FormClosing += MemberMainForm_FormClosing;
        Load += MemberMainForm_Load;
        ((System.ComponentModel.ISupportInitialize)flowLayout1).EndInit();
        _pnlMain.ResumeLayout(false);
        _pnlButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
    private Panel _pnlMain;
    private TableLayoutPanel _pnlButtons;
    private Syncfusion.WinForms.Controls.SfButton _btnReturnBook;
    private Syncfusion.WinForms.Controls.SfButton _btnBorrowBooks;
}