using book_store.database.entity;
using book_store.dto.author;
using book_store.service;
using book_store.util;
using book_store.validation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_store.form.admin
{
    public partial class FormBookInfoAdmin : Form
    {
        private readonly BookService bookService = new BookService();
        private readonly AuthorService authorService = new AuthorService();
        private readonly CategoryService categoryService = new CategoryService();
        private readonly PublisherService publisherService = new PublisherService();
        private readonly CoverTypeService coverTypeService = new CoverTypeService();
        private readonly LanguageService languageService = new LanguageService();
        private int bookId;
        private Book book;
        private string fileName;
        public FormBookInfoAdmin(int bookId)
        {
            this.bookId = bookId;
            InitializeComponent();
        }

        private async void FormBookInfoAdmin_Load(object sender, EventArgs e)
        {
            await LoadInfo();
        }

        private async Task LoadInfo()
        {
            book = (await bookService.FindById(bookId))!;

            cbAuthor.DisplayMember = "FullName";
            cbAuthor.ValueMember = "Id";
            cbAuthor.DataSource = await authorService.FindAllListDto();
            cbAuthor.SelectedValue = book.AuthorId;

            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.DataSource = await categoryService.FindAll();
            cbCategory.SelectedValue = book.CategoryId;

            cbPublisher.DisplayMember = "Name";
            cbPublisher.ValueMember = "Id";
            cbPublisher.DataSource = await publisherService.FindAll();
            cbPublisher.SelectedValue = book.PublisherId;

            cbCoverType.DisplayMember = "Type";
            cbCoverType.ValueMember = "Id";
            cbCoverType.DataSource = await coverTypeService.FindAll();
            cbCoverType.SelectedValue = book.CoverTypeId;

            cbLanguage.DisplayMember = "Name";
            cbLanguage.ValueMember = "Id";
            cbLanguage.DataSource = await languageService.FindAll();
            cbLanguage.SelectedValue = book.LanguageId;

            tbId.Text = book.Id.ToString();
            tbTitle.Text = book.Title;
            tbPrice.Text = book.Price.ToString();
            tbSeries.Text = book.Series;
            tbYearOfPublishing.Text = book.YearOfPublishing.ToString();
            tbIsbn.Text = book.Isbn;
            tbNumberOfPages.Text = book.NumberOfPages.ToString();
            tbHeight.Text = book.Height.ToString("G29");
            tbWidth.Text = book.Width.ToString("G29");
            tbLength.Text = book.Length.ToString("G29");
            tbCirculation.Text = book.Circulation.ToString();
            tbWeight.Text = book.Weight.ToString();
            tbAgeRestrictions.Text = $"{book.AgeRestrictions}+";
            tbDescription.Text = book.Description;

            pbBookImage.Image = ImageUtils.GetBookImageByPath(book.ImagePath);
        }

        private void buttonEditImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbBookImage.Image = new Bitmap(openFileDialog.FileName);
                    fileName = openFileDialog.FileName;
                }
            }
        }

        private async void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                MessageBox.Show("Название не должно быть пустым");
                return;
            }
            if (!int.TryParse(tbPrice.Text, out int price) || price <= 0)
            {
                MessageBox.Show("Цена некорректная");
                return;
            }
            if (!int.TryParse(tbYearOfPublishing.Text, out int yearOfPublishing) || yearOfPublishing > DateTime.Now.Year || yearOfPublishing < 0)
            {
                MessageBox.Show("Год издания некорректный");
                return;
            }

            if (!IsbnValidator.IsValid(tbIsbn.Text))
            {
                MessageBox.Show("isbn некорректный");
                return;
            }

            if (!int.TryParse(tbNumberOfPages.Text, out int numberOfPages) || numberOfPages <= 0)
            {
                MessageBox.Show("Количество страниц некорректное");
                return;
            }

            if (!int.TryParse(tbCirculation.Text, out int circulation) || circulation <= 0)
            {
                MessageBox.Show("Тираж некорректный");
                return;
            }

            if (!decimal.TryParse(tbHeight.Text, out decimal height) || height <= 0 ||
                !decimal.TryParse(tbWidth.Text, out decimal width) || width <= 0 ||
                !decimal.TryParse(tbLength.Text, out decimal length) || length <= 0)
            {
                MessageBox.Show("Размеры книги некорретные");
                return;
            }

            if (!int.TryParse(tbWeight.Text, out int weight) || weight <= 0)
            {
                MessageBox.Show("Вес некорректный");
                return;
            }

            if (!int.TryParse(tbAgeRestrictions.Text.Replace("+", ""), out int ageRestrictions) || ageRestrictions < 0)
            {
                MessageBox.Show("Возрастное ограничение некорректно");
                return;
            }
            var bookByTitleAndAuthor = bookService.FindByTitleAndAuthor(tbTitle.Text, (int)cbAuthor.SelectedValue!);
            if (bookByTitleAndAuthor != null && bookByTitleAndAuthor.Id != book.Id)
            {
                MessageBox.Show("Книга с таким названием и автором уже существует");
                return;
            }
            var bookByIsbn = bookService.FindByIsbn(tbIsbn.Text);
            if(bookByIsbn != null && bookByIsbn.Id != book.Id)
            {
                MessageBox.Show("Книга с таким isbn уже существует");
                return;
            }

            book.Title = tbTitle.Text;
            book.AuthorId = (cbAuthor.SelectedItem as AuthorListDto)!.Id;
            book.Price = price;
            book.Series = tbSeries.Text;
            book.YearOfPublishing = yearOfPublishing;
            book.Isbn = tbIsbn.Text;
            book.NumberOfPages = numberOfPages;
            book.Height = height;
            book.Width = width;
            book.Length = length;
            book.Circulation = circulation;
            book.Weight = weight;
            book.AgeRestrictions = ageRestrictions;
            book.CategoryId = (cbCategory.SelectedItem as Category)!.Id;
            book.Description = tbDescription.Text;
            book.PublisherId = (cbPublisher.SelectedItem as Publisher)!.Id;
            book.CoverTypeId = (cbCoverType.SelectedItem as CoverType)!.Id;
            book.LanguageId = (cbLanguage.SelectedItem as Language)!.Id;
            if (fileName != null)
            {
                book.ImagePath = fileName;
            }
            await bookService.Update(book);
            MessageBox.Show("Книга успешно обновлена ✅");
            await LoadInfo();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            OpenPreviousForm();
        }

        private async void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить объект?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await bookService.Delete(bookId);
                MessageBox.Show("Книга успешно удалена ✅");
                OpenPreviousForm();
            }
        }

        private void OpenPreviousForm()
        {
            FormBookManagement formBookManagement = new FormBookManagement();
            Close();
            formBookManagement.Show();
        }
    }
}
