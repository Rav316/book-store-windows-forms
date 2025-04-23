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

namespace book_store.form.admin
{
    public partial class FormPublisherManagement : Form
    {
        private readonly PublisherService publisherService = new PublisherService();
        private List<Publisher> publishers;
        public FormPublisherManagement()
        {
            InitializeComponent();
            dgvPublishers.ReadOnly = true;
            dgvPublishers.Columns[0].DataPropertyName = "Id";
            dgvPublishers.Columns[1].DataPropertyName = "Name";
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FormManagement formManagement = new FormManagement();
            Close();
            formManagement.Show();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text.ToLower();


            List<Publisher> filteredPublishers = publishers
                .Where(publisher => publisher.Name.ToLower().Contains(searchText))
                .ToList();
            dgvPublishers.DataSource = filteredPublishers;
        }

        private async void FormPublisherManagement_Load(object sender, EventArgs e)
        {
            publishers = await publisherService.FindAll();
            dgvPublishers.DataSource = publishers;
        }

        private void dgvPublishers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPublishers.CurrentRow == null)
            {
                return;
            }
            int selectedRowIndex = dgvPublishers.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                FormPublisherInfo formPublisherInfo = new FormPublisherInfo(((Publisher)dgvPublishers.CurrentRow!.DataBoundItem).Id);
                Close();
                formPublisherInfo.Show();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormPublisherCreate formPublisherCreate = new FormPublisherCreate();
            Close();
            formPublisherCreate.Show();
        }
    }
}
