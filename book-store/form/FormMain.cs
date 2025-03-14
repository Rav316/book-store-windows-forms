using book_store.entity;
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

namespace book_store.form
{
    public partial class FormMain : Form
    {
        private readonly BookService bookService = new BookService();
        private List<Book> books = new List<Book>();
        int selectedRowIndex = -1;
        public FormMain()
        {
            InitializeComponent();
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.Columns[0].DataPropertyName = "Id";
            dgvBooks.Columns[1].DataPropertyName = "BookName";
            dgvBooks.Columns[2].DataPropertyName = "AuthorName";
            dgvBooks.Columns[3].DataPropertyName = "Image";
            dgvBooks.Columns[4].DataPropertyName = "Price";
            dgvBooks.Columns[5].DataPropertyName = "IsInFavorites";
            dgvBooks.Columns[6].DataPropertyName = "IsInCart";
            dgvBooks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ViewAllBooks();
        }

        private void ViewAllBooks()
        {
            books = bookService.FindAllWithUserInfo();
            dgvBooks.DataSource = books;
        }

        private void dgvBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBooks.Columns[e.ColumnIndex].DataPropertyName == "Price" && e.RowIndex >= 0)
            {
                // Преобразуем значение в строку и добавляем символ рубля
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString() + " ₽";
                }
            }
        }
    }
}
