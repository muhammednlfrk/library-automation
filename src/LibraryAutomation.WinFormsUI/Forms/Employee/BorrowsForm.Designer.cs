namespace LibraryAutomation.WinFormsUI.Forms.Employee;

partial class BorrowsForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowsForm));
        _lblISBN = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxISBN = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _dataGridBorrows = new Syncfusion.WinForms.DataGrid.SfDataGrid();
        _lblSearch = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        ((System.ComponentModel.ISupportInitialize)_txtBoxISBN).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_dataGridBorrows).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxNumber).BeginInit();
        SuspendLayout();
        // 
        // _lblISBN
        // 
        _lblISBN.DY = -19;
        _lblISBN.LabeledControl = _txtBoxISBN;
        _lblISBN.Location = new Point(663, 1);
        _lblISBN.Name = "_lblISBN";
        _lblISBN.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblISBN.Size = new Size(35, 15);
        _lblISBN.TabIndex = 18;
        _lblISBN.Text = "ISBN:";
        // 
        // _txtBoxISBN
        // 
        _txtBoxISBN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxISBN.BeforeTouchSize = new Size(196, 23);
        _txtBoxISBN.Location = new Point(663, 20);
        _txtBoxISBN.MaxLength = 13;
        _txtBoxISBN.Name = "_txtBoxISBN";
        _txtBoxISBN.Size = new Size(132, 23);
        _txtBoxISBN.TabIndex = 17;
        _txtBoxISBN.TextChanged += _txtBoxISBN_TextChanged;
        // 
        // _dataGridBorrows
        // 
        _dataGridBorrows.AccessibleName = "Table";
        _dataGridBorrows.AllowEditing = false;
        _dataGridBorrows.AllowFiltering = true;
        _dataGridBorrows.AllowResizingColumns = true;
        _dataGridBorrows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _dataGridBorrows.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
        _dataGridBorrows.Location = new Point(5, 49);
        _dataGridBorrows.Name = "_dataGridBorrows";
        _dataGridBorrows.Size = new Size(790, 396);
        _dataGridBorrows.Style.BorderColor = Color.FromArgb(100, 100, 100);
        _dataGridBorrows.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
        _dataGridBorrows.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridBorrows.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridBorrows.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
        _dataGridBorrows.TabIndex = 16;
        _dataGridBorrows.Text = "sfDataGrid1";
        // 
        // _lblSearch
        // 
        _lblSearch.DY = -19;
        _lblSearch.LabeledControl = _txtBoxSearch;
        _lblSearch.Location = new Point(5, 1);
        _lblSearch.Name = "_lblSearch";
        _lblSearch.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblSearch.Size = new Size(28, 15);
        _lblSearch.TabIndex = 15;
        _lblSearch.Text = "Ara:";
        // 
        // _txtBoxSearch
        // 
        _txtBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxSearch.BeforeTouchSize = new Size(196, 23);
        _txtBoxSearch.Location = new Point(5, 20);
        _txtBoxSearch.Name = "_txtBoxSearch";
        _txtBoxSearch.Size = new Size(450, 23);
        _txtBoxSearch.TabIndex = 12;
        _txtBoxSearch.TextChanged += _txtBoxSearch_TextChanged;
        // 
        // _lblNumber
        // 
        _lblNumber.DY = -19;
        _lblNumber.LabeledControl = _txtBoxNumber;
        _lblNumber.Location = new Point(461, 1);
        _lblNumber.Name = "_lblNumber";
        _lblNumber.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblNumber.Size = new Size(84, 15);
        _lblNumber.TabIndex = 13;
        _lblNumber.Text = "Üye Numarası:";
        // 
        // _txtBoxNumber
        // 
        _txtBoxNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _txtBoxNumber.BeforeTouchSize = new Size(196, 23);
        _txtBoxNumber.Location = new Point(461, 20);
        _txtBoxNumber.MaxLength = 9;
        _txtBoxNumber.Name = "_txtBoxNumber";
        _txtBoxNumber.Size = new Size(196, 23);
        _txtBoxNumber.TabIndex = 11;
        _txtBoxNumber.WordWrap = false;
        _txtBoxNumber.TextChanged += _txtBoxNumber_TextChanged;
        // 
        // BorrowsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(_lblISBN);
        Controls.Add(_txtBoxISBN);
        Controls.Add(_dataGridBorrows);
        Controls.Add(_lblSearch);
        Controls.Add(_txtBoxSearch);
        Controls.Add(_lblNumber);
        Controls.Add(_txtBoxNumber);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "BorrowsForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Text = "Ödünç Almalar";
        ((System.ComponentModel.ISupportInitialize)_txtBoxISBN).EndInit();
        ((System.ComponentModel.ISupportInitialize)_dataGridBorrows).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxNumber).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblISBN;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxISBN;
    private Syncfusion.WinForms.DataGrid.SfDataGrid _dataGridBorrows;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblSearch;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxSearch;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblNumber;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxNumber;
}