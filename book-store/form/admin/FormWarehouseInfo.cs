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
    public partial class FormWarehouseInfo : Form
    {
        private readonly WarehouseService warehouseService = new WarehouseService();
        private int warehouseId;
        private Warehouse warehouse;
        public FormWarehouseInfo(int warehouseId)
        {
            this.warehouseId = warehouseId;
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

        private async void FormWarehouseInfo_Load(object sender, EventArgs e)
        {
            warehouse = (await warehouseService.FindById(warehouseId))!;
            tbId.Text = warehouse.Id.ToString();
            tbName.Text = warehouse.Name;
            tbAddress.Text = warehouse.Address;
        }

        private async void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Название склада не может быть пустым");
                return;
            }
            var existsWarehouse = warehouseService.FindByName(tbName.Text);
            if (existsWarehouse != null && existsWarehouse.Id != warehouse.Id)
            {
                MessageBox.Show($"Склад с названием {tbName.Text} уже существует");
                return;
            }
            warehouse.Name = tbName.Text;
            warehouse.Address = tbAddress.Text;
            await warehouseService.Update(warehouse);
            MessageBox.Show("Склад успешно обновлён ✅");
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить объект?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await warehouseService.Delete(warehouseId);
                MessageBox.Show("Склад успешно удалён ✅");
                OpenPreviousForm();
            }
        }
    }
}
