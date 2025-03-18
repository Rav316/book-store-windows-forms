using book_store.context;
using book_store.database.entity;
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
                if (!PasswordValidator.IsValidPassword(tbNewPassword.Text))
                {
                    MessageBox.Show("Пароль должен быть длиной минимум 6 символов, содержать спец. символы, цифры и заглавные буквы");
                    return;
                }
            }
            if (!EmailValidator.IsValidEmail(tbEmail.Text))
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
    }
}
