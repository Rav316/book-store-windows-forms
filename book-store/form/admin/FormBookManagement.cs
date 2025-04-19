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
    public partial class FormBookManagement : Form
    {
        private readonly BookService bookService = new BookService();
        private List<BookManagementDto> books;
        public FormBookManagement()
        {
            InitializeComponent();
            dgvBooks.ReadOnly = true;
            dgvBooks.Columns[0].DataPropertyName = "Id";
            dgvBooks.Columns[1].DataPropertyName = "Title";
            dgvBooks.Columns[2].DataPropertyName = "Author";
        }

        private void FormBookManagement_Load(object sender, EventArgs e)
        {
            ViewAllBooks();
        }

        private async void ViewAllBooks()
        {
            books = await bookService.FindAllForManagement();
            dgvBooks.DataSource = books;
        }

        private void dgvBooks_DoubleClick(object sender, EventArgs e)
        {
            if(dgvBooks.CurrentRow == null)
            {
                return;
            }
            int selectedRowIndex = dgvBooks.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                FormBookInfoAdmin formBookInfo = new FormBookInfoAdmin(((BookManagementDto)dgvBooks.CurrentRow!.DataBoundItem).Id);
                Close();
                formBookInfo.Show();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text.ToLower();

            List<BookManagementDto> filteredBooks = books
                .Where(book => book.Title.ToLower().Contains(searchText))
                .ToList();
            dgvBooks.DataSource = filteredBooks;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FormManagement formManagement = new FormManagement();
            Close();
            formManagement.Show();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormBookCreate formBookCreate = new FormBookCreate();
            Close();
            formBookCreate.Show();
        }
    }
}
