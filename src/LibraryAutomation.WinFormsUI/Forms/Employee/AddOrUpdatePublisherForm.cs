using FluentValidation;
using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class AddOrUpdatePublisherForm : SfForm
{
    private readonly IRepository<Publisher> _publisherRepository;
    private readonly IValidator<Publisher> _publisherValidator;

    public bool IsUpdate { get; set; } = false;
    public Publisher? PublisherToUpdate { get; set; }

    public AddOrUpdatePublisherForm(IRepository<Publisher> publisherRepository, IValidator<Publisher> publisherValidator)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);
        _btnSave.MakePrimary();
        _btnCancel.MakeOutline();

        _publisherRepository = publisherRepository;
        _publisherValidator = publisherValidator;
    }

    private void _btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_txtBoxName.Text))
        {
            MessageBox.Show("Lütfen yayınevi adını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        Publisher publisher = new()
        {
            Name = _txtBoxName.Text.Trim()
        };
        var validationResult = _publisherValidator.Validate(publisher);
        if (!validationResult.IsValid)
        {
            string errorMessage = string.Join(Environment.NewLine, validationResult.Errors.Select(e => e.ErrorMessage));
            MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (IsUpdate && PublisherToUpdate != null)
        {
            Publisher? existingPublisher = _publisherRepository.DbSet.FirstOrDefault(p => p.Name == publisher.Name && p.Id != PublisherToUpdate.Id);
            if (existingPublisher != null)
            {
                MessageBox.Show("Bu yayınevi adı zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PublisherToUpdate.Name = publisher.Name;
            _publisherRepository.DbSet.Update(PublisherToUpdate);
            _publisherRepository.DbContext.SaveChanges();
        }
        else
        {
            Publisher? existingPublisher = _publisherRepository.DbSet.FirstOrDefault(p => p.Name == publisher.Name);
            if (existingPublisher != null)
            {
                MessageBox.Show("Bu yayınevi adı zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _publisherRepository.DbSet.Add(publisher);
            _publisherRepository.DbContext.SaveChanges();
        }
        Close();
    }

    private void AddOrUpdatePublisherForm_Load(object sender, EventArgs e)
    {
        if (IsUpdate && PublisherToUpdate != null)
        {
            Text = "Yayınevi Güncelle";
            _txtBoxName.Text = PublisherToUpdate.Name;
        }
        else
        {
            Text = "Yeni Yayınevi Ekle";
        }
    }
}
