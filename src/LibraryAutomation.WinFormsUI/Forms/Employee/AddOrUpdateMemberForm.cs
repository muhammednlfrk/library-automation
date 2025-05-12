using FluentValidation;
using FluentValidation.Results;
using LibraryAutomation.ApplicationL.Identity;
using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Domain.Enums;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Theme;
using Syncfusion.WinForms.Controls;
using Syncfusion.Windows.Forms;

namespace LibraryAutomation.WinFormsUI.Forms.Employee.Member;

public partial class AddOrUpdateMemberForm : SfForm
{
    public bool IsUpdate { get; set; } = false;

    public User? UserToUpdate { get; set; }

    private readonly IRepository<User> _userRepository;
    private readonly IValidator<User> _userValidator;
    private readonly IPasswordHashGenerator _passwordHashGenerator;

    public AddOrUpdateMemberForm(IRepository<User> userRepository, IValidator<User> userValidator, IPasswordHashGenerator passwordHashGenerator)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);
        _btnSave.MakePrimary();
        _btnCancel.MakeOutline();

        _userRepository = userRepository;
        _userValidator = userValidator;
        _passwordHashGenerator = passwordHashGenerator;
    }

    private void AddOrUpdateMemberForm_Load(object sender, EventArgs e)
    {
        Text = IsUpdate ? "Üye Güncelle" : "Üye Ekle";

        if (UserToUpdate == null || UserToUpdate.UserGroup != UserGroup.StdUser)
            return;
        else
        {
            _txtBoxFullName.Text = UserToUpdate.Name + " " + UserToUpdate.Surname;
            _txtBoxEmail.Text = UserToUpdate.Email;
            _txtBoxUsername.Text = UserToUpdate.Username;
        }
    }

    private void _btnSave_Click(object sender, EventArgs e)
    {
        if(_txtBoxPassword.Text != _txtBoxPasswordAgain.Text)
        {
            MessageBoxAdv.Show("Şifreler eşleşmiyor.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string[] names = _txtBoxFullName.Text.Split(' ');
        if (names.Length < 2)
        {
            MessageBoxAdv.Show("Lütfen hem adı hem de soyadını girin.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        User targetUser = new()
        {
            UserGroup = UserGroup.StdUser,
            Name = string.Join(" ", names.Take(names.Length - 1)),
            Surname = names[^1],
            Email = _txtBoxEmail.Text,
            Username = _txtBoxUsername.Text,
            Password = _passwordHashGenerator.HashPassword(_txtBoxPassword.Text)
        };

        ValidationResult validationResult = _userValidator.Validate(targetUser);
        if (!validationResult.IsValid)
        {
            string errorMessage = string.Join(Environment.NewLine, validationResult.Errors.Select(e => e.ErrorMessage));
            MessageBoxAdv.Show(errorMessage, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        bool isOk;
        if (IsUpdate)
        {
            if (UserToUpdate == null)
                return;

            targetUser.Id = UserToUpdate.Id;
            isOk = updateUser(targetUser);
        }
        else
        {
            isOk = addUser(targetUser);
        }

        if (!isOk) return;
        Close();
    }

    private bool updateUser(User user)
    {
        if (user == null)
            return false;

        User? existingUser = _userRepository.DbSet.FirstOrDefault(x => x.Id == user.Id);

        if (existingUser == null)
        {
            MessageBoxAdv.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        existingUser.Name = user.Name;
        existingUser.Surname = user.Surname;
        existingUser.Email = user.Email;
        existingUser.Username = user.Username;
        existingUser.Password = user.Password;
        _userRepository.Update(existingUser);
        _userRepository.DbContext.SaveChanges();
        return true;
    }

    private bool addUser(User user)
    {
        if (user == null)
            return false;

        User? existingUser = _userRepository.DbSet.FirstOrDefault(x => x.Username == user.Username || x.Email == user.Email);

        if (existingUser != null)
        {
            MessageBoxAdv.Show("Kullanıcı adı zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        _userRepository.Add(user);
        _userRepository.DbContext.SaveChanges();
        return true;
    }
}
