using book_store.database.entity;
using book_store.dto.book;
using book_store.dto.bookReview;
using book_store.dto.bookWarehouse;
using book_store.service;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.ExpressionTranslators.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_store.form.admin
{
    public partial class FormReviewManagement : Form
    {
        private readonly BookReviewService bookReviewService = new BookReviewService();
        private readonly UserService userService = new UserService();
        private readonly BookService bookService = new BookService();
        private List<BookReviewManagementDto> bookReviews = new List<BookReviewManagementDto>();
        private List<User> users;
        private List<Book> books;
        public FormReviewManagement()
        {
            InitializeComponent();
            dgvReviews.ReadOnly = true;
            dgvReviews.Columns[0].DataPropertyName = "Id";
            dgvReviews.Columns[1].DataPropertyName = "UserId";
            dgvReviews.Columns[2].DataPropertyName = "BookId";
            dgvReviews.Columns[3].DataPropertyName = "Username";
            dgvReviews.Columns[4].DataPropertyName = "UserAvatar";
            dgvReviews.Columns[5].DataPropertyName = "Content";
            dgvReviews.Columns[6].DataPropertyName = "Rating";
            dgvReviews.Columns[7].DataPropertyName = "CreatedAt";
        }

        private async void FormReviewManagement_Load(object sender, EventArgs e)
        {
            users = await userService.FindAll();
            cbUser.DisplayMember = "Username";
            cbUser.ValueMember = "Id";
            users.Insert(0, new User { Id = 0, Username = "Все" });
            cbUser.DataSource = users;

            books = await bookService.FindAll();
            cbBook.DisplayMember = "Title";
            cbBook.ValueMember = "Id";
            books.Insert(0, new Book { Id = 0, Title = "Все" });
            cbBook.DataSource = books;

            LoadInfo();


        }

        private void LoadInfo()
        {
            bookReviews = bookReviewService.FindAll();
            dgvReviews.DataSource = bookReviews;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FormManagement formManagement = new FormManagement();
            Close();
            formManagement.Show();
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void UpdateFilter()
        {
            int selectedUser = cbUser.SelectedValue as int? ?? 0;
            int selectedBook = cbBook.SelectedValue as int? ?? 0;

            List<BookReviewManagementDto> filteredReviews = bookReviews
                                        .Where(book => selectedUser == 0 || book.UserId == selectedUser)
                                        .Where(book => selectedBook == 0 || book.BookId == selectedBook)
                                        .ToList();
            dgvReviews.DataSource = filteredReviews;
        }

        private void dgvReviews_DoubleClick(object sender, EventArgs e)
        {
            if(dgvReviews.CurrentRow == null)
            {
                return;
            }
            int selectedRowIndex = dgvReviews.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                var bookReview = (BookReviewManagementDto) dgvReviews.CurrentRow!.DataBoundItem;
                FormEditReview formEditReview = new FormEditReview(bookReview.Id);

                DialogResult dialogResult = formEditReview.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Отзыв успшено изменён ✅");
                    LoadInfo();
                } else if (dialogResult == DialogResult.Abort)
                {
                    MessageBox.Show("Отзыв успшено удалён ✅");
                    LoadInfo();
                }
            }
        }
    }
}
