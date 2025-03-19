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
    public partial class FormReviewInfo : Form
    {
        private PictureBox[] stars;
        private int selectedStars;
        public FormReviewInfo(int bookId, string bookName, string author, string content, int rating, string createdAt)
        {
            InitializeComponent();
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
            }
            labelBookName.Text = bookName;
            labelAuthorValue.Text = author;
            tbReviewContent.Text = content;
            selectedStars = rating;
            labelCreatedAt.Text = createdAt.ToString();
            UpdateStars();
        }

        private void UpdateStars(int highlightUpTo = 0)
        {
            for (int i = 0; i < selectedStars; i++)
            {
                stars[i].Image = Image.FromFile(@"..\..\..\Resources\Images\star.png");
            }
        }
    }
}
