using FluentValidation;
using FluentValidation.Results;
using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.WinForms.Controls;
using System.Text;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class AddOrUpdateTranslatorOrWriterForm : SfForm
{
    private readonly IRepository<Translator> _translatorRepository;
    private readonly IRepository<Writer> _writerRepository;
    private readonly IValidator<Translator> _translatorValidator;
    private readonly IValidator<Writer> _writerValidator;

    public bool IsUpdate { get; set; } = false;
    public Translator? TranslatorToUpdate { get; set; }
    public Writer? WriterToUpdate { get; set; }
    public bool IsTranslator { get; set; }

    public AddOrUpdateTranslatorOrWriterForm(
        IRepository<Translator> translatorRepository,
        IRepository<Writer> writerRepository,
        IValidator<Translator> translatorValidator,
        IValidator<Writer> writerValidator)
    {
        InitializeComponent();

        // Apply the Library theme to the form
        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);
        _btnSave.MakePrimary();
        _btnCancel.MakeOutline();

        _translatorRepository = translatorRepository;
        _writerRepository = writerRepository;
        _translatorValidator = translatorValidator;
        _writerValidator = writerValidator;
    }

    private void AddOrUpdateTranslatorOrWriterForm_Load(object sender, EventArgs e)
    {
        if (IsUpdate)
        {
            if (IsTranslator)
            {
                _txtBoxName.Text = TranslatorToUpdate!.Name;
                _txtBoxSurname.Text = TranslatorToUpdate.Surname;
                _dtEditBirthDate.Value = TranslatorToUpdate.BirthDate;
                _dtEditDeathDate.Value = TranslatorToUpdate.DeathDate;
                Text = "Çevirmen Güncelle";
            }
            else
            {
                _txtBoxName.Text = WriterToUpdate!.Name;
                _txtBoxSurname.Text = WriterToUpdate.Surname;
                _dtEditBirthDate.Value = WriterToUpdate.BirthDate;
                _dtEditDeathDate.Value = WriterToUpdate.DeathDate;
                Text = "Yazar Güncelle";
            }
        }
        else
        {
            Text = IsTranslator ? "Yeni Çevirmen" : "Yeni Yazar";
        }
    }

    private void _btnSave_Click(object sender, EventArgs e)
    {
        if (IsTranslator)
        {
            addOrUpdateTranslator();
        }
        else
        {
            addOrUpdateWriter();
        }
    }

    private void addOrUpdateWriter()
    {
        if (IsUpdate && WriterToUpdate == null)
        {
            MessageBox.Show("Güncellenecek yazar bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Writer writer = new()
        {
            Name = _txtBoxName.Text,
            Surname = _txtBoxSurname.Text,
            BirthDate = _dtEditBirthDate.Value,
            DeathDate = _dtEditDeathDate.Value
        };

        ValidationResult result = _writerValidator.Validate(writer);
        if (!result.IsValid)
        {
            StringBuilder sb = new();
            foreach (ValidationFailure failure in result.Errors)
                sb.AppendLine(failure.ErrorMessage);
            MessageBox.Show(sb.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        bool alredyExists = IsUpdate
            ? _writerRepository.Query.Any(w => w.Id != WriterToUpdate!.Id && w.Name == writer.Name && w.Surname == writer.Surname)
            : _writerRepository.Query.Any(w => w.Name == writer.Name && w.Surname == writer.Surname);
        if (alredyExists)
        {
            MessageBox.Show("Bu yazar zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (IsUpdate)
        {
            writer.Id = WriterToUpdate!.Id;
            _writerRepository.DbContext.Update(writer);
            _writerRepository.DbContext.SaveChanges();
        }
        else
        {
            _writerRepository.DbContext.Add(writer);
            _writerRepository.DbContext.SaveChanges();
        }
        Close();
    }

    private void addOrUpdateTranslator()
    {
        if (IsUpdate && TranslatorToUpdate == null)
        {
            MessageBox.Show("Güncellenecek çevirmen bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Translator translator = new()
        {
            Name = _txtBoxName.Text,
            Surname = _txtBoxSurname.Text,
            BirthDate = _dtEditBirthDate.Value,
            DeathDate = _dtEditDeathDate.Value
        };

        ValidationResult result = _translatorValidator.Validate(translator);
        if (!result.IsValid)
        {
            StringBuilder sb = new();
            foreach (ValidationFailure failure in result.Errors)
                sb.AppendLine(failure.ErrorMessage);
            MessageBox.Show(sb.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        bool alredyExists = IsUpdate
            ? _translatorRepository.Query.Any(t => t.Id != TranslatorToUpdate!.Id && t.Name == translator.Name && t.Surname == translator.Surname)
            : _translatorRepository.Query.Any(t => t.Name == translator.Name && t.Surname == translator.Surname);

        if (alredyExists)
        {
            MessageBox.Show("Bu çevirmen zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (IsUpdate)
        {
            translator.Id = TranslatorToUpdate!.Id;
            _translatorRepository.DbContext.Update(translator);
            _translatorRepository.DbContext.SaveChanges();
        }
        else
        {
            _translatorRepository.DbContext.Add(translator);
            _translatorRepository.DbContext.SaveChanges();
        }
        Close();
    }
}
