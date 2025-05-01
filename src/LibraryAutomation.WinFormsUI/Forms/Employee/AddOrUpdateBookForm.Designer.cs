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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateBookForm));
        _btnCancel = new Syncfusion.WinForms.Controls.SfButton();
        _btnSave = new Syncfusion.WinForms.Controls.SfButton();
        _lblUsername = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblOriginName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxOriginName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _dateEditPublishDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
        _lblPublishDate = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _lnlISBN = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxISBN = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _txtBoxStockCount = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
        _lblStockQuantity = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _cmbBoxWriters = new Syncfusion.WinForms.ListView.SfComboBox();
        _lblWriter = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _lblTranslators = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _cmbBoxTranslators = new Syncfusion.WinForms.ListView.SfComboBox();
        _lblPageCount = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxPageCount = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
        _lblLanguage = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _cmbBoxLanguage = new Syncfusion.WinForms.ListView.SfComboBox();
        _lblOriginalLanguage = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _cmbBoxOriginalLanguage = new Syncfusion.WinForms.ListView.SfComboBox();
        _lblShelfs = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _cmbBoxShelf = new Syncfusion.WinForms.ListView.SfComboBox();
        _lblPublisher = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _cmbBoxPublisher = new Syncfusion.WinForms.ListView.SfComboBox();
        _picBoxBook = new PictureBox();
        _imageFileSelector = new OpenFileDialog();
        _btnSelectFile = new Syncfusion.WinForms.Controls.SfButton();
        ((System.ComponentModel.ISupportInitialize)_txtBoxName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxOriginName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxISBN).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxStockCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxWriters).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxTranslators).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPageCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxLanguage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxOriginalLanguage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxShelf).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxPublisher).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_picBoxBook).BeginInit();
        SuspendLayout();
        // 
        // _btnCancel
        // 
        _btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnCancel.Font = new Font("Segoe UI Semibold", 9F);
        _btnCancel.Location = new Point(201, 798);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new Size(96, 28);
        _btnCancel.TabIndex = 6;
        _btnCancel.Text = "&İptal";
        // 
        // _btnSave
        // 
        _btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnSave.Font = new Font("Segoe UI Semibold", 9F);
        _btnSave.Location = new Point(303, 798);
        _btnSave.Name = "_btnSave";
        _btnSave.Size = new Size(96, 28);
        _btnSave.TabIndex = 7;
        _btnSave.Text = "&Kaydet";
        _btnSave.Click += _btnSave_Click;
        // 
        // _lblUsername
        // 
        _lblUsername.DY = -19;
        _lblUsername.LabeledControl = _txtBoxName;
        _lblUsername.Location = new Point(5, 297);
        _lblUsername.Name = "_lblUsername";
        _lblUsername.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblUsername.Size = new Size(28, 15);
        _lblUsername.TabIndex = 9;
        _lblUsername.Text = "Adı:";
        // 
        // _txtBoxName
        // 
        _txtBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxName.BeforeTouchSize = new Size(394, 23);
        _txtBoxName.Location = new Point(5, 316);
        _txtBoxName.Name = "_txtBoxName";
        _txtBoxName.Size = new Size(394, 23);
        _txtBoxName.TabIndex = 1;
        // 
        // _lblOriginName
        // 
        _lblOriginName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _lblOriginName.DY = -19;
        _lblOriginName.LabeledControl = _txtBoxOriginName;
        _lblOriginName.Location = new Point(5, 341);
        _lblOriginName.Name = "_lblOriginName";
        _lblOriginName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblOriginName.Size = new Size(66, 15);
        _lblOriginName.TabIndex = 11;
        _lblOriginName.Text = "Özgün Adı:";
        // 
        // _txtBoxOriginName
        // 
        _txtBoxOriginName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxOriginName.BeforeTouchSize = new Size(394, 23);
        _txtBoxOriginName.Location = new Point(5, 360);
        _txtBoxOriginName.Name = "_txtBoxOriginName";
        _txtBoxOriginName.Size = new Size(394, 23);
        _txtBoxOriginName.TabIndex = 2;
        // 
        // _dateEditPublishDate
        // 
        _dateEditPublishDate.AllowNull = true;
        _dateEditPublishDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _dateEditPublishDate.DateTimeIcon = null;
        _dateEditPublishDate.Location = new Point(5, 540);
        _dateEditPublishDate.Name = "_dateEditPublishDate";
        _dateEditPublishDate.Size = new Size(394, 23);
        _dateEditPublishDate.TabIndex = 6;
        _dateEditPublishDate.ToolTipText = "";
        _dateEditPublishDate.Value = null;
        _dateEditPublishDate.Watermark = "Tarih seçin";
        // 
        // _lblPublishDate
        // 
        _lblPublishDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _lblPublishDate.DY = -19;
        _lblPublishDate.LabeledControl = _dateEditPublishDate;
        _lblPublishDate.Location = new Point(5, 521);
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
        _lnlISBN.Location = new Point(5, 252);
        _lnlISBN.Name = "_lnlISBN";
        _lnlISBN.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lnlISBN.Size = new Size(35, 15);
        _lnlISBN.TabIndex = 21;
        _lnlISBN.Text = "ISBN:";
        // 
        // _txtBoxISBN
        // 
        _txtBoxISBN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxISBN.BeforeTouchSize = new Size(394, 23);
        _txtBoxISBN.Location = new Point(5, 271);
        _txtBoxISBN.MaxLength = 13;
        _txtBoxISBN.Name = "_txtBoxISBN";
        _txtBoxISBN.Size = new Size(394, 23);
        _txtBoxISBN.TabIndex = 0;
        // 
        // _txtBoxStockCount
        // 
        _txtBoxStockCount.AccessibilityEnabled = true;
        _txtBoxStockCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxStockCount.BeforeTouchSize = new Size(394, 23);
        _txtBoxStockCount.IntegerValue = 1L;
        _txtBoxStockCount.Location = new Point(5, 585);
        _txtBoxStockCount.Name = "_txtBoxStockCount";
        _txtBoxStockCount.Size = new Size(394, 23);
        _txtBoxStockCount.TabIndex = 7;
        _txtBoxStockCount.Text = "1";
        // 
        // _lblStockQuantity
        // 
        _lblStockQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _lblStockQuantity.DY = -19;
        _lblStockQuantity.LabeledControl = _txtBoxStockCount;
        _lblStockQuantity.Location = new Point(5, 566);
        _lblStockQuantity.Name = "_lblStockQuantity";
        _lblStockQuantity.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblStockQuantity.Size = new Size(67, 15);
        _lblStockQuantity.TabIndex = 23;
        _lblStockQuantity.Text = "Stok Adedi:";
        // 
        // _cmbBoxWriters
        // 
        _cmbBoxWriters.AllowNull = true;
        _cmbBoxWriters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _cmbBoxWriters.AutoCompleteMode = AutoCompleteMode.Suggest;
        _cmbBoxWriters.AutoCompleteSuggestDelay = 200;
        _cmbBoxWriters.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
        _cmbBoxWriters.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.MultiSelection;
        _cmbBoxWriters.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
        _cmbBoxWriters.EnableToken = true;
        _cmbBoxWriters.Location = new Point(5, 405);
        _cmbBoxWriters.Name = "_cmbBoxWriters";
        _cmbBoxWriters.Size = new Size(394, 23);
        _cmbBoxWriters.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
        _cmbBoxWriters.TabIndex = 24;
        _cmbBoxWriters.TabStop = false;
        _cmbBoxWriters.Text = "Yazar seçiniz";
        _cmbBoxWriters.ThemeName = "LibraryTheme";
        _cmbBoxWriters.Watermark = "Yazar seçiniz";
        // 
        // _lblWriter
        // 
        _lblWriter.DY = -19;
        _lblWriter.LabeledControl = _cmbBoxWriters;
        _lblWriter.Location = new Point(5, 386);
        _lblWriter.Name = "_lblWriter";
        _lblWriter.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblWriter.Size = new Size(50, 15);
        _lblWriter.TabIndex = 25;
        _lblWriter.Text = "Yazarlar:";
        // 
        // _lblTranslators
        // 
        _lblTranslators.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _lblTranslators.DY = -19;
        _lblTranslators.LabeledControl = _cmbBoxTranslators;
        _lblTranslators.Location = new Point(5, 431);
        _lblTranslators.Name = "_lblTranslators";
        _lblTranslators.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblTranslators.Size = new Size(71, 15);
        _lblTranslators.TabIndex = 27;
        _lblTranslators.Text = "Çevirmenler";
        // 
        // _cmbBoxTranslators
        // 
        _cmbBoxTranslators.AllowNull = true;
        _cmbBoxTranslators.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _cmbBoxTranslators.AutoCompleteMode = AutoCompleteMode.Suggest;
        _cmbBoxTranslators.AutoCompleteSuggestDelay = 200;
        _cmbBoxTranslators.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
        _cmbBoxTranslators.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.MultiSelection;
        _cmbBoxTranslators.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
        _cmbBoxTranslators.EnableToken = true;
        _cmbBoxTranslators.Location = new Point(5, 450);
        _cmbBoxTranslators.Name = "_cmbBoxTranslators";
        _cmbBoxTranslators.Size = new Size(394, 23);
        _cmbBoxTranslators.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
        _cmbBoxTranslators.TabIndex = 26;
        _cmbBoxTranslators.TabStop = false;
        _cmbBoxTranslators.Text = "Çevirmen seçiniz";
        _cmbBoxTranslators.ThemeName = "LibraryTheme";
        _cmbBoxTranslators.Watermark = "Çevirmen seçiniz";
        // 
        // _lblPageCount
        // 
        _lblPageCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _lblPageCount.DY = -19;
        _lblPageCount.LabeledControl = _txtBoxPageCount;
        _lblPageCount.Location = new Point(5, 476);
        _lblPageCount.Name = "_lblPageCount";
        _lblPageCount.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblPageCount.Size = new Size(70, 15);
        _lblPageCount.TabIndex = 29;
        _lblPageCount.Text = "Sayfa Sayısı:";
        // 
        // _txtBoxPageCount
        // 
        _txtBoxPageCount.AccessibilityEnabled = true;
        _txtBoxPageCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxPageCount.BeforeTouchSize = new Size(394, 23);
        _txtBoxPageCount.IntegerValue = 1L;
        _txtBoxPageCount.Location = new Point(5, 495);
        _txtBoxPageCount.Name = "_txtBoxPageCount";
        _txtBoxPageCount.Size = new Size(394, 23);
        _txtBoxPageCount.TabIndex = 28;
        _txtBoxPageCount.Text = "1";
        // 
        // _lblLanguage
        // 
        _lblLanguage.DY = -19;
        _lblLanguage.LabeledControl = _cmbBoxLanguage;
        _lblLanguage.Location = new Point(5, 611);
        _lblLanguage.Name = "_lblLanguage";
        _lblLanguage.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblLanguage.Size = new Size(24, 15);
        _lblLanguage.TabIndex = 31;
        _lblLanguage.Text = "Dil:";
        // 
        // _cmbBoxLanguage
        // 
        _cmbBoxLanguage.AllowNull = true;
        _cmbBoxLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _cmbBoxLanguage.AutoCompleteMode = AutoCompleteMode.Suggest;
        _cmbBoxLanguage.AutoCompleteSuggestDelay = 200;
        _cmbBoxLanguage.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
        _cmbBoxLanguage.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
        _cmbBoxLanguage.Location = new Point(5, 630);
        _cmbBoxLanguage.Name = "_cmbBoxLanguage";
        _cmbBoxLanguage.Size = new Size(394, 23);
        _cmbBoxLanguage.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
        _cmbBoxLanguage.TabIndex = 30;
        _cmbBoxLanguage.TabStop = false;
        _cmbBoxLanguage.Text = "Dil seçiniz";
        _cmbBoxLanguage.ThemeName = "LibraryTheme";
        _cmbBoxLanguage.Watermark = "Dil seçiniz";
        // 
        // _lblOriginalLanguage
        // 
        _lblOriginalLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _lblOriginalLanguage.DY = -19;
        _lblOriginalLanguage.LabeledControl = _cmbBoxOriginalLanguage;
        _lblOriginalLanguage.Location = new Point(5, 656);
        _lblOriginalLanguage.Name = "_lblOriginalLanguage";
        _lblOriginalLanguage.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblOriginalLanguage.Size = new Size(65, 15);
        _lblOriginalLanguage.TabIndex = 33;
        _lblOriginalLanguage.Text = "Orijinal Dil:";
        // 
        // _cmbBoxOriginalLanguage
        // 
        _cmbBoxOriginalLanguage.AllowNull = true;
        _cmbBoxOriginalLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _cmbBoxOriginalLanguage.AutoCompleteMode = AutoCompleteMode.Suggest;
        _cmbBoxOriginalLanguage.AutoCompleteSuggestDelay = 200;
        _cmbBoxOriginalLanguage.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
        _cmbBoxOriginalLanguage.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
        _cmbBoxOriginalLanguage.Location = new Point(5, 675);
        _cmbBoxOriginalLanguage.Name = "_cmbBoxOriginalLanguage";
        _cmbBoxOriginalLanguage.Size = new Size(394, 23);
        _cmbBoxOriginalLanguage.Style.DropDownStyle.BorderColor = Color.FromArgb(100, 100, 100);
        _cmbBoxOriginalLanguage.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
        _cmbBoxOriginalLanguage.TabIndex = 32;
        _cmbBoxOriginalLanguage.TabStop = false;
        _cmbBoxOriginalLanguage.Text = "Dil seçiniz";
        _cmbBoxOriginalLanguage.ThemeName = "LibraryTheme";
        _cmbBoxOriginalLanguage.Watermark = "Dil seçiniz";
        // 
        // _lblShelfs
        // 
        _lblShelfs.DY = -19;
        _lblShelfs.LabeledControl = _cmbBoxShelf;
        _lblShelfs.Location = new Point(5, 701);
        _lblShelfs.Name = "_lblShelfs";
        _lblShelfs.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblShelfs.Size = new Size(27, 15);
        _lblShelfs.TabIndex = 35;
        _lblShelfs.Text = "Raf:";
        // 
        // _cmbBoxShelf
        // 
        _cmbBoxShelf.AllowNull = true;
        _cmbBoxShelf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _cmbBoxShelf.AutoCompleteMode = AutoCompleteMode.Suggest;
        _cmbBoxShelf.AutoCompleteSuggestDelay = 200;
        _cmbBoxShelf.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
        _cmbBoxShelf.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
        _cmbBoxShelf.Location = new Point(5, 720);
        _cmbBoxShelf.Name = "_cmbBoxShelf";
        _cmbBoxShelf.Size = new Size(394, 23);
        _cmbBoxShelf.Style.DropDownStyle.BorderColor = Color.FromArgb(100, 100, 100);
        _cmbBoxShelf.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
        _cmbBoxShelf.TabIndex = 34;
        _cmbBoxShelf.TabStop = false;
        _cmbBoxShelf.Text = "Raf seçiniz";
        _cmbBoxShelf.ThemeName = "LibraryTheme";
        _cmbBoxShelf.Watermark = "Raf seçiniz";
        // 
        // _lblPublisher
        // 
        _lblPublisher.DY = -19;
        _lblPublisher.LabeledControl = _cmbBoxPublisher;
        _lblPublisher.Location = new Point(5, 746);
        _lblPublisher.Name = "_lblPublisher";
        _lblPublisher.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblPublisher.Size = new Size(53, 15);
        _lblPublisher.TabIndex = 37;
        _lblPublisher.Text = "Yayınevi:";
        // 
        // _cmbBoxPublisher
        // 
        _cmbBoxPublisher.AllowNull = true;
        _cmbBoxPublisher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _cmbBoxPublisher.AutoCompleteMode = AutoCompleteMode.Suggest;
        _cmbBoxPublisher.AutoCompleteSuggestDelay = 200;
        _cmbBoxPublisher.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
        _cmbBoxPublisher.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
        _cmbBoxPublisher.Location = new Point(5, 765);
        _cmbBoxPublisher.Name = "_cmbBoxPublisher";
        _cmbBoxPublisher.Size = new Size(394, 23);
        _cmbBoxPublisher.Style.DropDownStyle.BorderColor = Color.FromArgb(100, 100, 100);
        _cmbBoxPublisher.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
        _cmbBoxPublisher.TabIndex = 36;
        _cmbBoxPublisher.TabStop = false;
        _cmbBoxPublisher.Text = "Yayınevi seçiniz";
        _cmbBoxPublisher.ThemeName = "LibraryTheme";
        _cmbBoxPublisher.Watermark = "Yayınevi seçiniz";
        // 
        // _picBoxBook
        // 
        _picBoxBook.Anchor = AnchorStyles.Top;
        _picBoxBook.BorderStyle = BorderStyle.FixedSingle;
        _picBoxBook.Location = new Point(138, 5);
        _picBoxBook.Name = "_picBoxBook";
        _picBoxBook.Size = new Size(128, 200);
        _picBoxBook.SizeMode = PictureBoxSizeMode.Zoom;
        _picBoxBook.TabIndex = 38;
        _picBoxBook.TabStop = false;
        _picBoxBook.Click += _picBoxBook_Click;
        // 
        // _imageFileSelector
        // 
        _imageFileSelector.FileName = "Fotograf sec";
        _imageFileSelector.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
        _imageFileSelector.Title = "Resim Dosyası Seç";
        // 
        // _btnSelectFile
        // 
        _btnSelectFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _btnSelectFile.Font = new Font("Segoe UI Semibold", 9F);
        _btnSelectFile.Location = new Point(138, 211);
        _btnSelectFile.Name = "_btnSelectFile";
        _btnSelectFile.Size = new Size(128, 23);
        _btnSelectFile.TabIndex = 39;
        _btnSelectFile.Text = "&Dosya Seç";
        _btnSelectFile.Click += _btnSelectFile_Click;
        // 
        // AddOrUpdateBookForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = _btnCancel;
        ClientSize = new Size(404, 831);
        Controls.Add(_btnSelectFile);
        Controls.Add(_picBoxBook);
        Controls.Add(_lblPublisher);
        Controls.Add(_cmbBoxPublisher);
        Controls.Add(_lblShelfs);
        Controls.Add(_cmbBoxShelf);
        Controls.Add(_lblOriginalLanguage);
        Controls.Add(_cmbBoxOriginalLanguage);
        Controls.Add(_lblLanguage);
        Controls.Add(_cmbBoxLanguage);
        Controls.Add(_lblPageCount);
        Controls.Add(_txtBoxPageCount);
        Controls.Add(_lblTranslators);
        Controls.Add(_cmbBoxTranslators);
        Controls.Add(_lblWriter);
        Controls.Add(_cmbBoxWriters);
        Controls.Add(_lblStockQuantity);
        Controls.Add(_txtBoxStockCount);
        Controls.Add(_lnlISBN);
        Controls.Add(_txtBoxISBN);
        Controls.Add(_lblPublishDate);
        Controls.Add(_dateEditPublishDate);
        Controls.Add(_lblOriginName);
        Controls.Add(_txtBoxOriginName);
        Controls.Add(_lblUsername);
        Controls.Add(_txtBoxName);
        Controls.Add(_btnCancel);
        Controls.Add(_btnSave);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(420, 870);
        MinimizeBox = false;
        MinimumSize = new Size(420, 870);
        Name = "AddOrUpdateBookForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        Load += AddOrUpdateBookForm_Load;
        ((System.ComponentModel.ISupportInitialize)_txtBoxName).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxOriginName).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxISBN).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxStockCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxWriters).EndInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxTranslators).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxPageCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxLanguage).EndInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxOriginalLanguage).EndInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxShelf).EndInit();
        ((System.ComponentModel.ISupportInitialize)_cmbBoxPublisher).EndInit();
        ((System.ComponentModel.ISupportInitialize)_picBoxBook).EndInit();
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
    private Syncfusion.WinForms.Input.SfDateTimeEdit _dateEditPublishDate;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblPublishDate;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lnlISBN;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxISBN;
    private Syncfusion.Windows.Forms.Tools.IntegerTextBox _txtBoxStockCount;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblStockQuantity;
    private Syncfusion.WinForms.ListView.SfComboBox _cmbBoxWriters;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblWriter;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblTranslators;
    private Syncfusion.WinForms.ListView.SfComboBox _cmbBoxTranslators;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblPageCount;
    private Syncfusion.Windows.Forms.Tools.IntegerTextBox _txtBoxPageCount;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblLanguage;
    private Syncfusion.WinForms.ListView.SfComboBox _cmbBoxLanguage;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblOriginalLanguage;
    private Syncfusion.WinForms.ListView.SfComboBox _cmbBoxOriginalLanguage;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblShelfs;
    private Syncfusion.WinForms.ListView.SfComboBox _cmbBoxShelf;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblPublisher;
    private Syncfusion.WinForms.ListView.SfComboBox _cmbBoxPublisher;
    private PictureBox _picBoxBook;
    private OpenFileDialog _imageFileSelector;
    private Syncfusion.WinForms.Controls.SfButton _btnSelectFile;
}