using FluentValidation;
using FluentValidation.Results;
using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.WinForms.Controls;
using System.Text;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;
public partial class AddOrUpdateShelfForm : SfForm
{
    private readonly IRepository<Shelf> _shelfRepository;
    private readonly IValidator<Shelf> _shelfValidator;


    public bool IsUpdate { get; set; } = false;
    public Shelf? ShelfToUpdate { get; set; }

    public AddOrUpdateShelfForm(IRepository<Shelf> shelfRepository, IValidator<Shelf> shelfValidator)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);
        _btnSave.MakePrimary();
        _btnCancel.MakeOutline();

        _shelfRepository = shelfRepository;
        _shelfValidator = shelfValidator;
    }

    private void AddOrUpdateShelfForm_Load(object sender, EventArgs e)
    {
        if (IsUpdate && _shelfRepository != null)
        {
            _txtBoxName.Text = ShelfToUpdate?.Name;
            _txtBoxDescription.Text = ShelfToUpdate?.Description;
            Text = "Raf Güncelle";
        }
        else
        {
            Text = "Yeni Raf Ekle";
        }
    }

    private void _btnSave_Click(object sender, EventArgs e)
    {
        Shelf shelf = new()
        {
            Name = _txtBoxName.Text,
            Description = _txtBoxDescription.Text
        };

        ValidationResult validationResult = _shelfValidator.Validate(shelf);
        if (!validationResult.IsValid)
        {
            StringBuilder sb = new();

            foreach (var error in validationResult.Errors)
                sb.AppendLine(error.ErrorMessage);

            MessageBox.Show(sb.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        bool exists = IsUpdate
            ? _shelfRepository.Query.Any(x => x.Id != ShelfToUpdate!.Id && x.Name == shelf.Name)
            :_shelfRepository.Query.Any( x => x.Name == shelf.Name);

        if (exists)
        {
            MessageBox.Show("Bu isimde bir raf zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (IsUpdate)
        {
            shelf.Id = ShelfToUpdate?.Id ?? 0;
            _shelfRepository.DbSet.Update(shelf);
            _shelfRepository.DbContext.SaveChanges();
        }
        else
        {
            _shelfRepository.DbSet.Add(shelf);
            _shelfRepository.DbContext.SaveChanges();
        }
        Close();
    }
}
