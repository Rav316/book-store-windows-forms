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
    public partial class FormCategoryManagement : Form
    {
        private readonly CategoryService categoryService = new CategoryService();
        private List<Category> categories;
        public FormCategoryManagement()
        {
            InitializeComponent();
            dgvCategories.Columns[0].DataPropertyName = "Id";
            dgvCategories.Columns[1].DataPropertyName = "Name";
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


            List<Category> filteredCategories = categories
                .Where(category => category.Name.ToLower().Contains(searchText))
                .ToList();
            dgvCategories.DataSource = filteredCategories;
        }

        private async void FormCategoryManagement_Load(object sender, EventArgs e)
        {
            categories = await categoryService.FindAll();
            dgvCategories.DataSource = categories;
        }

        private void dgvCategories_DoubleClick(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvCategories.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                FormCategoryInfo formCategoryInfo = new FormCategoryInfo(((Category)dgvCategories.CurrentRow!.DataBoundItem).Id);
                Close();
                formCategoryInfo.Show();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormCategoryCreate formCategoryCreate = new FormCategoryCreate();
            Close();
            formCategoryCreate.Show();
        }
    }
}
