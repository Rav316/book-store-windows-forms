using book_store.database.entity;
using book_store.exception;
//using book_store.service;
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
    public partial class FormBookInfo : Form
    {
        //private readonly BookService bookService = new BookService();
        //private readonly AuthorService authorService = new AuthorService();
        private int bookId;
        private Book book;
        private Author author;
        public FormBookInfo(int bookId)
        {
            this.bookId = bookId;
            InitializeComponent();
        }

        private void FormBookInfo_Load(object sender, EventArgs e)
        {
            try
            {
                //book = bookService.FindById(bookId);
                //author = authorService.FindById(book.AuthorId);
            } 
            catch (EntityNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            //pbBookImage.Image = book.Image;
            //labelBookName.Text = book.BookName;
            labelAuthor.Text = $"{author.FirstName} {author.LastName}";
            labelId.Text = book.Id.ToString();
        }
    }
}
