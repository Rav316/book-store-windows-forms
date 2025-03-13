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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text.Equals("") || tbPassword.Text.Equals(""))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            try
            {
                userService.Authenticate(tbUsername.Text, tbPassword.Text);
                MessageBox.Show("авторизация успешно пройдена ✅");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при авторизации пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
