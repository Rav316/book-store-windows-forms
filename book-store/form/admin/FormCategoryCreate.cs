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
    public partial class FormCategoryCreate : Form
    {
        private readonly CategoryService categoryService = new CategoryService();
        private Category category = new Category();
        public FormCategoryCreate()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            OpenPreviousForm();
        }

        private void OpenPreviousForm()
        {
            FormCategoryManagement formCategoryManagement = new FormCategoryManagement();
            Close();
            formCategoryManagement.Show();
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Название категории не может быть пустым");
                return;
            }
            if (categoryService.FindByName(tbName.Text) != null)
            {
                MessageBox.Show($"Категория с названием {tbName.Text} уже существует");
                return;
            }
            category.Name = tbName.Text;
            await categoryService.Create(category);
            MessageBox.Show("Категория успешно создана ✅");
            OpenPreviousForm();
        }
    }
}
