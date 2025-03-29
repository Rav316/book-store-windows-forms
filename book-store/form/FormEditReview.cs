using book_store.context;
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

namespace book_store.form
{
    public partial class FormEditReview : Form
    {
        private BookReviewService bookReviewService = new BookReviewService();
        private PictureBox[] stars;
        private int selectedStars = 0;
        private int bookId;
        private BookReview bookReview;
        public FormEditReview(int bookId, string bookName, string author, BookReview bookReview)
        {
            InitializeComponent();
            this.bookId = bookId;
            this.bookReview = bookReview;
            labelBookName.Text = bookName;
            labelAuthorValue.Text = author;
            selectedStars = bookReview.Rating;
            tbReviewContent.Text = bookReview.Content;
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

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            if (tbReviewContent.Text.Equals(""))
            {
                MessageBox.Show("Напишите отзыв");
                return;
            }
            bookReview.Content = tbReviewContent.Text;
            bookReview.Rating = selectedStars;
            bookReview.CreatedAt = bookReview.CreatedAt.ToUniversalTime();
            bookReview.UpdatedAt = DateTime.Now.ToUniversalTime();
            await bookReviewService.Update(bookReview);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить объект?", "Подтверждение",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await bookReviewService.Delete(bookReview.Id);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }
    }
}
