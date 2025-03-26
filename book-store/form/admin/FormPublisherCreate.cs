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
    public partial class FormPublisherCreate : Form
    {
        private readonly PublisherService publisherService = new PublisherService();
        private Publisher publisher = new Publisher();
        public FormPublisherCreate()
        {
            InitializeComponent();
        }

        private void OpenPreviousForm()
        {
            FormPublisherManagement formPublisherManagement = new FormPublisherManagement();
            Close();
            formPublisherManagement.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            OpenPreviousForm();
        }

        private async void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Название издателя не может быть пустым");
                return;
            }
            if (publisherService.FindByName(tbName.Text) != null)
            {
                MessageBox.Show($"Издатель с названием {tbName.Text} уже существует");
                return;
            }
            publisher.Name = tbName.Text;
            await publisherService.Create(publisher);
            MessageBox.Show("издатель успешно создан ✅");
            OpenPreviousForm();
        }
    }
}
