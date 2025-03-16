using book_store.database.entity;
using book_store.dto.book;
using book_store.service;
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
        //private readonly FavoritesService favoritesService = new FavoritesService();
        //private List<BookFavoriteDto> favoriteBooks;
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
            dgvBooks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void FormFavorites_Load(object sender, EventArgs e)
        {
            //favoriteBooks = bookService.FindAllFavoritesByUser();
            dgvBooks.DataSource = null;
            //dgvBooks.DataSource = favoriteBooks;
            CheckAllBoxes();
        }

        private void CheckAllBoxes()
        {
            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells[5].Value = true;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CheckAllBoxes();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Если пользователь нажал "Да"
            if (result == DialogResult.Yes)
            {
                List<int> listForDeletion = new List<int>();
                List<int> listForAddition = new List<int>();

                foreach (DataGridViewRow row in dgvBooks.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if ((bool)row.Cells[5].Value)
                        {
                            listForAddition.Add((int)row.Cells[0].Value);
                        } else
                        {
                            listForDeletion.Add((int)row.Cells[0].Value);
                        }
                    }
                }

                //await favoritesService.DeleteByIdsAsync(listForDeletion);
            } else
            {
                // Если пользователь выбрал "Нет", отменяем операцию
                return;
            }
        }

    }
}
