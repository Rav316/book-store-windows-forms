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
    public partial class FormAuthorCreate : Form
    {
        private readonly AuthorService authorService = new AuthorService();
        private Author author = new Author();
        public FormAuthorCreate()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            OpenPreviousForm();
        }

        private void OpenPreviousForm()
        {
            FormAuthorManagement formAuthorManagement = new FormAuthorManagement();
            Close();
            formAuthorManagement.Show();
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "")
            {
                MessageBox.Show("имя автора не может быть пустым");
                return;
            }
            if (tbLastName.Text == "")
            {
                MessageBox.Show("фамилия автора не может быть пустой");
                return;
            }
            if (dtpBirthDate.Checked)
            {
                if (dtpBirthDate.Value >= DateTime.Now)
                {
                    MessageBox.Show("Дата рождения автора не может быть больше текущей");
                    return;
                }
                author.BirthDate = dtpBirthDate.Value.ToUniversalTime();
            } else
            {
                author.BirthDate = null;
            }
            if (dtpDeathDate.Checked)
            {
                if (dtpDeathDate.Value >= DateTime.Now || dtpDeathDate.Value < dtpBirthDate.Value)
                {
                    MessageBox.Show("Введите корректную дату смерти");
                    return;
                }
                author.DeathDate = dtpDeathDate.Value.ToUniversalTime();
            } else
            {
                author.DeathDate = null;
            }

            author.FirstName = tbFirstName.Text;
            author.LastName = tbLastName.Text;
            author.MidName = tbMidName.Text;
            author.Nationality = tbNationality.Text;

            await authorService.Update(author);
            MessageBox.Show("Автор книги успешно создан ✅");
            OpenPreviousForm();
        }

        private void FormAuthorCreate_Load(object sender, EventArgs e)
        {
            dtpBirthDate.ShowCheckBox = true;
            dtpBirthDate.Checked = false;
            dtpDeathDate.ShowCheckBox = true;
            dtpDeathDate.Checked = false;
        }
    }
}
