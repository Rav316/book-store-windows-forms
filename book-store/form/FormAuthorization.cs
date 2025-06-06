﻿using book_store.database.entity;
using book_store.exception;
using book_store.form;
using book_store.service;

using book_store.util;
using System.Drawing.Drawing2D;

namespace book_store
{
    public partial class FormAuthorization : Form
    {
        private readonly UserService userService = new UserService();
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration(this);
            Hide();
            formRegistration.Show();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Equals("") || tbPassword.Text.Equals(""))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            try
            {
                var user = await userService.AuthenticateAsync(tbUsername.Text, tbPassword.Text);
                Hide();
                if (user.Role == Role.User)
                {
                    FormMain formMain = new FormMain();
                    formMain.Show();
                }
                else
                {
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                }
                
            } catch (Exception ex) when (ex is EntityNotFoundException || ex is AuthenticationException || ex is ArgumentException)
            {
                MessageBox.Show(ex.Message, "Ошибка при авторизации пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
