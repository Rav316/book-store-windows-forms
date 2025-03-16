using book_store.database.entity;
using book_store.exception;
using book_store.service;
using book_store.util;
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
        private readonly BookService bookService = new BookService();
        private int bookId;
        private bool isInFavorites;
        private bool isInCart;
        private Book book;
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
            pbBookImage.Image = ImageUtils.GetImageByPath(book.ImagePath);
            labelBookName.Text = book.Title;
            var author = book.Author;
            labelAuthor.Text = $"{author?.FirstName} {author?.LastName}";
            labelIdValue.Text = book.Id.ToString();
            labelPublisherValue.Text = book.Publisher?.Id.ToString();
            labelSeriesValue.Text = book.Series;
            labelYearOfPublishingValue.Text = book.YearOfPublishing.ToString();
            labelIsbnValue.Text = book.Isbn;
            labelNumberOfPages.Text = book.NumberOfPages.ToString();
            labelSizeValue.Text = book.Size;
            labelCoverTypeValue.Text = book.CoverType?.Type;
            labelCirculationValue.Text = book.Circulation.ToString();
            labelWeightValue.Text = book.Weight.ToString();
            labelAgeRestrictionValue.Text = $"{book.AgeRestrictions}+";
            tbBookDescription.Text = book.Description;
            labelPrice.Text = $"{book.Price} ₽";
            isInFavorites = bookService.IsInFavoritesForCurrentUser(bookId);
            isInCart = bookService.IsInCartForCurrentUser(bookId);

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
            } else
            {
                buttonInCart.Text = "Добавить в корзину";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void pbInFavorites_Click(object sender, EventArgs e)
        {
            if(isInFavorites)
            {
                bookService.RemoveFromFavorites(bookId);
                isInFavorites = false;
                pbInFavorites.Image = Image.FromFile(@"..\..\..\Resources\images\favorites-big.png");
            }
            else
            {
                bookService.AddToFavorites(bookId);
                isInFavorites = true;
                pbInFavorites.Image = Image.FromFile(@"..\..\..\Resources\images\marked-favorites-big.png");
            }
            
        }
    }
}
