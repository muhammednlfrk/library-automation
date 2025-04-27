namespace LibraryAutomation.WinFormsUI.Forms.Member;

partial class BorrowBookForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBookForm));
        _dataGridBook = new Syncfusion.WinForms.DataGrid.SfDataGrid();
        _txtBoxISBN = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblISBN = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        pictureBox1 = new PictureBox();
        _txtBoxName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxWriter = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblWriter = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxOriginalName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblOriginName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxPublisher = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblPublisher = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxPublishDate = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblPublishDate = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxPageCount = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblPageCount = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _btnBorrow = new Syncfusion.WinForms.Controls.SfButton();
        _btnCancel = new Syncfusion.WinForms.Controls.SfButton();
        panel1 = new Panel();
        _txtBoxSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblSearch = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _lblNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        ((System.ComponentModel.ISupportInitialize)_dataGridBook).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxISBN).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxWriter).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxOriginalName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPublisher).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPublishDate).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPageCount).BeginInit();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxNumber).BeginInit();
        SuspendLayout();
        // 
        // _dataGridBook
        // 
        _dataGridBook.AccessibleName = "Table";
        _dataGridBook.AllowEditing = false;
        _dataGridBook.AllowFiltering = true;
        _dataGridBook.AllowResizingColumns = true;
        _dataGridBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _dataGridBook.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
        _dataGridBook.Location = new Point(5, 56);
        _dataGridBook.Name = "_dataGridBook";
        _dataGridBook.Size = new Size(650, 537);
        _dataGridBook.Style.BorderColor = Color.FromArgb(100, 100, 100);
        _dataGridBook.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
        _dataGridBook.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridBook.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridBook.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
        _dataGridBook.TabIndex = 0;
        _dataGridBook.Text = "sfDataGrid1";
        _dataGridBook.SelectionChanged += _dataGridBook_SelectionChanged;
        // 
        // _txtBoxISBN
        // 
        _txtBoxISBN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxISBN.BeforeTouchSize = new Size(196, 23);
        _txtBoxISBN.Location = new Point(3, 225);
        _txtBoxISBN.Name = "_txtBoxISBN";
        _txtBoxISBN.Size = new Size(264, 23);
        _txtBoxISBN.TabIndex = 0;
        _txtBoxISBN.Click += _txtBoxISBN_Click;
        _txtBoxISBN.TextChanged += _txtBoxISBN_TextChanged;
        // 
        // _lblISBN
        // 
        _lblISBN.DY = -19;
        _lblISBN.LabeledControl = _txtBoxISBN;
        _lblISBN.Location = new Point(3, 206);
        _lblISBN.Name = "_lblISBN";
        _lblISBN.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblISBN.Size = new Size(35, 15);
        _lblISBN.TabIndex = 2;
        _lblISBN.Text = "ISBN:";
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        pictureBox1.Image = Properties.Resources.dune;
        pictureBox1.Location = new Point(71, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(128, 200);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // _txtBoxName
        // 
        _txtBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxName.BeforeTouchSize = new Size(196, 23);
        _txtBoxName.Enabled = false;
        _txtBoxName.Location = new Point(3, 270);
        _txtBoxName.Name = "_txtBoxName";
        _txtBoxName.Size = new Size(264, 23);
        _txtBoxName.TabIndex = 4;
        // 
        // _lblName
        // 
        _lblName.DY = -19;
        _lblName.LabeledControl = _txtBoxName;
        _lblName.Location = new Point(3, 251);
        _lblName.Name = "_lblName";
        _lblName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblName.Size = new Size(28, 15);
        _lblName.TabIndex = 5;
        _lblName.Text = "Adı:";
        // 
        // _txtBoxWriter
        // 
        _txtBoxWriter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxWriter.BeforeTouchSize = new Size(196, 23);
        _txtBoxWriter.Enabled = false;
        _txtBoxWriter.Location = new Point(3, 315);
        _txtBoxWriter.Name = "_txtBoxWriter";
        _txtBoxWriter.Size = new Size(264, 23);
        _txtBoxWriter.TabIndex = 6;
        // 
        // _lblWriter
        // 
        _lblWriter.DY = -19;
        _lblWriter.LabeledControl = _txtBoxWriter;
        _lblWriter.Location = new Point(3, 296);
        _lblWriter.Name = "_lblWriter";
        _lblWriter.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblWriter.Size = new Size(40, 15);
        _lblWriter.TabIndex = 7;
        _lblWriter.Text = "Yazarı:";
        // 
        // _txtBoxOriginalName
        // 
        _txtBoxOriginalName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxOriginalName.BeforeTouchSize = new Size(196, 23);
        _txtBoxOriginalName.Enabled = false;
        _txtBoxOriginalName.Location = new Point(3, 360);
        _txtBoxOriginalName.Name = "_txtBoxOriginalName";
        _txtBoxOriginalName.Size = new Size(264, 23);
        _txtBoxOriginalName.TabIndex = 8;
        // 
        // _lblOriginName
        // 
        _lblOriginName.DY = -19;
        _lblOriginName.LabeledControl = _txtBoxOriginalName;
        _lblOriginName.Location = new Point(3, 341);
        _lblOriginName.Name = "_lblOriginName";
        _lblOriginName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblOriginName.Size = new Size(69, 15);
        _lblOriginName.TabIndex = 9;
        _lblOriginName.Text = "Orijinal Adı:";
        // 
        // _txtBoxPublisher
        // 
        _txtBoxPublisher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxPublisher.BeforeTouchSize = new Size(196, 23);
        _txtBoxPublisher.Enabled = false;
        _txtBoxPublisher.Location = new Point(3, 405);
        _txtBoxPublisher.Name = "_txtBoxPublisher";
        _txtBoxPublisher.Size = new Size(264, 23);
        _txtBoxPublisher.TabIndex = 10;
        // 
        // _lblPublisher
        // 
        _lblPublisher.DY = -19;
        _lblPublisher.LabeledControl = _txtBoxPublisher;
        _lblPublisher.Location = new Point(3, 386);
        _lblPublisher.Name = "_lblPublisher";
        _lblPublisher.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblPublisher.Size = new Size(53, 15);
        _lblPublisher.TabIndex = 11;
        _lblPublisher.Text = "Yayınevi:";
        // 
        // _txtBoxPublishDate
        // 
        _txtBoxPublishDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxPublishDate.BeforeTouchSize = new Size(196, 23);
        _txtBoxPublishDate.Enabled = false;
        _txtBoxPublishDate.Location = new Point(3, 450);
        _txtBoxPublishDate.Name = "_txtBoxPublishDate";
        _txtBoxPublishDate.Size = new Size(264, 23);
        _txtBoxPublishDate.TabIndex = 12;
        // 
        // _lblPublishDate
        // 
        _lblPublishDate.DY = -19;
        _lblPublishDate.LabeledControl = _txtBoxPublishDate;
        _lblPublishDate.Location = new Point(3, 431);
        _lblPublishDate.Name = "_lblPublishDate";
        _lblPublishDate.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblPublishDate.Size = new Size(70, 15);
        _lblPublishDate.TabIndex = 13;
        _lblPublishDate.Text = "Yayın Tarihi:";
        // 
        // _txtBoxPageCount
        // 
        _txtBoxPageCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxPageCount.BeforeTouchSize = new Size(196, 23);
        _txtBoxPageCount.Enabled = false;
        _txtBoxPageCount.Location = new Point(3, 495);
        _txtBoxPageCount.Name = "_txtBoxPageCount";
        _txtBoxPageCount.Size = new Size(264, 23);
        _txtBoxPageCount.TabIndex = 14;
        // 
        // _lblPageCount
        // 
        _lblPageCount.DY = -19;
        _lblPageCount.LabeledControl = _txtBoxPageCount;
        _lblPageCount.Location = new Point(3, 476);
        _lblPageCount.Name = "_lblPageCount";
        _lblPageCount.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblPageCount.Size = new Size(70, 15);
        _lblPageCount.TabIndex = 15;
        _lblPageCount.Text = "Sayfa Sayısı:";
        // 
        // _btnBorrow
        // 
        _btnBorrow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _btnBorrow.Enabled = false;
        _btnBorrow.Font = new Font("Segoe UI Semibold", 9F);
        _btnBorrow.Location = new Point(3, 524);
        _btnBorrow.Name = "_btnBorrow";
        _btnBorrow.Size = new Size(264, 28);
        _btnBorrow.TabIndex = 1;
        _btnBorrow.Text = "Ödünç Al";
        // 
        // _btnCancel
        // 
        _btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _btnCancel.Font = new Font("Segoe UI Semibold", 9F);
        _btnCancel.Location = new Point(3, 558);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new Size(264, 28);
        _btnCancel.TabIndex = 16;
        _btnCancel.Text = "İptal";
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        panel1.Controls.Add(pictureBox1);
        panel1.Controls.Add(_btnCancel);
        panel1.Controls.Add(_txtBoxISBN);
        panel1.Controls.Add(_btnBorrow);
        panel1.Controls.Add(_lblISBN);
        panel1.Controls.Add(_lblPageCount);
        panel1.Controls.Add(_txtBoxName);
        panel1.Controls.Add(_txtBoxPageCount);
        panel1.Controls.Add(_lblName);
        panel1.Controls.Add(_lblPublishDate);
        panel1.Controls.Add(_txtBoxWriter);
        panel1.Controls.Add(_txtBoxPublishDate);
        panel1.Controls.Add(_lblWriter);
        panel1.Controls.Add(_lblPublisher);
        panel1.Controls.Add(_txtBoxOriginalName);
        panel1.Controls.Add(_txtBoxPublisher);
        panel1.Controls.Add(_lblOriginName);
        panel1.Location = new Point(661, 5);
        panel1.Name = "panel1";
        panel1.Size = new Size(270, 588);
        panel1.TabIndex = 17;
        // 
        // _txtBoxSearch
        // 
        _txtBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxSearch.BeforeTouchSize = new Size(196, 23);
        _txtBoxSearch.Location = new Point(5, 27);
        _txtBoxSearch.Name = "_txtBoxSearch";
        _txtBoxSearch.Size = new Size(448, 23);
        _txtBoxSearch.TabIndex = 18;
        _txtBoxSearch.TextChanged += _txtBoxSearch_TextChanged;
        // 
        // _lblSearch
        // 
        _lblSearch.DY = -19;
        _lblSearch.LabeledControl = _txtBoxSearch;
        _lblSearch.Location = new Point(5, 8);
        _lblSearch.Name = "_lblSearch";
        _lblSearch.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblSearch.Size = new Size(28, 15);
        _lblSearch.TabIndex = 19;
        _lblSearch.Text = "Ara:";
        // 
        // _lblNumber
        // 
        _lblNumber.DY = -19;
        _lblNumber.LabeledControl = _txtBoxNumber;
        _lblNumber.Location = new Point(459, 8);
        _lblNumber.Name = "_lblNumber";
        _lblNumber.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblNumber.Size = new Size(84, 15);
        _lblNumber.TabIndex = 21;
        _lblNumber.Text = "Üye Numarası:";
        // 
        // _txtBoxNumber
        // 
        _txtBoxNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxNumber.BeforeTouchSize = new Size(196, 23);
        _txtBoxNumber.Location = new Point(459, 27);
        _txtBoxNumber.MaxLength = 9;
        _txtBoxNumber.Name = "_txtBoxNumber";
        _txtBoxNumber.Size = new Size(196, 23);
        _txtBoxNumber.TabIndex = 20;
        _txtBoxNumber.WordWrap = false;
        _txtBoxNumber.TextChanged += _txtBoxNumber_TextChanged;
        // 
        // BorrowBookForm
        // 
        AcceptButton = _btnBorrow;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = _btnCancel;
        ClientSize = new Size(936, 598);
        Controls.Add(_lblNumber);
        Controls.Add(_txtBoxNumber);
        Controls.Add(_txtBoxSearch);
        Controls.Add(_lblSearch);
        Controls.Add(panel1);
        Controls.Add(_dataGridBook);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "BorrowBookForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Text = "Ödünç Al";
        WindowState = FormWindowState.Maximized;
        Load += BorrowBookForm_Load;
        ((System.ComponentModel.ISupportInitialize)_dataGridBook).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxISBN).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxName).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxWriter).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxOriginalName).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPublisher).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPublishDate).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPageCount).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxNumber).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Syncfusion.WinForms.DataGrid.SfDataGrid _dataGridBook;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxISBN;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblISBN;
    private PictureBox pictureBox1;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxName;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblName;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxWriter;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblWriter;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxOriginalName;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblOriginName;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxPublisher;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblPublisher;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxPublishDate;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblPublishDate;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxPageCount;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblPageCount;
    private Syncfusion.WinForms.Controls.SfButton _btnBorrow;
    private Syncfusion.WinForms.Controls.SfButton _btnCancel;
    private Panel panel1;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxSearch;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblSearch;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblNumber;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxNumber;
}