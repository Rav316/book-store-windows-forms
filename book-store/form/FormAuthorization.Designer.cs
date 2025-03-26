namespace book_store
{
    partial class FormAuthorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            labelLogin = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            buttonLogin = new Button();
            label1 = new Label();
            labelRegister = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(336, 53);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(99, 48);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Вход";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(224, 224, 224);
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Philosopher", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbUsername.Location = new Point(234, 152);
            tbUsername.MinimumSize = new Size(300, 50);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(300, 50);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(224, 224, 224);
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Philosopher", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPassword.Location = new Point(234, 250);
            tbPassword.MinimumSize = new Size(300, 50);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '•';
            tbPassword.Size = new Size(300, 50);
            tbPassword.TabIndex = 2;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(41, 2, 71);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogin.ForeColor = SystemColors.Window;
            buttonLogin.Location = new Point(234, 317);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(300, 50);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Вход";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Philosopher", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(234, 385);
            label1.Name = "label1";
            label1.Size = new Size(148, 17);
            label1.TabIndex = 4;
            label1.Text = "Впервые в приложении?";
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Cursor = Cursors.Hand;
            labelRegister.Font = new Font("Philosopher", 9.749999F, FontStyle.Underline, GraphicsUnit.Point, 204);
            labelRegister.Location = new Point(409, 385);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(125, 17);
            labelRegister.TabIndex = 5;
            labelRegister.Text = "Зарегистрироваться";
            labelRegister.Click += labelRegister_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Philosopher", 9.749999F);
            labelUsername.Location = new Point(234, 125);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(114, 17);
            labelUsername.TabIndex = 6;
            labelUsername.Text = "Имя пользователя";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Philosopher", 9.749999F);
            labelPassword.Location = new Point(234, 220);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(50, 17);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Пароль";
            // 
            // FormAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelRegister);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(labelLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAuthorization";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button buttonLogin;
        private Label label1;
        private Label labelRegister;
        private Label labelUsername;
        private Label labelPassword;
    }
}
