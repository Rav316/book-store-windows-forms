using book_store.database.entity;
using book_store.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_store.form.admin
{
    public partial class FormWarehouseCreate : Form
    {
        private readonly WarehouseService warehouseService = new WarehouseService();
        private Warehouse warehouse = new Warehouse();
        public FormWarehouseCreate()
        {
            InitializeComponent();
        }

        private void OpenPreviousForm()
        {
            FormWarehouseManagement formWarehouseManagement = new FormWarehouseManagement();
            Close();
            formWarehouseManagement.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            OpenPreviousForm();
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Название издателя не может быть пустым");
                return;
            }
            if (warehouseService.FindByName(tbName.Text) != null)
            {
                MessageBox.Show($"Склад с названием {tbName.Text} уже существует");
                return;
            }
            warehouse.Name = tbName.Text;
            warehouse.Address = tbAddress.Text;
            await warehouseService.Create(warehouse);
            MessageBox.Show("Склад успешно создан ✅");
            OpenPreviousForm();
        }
    }
}
