namespace LibraryAutomation.WinFormsUI.Forms.Employee;

partial class AddOrUpdateTranslatorOrWriterForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateTranslatorOrWriterForm));
        _btnCancel = new Syncfusion.WinForms.Controls.SfButton();
        _btnSave = new Syncfusion.WinForms.Controls.SfButton();
        _lblName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblSurname = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxSurname = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblBirthDate = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _dtEditBirthDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
        _lblDeathDate = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _dtEditDeathDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSurname).BeginInit();
        SuspendLayout();
        // 
        // _btnCancel
        // 
        _btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnCancel.Font = new Font("Segoe UI Semibold", 9F);
        _btnCancel.Location = new Point(131, 189);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new Size(96, 28);
        _btnCancel.TabIndex = 16;
        _btnCancel.Text = "&İptal";
        // 
        // _btnSave
        // 
        _btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnSave.Font = new Font("Segoe UI Semibold", 9F);
        _btnSave.Location = new Point(233, 189);
        _btnSave.Name = "_btnSave";
        _btnSave.Size = new Size(96, 28);
        _btnSave.TabIndex = 17;
        _btnSave.Text = "&Kaydet";
        // 
        // _lblName
        // 
        _lblName.DY = -19;
        _lblName.LabeledControl = _txtBoxName;
        _lblName.Location = new Point(5, 3);
        _lblName.Name = "_lblName";
        _lblName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblName.Size = new Size(28, 15);
        _lblName.TabIndex = 14;
        _lblName.Text = "Adı:";
        // 
        // _txtBoxName
        // 
        _txtBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxName.BeforeTouchSize = new Size(324, 23);
        _txtBoxName.Location = new Point(5, 22);
        _txtBoxName.Name = "_txtBoxName";
        _txtBoxName.Size = new Size(324, 23);
        _txtBoxName.TabIndex = 0;
        // 
        // _lblSurname
        // 
        _lblSurname.DY = -19;
        _lblSurname.LabeledControl = _txtBoxSurname;
        _lblSurname.Location = new Point(5, 48);
        _lblSurname.Name = "_lblSurname";
        _lblSurname.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblSurname.Size = new Size(45, 15);
        _lblSurname.TabIndex = 18;
        _lblSurname.Text = "Soyadı:";
        // 
        // _txtBoxSurname
        // 
        _txtBoxSurname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxSurname.BeforeTouchSize = new Size(324, 23);
        _txtBoxSurname.Location = new Point(5, 67);
        _txtBoxSurname.Name = "_txtBoxSurname";
        _txtBoxSurname.Size = new Size(324, 23);
        _txtBoxSurname.TabIndex = 1;
        // 
        // _lblBirthDate
        // 
        _lblBirthDate.DY = -19;
        _lblBirthDate.LabeledControl = _dtEditBirthDate;
        _lblBirthDate.Location = new Point(5, 93);
        _lblBirthDate.Name = "_lblBirthDate";
        _lblBirthDate.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblBirthDate.Size = new Size(82, 15);
        _lblBirthDate.TabIndex = 22;
        _lblBirthDate.Text = "Doğum Tarihi:";
        // 
        // _dtEditBirthDate
        // 
        _dtEditBirthDate.AllowNull = true;
        _dtEditBirthDate.DateTimeIcon = null;
        _dtEditBirthDate.Location = new Point(5, 112);
        _dtEditBirthDate.Name = "_dtEditBirthDate";
        _dtEditBirthDate.Size = new Size(324, 23);
        _dtEditBirthDate.TabIndex = 25;
        _dtEditBirthDate.ToolTipText = "";
        _dtEditBirthDate.Value = null;
        _dtEditBirthDate.Watermark = "Bir tarih Seçin";
        // 
        // _lblDeathDate
        // 
        _lblDeathDate.DY = -19;
        _lblDeathDate.LabeledControl = _dtEditDeathDate;
        _lblDeathDate.Location = new Point(5, 138);
        _lblDeathDate.Name = "_lblDeathDate";
        _lblDeathDate.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblDeathDate.Size = new Size(72, 15);
        _lblDeathDate.TabIndex = 24;
        _lblDeathDate.Text = "Ölüm Tarihi:";
        // 
        // _dtEditDeathDate
        // 
        _dtEditDeathDate.AllowNull = true;
        _dtEditDeathDate.DateTimeIcon = null;
        _dtEditDeathDate.Location = new Point(5, 157);
        _dtEditDeathDate.Name = "_dtEditDeathDate";
        _dtEditDeathDate.Size = new Size(324, 23);
        _dtEditDeathDate.TabIndex = 26;
        _dtEditDeathDate.ToolTipText = "";
        _dtEditDeathDate.Value = null;
        _dtEditDeathDate.Watermark = "Bir tarih seçin";
        // 
        // AddOrUpdateTranslatorOrWriterForm
        // 
        AcceptButton = _btnSave;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = _btnCancel;
        ClientSize = new Size(334, 221);
        Controls.Add(_dtEditDeathDate);
        Controls.Add(_dtEditBirthDate);
        Controls.Add(_lblDeathDate);
        Controls.Add(_lblBirthDate);
        Controls.Add(_lblSurname);
        Controls.Add(_txtBoxSurname);
        Controls.Add(_btnCancel);
        Controls.Add(_btnSave);
        Controls.Add(_lblName);
        Controls.Add(_txtBoxName);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(350, 260);
        MinimizeBox = false;
        MinimumSize = new Size(350, 260);
        Name = "AddOrUpdateTranslatorOrWriterForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        ((System.ComponentModel.ISupportInitialize)_txtBoxName).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxSurname).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Syncfusion.WinForms.Controls.SfButton _btnCancel;
    private Syncfusion.WinForms.Controls.SfButton _btnSave;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblName;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxName;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblSurname;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxSurname;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblBirthDate;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblDeathDate;
    private Syncfusion.WinForms.Input.SfDateTimeEdit _dtEditBirthDate;
    private Syncfusion.WinForms.Input.SfDateTimeEdit _dtEditDeathDate;
}