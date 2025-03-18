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

namespace book_store.form
{
    public partial class FormCart : Form
    {
        private readonly BookService bookService = new BookService();
        private List<BookListDto> allBooks = new List<BookListDto>();
        int selectedRowIndex = -1;
        public FormCart()
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
            dgvBooks.Columns[7].DataPropertyName = "Quantity";
            dgvBooks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void ViewAllBooks()
        {
            allBooks = bookService.FindAllInCartWithUserInfo();
            allBooks.ForEach(book =>
            {
                book.image = ImageUtils.GetBookImageByPath(book.ImagePath);
            });
            dgvBooks.DataSource = allBooks;
            labelTotalSum.Text =  $"{CalculateTotalSum()} ₽";

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

        private void UpdateGridViewVisibility()
        {
            if (dgvBooks.Rows.Count == 0)
            {
                dgvBooks.Visible = false;
                labelResult.Visible = false;
                labelTotalSum.Visible = false;
                buttonPlaceOrder.Visible = false;
                labelEmpty.Visible = true;
                buttonBackToMainForm.Visible = true;
            } else
            {
                dgvBooks.Visible = true;
                labelResult.Visible = true;
                labelTotalSum.Visible = true;
                buttonPlaceOrder.Visible = true;
                labelEmpty.Visible = false;
                buttonBackToMainForm.Visible = false;
            }
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            ViewAllBooks();
            UpdateGridViewVisibility();
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

        private void dgvBooks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                if (dgvBooks[e.ColumnIndex, e.RowIndex] is DataGridViewTextBoxCell textBoxCell)
                {
                    bookService.UpdateQuantityInCartForCurrentUser(
                        (int)dgvBooks[0, e.RowIndex].Value, (int)dgvBooks[e.ColumnIndex, e.RowIndex].Value
                    );
                    labelTotalSum.Text = $"{CalculateTotalSum()} ₽";
                }
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

                    if (!isChecked)
                    {
                        await bookService.RemoveFromCart((int)dgvBooks[0, e.RowIndex].Value);
                        var list = (List<BookListDto>)dgvBooks.DataSource;
                        list.RemoveAt(e.RowIndex);
                        dgvBooks.DataSource = null;
                        dgvBooks.DataSource = list;
                        UpdateGridViewVisibility();
                        labelTotalSum.Text = $"{CalculateTotalSum()} ₽";
                    }
                }
            }
        }

        private void dgvBooks_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvBooks.CancelEdit();
            MessageBox.Show("Введите корректное положительное число.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.Cancel = false;
        }

        private int CalculateTotalSum()
        {
            int totalSum = 0;
            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[5].Value != null)
                {
                    if (int.TryParse(row.Cells[4].Value.ToString(), out int value1) &&
                        int.TryParse(row.Cells[7].Value.ToString(), out int value2))
                    {
                        totalSum += value1 * value2;
                    }
                }
            }
            return totalSum;
        }
    }
}
