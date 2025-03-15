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
    public partial class FormFavorites : Form
    {
        private readonly BookService bookService = new BookService();
        public FormFavorites()
        {
            InitializeComponent();
            InitializeComponent();
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.Columns[0].DataPropertyName = "Id";
            dgvBooks.Columns[1].DataPropertyName = "BookName";
            dgvBooks.Columns[2].DataPropertyName = "AuthorName";
            dgvBooks.Columns[3].DataPropertyName = "Image";
            dgvBooks.Columns[4].DataPropertyName = "Price";
            dgvBooks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}
