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
    }
}
