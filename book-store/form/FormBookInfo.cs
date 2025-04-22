using book_store.database.entity;
using book_store.database.repository;
using book_store.dto.bookReview;
using book_store.exception;
using book_store.service;
using book_store.util;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace book_store.form
{
    public partial class FormBookInfo : Form
    {
        private readonly BookService bookService = new BookService();
        private readonly BookReviewService bookReviewService = new BookReviewService();
        private int bookId;
        private bool isInFavorites;
        private bool isInCart;
        private bool isBookAvailable;
        private Book book;
        private List<BookReviewListDto> bookReviews;
        private BookReview? bookReview;
        private bool hasReview = false;
        private bool isBookPurchased;
        public FormBookInfo(int bookId)
        {
            this.bookId = bookId;
            InitializeComponent();
        }

        private void FormBookInfo_Load(object sender, EventArgs e)
        {
            try
            {
                book = Task.Run(() => bookService.FindById(bookId)).Result;
            } catch (EntityNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            pbBookImage.Image = ImageUtils.GetBookImageByPath(book.ImagePath);
            labelBookName.Text = book.Title;
            var author = book.Author;
            labelAuthor.Text = $"{author?.FirstName} {author?.LastName}";
            labelIdValue.Text = book.Id.ToString();
            labelPublisherValue.Text = book.Publisher?.Id.ToString();
            labelSeriesValue.Text = book.Series;
            labelYearOfPublishingValue.Text = book.YearOfPublishing.ToString();
            labelIsbnValue.Text = book.Isbn;
            labelNumberOfPages.Text = book.NumberOfPages.ToString();
            labelSizeValue.Text = $"{book.Height} см x {book.Width} см x {book.Length} см";
            labelCoverTypeValue.Text = book.CoverType?.Type;
            labelCirculationValue.Text = book.Circulation.ToString();
            labelWeightValue.Text = book.Weight.ToString();
            labelAgeRestrictionValue.Text = $"{book.AgeRestrictions}+";
            tbBookDescription.Text = book.Description;
            labelPrice.Text = $"{book.Price} ₽";
            isInFavorites = bookService.IsInFavoritesForCurrentUser(bookId);
            isInCart = bookService.IsInCartForCurrentUser(bookId);
            isBookAvailable = bookService.IsBookAvailable(bookId);
            isBookPurchased = bookService.IsBookPurchased(bookId);

            if (isInFavorites)
            {
                pbInFavorites.Image = Image.FromFile(@"..\..\..\Resources\images\marked-favorites-big.png");
            } else
            {
                pbInFavorites.Image = Image.FromFile(@"..\..\..\Resources\images\favorites-big.png");
            }

            if (isInCart)
            {
                buttonInCart.Text = "Удалить из корзины";
            } 
            else if(!isInCart && isBookAvailable)
            {
                buttonInCart.Text = "Добавить в корзину";
            } else if(!isInCart && !isBookAvailable)
            {
                buttonInCart.Text = "Нет в наличии";
                buttonInCart.Enabled = false;
                buttonInCart.BackColor = Color.LightGray;
                buttonInCart.ForeColor = Color.Gray;
            }

            cbOrderByDate.SelectedIndex = 0;
            cbOrderByRating.SelectedIndex = 0;


            dgvReviews.AutoGenerateColumns = false;
            dgvReviews.ReadOnly = true;
            dgvReviews.Columns[0].DataPropertyName = "Id";
            dgvReviews.Columns[1].DataPropertyName = "Username";
            dgvReviews.Columns[2].DataPropertyName = "UserAvatar";
            dgvReviews.Columns[3].DataPropertyName = "Content";
            dgvReviews.Columns[4].DataPropertyName = "Rating";
            dgvReviews.Columns[5].DataPropertyName = "CreatedAt";
            bookReview = bookReviewService.FindByBookAndUser(bookId);
            hasReview = bookReview != null;

            if (!isBookPurchased)
            {
                buttonAddReview.Visible = false;
            }

            ViewAllReviews();
        }

        private void ViewAllReviews()
        {
            if (hasReview)
            {
                buttonAddReview.Text = "Изменить отзыв";
            } else
            {
                buttonAddReview.Text = "Написать отзыв";
            }
            bookReviews = bookReviewService.GetReviewsByBook(bookId);
            dgvReviews.DataSource = bookReviews;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void pbInFavorites_Click(object sender, EventArgs e)
        {
            if (isInFavorites)
            {
                await bookService.RemoveFromFavorites(bookId);
                isInFavorites = false;
                pbInFavorites.Image = Image.FromFile(@"..\..\..\Resources\images\favorites-big.png");
            } else
            {
                await bookService.AddToFavorites(bookId);
                isInFavorites = true;
                pbInFavorites.Image = Image.FromFile(@"..\..\..\Resources\images\marked-favorites-big.png");
            }

        }

        private async void buttonInCart_Click(object sender, EventArgs e)
        {
            if (isInCart)
            {
                await bookService.RemoveFromCart(bookId);
                isInCart = false;
                if(isBookAvailable)
                {
                    buttonInCart.Text = "Добавить в корзину";
                } else
                {
                    buttonInCart.Text = "Нет в наличии";
                    buttonInCart.Enabled = false;
                    buttonInCart.BackColor = Color.LightGray;
                    buttonInCart.ForeColor = Color.Gray;
                }
            } else
            {
                await bookService.AddToCart(bookId, 1);
                isInCart = true;
                buttonInCart.Text = "Удалить из корзины";
            }
        }

        private void cbOrderByDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortReviews();
        }

        private void cbOrderByRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortReviews();
        }

        private void SortReviews()
        {
            int dateSort = cbOrderByDate.SelectedIndex;
            int ratingSort = cbOrderByRating.SelectedIndex;

            var sortedReviews = bookReviews?.ToList();

            if (dateSort == 1)
                sortedReviews = sortedReviews?.OrderByDescending(r => r.CreatedAt).ToList();
            else if (dateSort == 2)
                sortedReviews = sortedReviews?.OrderBy(r => r.CreatedAt).ToList();

            if (ratingSort == 1)
                sortedReviews = sortedReviews?.OrderByDescending(r => r.Rating).ToList();
            else if (ratingSort == 2)
                sortedReviews = sortedReviews?.OrderBy(r => r.Rating).ToList();

            dgvReviews.DataSource = sortedReviews;
        }

        private void buttonAddReview_Click(object sender, EventArgs e)
        {
            if (hasReview)
            {
                FormEditReview formEditReview = new FormEditReview(bookId, labelBookName.Text, labelAuthor.Text, bookReview);
                DialogResult dialogResult = formEditReview.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Отзыв успшено изменён ✅");
                    ViewAllReviews();
                } else if (dialogResult == DialogResult.Abort)
                {
                    MessageBox.Show("Отзыв успшено удалён ✅");
                    hasReview = false;
                    ViewAllReviews();
                }

            } else
            {
                using (FormAddReview formAddReview = new FormAddReview(bookId, labelBookName.Text, labelAuthor.Text))
                {
                    if (formAddReview.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Отзыв успшено опубликован ✅");
                        bookReview = formAddReview.CreatedReview;
                        hasReview = true;
                        ViewAllReviews();
                    }
                }
            }
            
            
        }

        private void dgvReviews_DoubleClick(object sender, EventArgs e)
        {
            if(dgvReviews.CurrentRow == null)
            {
                return;
            }
            int selectedRowIndex = dgvReviews.CurrentRow.Index;
            if(selectedRowIndex >= 0)
            {
                
                FormReviewInfo formReviewInfo = new FormReviewInfo(
                    bookId,
                    book.Title,
                    labelAuthor.Text,
                    dgvReviews[1, selectedRowIndex].Value.ToString(),
                    dgvReviews[3, selectedRowIndex].Value.ToString(),
                    (int)dgvReviews[4, selectedRowIndex].Value,
                    dgvReviews[5, selectedRowIndex].Value.ToString()
                );
                formReviewInfo.ShowDialog();
            }
        }
    }
}
