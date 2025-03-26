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
using static System.Reflection.Metadata.BlobBuilder;

namespace book_store.form.admin
{
    public partial class FormBookWarehouseCreate : Form
    {
        private readonly BookWarehouseService bookWarehouseService = new BookWarehouseService();
        private readonly BookService bookService = new BookService();
        private readonly WarehouseService warehouseService = new WarehouseService();
        private BookWarehouse bookWarehouse = new BookWarehouse();
        private List<Book> books;
        private List<Warehouse> warehouses;
        public FormBookWarehouseCreate()
        {
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

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Количество книг на складе некорректное");
                return;
            }
            int bookId = (int)cbBook.SelectedValue!;
            int warehouseId = (int)cbWarehouse.SelectedValue!;
            var byBookAndWarehouse = await bookWarehouseService.FindByBookAndWarehouse(bookId, warehouseId);
            if (byBookAndWarehouse != null)
            {
                MessageBox.Show($"Книга с id {bookId} уже существует на складе {warehouseId}");
                return;
            }
            bookWarehouse.BookId = (int)cbBook.SelectedValue!;
            bookWarehouse.WarehouseId = (int)cbWarehouse.SelectedValue!;
            await bookWarehouseService.Create(bookWarehouse);
            MessageBox.Show("Книга успешно добавлена на склад ✅");
            OpenPreviousForm();
        }

        private async void FormBookWarehouseCreate_Load(object sender, EventArgs e)
        {
            books = await bookService.FindAll();
            cbBook.DisplayMember = "Id";
            cbBook.ValueMember = "Id";
            cbBook.DataSource = books;

            warehouses = await warehouseService.FindAll();
            cbWarehouse.DisplayMember = "Id";
            cbWarehouse.ValueMember = "Id";
            cbWarehouse.DataSource = warehouses;
        }
    }
}
