using book_store.form.admin;
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
    public partial class FormManagement : Form
    {
        public FormManagement()
        {
            InitializeComponent();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBookManagement());
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAuthorManagement());
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            OpenForm(new FormCategoryManagement());
        }

        private void buttonPublishers_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPublisherManagement());
        }

        private void buttonWarehouses_Click(object sender, EventArgs e)
        {
            OpenForm(new FormWarehouseManagement());
        }

        private void buttonBookWarehouses_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBookWarehouseManagement());
        }

        private void buttonApp_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMain());
        }

        private void buttonReviews_Click(object sender, EventArgs e)
        {
            OpenForm(new FormReviewManagement());
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAdmin());
        }

        private void OpenForm(Form form)
        {
            Close();
            form.Show();
        }
    }
}
