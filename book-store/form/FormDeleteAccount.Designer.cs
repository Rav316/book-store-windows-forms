namespace book_store.form
{
    partial class FormDeleteAccount
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
            buttonYes = new Button();
            buttonCancel = new Button();
            labelEnterPassword = new Label();
            tbPassword = new TextBox();
            SuspendLayout();
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(29, 142);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(125, 36);
            buttonYes.TabIndex = 0;
            buttonYes.Text = "Да, удалить аккаунт";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(256, 142);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 36);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelEnterPassword
            // 
            labelEnterPassword.AutoSize = true;
            labelEnterPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelEnterPassword.Location = new Point(74, 24);
            labelEnterPassword.Name = "labelEnterPassword";
            labelEnterPassword.Size = new Size(265, 20);
            labelEnterPassword.TabIndex = 2;
            labelEnterPassword.Text = "Введите текущий пароль от аккаунта";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(74, 63);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '•';
            tbPassword.Size = new Size(265, 23);
            tbPassword.TabIndex = 3;
            // 
            // FormDeleteAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 223);
            Controls.Add(tbPassword);
            Controls.Add(labelEnterPassword);
            Controls.Add(buttonCancel);
            Controls.Add(buttonYes);
            Name = "FormDeleteAccount";
            Text = "Вы действительно хотите удалить аккаунт?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonYes;
        private Button buttonCancel;
        private Label labelEnterPassword;
        private TextBox tbPassword;
    }
}