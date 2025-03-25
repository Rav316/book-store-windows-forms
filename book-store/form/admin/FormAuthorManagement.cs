using book_store.database.entity;
using book_store.dto.book;
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
using static System.Reflection.Metadata.BlobBuilder;

namespace book_store.form.admin
{
    public partial class FormAuthorManagement : Form
    {
        private readonly AuthorService authorService = new AuthorService();
        private List<Author> authors;
        public FormAuthorManagement()
        {
            InitializeComponent();
            dgvAuthors.ReadOnly = true;
            dgvAuthors.Columns[0].DataPropertyName = "Id";
            dgvAuthors.Columns[1].DataPropertyName = "FirstName";
            dgvAuthors.Columns[2].DataPropertyName = "MidName";
            dgvAuthors.Columns[3].DataPropertyName = "LastName";
            ViewAllAuthors();
        }

        private void FormAuthorManagement_Load(object sender, EventArgs e)
        {

        }

        private async void ViewAllAuthors()
        {
            authors = await authorService.FindAll();
            dgvAuthors.DataSource = authors;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text.ToLower();


            List<Author> filteredAuthors = authors
                .Where(author => $"{author.FirstName} {author.MidName} {author.LastName}".ToLower().Contains(searchText))
                .ToList();
            dgvAuthors.DataSource = filteredAuthors;
        }

        private void dgvAuthors_DoubleClick(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvAuthors.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                FormAuthorInfo formAuthorInfo = new FormAuthorInfo(((Author)dgvAuthors.CurrentRow!.DataBoundItem).Id);
                Close();
                formAuthorInfo.Show();
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FormManagement formManagement = new FormManagement();
            Close();
            formManagement.Show();
        }
    }
}
