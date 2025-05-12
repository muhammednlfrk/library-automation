using FluentValidation;
using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;
using LibraryAutomation.WinFormsUI.Extensions;
using LibraryAutomation.WinFormsUI.Theme;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Caching.Memory;
using Syncfusion.WinForms.Controls;

namespace LibraryAutomation.WinFormsUI.Forms.Employee;

public partial class AddOrUpdateBookForm : SfForm
{
    private readonly ICollection<Translator> _translators;
    private readonly ICollection<Writer> _writers;
    private readonly ICollection<Language> _languages;
    private readonly ICollection<Shelf> _shelves;
    private readonly ICollection<Publisher> _publishers;

    private readonly IRepository<Book> _bookRepository;
    private readonly IRepository<BooksWriter> _booksWriterRepository;
    private readonly IRepository<BooksTranslator> _booksTranslatorRepository;
    private readonly IValidator<Book> _bookValidator;

    string _imageFilePath = string.Empty;

    public bool IsUpdate { get; set; } = false;
    public Book? BookToUpdate { get; set; }

    public AddOrUpdateBookForm(IMemoryCache memoryCache, IRepository<Book> bookRepository, IValidator<Book> bookValidator, IRepository<BooksWriter> booksWriterRepository, IRepository<BooksTranslator> booksTranslatorRepository)
    {
        InitializeComponent();

        SfSkinManager.SetVisualStyle(this, "LibraryTheme");
        LibraryThemeExtensions.ApplySkin(this);
        _btnSave.MakePrimary();
        _btnCancel.MakeOutline();
        _btnSelectFile.MakeOutline();

        _cmbBoxWriters.ShowToolTip = true;
        _cmbBoxWriters.ShowClearButton = true;
        _cmbBoxTranslators.ShowToolTip = true;
        _cmbBoxTranslators.ShowClearButton = true;

        _translators = memoryCache.GetTranslators();
        _writers = memoryCache.GetWriters();
        _languages = memoryCache.GetLanguages();
        _shelves = memoryCache.GetShelfs();
        _publishers = memoryCache.GetPublishers();

        _cmbBoxWriters.DataSource = _writers;
        _cmbBoxWriters.DisplayMember = nameof(Writer.FullName);
        _cmbBoxWriters.ValueMember = nameof(Writer.Id);

        _cmbBoxTranslators.DataSource = _translators;
        _cmbBoxTranslators.DisplayMember = nameof(Translator.FullName);
        _cmbBoxTranslators.ValueMember = nameof(Translator.Id);

        _cmbBoxLanguage.DataSource = _languages;
        _cmbBoxLanguage.DisplayMember = nameof(Language.NameTR);
        _cmbBoxLanguage.ValueMember = nameof(Language.Id);

        _cmbBoxOriginalLanguage.DataSource = _languages;
        _cmbBoxOriginalLanguage.DisplayMember = nameof(Language.NameTR);
        _cmbBoxOriginalLanguage.ValueMember = nameof(Language.Id);

        _cmbBoxShelf.DataSource = _shelves;
        _cmbBoxShelf.DisplayMember = nameof(Shelf.Name);
        _cmbBoxShelf.ValueMember = nameof(Shelf.Id);

        _cmbBoxPublisher.DataSource = _publishers;
        _cmbBoxPublisher.DisplayMember = nameof(Publisher.Name);
        _cmbBoxPublisher.ValueMember = nameof(Publisher.Id);

        _bookRepository = bookRepository;
        _bookValidator = bookValidator;
        _booksWriterRepository = booksWriterRepository;
        _booksTranslatorRepository = booksTranslatorRepository;
    }

