namespace book_store.form
{
    partial class FormAdmin
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
            labelAdmin = new Label();
            buttonManagement = new Button();
            buttonApp = new Button();
            SuspendLayout();
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdmin.Location = new Point(213, 50);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(399, 48);
            labelAdmin.TabIndex = 1;
            labelAdmin.Text = "Форма администратора";
            // 
            // buttonManagement
            // 
            buttonManagement.BackColor = Color.FromArgb(41, 2, 71);
            buttonManagement.Cursor = Cursors.Hand;
            buttonManagement.FlatStyle = FlatStyle.Flat;
            buttonManagement.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonManagement.ForeColor = SystemColors.Window;
            buttonManagement.Location = new Point(252, 154);
            buttonManagement.Name = "buttonManagement";
            buttonManagement.Size = new Size(300, 50);
            buttonManagement.TabIndex = 4;
            buttonManagement.Text = "Управление системой";
            buttonManagement.UseVisualStyleBackColor = false;
            buttonManagement.Click += buttonManagement_Click;
            // 
            // buttonApp
            // 
            buttonApp.BackColor = Color.FromArgb(41, 2, 71);
            buttonApp.Cursor = Cursors.Hand;
            buttonApp.FlatStyle = FlatStyle.Flat;
            buttonApp.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonApp.ForeColor = SystemColors.Window;
            buttonApp.Location = new Point(252, 290);
            buttonApp.Name = "buttonApp";
            buttonApp.Size = new Size(300, 50);
            buttonApp.TabIndex = 5;
            buttonApp.Text = "Переход в приложение";
            buttonApp.UseVisualStyleBackColor = false;
            buttonApp.Click += buttonApp_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonApp);
            Controls.Add(buttonManagement);
            Controls.Add(labelAdmin);
            Name = "FormAdmin";
            Text = "Форма администратора";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAdmin;
        private Button buttonManagement;
        private Button buttonApp;
    }
}