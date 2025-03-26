using book_store.database.entity;
using book_store.service;
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
        private readonly BookWarehouseService bookWarehouseService = new BookWarehouseService();
        private int bookId;
        private int warehouseId;
        private BookWarehouse bookWarehouse;
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
            tbBook.Text = bookId.ToString();
            tbWarehouse.Text = warehouseId.ToString();

            tbQuantity.Text = bookWarehouse.Quantity.ToString();
        }

        private async void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Количество книг на складе некорректное");
                return;
            }
            bookWarehouse.Quantity = quantity;
            await bookWarehouseService.Update(bookWarehouse);
            MessageBox.Show("Количество книг на складе успешно обновлено ✅");
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
