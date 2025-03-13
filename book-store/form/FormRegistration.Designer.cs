namespace book_store.form
{
    partial class FormRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonRegister = new Button();
            labelRegistration = new Label();
            tbUsername = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            labelConfirmPassword = new Label();
            labelEmail = new Label();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            tbEmail = new TextBox();
            tbAddress = new TextBox();
            labelAddress = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(88, 3, 154);
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRegister.ForeColor = SystemColors.Window;
            buttonRegister.Location = new Point(250, 398);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(300, 40);
            buttonRegister.TabIndex = 9;
            buttonRegister.Text = "Зарегистироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegistration.Location = new Point(293, 9);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(221, 48);
            labelRegistration.TabIndex = 6;
            labelRegistration.Text = "Регистрация";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(224, 224, 224);
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbUsername.Location = new Point(250, 93);
            tbUsername.MinimumSize = new Size(300, 25);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(300, 25);
            tbUsername.TabIndex = 7;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Philosopher", 9.749999F);
            labelUsername.Location = new Point(250, 64);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(114, 17);
            labelUsername.TabIndex = 13;
            labelUsername.Text = "Имя пользователя";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Philosopher", 9.749999F);
            labelPassword.Location = new Point(250, 130);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(50, 17);
            labelPassword.TabIndex = 14;
            labelPassword.Text = "Пароль";
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Philosopher", 9.749999F);
            labelConfirmPassword.Location = new Point(250, 196);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(113, 17);
            labelConfirmPassword.TabIndex = 15;
            labelConfirmPassword.Text = "Повторите пароль";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Philosopher", 9.749999F);
            labelEmail.Location = new Point(250, 262);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(119, 17);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Электронная почта";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(224, 224, 224);
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPassword.Location = new Point(250, 159);
            tbPassword.MinimumSize = new Size(300, 25);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(300, 25);
            tbPassword.TabIndex = 17;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.BackColor = Color.FromArgb(224, 224, 224);
            tbConfirmPassword.BorderStyle = BorderStyle.None;
            tbConfirmPassword.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbConfirmPassword.Location = new Point(250, 225);
            tbConfirmPassword.MinimumSize = new Size(300, 25);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '•';
            tbConfirmPassword.Size = new Size(300, 25);
            tbConfirmPassword.TabIndex = 18;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.FromArgb(224, 224, 224);
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbEmail.Location = new Point(250, 291);
            tbEmail.MinimumSize = new Size(300, 25);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(300, 25);
            tbEmail.TabIndex = 19;
            // 
            // tbAddress
            // 
            tbAddress.BackColor = Color.FromArgb(224, 224, 224);
            tbAddress.BorderStyle = BorderStyle.None;
            tbAddress.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbAddress.Location = new Point(250, 357);
            tbAddress.MinimumSize = new Size(300, 25);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(300, 25);
            tbAddress.TabIndex = 20;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Philosopher", 9.749999F);
            labelAddress.Location = new Point(250, 328);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(42, 17);
            labelAddress.TabIndex = 21;
            labelAddress.Text = "Адрес";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(369, 57);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 22;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(306, 121);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 23;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(369, 187);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 24;
            label3.Text = "*";
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelAddress);
            Controls.Add(tbAddress);
            Controls.Add(tbEmail);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelConfirmPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(buttonRegister);
            Controls.Add(tbUsername);
            Controls.Add(labelRegistration);
            Name = "FormRegistration";
            Text = "Регистрация";
            FormClosing += FormRegistration_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonRegister;
        private Label labelRegistration;
        private TextBox tbUsername;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelConfirmPassword;
        private Label labelEmail;
        private TextBox tbPassword;
        private TextBox tbConfirmPassword;
        private TextBox tbEmail;
        private TextBox tbAddress;
        private Label labelAddress;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}