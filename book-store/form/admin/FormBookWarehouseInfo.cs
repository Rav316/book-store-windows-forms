using book_store.database.entity;
using book_store.service;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace book_store.form.admin
{
    public partial class FormBookWarehouseInfo : Form
    {
        private readonly BookService bookService = new BookService();
        private readonly WarehouseService warehouseService = new WarehouseService();
        private readonly BookWarehouseService bookWarehouseService = new BookWarehouseService();
        private List<Warehouse> warehouses;
        private int bookId;
        private int warehouseId;
        private int currentQuantity;
        private BookWarehouse bookWarehouse;
        private Book book;
        public FormBookWarehouseInfo(int bookId, int warehouseId)
        {
            this.bookId = bookId;
            this.warehouseId = warehouseId;
            InitializeComponent();
        }

        private void OpenPreviousForm()
        {
            FormBookWarehouseManagement formBookWarehouseManagement = new FormBookWarehouseManagement();
            Close();
            formBookWarehouseManagement.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            OpenPreviousForm();
        }

        private async void FormBookWarehouseInfo_Load(object sender, EventArgs e)
        {
            bookWarehouse = (await bookWarehouseService.FindByBookAndWarehouse(bookId, warehouseId))!;

            book = (await bookService.FindById(bookId))!;
            tbBook.Text = book.Title;

            warehouses = await warehouseService.FindAll();
            cbWarehouse.DisplayMember = "Name";
            cbWarehouse.ValueMember = "Id";
            cbWarehouse.DataSource = warehouses;
            cbWarehouse.SelectedValue = warehouseId;

            currentQuantity = bookWarehouse.Quantity;
            tbQuantity.Text = currentQuantity.ToString();
        }

        private async void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Количество книг на складе некорректное");
                return;
            }
            int newWarehouseId = (int)cbWarehouse.SelectedValue!;
            if(newWarehouseId != warehouseId)
            {
                if(quantity > currentQuantity)
                {
                    MessageBox.Show("Недостаточно книг на исходном складе.");
                    return;
                }
                bookWarehouse.Quantity -= quantity;
                if(bookWarehouse.Quantity == 0)
                {
                    await bookWarehouseService.Delete(bookId, warehouseId);
                }
                else
                {
                    await bookWarehouseService.Update(bookWarehouse);
                }
                var newEntry = await bookWarehouseService.FindByBookAndWarehouse(bookId, newWarehouseId);
                if(newEntry != null)
                {
                    newEntry.Quantity += quantity;
                    await bookWarehouseService.Update(newEntry);
                }
                else
                {
                    var created = new BookWarehouse
                    {
                        BookId = bookId,
                        WarehouseId = newWarehouseId,
                        Quantity = quantity
                    };
                    await bookWarehouseService.Create(created);
                }
                warehouseId = newWarehouseId;
                bookWarehouse = (await bookWarehouseService.FindByBookAndWarehouse(bookId, warehouseId))!;
                currentQuantity = bookWarehouse.Quantity;
                tbQuantity.Text = currentQuantity.ToString();
                cbWarehouse.SelectedValue = warehouseId;

                MessageBox.Show("Перемещение книг успешно завершено ✅");
            } else
            {
                bookWarehouse.Quantity = quantity;
                await bookWarehouseService.Update(bookWarehouse);

                warehouseId = newWarehouseId;
                currentQuantity = quantity;
                bookWarehouse = (await bookWarehouseService.FindByBookAndWarehouse(bookId, warehouseId))!;
                MessageBox.Show("Количество книг на складе успешно обновлено ✅");
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить объект?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await bookWarehouseService.Delete(bookId, warehouseId);
                MessageBox.Show("Книга успешно удалена со склада ✅");
                OpenPreviousForm();
            }
        }
    }
}
