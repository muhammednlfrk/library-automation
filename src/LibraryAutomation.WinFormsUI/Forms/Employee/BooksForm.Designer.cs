namespace LibraryAutomation.WinFormsUI.Forms.Employee;

partial class BooksForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
        _btnUpdate = new Syncfusion.WinForms.Controls.SfButton();
        _btnDelete = new Syncfusion.WinForms.Controls.SfButton();
        _btnAdd = new Syncfusion.WinForms.Controls.SfButton();
        _dataGridBooks = new Syncfusion.WinForms.DataGrid.SfDataGrid();
        _lblSearch = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        ((System.ComponentModel.ISupportInitialize)_dataGridBooks).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).BeginInit();
        SuspendLayout();
        // 
        // _btnUpdate
        // 
        _btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _btnUpdate.Enabled = false;
        _btnUpdate.Font = new Font("Segoe UI Semibold", 9F);
        _btnUpdate.ImageSize = new Size(16, 16);
        _btnUpdate.Location = new Point(683, 17);
        _btnUpdate.Name = "_btnUpdate";
        _btnUpdate.Size = new Size(28, 28);
        _btnUpdate.Style.Image = Properties.Resources.edit;
        _btnUpdate.TabIndex = 43;
        _btnUpdate.Click += _btnUpdate_Click;
        // 
        // _btnDelete
        // 
        _btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _btnDelete.Enabled = false;
        _btnDelete.Font = new Font("Segoe UI Semibold", 9F);
        _btnDelete.ImageSize = new Size(16, 16);
        _btnDelete.Location = new Point(717, 17);
        _btnDelete.Name = "_btnDelete";
        _btnDelete.Size = new Size(28, 28);
        _btnDelete.Style.Image = Properties.Resources.unavailable;
        _btnDelete.TabIndex = 42;
        _btnDelete.Click += _btnDelete_Click;
        // 
        // _btnAdd
        // 
        _btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _btnAdd.Font = new Font("Segoe UI Semibold", 9F);
        _btnAdd.ImageSize = new Size(16, 16);
        _btnAdd.Location = new Point(751, 17);
        _btnAdd.Name = "_btnAdd";
        _btnAdd.Size = new Size(28, 28);
        _btnAdd.Style.Image = Properties.Resources.add;
        _btnAdd.TabIndex = 41;
        _btnAdd.Click += _btnAdd_Click;
        // 
        // _dataGridBooks
        // 
        _dataGridBooks.AccessibleName = "Table";
        _dataGridBooks.AllowEditing = false;
        _dataGridBooks.AllowFiltering = true;
        _dataGridBooks.AllowResizingColumns = true;
        _dataGridBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _dataGridBooks.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
        _dataGridBooks.Location = new Point(5, 51);
        _dataGridBooks.Name = "_dataGridBooks";
        _dataGridBooks.Size = new Size(774, 406);
        _dataGridBooks.Style.BorderColor = Color.FromArgb(100, 100, 100);
        _dataGridBooks.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
        _dataGridBooks.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridBooks.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridBooks.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
        _dataGridBooks.TabIndex = 40;
        _dataGridBooks.Text = "sfDataGrid1";
        _dataGridBooks.SelectionChanged += _dataGridBooks_SelectionChanged;
        // 
        // _lblSearch
        // 
        _lblSearch.DY = -19;
        _lblSearch.LabeledControl = _txtBoxSearch;
        _lblSearch.Location = new Point(5, 3);
        _lblSearch.Name = "_lblSearch";
        _lblSearch.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblSearch.Size = new Size(28, 15);
        _lblSearch.TabIndex = 39;
        _lblSearch.Text = "Ara:";
        // 
        // _txtBoxSearch
        // 
        _txtBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxSearch.BeforeTouchSize = new Size(672, 23);
        _txtBoxSearch.Location = new Point(5, 22);
        _txtBoxSearch.Name = "_txtBoxSearch";
        _txtBoxSearch.Size = new Size(672, 23);
        _txtBoxSearch.TabIndex = 38;
        _txtBoxSearch.TextChanged += _txtBoxSearch_TextChanged;
        // 
        // BooksForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 461);
        Controls.Add(_dataGridBooks);
        Controls.Add(_btnUpdate);
        Controls.Add(_btnDelete);
        Controls.Add(_btnAdd);
        Controls.Add(_lblSearch);
        Controls.Add(_txtBoxSearch);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "BooksForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Text = "Kitaplar";
        Load += BooksForm_Load;
        ((System.ComponentModel.ISupportInitialize)_dataGridBooks).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Syncfusion.WinForms.Controls.SfButton _btnUpdate;
    private Syncfusion.WinForms.Controls.SfButton _btnDelete;
    private Syncfusion.WinForms.Controls.SfButton _btnAdd;
    private Syncfusion.WinForms.DataGrid.SfDataGrid _dataGridBooks;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblSearch;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxSearch;
}