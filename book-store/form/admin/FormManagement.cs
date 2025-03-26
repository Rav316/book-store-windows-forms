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
            FormBookManagement formBookManagement = new FormBookManagement();
            Close();
            formBookManagement.Show();
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            FormAuthorManagement formAuthorManagement = new FormAuthorManagement();
            Close();
            formAuthorManagement.Show();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            FormCategoryManagement formCategoryManagement = new FormCategoryManagement();
            Close();
            formCategoryManagement.Show();
        }

        private void buttonPublishers_Click(object sender, EventArgs e)
        {
            FormPublisherManagement formPublisherManagement = new FormPublisherManagement();
            Close();
            formPublisherManagement.Show();
        }
    }
}
