using book_store.database.entity;
using book_store.dto.book;
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

namespace book_store.form.admin
{
    public partial class FormBookWarehouseManagement : Form
    {
        private readonly BookWarehouseService bookWarehouseService = new BookWarehouseService();
        private readonly BookService bookService = new BookService();
        private readonly WarehouseService warehouseService = new WarehouseService();
        private List<BookWarehouse> bookWarehouses;
        private List<Book> books;
        private List<Warehouse> warehouses;
        public FormBookWarehouseManagement()
        {
            InitializeComponent();
            dgvBookWarehouses.AutoGenerateColumns = false;
            dgvBookWarehouses.Columns[0].DataPropertyName = "Id";
            dgvBookWarehouses.Columns[1].DataPropertyName = "BookId";
            dgvBookWarehouses.Columns[2].DataPropertyName = "WarehouseId";
            dgvBookWarehouses.Columns[3].DataPropertyName = "Quantity";
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FormManagement formManagement = new FormManagement();
            Close();
            formManagement.Show();
        }

        private async void FormBookWarehouseManagement_Load(object sender, EventArgs e)
        {
            bookWarehouses = await bookWarehouseService.FindAll();
            dgvBookWarehouses.DataSource = bookWarehouses;

            books = await bookService.FindAll();
            cbBook.DisplayMember = "Title";
            cbBook.ValueMember = "Id";
            books.Insert(0, new Book
            {
                Id = 0,
                Title = "Все"
            });
            cbBook.DataSource = books;
            cbBook.SelectedValue = 0;

            warehouses = await warehouseService.FindAll();
            warehouses.Insert(0, new Warehouse
            {
                Id = 0,
                Name = "Все"
            });
            cbWarehouse.DisplayMember = "Name";
            cbWarehouse.ValueMember = "Id";
            cbWarehouse.DataSource = warehouses;
            cbWarehouse.SelectedValue = 0;
        }

        private void dgvBookWarehouses_DoubleClick(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvBookWarehouses.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                var bookWarehouse = (BookWarehouse)dgvBookWarehouses.CurrentRow!.DataBoundItem;
                FormBookWarehouseInfo formBookWarehouseInfo = new FormBookWarehouseInfo(
                    bookWarehouse.BookId, bookWarehouse.WarehouseId
                );
                Close();
                formBookWarehouseInfo.Show();
            }
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void cbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void UpdateFilter()
        {
            int selectedBook = cbBook.SelectedValue as int? ?? 0;
            int selectedWarehouse = cbWarehouse.SelectedValue as int? ?? 0;

            List<BookWarehouse> filteredBookWarehouses = bookWarehouses
                                        .Where(bw => selectedBook == 0 || bw.BookId == selectedBook)
                                        .Where(bw => selectedWarehouse == 0 || bw.WarehouseId == selectedWarehouse)
                                        .ToList();
            dgvBookWarehouses.DataSource = filteredBookWarehouses;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormBookWarehouseCreate formBookWarehouseCreate = new FormBookWarehouseCreate();
            Close();
            formBookWarehouseCreate.Show();
        }
    }
}
