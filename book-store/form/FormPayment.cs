using book_store.database.entity;
using book_store.service;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace book_store.form
{
    public partial class FormPayment : Form
    {
        private readonly OrderService orderService = new OrderService();
        private int orderId;
        private int orderCost;
        public FormPayment(int orderId, int orderCost)
        {
            this.orderId = orderId;
            this.orderCost = orderCost;
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void buttonPay_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tbMonth.Text, out int month) && int.TryParse(tbYear.Text, out int year))
            {
                if(month < 0 || month > 12)
                {
                    MessageBox.Show("Введите корректный месяц");
                    return;
                }
                int lastDay = DateTime.DaysInMonth(year, month);
                DateTime expirationDate = new DateTime(2000 + year, month, lastDay);
                if (expirationDate < DateTime.Now)
                {
                    MessageBox.Show("Срок действия карты некорректный");
                    return;
                }
                await orderService.PayForTheOrder(new PaymentDetail
                {
                    OrderId = orderId,
                    CardNumber = tbCardNumber.Text,
                    ExpirationDate = expirationDate,
                    Code = short.Parse(tbCode.Text)
                });
                this.DialogResult = DialogResult.OK;
                Close();
            } else
            {
                MessageBox.Show("Введите корректный месяц и год");
            }
           
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            labelOrderInfo.Text = $"Оплата заказа #{orderId} на сумму {orderCost} ₽";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
