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
    public partial class FormPublisherInfo : Form
    {
        private readonly PublisherService publisherService = new PublisherService();
        private int publisherId;
        private Publisher publisher;
        public FormPublisherInfo(int publisherId)
        {
            this.publisherId = publisherId;
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            OpenPreviousForm();
        }

        private void OpenPreviousForm()
        {
            FormPublisherManagement formPublisherManagement = new FormPublisherManagement();
            Close();
            formPublisherManagement.Show();
        }

        private async void FormPublisherInfo_Load(object sender, EventArgs e)
        {
            publisher = (await publisherService.FindById(publisherId))!;
            tbId.Text = publisher.Id.ToString();
            tbName.Text = publisher.Name;
        }

        private async void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Название издателя не может быть пустым");
                return;
            }
            var existsPublisher = publisherService.FindByName(tbName.Text);
            if (existsPublisher != null && existsPublisher.Id != publisher.Id)
            {
                MessageBox.Show($"Издатель с названием {tbName.Text} уже существует");
                return;
            }
            publisher.Name = tbName.Text;
            await publisherService.Update(publisher);
            MessageBox.Show("издатель успешно обновлён ✅");
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить объект?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await publisherService.Delete(publisherId);
                MessageBox.Show("Издатель успешно удалён ✅");
                OpenPreviousForm();
            }
        }
    }
}
