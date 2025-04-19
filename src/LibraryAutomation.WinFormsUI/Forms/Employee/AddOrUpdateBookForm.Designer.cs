namespace LibraryAutomation.WinFormsUI.Forms.Employee;

partial class AddOrUpdateBookForm
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
        Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
        Syncfusion.Windows.Forms.MetroColorTable metroColorTable2 = new Syncfusion.Windows.Forms.MetroColorTable();
        Syncfusion.Windows.Forms.MetroColorTable metroColorTable3 = new Syncfusion.Windows.Forms.MetroColorTable();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateBookForm));
        _btnCancel = new Syncfusion.WinForms.Controls.SfButton();
        _btnSave = new Syncfusion.WinForms.Controls.SfButton();
        _lblUsername = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblOriginName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxOriginName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _cmbBoxWriter = new Syncfusion.Windows.Forms.Tools.MultiColumnComboBox();
        _lblWriter = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _lblTranslator = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _cmbBoxTranslators = new Syncfusion.Windows.Forms.Tools.MultiColumnComboBox();
        _lblPublisher = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _cmbBoxPublisher = new Syncfusion.Windows.Forms.Tools.MultiColumnComboBox();
        _dateEditPublishDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
        _lblPublishDate = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _lnlISBN = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxISBN = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        integerTextBox1 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
        _lblStockQuantity = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        ((System.ComponentModel.ISupportInitialize)_txtBoxName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxOriginName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxWriter).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxTranslators).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxPublisher).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxISBN).BeginInit();
        ((System.ComponentModel.ISupportInitialize)integerTextBox1).BeginInit();
        SuspendLayout();
        // 
        // _btnCancel
        // 
        _btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnCancel.Font = new Font("Segoe UI Semibold", 9F);
        _btnCancel.Location = new Point(163, 366);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new Size(96, 28);
        _btnCancel.TabIndex = 6;
        _btnCancel.Text = "&İptal";
        // 
        // _btnSave
        // 
        _btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnSave.Font = new Font("Segoe UI Semibold", 9F);
        _btnSave.Location = new Point(265, 366);
        _btnSave.Name = "_btnSave";
        _btnSave.Size = new Size(96, 28);
        _btnSave.TabIndex = 7;
        _btnSave.Text = "&Kaydet";
        // 
        // _lblUsername
        // 
        _lblUsername.DY = -19;
        _lblUsername.LabeledControl = _txtBoxName;
        _lblUsername.Location = new Point(5, 47);
        _lblUsername.Name = "_lblUsername";
        _lblUsername.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblUsername.Size = new Size(28, 15);
        _lblUsername.TabIndex = 9;
        _lblUsername.Text = "Adı:";
        // 
        // _txtBoxName
        // 
        _txtBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxName.BeforeTouchSize = new Size(353, 23);
        _txtBoxName.Location = new Point(5, 66);
        _txtBoxName.Name = "_txtBoxName";
        _txtBoxName.Size = new Size(356, 23);
        _txtBoxName.TabIndex = 1;
        // 
        // _lblOriginName
        // 
        _lblOriginName.DY = -19;
        _lblOriginName.LabeledControl = _txtBoxOriginName;
        _lblOriginName.Location = new Point(5, 92);
        _lblOriginName.Name = "_lblOriginName";
        _lblOriginName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblOriginName.Size = new Size(66, 15);
        _lblOriginName.TabIndex = 11;
        _lblOriginName.Text = "Özgün Adı:";
        // 
        // _txtBoxOriginName
        // 
        _txtBoxOriginName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxOriginName.BeforeTouchSize = new Size(353, 23);
        _txtBoxOriginName.Location = new Point(5, 111);
        _txtBoxOriginName.Name = "_txtBoxOriginName";
        _txtBoxOriginName.Size = new Size(356, 23);
        _txtBoxOriginName.TabIndex = 2;
        // 
        // _cmbBoxWriter
        // 
        _cmbBoxWriter.AllowFiltering = false;
        _cmbBoxWriter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _cmbBoxWriter.Filter = null;
        _cmbBoxWriter.Location = new Point(5, 156);
        _cmbBoxWriter.MetroColor = Color.FromArgb(22, 165, 220);
        _cmbBoxWriter.MultiColumn = false;
        _cmbBoxWriter.Name = "_cmbBoxWriter";
        _cmbBoxWriter.ScrollMetroColorTable = metroColorTable1;
        _cmbBoxWriter.SelectedIndex = -1;
        _cmbBoxWriter.ShowColumnHeader = false;
        _cmbBoxWriter.Size = new Size(356, 23);
        _cmbBoxWriter.Sorted = true;
        _cmbBoxWriter.TabIndex = 3;
        _cmbBoxWriter.ThemeName = "LibraryTheme";
        // 
        // _lblWriter
        // 
        _lblWriter.DY = -19;
        _lblWriter.LabeledControl = _cmbBoxWriter;
        _lblWriter.Location = new Point(5, 137);
        _lblWriter.Name = "_lblWriter";
        _lblWriter.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblWriter.Size = new Size(37, 15);
        _lblWriter.TabIndex = 13;
        _lblWriter.Text = "Yazar:";
        // 
        // _lblTranslator
        // 
        _lblTranslator.DY = -19;
        _lblTranslator.LabeledControl = _cmbBoxTranslators;
        _lblTranslator.Location = new Point(5, 180);
        _lblTranslator.Name = "_lblTranslator";
        _lblTranslator.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblTranslator.Size = new Size(61, 15);
        _lblTranslator.TabIndex = 15;
        _lblTranslator.Text = "Çevirmen:";
        // 
        // _cmbBoxTranslators
        // 
        _cmbBoxTranslators.AllowFiltering = false;
        _cmbBoxTranslators.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _cmbBoxTranslators.Filter = null;
        _cmbBoxTranslators.Location = new Point(5, 199);
        _cmbBoxTranslators.MetroColor = Color.FromArgb(22, 165, 220);
        _cmbBoxTranslators.MultiColumn = false;
        _cmbBoxTranslators.Name = "_cmbBoxTranslators";
        _cmbBoxTranslators.ScrollMetroColorTable = metroColorTable2;
        _cmbBoxTranslators.SelectedIndex = -1;
        _cmbBoxTranslators.ShowColumnHeader = false;
        _cmbBoxTranslators.Size = new Size(356, 23);
        _cmbBoxTranslators.Sorted = true;
        _cmbBoxTranslators.TabIndex = 4;
        _cmbBoxTranslators.ThemeName = "LibraryTheme";
        // 
        // _lblPublisher
        // 
        _lblPublisher.DY = -19;
        _lblPublisher.LabeledControl = _cmbBoxPublisher;
        _lblPublisher.Location = new Point(5, 223);
        _lblPublisher.Name = "_lblPublisher";
        _lblPublisher.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblPublisher.Size = new Size(53, 15);
        _lblPublisher.TabIndex = 17;
        _lblPublisher.Text = "Yayınevi:";
        // 
        // _cmbBoxPublisher
        // 
        _cmbBoxPublisher.AllowFiltering = false;
        _cmbBoxPublisher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _cmbBoxPublisher.Filter = null;
        _cmbBoxPublisher.Location = new Point(5, 242);
        _cmbBoxPublisher.MetroColor = Color.FromArgb(22, 165, 220);
        _cmbBoxPublisher.MultiColumn = false;
        _cmbBoxPublisher.Name = "_cmbBoxPublisher";
        _cmbBoxPublisher.ScrollMetroColorTable = metroColorTable3;
        _cmbBoxPublisher.SelectedIndex = -1;
        _cmbBoxPublisher.ShowColumnHeader = false;
        _cmbBoxPublisher.Size = new Size(356, 23);
        _cmbBoxPublisher.Sorted = true;
        _cmbBoxPublisher.TabIndex = 5;
        _cmbBoxPublisher.ThemeName = "LibraryTheme";
        // 
        // _dateEditPublishDate
        // 
        _dateEditPublishDate.AllowNull = true;
        _dateEditPublishDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _dateEditPublishDate.DateTimeIcon = null;
        _dateEditPublishDate.Location = new Point(5, 285);
        _dateEditPublishDate.Name = "_dateEditPublishDate";
        _dateEditPublishDate.Size = new Size(356, 23);
        _dateEditPublishDate.TabIndex = 6;
        _dateEditPublishDate.ToolTipText = "";
        _dateEditPublishDate.Value = null;
        _dateEditPublishDate.Watermark = "Tarih seçin";
        // 
        // _lblPublishDate
        // 
        _lblPublishDate.DY = -19;
        _lblPublishDate.LabeledControl = _dateEditPublishDate;
        _lblPublishDate.Location = new Point(5, 266);
        _lblPublishDate.Name = "_lblPublishDate";
        _lblPublishDate.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblPublishDate.Size = new Size(70, 15);
        _lblPublishDate.TabIndex = 19;
        _lblPublishDate.Text = "Yayın Tarihi:";
        // 
        // _lnlISBN
        // 
        _lnlISBN.DY = -19;
        _lnlISBN.LabeledControl = _txtBoxISBN;
        _lnlISBN.Location = new Point(5, 2);
        _lnlISBN.Name = "_lnlISBN";
        _lnlISBN.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lnlISBN.Size = new Size(35, 15);
        _lnlISBN.TabIndex = 21;
        _lnlISBN.Text = "ISBN:";
        // 
        // _txtBoxISBN
        // 
        _txtBoxISBN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxISBN.BeforeTouchSize = new Size(353, 23);
        _txtBoxISBN.Location = new Point(5, 21);
        _txtBoxISBN.MaxLength = 13;
        _txtBoxISBN.Name = "_txtBoxISBN";
        _txtBoxISBN.Size = new Size(356, 23);
        _txtBoxISBN.TabIndex = 0;
        // 
        // integerTextBox1
        // 
        integerTextBox1.AccessibilityEnabled = true;
        integerTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        integerTextBox1.BeforeTouchSize = new Size(353, 23);
        integerTextBox1.IntegerValue = 1L;
        integerTextBox1.Location = new Point(8, 330);
        integerTextBox1.Name = "integerTextBox1";
        integerTextBox1.Size = new Size(353, 23);
        integerTextBox1.TabIndex = 7;
        integerTextBox1.Text = "1";
        // 
        // _lblStockQuantity
        // 
        _lblStockQuantity.DY = -19;
        _lblStockQuantity.LabeledControl = integerTextBox1;
        _lblStockQuantity.Location = new Point(8, 311);
        _lblStockQuantity.Name = "_lblStockQuantity";
        _lblStockQuantity.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblStockQuantity.Size = new Size(67, 15);
        _lblStockQuantity.TabIndex = 23;
        _lblStockQuantity.Text = "Stok Adedi:";
        // 
        // AddOrUpdateBookForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(366, 399);
        Controls.Add(_lblStockQuantity);
        Controls.Add(integerTextBox1);
        Controls.Add(_lnlISBN);
        Controls.Add(_txtBoxISBN);
        Controls.Add(_lblPublishDate);
        Controls.Add(_dateEditPublishDate);
        Controls.Add(_lblPublisher);
        Controls.Add(_cmbBoxPublisher);
        Controls.Add(_lblTranslator);
        Controls.Add(_cmbBoxTranslators);
        Controls.Add(_lblWriter);
        Controls.Add(_cmbBoxWriter);
        Controls.Add(_lblOriginName);
        Controls.Add(_txtBoxOriginName);
        Controls.Add(_lblUsername);
        Controls.Add(_txtBoxName);
        Controls.Add(_btnCancel);
        Controls.Add(_btnSave);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(382, 438);
        MinimizeBox = false;
        MinimumSize = new Size(382, 438);
        Name = "AddOrUpdateBookForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        ((System.ComponentModel.ISupportInitialize)_txtBoxName).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxOriginName).EndInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxWriter).EndInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxTranslators).EndInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxPublisher).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxISBN).EndInit();
        ((System.ComponentModel.ISupportInitialize)integerTextBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Syncfusion.WinForms.Controls.SfButton _btnCancel;
    private Syncfusion.WinForms.Controls.SfButton _btnSave;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblUsername;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxName;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblOriginName;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxOriginName;
    private Syncfusion.Windows.Forms.Tools.MultiColumnComboBox _cmbBoxWriter;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblWriter;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblTranslator;
    private Syncfusion.Windows.Forms.Tools.MultiColumnComboBox _cmbBoxTranslators;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblPublisher;
    private Syncfusion.Windows.Forms.Tools.MultiColumnComboBox _cmbBoxPublisher;
    private Syncfusion.WinForms.Input.SfDateTimeEdit _dateEditPublishDate;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblPublishDate;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lnlISBN;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxISBN;
    private Syncfusion.Windows.Forms.Tools.IntegerTextBox integerTextBox1;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblStockQuantity;
}