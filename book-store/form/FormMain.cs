using book_store.entity;
using book_store.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace book_store.form
{
    public partial class FormMain : Form
    {
        private readonly BookService bookService = new BookService();
        private readonly CategoryService categoryService = new CategoryService();
        private readonly CoverTypeService coverTypeService = new CoverTypeService();
        private readonly LanguageService languageService = new LanguageService();
        private List<Book> allBooks = new List<Book>();
        private List<Book> books = new List<Book>();
        private List<Category> categories = new List<Category>();
        private List<CoverType> coverTypes = new List<CoverType>();
        private List<Language> languages = new List<Language>();
        int selectedRowIndex = -1;
        public FormMain()
        {
            InitializeComponent();
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.Columns[0].DataPropertyName = "Id";
            dgvBooks.Columns[1].DataPropertyName = "BookName";
            dgvBooks.Columns[2].DataPropertyName = "AuthorName";
            dgvBooks.Columns[3].DataPropertyName = "Image";
            dgvBooks.Columns[4].DataPropertyName = "Price";
            dgvBooks.Columns[5].DataPropertyName = "IsInFavorites";
            dgvBooks.Columns[6].DataPropertyName = "IsInCart";
            dgvBooks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ViewAllBooks();

            categories = categoryService.FindAll();
            categories.Insert(0, new Category(0, "All"));

            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.DataSource = categories;

            coverTypes = coverTypeService.FindAll();
            coverTypes.Insert(0, new CoverType(0, "Не выбрана"));

            cbCoverType.DisplayMember = "Name";
            cbCoverType.ValueMember = "Id";
            cbCoverType.DataSource = coverTypes;

            languages = languageService.FindAll();
            languages.Insert(0, new Language(0, "All"));

            cbLanguage.DisplayMember = "Name";
            cbLanguage.ValueMember = "Id";
            cbLanguage.DataSource = languages;

            (int minPrice, int maxPrice) = bookService.GetMinAndMaxPrice();
            nudMinPrice.Minimum = minPrice;
            nudMinPrice.Maximum = maxPrice;
            nudMaxPrice.Minimum = minPrice;
            nudMaxPrice.Maximum = maxPrice;
            nudMinPrice.Value = minPrice;
            nudMaxPrice.Value = maxPrice;
        }

        private void ViewAllBooks()
        {
            allBooks = bookService.FindAllWithUserInfo();
            dgvBooks.DataSource = allBooks;
        }

        private void dgvBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBooks.Columns[e.ColumnIndex].DataPropertyName == "Price" && e.RowIndex >= 0)
            {
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString() + " ₽";
                }
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void UpdateFilter()
        {
            string searchText = tbSearch.Text.ToLower();
            int selectedCategory = (int)cbCategory.SelectedValue;
            string authorText = tbAuthor.Text.ToLower();
            int selectedCoverType = cbCoverType.SelectedValue as int? ?? 0;
            int selectedLanguage = cbLanguage.SelectedValue as int? ?? 0;

            List<Book> filteredBooks = allBooks
                                        .Where(book => book.BookName.ToLower().Contains(searchText))
                                        .Where(book => book.AuthorName.ToLower().Contains(authorText))
                                        .Where(book => selectedCategory == 0 || book.CategoryId == selectedCategory)
                                        .Where(book => selectedCoverType == 0 || book.CoverTypeId == selectedCoverType)
                                        .Where(book => selectedLanguage == 0 || book.LanguageId == selectedLanguage)
                                        .Where(book => book.Price >= nudMinPrice.Value && book.Price <= nudMaxPrice.Value)
                                        .ToList();
            dgvBooks.DataSource = filteredBooks;
        }

        private void tbAuthor_TextChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void cbCoverType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void rangeTrackBar1_RangeChanged(object sender, EventArgs e)
        {

        }

        private void nudMinPrice_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void nudMaxPrice_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }
    }
}
