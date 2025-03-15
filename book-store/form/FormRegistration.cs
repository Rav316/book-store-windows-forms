using book_store.service;
using book_store.validation;
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
    public partial class FormRegistration : Form
    {
        private readonly UserService userService = new UserService();
        private FormAuthorization formAuthorization;
        public FormRegistration(FormAuthorization formAuthorization)
        {
            this.formAuthorization = formAuthorization;
            InitializeComponent();
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Equals("") || tbPassword.Text.Equals(""))
            {
                MessageBox.Show("Необходимо заполнить все обязательные поля");
                return;
            }
            if(!tbEmail.Text.Equals("") && !EmailValidator.IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("email некорректный");
                return;
            }
            if (!tbPassword.Text.Equals(tbConfirmPassword.Text))
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            if (!PasswordValidator.IsValidPassword(tbPassword.Text))
            {
                MessageBox.Show("Пароль должен быть длиной минимум 6 символов, содержать спец. символы, цифры и заглавные буквы");
                return;
            }
            try
            {
                await userService.CreateUser(tbUsername.Text, tbPassword.Text, tbEmail.Text, tbAddress.Text);
                MessageBox.Show("Пользователь успешно создан ✅");
                Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при создании пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAuthorization.Show();
        }
    }
}
