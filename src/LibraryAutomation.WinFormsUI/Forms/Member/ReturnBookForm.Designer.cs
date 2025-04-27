namespace LibraryAutomation.WinFormsUI.Forms.Member;

partial class ReturnBookForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
        _txtBoxNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _lblWaning = new Label();
        _txtBoxSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblSearch = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _dataGridBorrows = new Syncfusion.WinForms.DataGrid.SfDataGrid();
        _btnReturn = new Syncfusion.WinForms.Controls.SfButton();
        _btnCancel = new Syncfusion.WinForms.Controls.SfButton();
        _lblISBN = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxISBN = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        ((System.ComponentModel.ISupportInitialize)_txtBoxNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_dataGridBorrows).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxISBN).BeginInit();
        SuspendLayout();
        // 
        // _txtBoxNumber
        // 
        _txtBoxNumber.BeforeTouchSize = new Size(132, 23);
        _txtBoxNumber.Location = new Point(5, 21);
        _txtBoxNumber.MaxLength = 9;
        _txtBoxNumber.Name = "_txtBoxNumber";
        _txtBoxNumber.Size = new Size(196, 23);
        _txtBoxNumber.TabIndex = 0;
        _txtBoxNumber.WordWrap = false;
        _txtBoxNumber.Click += _txtBoxNumber_Click;
        _txtBoxNumber.TextChanged += _txtBoxNumber_TextChanged;
        // 
        // _lblNumber
        // 
        _lblNumber.DY = -19;
        _lblNumber.LabeledControl = _txtBoxNumber;
        _lblNumber.Location = new Point(5, 2);
        _lblNumber.Name = "_lblNumber";
        _lblNumber.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblNumber.Size = new Size(84, 15);
        _lblNumber.TabIndex = 1;
        _lblNumber.Text = "Üye Numarası:";
        // 
        // _lblWaning
        // 
        _lblWaning.Location = new Point(5, 47);
        _lblWaning.Name = "_lblWaning";
        _lblWaning.Size = new Size(196, 169);
        _lblWaning.TabIndex = 2;
        _lblWaning.Text = resources.GetString("_lblWaning.Text");
        // 
        // _txtBoxSearch
        // 
        _txtBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxSearch.BeforeTouchSize = new Size(132, 23);
        _txtBoxSearch.Location = new Point(207, 21);
        _txtBoxSearch.Name = "_txtBoxSearch";
        _txtBoxSearch.Size = new Size(456, 23);
        _txtBoxSearch.TabIndex = 1;
        _txtBoxSearch.TextChanged += _txtBoxSearch_TextChanged;
        // 
        // _lblSearch
        // 
        _lblSearch.DY = -19;
        _lblSearch.LabeledControl = _txtBoxSearch;
        _lblSearch.Location = new Point(207, 2);
        _lblSearch.Name = "_lblSearch";
        _lblSearch.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblSearch.Size = new Size(28, 15);
        _lblSearch.TabIndex = 5;
        _lblSearch.Text = "Ara:";
        // 
        // _dataGridBorrows
        // 
        _dataGridBorrows.AccessibleName = "Table";
        _dataGridBorrows.AllowEditing = false;
        _dataGridBorrows.AllowFiltering = true;
        _dataGridBorrows.AllowResizingColumns = true;
        _dataGridBorrows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _dataGridBorrows.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
        _dataGridBorrows.Location = new Point(207, 50);
        _dataGridBorrows.Name = "_dataGridBorrows";
        _dataGridBorrows.Size = new Size(594, 396);
        _dataGridBorrows.Style.BorderColor = Color.FromArgb(100, 100, 100);
        _dataGridBorrows.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
        _dataGridBorrows.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridBorrows.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridBorrows.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
        _dataGridBorrows.TabIndex = 6;
        _dataGridBorrows.Text = "sfDataGrid1";
        // 
        // _btnReturn
        // 
        _btnReturn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnReturn.Enabled = false;
        _btnReturn.Font = new Font("Segoe UI Semibold", 9F);
        _btnReturn.Location = new Point(669, 452);
        _btnReturn.Name = "_btnReturn";
        _btnReturn.Size = new Size(132, 28);
        _btnReturn.TabIndex = 7;
        _btnReturn.Text = "İade Et";
        // 
        // _btnCancel
        // 
        _btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnCancel.Font = new Font("Segoe UI Semibold", 9F);
        _btnCancel.Location = new Point(531, 452);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new Size(132, 28);
        _btnCancel.TabIndex = 8;
        _btnCancel.Text = "İptal";
        // 
        // _lblISBN
        // 
        _lblISBN.DY = -19;
        _lblISBN.LabeledControl = _txtBoxISBN;
        _lblISBN.Location = new Point(669, 2);
        _lblISBN.Name = "_lblISBN";
        _lblISBN.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblISBN.Size = new Size(35, 15);
        _lblISBN.TabIndex = 10;
        _lblISBN.Text = "ISBN:";
        // 
        // _txtBoxISBN
        // 
        _txtBoxISBN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxISBN.BeforeTouchSize = new Size(132, 23);
        _txtBoxISBN.Location = new Point(669, 21);
        _txtBoxISBN.MaxLength = 13;
        _txtBoxISBN.Name = "_txtBoxISBN";
        _txtBoxISBN.Size = new Size(132, 23);
        _txtBoxISBN.TabIndex = 9;
        _txtBoxISBN.TextChanged += _txtBoxISBN_TextChanged;
        // 
        // ReturnBookForm
        // 
        AcceptButton = _btnReturn;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = _btnCancel;
        ClientSize = new Size(806, 485);
        Controls.Add(_lblISBN);
        Controls.Add(_txtBoxISBN);
        Controls.Add(_btnCancel);
        Controls.Add(_btnReturn);
        Controls.Add(_dataGridBorrows);
        Controls.Add(_lblSearch);
        Controls.Add(_txtBoxSearch);
        Controls.Add(_lblWaning);
        Controls.Add(_lblNumber);
        Controls.Add(_txtBoxNumber);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "ReturnBookForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Text = "Kitap İade";
        WindowState = FormWindowState.Maximized;
        Load += ReturnBookForm_Load;
        ((System.ComponentModel.ISupportInitialize)_txtBoxNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).EndInit();
        ((System.ComponentModel.ISupportInitialize)_dataGridBorrows).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxISBN).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxNumber;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblNumber;
    private Label _lblWaning;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxSearch;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblSearch;
    private Syncfusion.WinForms.DataGrid.SfDataGrid _dataGridBorrows;
    private Syncfusion.WinForms.Controls.SfButton _btnReturn;
    private Syncfusion.WinForms.Controls.SfButton _btnCancel;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblISBN;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxISBN;
}