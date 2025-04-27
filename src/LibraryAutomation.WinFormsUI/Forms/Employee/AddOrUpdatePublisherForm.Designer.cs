namespace LibraryAutomation.WinFormsUI.Forms.Employee;

partial class AddOrUpdatePublisherForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdatePublisherForm));
        _lblName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
        _txtBoxFullName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
        _btnCancel = new Syncfusion.WinForms.Controls.SfButton();
        _btnSave = new Syncfusion.WinForms.Controls.SfButton();
        ((System.ComponentModel.ISupportInitialize)_txtBoxFullName).BeginInit();
        SuspendLayout();
        // 
        // _lblName
        // 
        _lblName.DY = -19;
        _lblName.LabeledControl = _txtBoxFullName;
        _lblName.Location = new Point(5, 2);
        _lblName.Name = "_lblName";
        _lblName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
        _lblName.Size = new Size(74, 15);
        _lblName.TabIndex = 2;
        _lblName.Text = "Yayınevi Adı:";
        // 
        // _txtBoxFullName
        // 
        _txtBoxFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _txtBoxFullName.BeforeTouchSize = new Size(274, 23);
        _txtBoxFullName.Location = new Point(5, 21);
        _txtBoxFullName.Name = "_txtBoxFullName";
        _txtBoxFullName.Size = new Size(274, 23);
        _txtBoxFullName.TabIndex = 3;
        // 
        // _btnCancel
        // 
        _btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnCancel.Font = new Font("Segoe UI Semibold", 9F);
        _btnCancel.Location = new Point(81, 53);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new Size(96, 28);
        _btnCancel.TabIndex = 6;
        _btnCancel.Text = "&İptal";
        // 
        // _btnSave
        // 
        _btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnSave.Font = new Font("Segoe UI Semibold", 9F);
        _btnSave.Location = new Point(183, 53);
        _btnSave.Name = "_btnSave";
        _btnSave.Size = new Size(96, 28);
        _btnSave.TabIndex = 7;
        _btnSave.Text = "&Kaydet";
        // 
        // AddOrUpdatePublisherForm
        // 
        AcceptButton = _btnSave;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = _btnCancel;
        ClientSize = new Size(284, 86);
        Controls.Add(_btnCancel);
        Controls.Add(_btnSave);
        Controls.Add(_lblName);
        Controls.Add(_txtBoxFullName);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(300, 125);
        MinimizeBox = false;
        MinimumSize = new Size(300, 125);
        Name = "AddOrUpdatePublisherForm";
        StartPosition = FormStartPosition.CenterScreen;
        Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        ((System.ComponentModel.ISupportInitialize)_txtBoxFullName).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Syncfusion.Windows.Forms.Tools.AutoLabel _lblName;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt _txtBoxFullName;
    private Syncfusion.WinForms.Controls.SfButton _btnCancel;
    private Syncfusion.WinForms.Controls.SfButton _btnSave;
}