    private void _btnSave_Click(object sender, EventArgs e)
    {
        if (!IsUpdate && _bookRepository.GetAll().Any(b => b.Name == _txtBoxName.Text))
        {
            MessageBox.Show("Bu isimde bir kitap zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!IsUpdate && _bookRepository.GetAll().Any(b => b.ISBN == _txtBoxISBN.Text))
        {
            MessageBox.Show("Bu ISBN numarasına sahip bir kitap zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!IsUpdate && _bookRepository.GetAll().Any(b => b.OriginName == _txtBoxOriginName.Text))
        {
            MessageBox.Show("Bu isimde bir kitap zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!_dateEditPublishDate.Value.HasValue)
        {
            MessageBox.Show("Lütfen geçerli bir yayın tarihi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (_cmbBoxWriters.SelectedItems.Count == 0)
        {
            MessageBox.Show("Lütfen en az bir yazar seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (_cmbBoxTranslators.SelectedItems.Count == 0)
        {
            MessageBox.Show("Lütfen en az bir çevirmen seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Book book;

        if (IsUpdate)
        {
            book = BookToUpdate!;
        }
        else
        {
            book = new();
        }

        book.Name = _txtBoxName.Text;
        book.OriginName = _txtBoxOriginName.Text;
        book.PublishDate = _dateEditPublishDate.Value ?? DateTime.Now;
        book.PageCount = (int)_txtBoxPageCount.IntegerValue;
        book.ISBN = _txtBoxISBN.Text;
        book.StockQuantity = (int)_txtBoxStockCount.IntegerValue;
        book.BorrowQuantity = 0;
        book.PublisherId = (int)_cmbBoxPublisher.SelectedValue;
        book.LanguageId = (int)_cmbBoxLanguage.SelectedValue;
        book.OriginalLanguageId = (int)_cmbBoxOriginalLanguage.SelectedValue;
        book.ShelfId = (int)_cmbBoxShelf.SelectedValue;

        var result = _bookValidator.Validate(book);
        if (!result.IsValid)
        {
            string errorMessage = string.Join(Environment.NewLine, result.Errors.Select(e => e.ErrorMessage));
            MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        using IDbContextTransaction transaction = _bookRepository.DbContext.Database.BeginTransaction();
        if (IsUpdate)
        {
            _booksTranslatorRepository.DbSet.RemoveRange(_booksTranslatorRepository.DbSet.Where(x => x.BookId == book.Id));
            _booksWriterRepository.DbSet.RemoveRange(_booksWriterRepository.DbSet.Where(x => x.BookId == book.Id));
            _bookRepository.DbContext.SaveChanges();
            _bookRepository.Update(book);
            foreach (var writer in _cmbBoxWriters.SelectedItems.Cast<Writer>())
            {
                _booksWriterRepository.Add(new BooksWriter
                {
                    BookId = book.Id,
                    WriterId = writer.Id
                });
            }
            foreach (var translator in _cmbBoxTranslators.SelectedItems.Cast<Translator>())
            {
                _booksTranslatorRepository.Add(new BooksTranslator
                {
                    BookId = book.Id,
                    TranslatorId = translator.Id
                });
            }
            _bookRepository.DbContext.SaveChanges();
            transaction.Commit();
        }
        else
        {
            book = _bookRepository.Add(book);
            _bookRepository.DbContext.SaveChanges();

            foreach (var writer in _cmbBoxWriters.SelectedItems.Cast<Writer>())
            {
                _booksWriterRepository.Add(new BooksWriter
                {
                    BookId = book.Id,
                    WriterId = writer.Id
                });
            }
            _booksWriterRepository.DbContext.SaveChanges();

            foreach (var translator in _cmbBoxTranslators.SelectedItems.Cast<Translator>())
            {
                _booksTranslatorRepository.Add(new BooksTranslator
                {
                    BookId = book.Id,
                    TranslatorId = translator.Id
                });
            }
            _booksWriterRepository.DbContext.SaveChanges();
            transaction.Commit();
        }
        if (!string.IsNullOrEmpty(_imageFilePath))
        {
            BookImageManager.AddOrUpdteBookImage(book.Id.ToString(), _imageFilePath);
        }
        Close();
    }

    private void AddOrUpdateBookForm_Load(object sender, EventArgs e)
    {
        if (IsUpdate)
        {
            Text = "Kitap Güncelle";
            if (BookToUpdate == null)
            {
                MessageBox.Show("Güncellenecek kitap bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            _bookRepository.DbContext.ChangeTracker.Clear();

            BookToUpdate = _bookRepository.DbSet
                .Where(b => b.Id == BookToUpdate.Id)
                .Include(b => b.Translators)
                .Include(b => b.BooksTranslators)
                .Include(b => b.Writers)
                .Include(b => b.BooksWriters)
                .Include(b => b.Publisher)
                .Include(b => b.Language)
                .Include(b => b.OriginalLanguage)
                .Include(b => b.Shelf)
                .FirstOrDefault();

            _txtBoxName.Text = BookToUpdate!.Name;
            _txtBoxOriginName.Text = BookToUpdate.OriginName;
            _dateEditPublishDate.Value = BookToUpdate.PublishDate;
            _txtBoxPageCount.IntegerValue = BookToUpdate.PageCount;
            _txtBoxISBN.Text = BookToUpdate.ISBN;
            _txtBoxStockCount.IntegerValue = BookToUpdate.StockQuantity;
            _cmbBoxPublisher.SelectedValue = BookToUpdate.PublisherId;
            _cmbBoxLanguage.SelectedValue = BookToUpdate.LanguageId;
            _cmbBoxOriginalLanguage.SelectedValue = BookToUpdate.OriginalLanguageId;
            _cmbBoxShelf.SelectedValue = BookToUpdate.ShelfId;
            foreach (var writer in BookToUpdate!.Writers!)
                _cmbBoxWriters.SelectedItems.Add(_writers.FirstOrDefault(x => x.Id == writer.Id));
            foreach (var translator in BookToUpdate!.Translators!)
                _cmbBoxTranslators.SelectedItems.Add(_translators.FirstOrDefault(x => x.Id == translator.Id));

            _picBoxBook.Image = Image.FromFile(BookImageManager.GetBookImagePath(BookToUpdate!.Id.ToString()));
        }
        else
        {
            Text = "Yeni Kitap Ekle";
        }
    }

    private void _btnSelectFile_Click(object sender, EventArgs e)
    {
        if (_imageFileSelector.ShowDialog() == DialogResult.OK)
        {
            var filePath = _imageFileSelector.FileName;
            if (filePath != null)
            {
                _picBoxBook.Image = Image.FromFile(filePath);
                _imageFilePath = filePath;
            }
        }
    }

    private void _picBoxBook_Click(object sender, EventArgs e)
    {
        _btnSelectFile.PerformClick();
    }
}
