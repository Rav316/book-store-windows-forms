using book_store.database.entity;
using book_store.dto.book;
using book_store.service;
using book_store.util;
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
        private List<BookListDto> allBooks = new List<BookListDto>();
        private List<Category> categories = new List<Category>();
        private List<CoverType> coverTypes = new List<CoverType>();
        private List<Language> languages = new List<Language>();
        public FormMain()
        {
            InitializeComponent();
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.Columns[0].DataPropertyName = "Id";
            dgvBooks.Columns[0].ReadOnly = true;
            dgvBooks.Columns[1].DataPropertyName = "Title";
            dgvBooks.Columns[1].ReadOnly = true;
            dgvBooks.Columns[2].DataPropertyName = "AuthorFullName";
            dgvBooks.Columns[2].ReadOnly = true;
            dgvBooks.Columns[3].DataPropertyName = "Image";
            dgvBooks.Columns[3].ReadOnly = true;
            dgvBooks.Columns[4].DataPropertyName = "Price";
            dgvBooks.Columns[4].ReadOnly = true;
            dgvBooks.Columns[5].DataPropertyName = "IsFavorite";
            dgvBooks.Columns[6].DataPropertyName = "IsInCart";
            dgvBooks.Columns[7].DataPropertyName = "IsAvailable";
            dgvBooks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private async void FormMain_Load(object sender, EventArgs e)
        {


            categories = await categoryService.FindAll();
            categories.Insert(0, new Category { Id = 0, Name = "Все" });

            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.DataSource = categories;

            coverTypes = await coverTypeService.FindAll();
            coverTypes.Insert(0, new CoverType { Id = 0, Type = "Не выбрана" });

            cbCoverType.DisplayMember = "Type";
            cbCoverType.ValueMember = "Id";
            cbCoverType.DataSource = coverTypes;

            languages = await languageService.FindAll();
            languages.Insert(0, new Language { Id = 0, Name = "Не выбран" });

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
            ViewAllBooks();
            
        }

        private void ViewAllBooks()
        {
            allBooks = bookService.FindAllWithUserInfo();
            allBooks.ForEach(book =>
            {
                book.image = ImageUtils.GetBookImageByPath(book.ImagePath);
            });
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

            if (dgvBooks.Columns[e.ColumnIndex].DataPropertyName == "IsInCart" && e.RowIndex >= 0)
            {
                bool isAvailable = Convert.ToBoolean(dgvBooks.Rows[e.RowIndex].Cells["IsAvailable"].Value);
                bool isInCart = Convert.ToBoolean(dgvBooks.Rows[e.RowIndex].Cells["IsInCart"].Value);
                dgvBooks.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.LightGray;

                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dgvBooks.Rows[e.RowIndex].Cells[e.ColumnIndex];
                checkBoxCell.ReadOnly = !isAvailable && !isInCart;

                if (!isAvailable)
                {
                    dgvBooks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    dgvBooks.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
                } else
                {
                    dgvBooks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dgvBooks.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
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

            List<BookListDto> filteredBooks = allBooks
                                        .Where(book => book.Title.ToLower().Contains(searchText))
                                        .Where(book => book.AuthorFullName.ToLower().Contains(authorText))
                                        .Where(book => selectedCategory == 0 || book.Category == selectedCategory)
                                        .Where(book => selectedCoverType == 0 || book.CoverType == selectedCoverType)
                                        .Where(book => selectedLanguage == 0 || book.Language == selectedLanguage)
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

        private void pbFavorites_Click(object sender, EventArgs e)
        {
            FormFavorites formFavorites = new FormFavorites();
            Close();
            formFavorites.Show();
        }

        private void dgvBooks_DoubleClick(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvBooks.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                FormBookInfo formBookInfo = new FormBookInfo(allBooks[selectedRowIndex].Id);
                formBookInfo.ShowDialog();
                ViewAllBooks();
            }
        }

        private async void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                dgvBooks.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if (dgvBooks[e.ColumnIndex, e.RowIndex] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    bool isChecked = (bool)checkBoxCell.Value;

                    if (isChecked)
                    {
                        await bookService.AddToFavorites((int)dgvBooks[0, e.RowIndex].Value);
                    } else
                    {
                        await bookService.RemoveFromFavorites((int)dgvBooks[0, e.RowIndex].Value);
                    }
                }
            } else if (e.ColumnIndex == 6)
            {
                dgvBooks.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if (dgvBooks[e.ColumnIndex, e.RowIndex] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    bool isChecked = (bool)checkBoxCell.Value;

                    if (isChecked)
                    {
                        await bookService.AddToCart((int)dgvBooks[0, e.RowIndex].Value, 1);
                    } else
                    {
                        await bookService.RemoveFromCart((int)dgvBooks[0, e.RowIndex].Value);
                    }
                }
            }
        }

        private void pbCart_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart();
            Close();
            formCart.Show();
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            Close();
            formProfile.Show();
        }
    }
}
