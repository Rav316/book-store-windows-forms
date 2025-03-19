using book_store.context;
using book_store.database.entity;
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
    public partial class FormAddReview : Form
    {
        private BookReviewService bookReviewService = new BookReviewService();
        private PictureBox[] stars;
        private int selectedStars = 1;
        private int bookId;
        private string bookName;
        private string author;

        public BookReview CreatedReview { get;  private set; }
        public FormAddReview(int bookId, string bookName, string author)
        {
            InitializeComponent();
            this.bookId = bookId;
            this.bookName = bookName;
            this.author = author;
            stars =
            [
                pbStar1,
                pbStar2,
                pbStar3,
                pbStar4,
                pbStar5,
            ];
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Tag = i + 1;
                stars[i].MouseEnter += Star_MouseEnter;
                stars[i].MouseLeave += Star_MouseLeave;
                stars[i].Click += Star_Click;
            }
            UpdateStars();
            labelBookName.Text = bookName;
            labelAuthorValue.Text = author;
        }

        private void Star_MouseEnter(object sender, EventArgs e)
        {
            int hoverIndex = (int)((PictureBox)sender).Tag;
            UpdateStars(hoverIndex);
        }

        private void Star_MouseLeave(object sender, EventArgs e)
        {
            UpdateStars();
        }

        private void Star_Click(object sender, EventArgs e)
        {
            selectedStars = (int)((PictureBox)sender).Tag;
            UpdateStars();
        }

        private void UpdateStars(int highlightUpTo = 0)
        {
            for (int i = 0; i < stars.Length; i++)
            {
                if (i < (highlightUpTo > 0 ? highlightUpTo : selectedStars))
                {
                    stars[i].Image = Image.FromFile(@"..\..\..\Resources\Images\star.png");
                } else
                {
                    stars[i].Image = Image.FromFile(@"..\..\..\Resources\Images\empty-star.png"); ;
                }
            }
        }

        private async void buttonPublish_Click(object sender, EventArgs e)
        {
            if(tbReviewContent.Text.Equals(""))
            {
                MessageBox.Show("Напишите отзыв");
                return;
            }
            BookReview bookReview = new BookReview
            {
                BookId = bookId,
                UserId = SecurityContext.Authentication.Id,
                Content = tbReviewContent.Text,
                Rating = selectedStars
            };
            await bookReviewService.Create(bookReview);
            CreatedReview = bookReview;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
