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
    public partial class FormCategoryInfo : Form
    {
        private readonly CategoryService categoryService = new CategoryService();
        private int categoryId;
        private Category category;
        public FormCategoryInfo(int categoryId)
        {
            this.categoryId = categoryId;
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

        private async void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Название категории не может быть пустым");
                return;
            }
            var existsCategory = categoryService.FindByName(tbName.Text);
            if (existsCategory != null && existsCategory.Id != category.Id  )
            {
                MessageBox.Show($"Категория с названием {tbName.Text} уже существует");
                return;
            }
            category.Name = tbName.Text;
            await categoryService.Update(category);
            MessageBox.Show("Категория успешно обновлена ✅");
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить объект?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await categoryService.Delete(categoryId);
                MessageBox.Show("Категория успешно удалена ✅");
                OpenPreviousForm();
            }
        }

        private async void FormCategoryInfo_Load(object sender, EventArgs e)
        {
            category = (await categoryService.FindById(categoryId))!;
            tbId.Text = category.Id.ToString();
            tbName.Text = category.Name;
        }
    }
}
