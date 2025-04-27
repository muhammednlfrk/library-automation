namespace LibraryAutomation.WinFormsUI.Forms.Employee;

partial class AddOrUpdateShelfForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateShelfForm));
        _btnCancel = new Syncfusion.WinForms.Controls.SfButton();
        _btnSave = new Syncfusion.WinForms.Controls.SfButton();
        _lblName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _lblDescription = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        ((System.ComponentModel.ISupportInitialize)_txtBoxName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxDescription).BeginInit();
        SuspendLayout();
        // 
        // _btnCancel
        // 
        _btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnCancel.Font = new Font("Segoe UI Semibold", 9F);
        _btnCancel.Location = new Point(131, 198);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new Size(96, 28);
        _btnCancel.TabIndex = 10;
        _btnCancel.Text = "&İptal";
        // 
        // _btnSave
        // 
        _btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnSave.Font = new Font("Segoe UI Semibold", 9F);
        _btnSave.Location = new Point(233, 198);
        _btnSave.Name = "_btnSave";
        _btnSave.Size = new Size(96, 28);
        _btnSave.TabIndex = 11;
        _btnSave.Text = "&Kaydet";
        // 
        // _lblName
        // 
        _lblName.DY = -19;
        _lblName.LabeledControl = _txtBoxName;
        _lblName.Location = new Point(5, 2);
        _lblName.Name = "_lblName";
        _lblName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblName.Size = new Size(48, 15);
        _lblName.TabIndex = 8;
        _lblName.Text = "Raf Adı:";
        // 
        // _txtBoxName
        // 
        _txtBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxName.BeforeTouchSize = new Size(324, 126);
        _txtBoxName.Location = new Point(5, 21);
        _txtBoxName.Name = "_txtBoxName";
        _txtBoxName.Size = new Size(324, 23);
        _txtBoxName.TabIndex = 9;
        // 
        // _lblDescription
        // 
        _lblDescription.DY = -19;
        _lblDescription.LabeledControl = _txtBoxDescription;
        _lblDescription.Location = new Point(5, 47);
        _lblDescription.Name = "_lblDescription";
        _lblDescription.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblDescription.Size = new Size(87, 15);
        _lblDescription.TabIndex = 12;
        _lblDescription.Text = "Raf Açıklaması:";
        // 
        // _txtBoxDescription
        // 
        _txtBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxDescription.BeforeTouchSize = new Size(324, 126);
        _txtBoxDescription.Location = new Point(5, 66);
        _txtBoxDescription.Multiline = true;
        _txtBoxDescription.Name = "_txtBoxDescription";
        _txtBoxDescription.Size = new Size(324, 126);
        _txtBoxDescription.TabIndex = 13;
        // 
        // AddOrUpdateShelfForm
        // 
        AcceptButton = _btnSave;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = _btnCancel;
        ClientSize = new Size(334, 231);
        Controls.Add(_lblDescription);
        Controls.Add(_txtBoxDescription);
        Controls.Add(_btnCancel);
        Controls.Add(_btnSave);
        Controls.Add(_lblName);
        Controls.Add(_txtBoxName);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AddOrUpdateShelfForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        ((System.ComponentModel.ISupportInitialize)_txtBoxName).EndInit();
        ((System.ComponentModel.ISupportInitialize)_txtBoxDescription).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Syncfusion.WinForms.Controls.SfButton _btnCancel;
    private Syncfusion.WinForms.Controls.SfButton _btnSave;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblName;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxName;
    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblDescription;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxDescription;
}