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
        private readonly OrderService orderService = new OrderService();
        private List<BookCartDto> allBooks = new List<BookCartDto>();
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
            dgvBooks.Columns[8].DataPropertyName = "IsAvailable";
            dgvBooks.Columns[9].DataPropertyName = "AvailableQuantity";
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
            labelTotalSum.Text = $"{CalculateTotalSum()} ₽";

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
            UpdatePlaceOrderButtonState();
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

            if (dgvBooks.Columns[e.ColumnIndex].DataPropertyName == "Quantity" && e.RowIndex >= 0)
            {
                int availableQuantity = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["AvailableQuantity"].Value);
                if (int.TryParse(e.Value?.ToString(), out int quantity) && quantity > availableQuantity)
                {
                    dgvBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                } else
                {
                    dgvBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                }
                UpdatePlaceOrderButtonState();
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
                    if (int.TryParse(dgvBooks[e.ColumnIndex, e.RowIndex].Value.ToString(), out int quantity))
                    {
                        if (quantity < 0)
                        {
                            quantity = Math.Abs(quantity);
                            dgvBooks[e.ColumnIndex, e.RowIndex].Value = quantity;
                        }

                        int availableQuantity = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["AvailableQuantity"].Value);

                        if (quantity > availableQuantity)
                        {
                            dgvBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                        } else
                        {
                            dgvBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                        }

                        bookService.UpdateQuantityInCartForCurrentUser(
                            (int)dgvBooks[0, e.RowIndex].Value,
                            quantity
                        );

                        labelTotalSum.Text = $"{CalculateTotalSum()} ₽";

                        UpdatePlaceOrderButtonState();
                    }
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
                        var list = (List<BookCartDto>)dgvBooks.DataSource;
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

        private void UpdatePlaceOrderButtonState()
        {
            bool hasInvalidQuantity = false;
            bool hasUnavailableBooks = false;

            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                if (row.Cells["AvailableQuantity"].Value != null && row.Cells["Quantity"].Value != null)
                {
                    int availableQuantity = Convert.ToInt32(row.Cells["AvailableQuantity"].Value);
                    if (int.TryParse(row.Cells["Quantity"].Value.ToString(), out int quantity) && quantity > availableQuantity)
                    {
                        hasInvalidQuantity = true;
                    }
                }

                if (row.DefaultCellStyle.BackColor == Color.LightGray)
                {
                    hasUnavailableBooks = true;
                }
            }

            bool isEnabled = !(hasInvalidQuantity || hasUnavailableBooks);
            buttonPlaceOrder.Enabled = isEnabled;

            if (isEnabled)
            {
                buttonPlaceOrder.BackColor = ColorTranslator.FromHtml("#290247"); ;
                buttonPlaceOrder.ForeColor = Color.White;
            } else
            {
                buttonPlaceOrder.BackColor = Color.LightGray;
                buttonPlaceOrder.ForeColor = Color.Gray;
            }
        }

        private async void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            buttonPlaceOrder.Enabled = false;
            try
            {
                List<int> bookIds = allBooks
                    .Select(b => b.Id)
                    .ToList();
                await orderService.CreateOrderFromCartAsync(int.Parse(labelTotalSum.Text.Replace("₽", "")), bookIds);
                MessageBox.Show("Заказ успешно оформлен ✅");
                allBooks = bookService.FindAllInCartWithUserInfo();
                dgvBooks.DataSource = allBooks;
                UpdateGridViewVisibility();
            }
            finally
            {
                buttonPlaceOrder.Enabled = true;
            }
        }
    }
}
