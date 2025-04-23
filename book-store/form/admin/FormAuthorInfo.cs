using book_store.database.entity;
using book_store.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_store.form.admin
{
    public partial class FormAuthorInfo : Form
    {
        private readonly AuthorService authorService = new AuthorService();
        private int authorId;
        private Author author;
        public FormAuthorInfo(int authorId)
        {
            this.authorId = authorId;
            InitializeComponent();
        }

        private async void FormAuthorInfo_Load(object sender, EventArgs e)
        {
            await LoadInfo();
        }

        private async Task LoadInfo()
        {
            author = (await authorService.FindById(authorId))!;

            tbId.Text = author.Id.ToString();
            tbFirstName.Text = author.FirstName;
            tbMidName.Text = author.MidName;
            tbLastName.Text = author.LastName;
            dtpBirthDate.ShowCheckBox = true;
            dtpBirthDate.Checked = false;
            if (author.BirthDate != null)
            {
                dtpBirthDate.Value = author.BirthDate.Value;
                dtpBirthDate.Checked = true;
            }
            dtpDeathDate.ShowCheckBox = true;
            dtpDeathDate.Checked = false;
            if (author.DeathDate != null)
            {
                dtpDeathDate.Value = author.DeathDate.Value;
                dtpDeathDate.Checked = true;
            }
            tbNationality.Text = author.Nationality;
        }

        private void OpenPreviousForm()
        {
            FormAuthorManagement formAuthorManagement = new FormAuthorManagement();
            Close();
            formAuthorManagement.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            OpenPreviousForm();
        }

        private async void buttonSaveChanges_Click(object sender, EventArgs e)
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
                if (dtpDeathDate.Value >= DateTime.Now || (dtpBirthDate.Checked && dtpDeathDate.Value < dtpBirthDate.Value))
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
            MessageBox.Show("Автор книги успешно обновлён ✅");
            await LoadInfo();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить объект?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await authorService.Delete(authorId);
                MessageBox.Show("Автор книги успешно удалён ✅");
                OpenPreviousForm();
            }
        }
    }
}
