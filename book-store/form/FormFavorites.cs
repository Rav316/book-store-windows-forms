using book_store.database.entity;
using book_store.dto.book;
using book_store.service;
using book_store.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_store.form
{
    public partial class FormFavorites : Form
    {
        private readonly BookService bookService = new BookService();
        private List<BookListDto> allBooks = new List<BookListDto>();
        int selectedRowIndex = -1;
        public FormFavorites()
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
            dgvBooks.Columns[7].DataPropertyName = "FavoriteItemId";
            dgvBooks.Columns[8].DataPropertyName = "CartItemId";
            dgvBooks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void ViewAllBooks()
        {
            allBooks = bookService.FindAllFavoritesWithUserInfo();
            allBooks.ForEach(book =>
            {
                book.image = ImageUtils.GetImageByPath(book.ImagePath);
            });
            dgvBooks.DataSource = allBooks;

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            OpenMainForm();
        }

        private void OpenMainForm()
        {
            Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void FormFavorites_Load(object sender, EventArgs e)
        {
            ViewAllBooks();
            UpdateGridViewVisibility();
        }

        private void UpdateGridViewVisibility()
        {
            if (dgvBooks.Rows.Count == 0)
            {
                dgvBooks.Visible = false;
                buttonClearFavorites.Visible = false;
                labelEmpty.Visible = true;
                buttonBackToMainForm.Visible = true;
            } else
            {
                dgvBooks.Visible = true;
                buttonClearFavorites.Visible = true;
                labelEmpty.Visible = false;
                buttonBackToMainForm.Visible = false;
            }
        }

        private void buttonBackToMainForm_Click(object sender, EventArgs e)
        {
            OpenMainForm();
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

        private void dgvBooks_DoubleClick(object sender, EventArgs e)
        {
            selectedRowIndex = dgvBooks.CurrentRow.Index;
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

                    if (!isChecked)
                    {
                        await bookService.RemoveFromFavorites((int)dgvBooks[0, e.RowIndex].Value);
                        var list = (List<BookListDto>)dgvBooks.DataSource;
                        list.RemoveAt(e.RowIndex);
                        dgvBooks.DataSource = null;
                        dgvBooks.DataSource = list;
                        UpdateGridViewVisibility();
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

        private void buttonClearFavorites_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы точно хотите удалить все книги из избранного?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bookService.RemoveAllFavoritesForCurrentUser();
                ViewAllBooks();
                UpdateGridViewVisibility();
                MessageBox.Show("Все книги удалены из избранного.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
