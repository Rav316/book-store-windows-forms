using book_store.dto.order;
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

namespace book_store.form
{
    public partial class FormOrderInfo : Form
    {
        private readonly BookService bookService = new BookService();
        private OrderProfileDto order;
        public FormOrderInfo(OrderProfileDto order)
        {
            this.order = order;
            InitializeComponent();

            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.ReadOnly = true;
            dgvBooks.Columns[0].DataPropertyName = "Id";
            dgvBooks.Columns[1].DataPropertyName = "Title";
            dgvBooks.Columns[2].DataPropertyName = "AuthorFullName";
            dgvBooks.Columns[3].DataPropertyName = "Image";
            dgvBooks.Columns[4].DataPropertyName = "Price";
            ViewAllBooks();
        }

        private void ViewAllBooks()
        {
            dgvBooks.DataSource = bookService.FindAllByOrder(order.Id);
        }

        private void FormOrderInfo_Load(object sender, EventArgs e)
        {
            labelOrder.Text = $"Заказ #{order.Id}";
            labelStatusValue.Text = order.OrderStatus;
            labelPaymentStatusValue.Text = order.PaymentStatus;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Close();
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
        }
    }
}
