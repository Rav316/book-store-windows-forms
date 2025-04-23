using book_store.database.entity;
using book_store.database.repository;
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
    public partial class FormWarehouseManagement : Form
    {
        private readonly WarehouseService warehouseService = new WarehouseService();
        private List<Warehouse> warehouses;
        public FormWarehouseManagement()
        {
            InitializeComponent();
            dgvWarehouses.ReadOnly = true;
            dgvWarehouses.Columns[0].DataPropertyName = "Id";
            dgvWarehouses.Columns[1].DataPropertyName = "Name";
            dgvWarehouses.Columns[2].DataPropertyName = "Address";
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

            List<Warehouse> filteredWarehouses = warehouses
                .Where(warehouse => warehouse.Name.ToLower().Contains(searchText))
                .ToList();
            dgvWarehouses.DataSource = filteredWarehouses;
        }

        private async void FormWarehouseManagement_Load(object sender, EventArgs e)
        {
            warehouses = await warehouseService.FindAll();
            dgvWarehouses.DataSource = warehouses;
        }

        private void dgvWarehouses_DoubleClick(object sender, EventArgs e)
        {
            if (dgvWarehouses.CurrentRow == null)
            {
                return;
            }
            int selectedRowIndex = dgvWarehouses.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                FormWarehouseInfo formWarehouseInfo = new FormWarehouseInfo(((Warehouse)dgvWarehouses.CurrentRow!.DataBoundItem).Id);
                Close();
                formWarehouseInfo.Show();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormWarehouseCreate formWarehouseCreate = new FormWarehouseCreate();
            Close();
            formWarehouseCreate.Show();
        }
    }
}
