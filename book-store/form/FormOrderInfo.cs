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
        private readonly OrderService orderService = new OrderService();
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
            dgvBooks.Columns[4].DataPropertyName = "TotalQuantity";
            ViewAllBooks();
            UpdateButtonVisibility();
        }

        private void UpdateButtonVisibility()
        {
            if(order.PaymentStatus == "оплачен" || order.OrderStatus == "отменён")
            {
                buttonCancelOrder.Hide();
                buttonPayOrder.Hide();
            } else
            {
                buttonCancelOrder.Show();
                buttonPayOrder.Show();
            }
        }

        private void ViewAllBooks()
        {
            dgvBooks.DataSource = bookService.FindAllByOrder(order.Id);
        }

        private void FormOrderInfo_Load(object sender, EventArgs e)
        {
            UpdateOrderInfo();
        }

        private void UpdateOrderInfo()
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

        private async void buttonPayOrder_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment(order.Id, order.Cost);
            if (formPayment.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Заказ успешно оплачен ✅");
                order = await orderService.FindById(order.Id);
                UpdateOrderInfo();
                UpdateButtonVisibility();
            }
        }

        private async void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите отменить заказ?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                await orderService.CancelOrder(order.Id);
                MessageBox.Show("Заказ отменен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                order = await orderService.FindById(order.Id);
                UpdateOrderInfo();
                UpdateButtonVisibility();
            }
        }
    }
}
