﻿using book_store.context;
using book_store.database.entity;
using book_store.dto.book;
using book_store.dto.order;
using book_store.exception;
using book_store.service;
using book_store.util;
using book_store.validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_store.form
{
    public partial class FormProfile : Form
    {
        private readonly UserService userService = new UserService();
        private readonly BookReviewService bookReviewService = new BookReviewService();
        private readonly OrderService orderService = new OrderService();
        private List<OrderProfileDto> orders;
        private string fileName;
        public FormProfile()
        {
            InitializeComponent();
        }

        private void OpenMainForm()
        {
            Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            OpenMainForm();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            User authenticatedUser = SecurityContext.Authentication;
            tbUsername.Text = authenticatedUser.Username;
            tbEmail.Text = authenticatedUser.Email;
            tbAddress.Text = authenticatedUser.Address;
            pbAvatar.Image = ImageUtils.GetUserAvatarByPath(authenticatedUser.ImagePath);

            dgvReviews.AutoGenerateColumns = false;
            dgvReviews.ReadOnly = true;
            dgvReviews.Columns[0].DataPropertyName = "Id";
            dgvReviews.Columns[1].DataPropertyName = "BookId";
            dgvReviews.Columns[2].DataPropertyName = "BookName";
            dgvReviews.Columns[3].DataPropertyName = "Author";
            dgvReviews.Columns[4].DataPropertyName = "BookImage";
            dgvReviews.Columns[5].DataPropertyName = "Content";
            dgvReviews.Columns[6].DataPropertyName = "Rating";
            dgvReviews.Columns[7].DataPropertyName = "CreatedAt";
            dgvReviews.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvOrders.ReadOnly = true;
            dgvOrders.Columns[0].DataPropertyName = "Id";
            dgvOrders.Columns[1].DataPropertyName = "PaymentMethod";
            dgvOrders.Columns[2].DataPropertyName = "PaymentStatus";
            dgvOrders.Columns[3].DataPropertyName = "OrderStatus";
            dgvOrders.Columns[4].DataPropertyName = "Cost";
            dgvOrders.Columns[5].DataPropertyName = "PaidIn";
            dgvOrders.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            ViewAllReviews();
            ViewAllOrders();
        }

        private void ViewAllOrders()
        {
            orders = orderService.FindAllForCurrentUser();
            dgvOrders.DataSource = orders;
        }

        private void ViewAllReviews()
        {
            dgvReviews.DataSource = bookReviewService.GetReviewsForCurrentUser();
        }

        private void buttonEditAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbAvatar.Image = new Bitmap(openFileDialog.FileName);
                    fileName = openFileDialog.FileName;
                }
            }
        }

        private async void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Equals(""))
            {
                MessageBox.Show("Заполните имя пользователя");
                return;
            }
            if (!tbNewPassword.Text.Equals(""))
            {
                if (!tbNewPassword.Text.Equals(tbConfirmNewPassword.Text))
                {
                    MessageBox.Show("Повторённый новый пароль не совпадает с новым паролем");
                    return;
                }
                if (!PasswordValidator.IsValid(tbNewPassword.Text))
                {
                    MessageBox.Show("Пароль должен быть длиной минимум 6 символов, содержать спец. символы, цифры и заглавные буквы");
                    return;
                }
            }
            if (!EmailValidator.IsValid(tbEmail.Text))
            {
                MessageBox.Show("email некорректный");
                return;
            }
            try
            {
                await userService.UpdateUser(tbUsername.Text, tbCurrentPassword.Text, tbNewPassword.Text, tbEmail.Text, tbAddress.Text, fileName);
                MessageBox.Show("Профиль успешно обновлён ✅");
            } catch (Exception ex) when (ex is AuthenticationException || ex is ArgumentException)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            using (FormDeleteAccount confirmForm = new FormDeleteAccount())
            {
                if (confirmForm.ShowDialog() == DialogResult.OK)
                {
                    string password = confirmForm.EnteredPassword;
                    try
                    {
                        await userService.DeleteProfile(password);
                        Close();
                        FormAuthorization formAuthorization = new FormAuthorization();
                        formAuthorization.Show();
                        MessageBox.Show("Профиль успешно удалён ✅");
                    } catch (AuthenticationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async void dgvReviews_DoubleClick(object sender, EventArgs e)
        {
            if(dgvReviews.CurrentRow == null)
            {
                return;
            }
            int selectedRowIndex = dgvReviews.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                FormEditReview formEditReview = new FormEditReview
                (
                    (int)dgvReviews[1, selectedRowIndex].Value,
                    dgvReviews[2, selectedRowIndex].Value.ToString(),
                    dgvReviews[3, selectedRowIndex].Value.ToString(),
                    await bookReviewService.FindByIdAsync((int)dgvReviews[0, selectedRowIndex].Value)
                );
                DialogResult dialogResult = formEditReview.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Отзыв успшено изменён ✅");
                    ViewAllReviews();
                } else if (dialogResult == DialogResult.Abort)
                {
                    MessageBox.Show("Отзыв успшено удалён ✅");
                    ViewAllReviews();
                }
            }
        }

        private void dgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrders.Columns[e.ColumnIndex].DataPropertyName == "Cost" && e.RowIndex >= 0)
            {
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString() + " ₽";
                }
            }
        }

        private void dgvOrders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                return;
            }
            int selectedRowIndex = dgvOrders.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                FormOrderInfo formOrderInfo = new FormOrderInfo(orders[selectedRowIndex]);
                Close();
                formOrderInfo.Show();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            SecurityContext.Authentication = null;
            FormAuthorization formAuthorization = new FormAuthorization();
            Hide();
            formAuthorization.Show();
        }
    }
}
