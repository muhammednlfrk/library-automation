namespace LibraryAutomation.WinFormsUI.Forms.Employee;

partial class PublishersForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublishersForm));
        _dataGridPublishers = new Syncfusion.WinForms.DataGrid.SfDataGrid();
        _lblSearch = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _btnDelete = new Syncfusion.WinForms.Controls.SfButton();
        _btnAdd = new Syncfusion.WinForms.Controls.SfButton();
        _btnUpdate = new Syncfusion.WinForms.Controls.SfButton();
        ((System.ComponentModel.ISupportInitialize)_dataGridPublishers).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).BeginInit();
        SuspendLayout();
        // 
        // _dataGridPublishers
        // 
        _dataGridPublishers.AccessibleName = "Table";
        _dataGridPublishers.AllowEditing = false;
        _dataGridPublishers.AllowFiltering = true;
        _dataGridPublishers.AllowResizingColumns = true;
        _dataGridPublishers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _dataGridPublishers.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
        _dataGridPublishers.Location = new Point(5, 50);
        _dataGridPublishers.Name = "_dataGridPublishers";
        _dataGridPublishers.Size = new Size(574, 306);
        _dataGridPublishers.Style.BorderColor = Color.FromArgb(100, 100, 100);
        _dataGridPublishers.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
        _dataGridPublishers.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridPublishers.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
        _dataGridPublishers.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
        _dataGridPublishers.TabIndex = 19;
        _dataGridPublishers.Text = "sfDataGrid1";
        _dataGridPublishers.SelectionChanged += _dataGridPublishers_SelectionChanged;
        // 
        // _lblSearch
        // 
        _lblSearch.DY = -19;
        _lblSearch.LabeledControl = _txtBoxSearch;
        _lblSearch.Location = new Point(5, 2);
        _lblSearch.Name = "_lblSearch";
        _lblSearch.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblSearch.Size = new Size(28, 15);
        _lblSearch.TabIndex = 18;
        _lblSearch.Text = "Ara:";
        // 
        // _txtBoxSearch
        // 
        _txtBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxSearch.BeforeTouchSize = new Size(472, 23);
        _txtBoxSearch.Location = new Point(5, 21);
        _txtBoxSearch.Name = "_txtBoxSearch";
        _txtBoxSearch.Size = new Size(472, 23);
        _txtBoxSearch.TabIndex = 17;
        _txtBoxSearch.TextChanged += _txtBoxSearch_TextChanged;
        // 
        // _btnDelete
        // 
        _btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _btnDelete.Enabled = false;
        _btnDelete.Font = new Font("Segoe UI Semibold", 9F);
        _btnDelete.ImageSize = new Size(16, 16);
        _btnDelete.Location = new Point(517, 16);
        _btnDelete.Name = "_btnDelete";
        _btnDelete.Size = new Size(28, 28);
        _btnDelete.Style.Image = Properties.Resources.unavailable;
        _btnDelete.TabIndex = 30;
        // 
        // _btnAdd
        // 
        _btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _btnAdd.Font = new Font("Segoe UI Semibold", 9F);
        _btnAdd.ImageSize = new Size(16, 16);
        _btnAdd.Location = new Point(551, 16);
        _btnAdd.Name = "_btnAdd";
        _btnAdd.Size = new Size(28, 28);
        _btnAdd.Style.Image = Properties.Resources.add;
        _btnAdd.TabIndex = 29;
        _btnAdd.Click += _btnAdd_Click;
        // 
        // _btnUpdate
        // 
        _btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _btnUpdate.Enabled = false;
        _btnUpdate.Font = new Font("Segoe UI Semibold", 9F);
        _btnUpdate.ImageSize = new Size(16, 16);
        _btnUpdate.Location = new Point(483, 16);
        _btnUpdate.Name = "_btnUpdate";
        _btnUpdate.Size = new Size(28, 28);
        _btnUpdate.Style.Image = Properties.Resources.edit;
        _btnUpdate.TabIndex = 31;
        // 
        // PublishersForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(584, 361);
        Controls.Add(_btnUpdate);
        Controls.Add(_btnDelete);
        Controls.Add(_btnAdd);
        Controls.Add(_dataGridPublishers);
        Controls.Add(_lblSearch);
        Controls.Add(_txtBoxSearch);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "PublishersForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Text = "Yayın Evleri";
        ((System.ComponentModel.ISupportInitialize)_dataGridPublishers).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSearch).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Syncfusion.WinForms.DataGrid.SfDataGrid _dataGridPublishers;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblSearch;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxSearch;
    private Syncfusion.WinForms.Controls.SfButton _btnDelete;
    private Syncfusion.WinForms.Controls.SfButton _btnAdd;
    private Syncfusion.WinForms.Controls.SfButton _btnUpdate;
}