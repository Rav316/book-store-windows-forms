namespace book_store.form
{
    partial class FormManagement
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
            labelManagement = new Label();
            buttonBooks = new Button();
            buttonAuthors = new Button();
            buttonCategories = new Button();
            buttonPublishers = new Button();
            buttonWarehouses = new Button();
            buttonBookWarehouses = new Button();
            buttonApp = new Button();
            SuspendLayout();
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManagement.Location = new Point(133, 35);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(538, 48);
            labelManagement.TabIndex = 2;
            labelManagement.Text = "Управление объектами системы";
            // 
            // buttonBooks
            // 
            buttonBooks.BackColor = Color.FromArgb(41, 2, 71);
            buttonBooks.Cursor = Cursors.Hand;
            buttonBooks.FlatStyle = FlatStyle.Flat;
            buttonBooks.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonBooks.ForeColor = SystemColors.Window;
            buttonBooks.Location = new Point(133, 114);
            buttonBooks.Name = "buttonBooks";
            buttonBooks.Size = new Size(218, 50);
            buttonBooks.TabIndex = 5;
            buttonBooks.Text = "Книги";
            buttonBooks.UseVisualStyleBackColor = false;
            buttonBooks.Click += buttonBooks_Click;
            // 
            // buttonAuthors
            // 
            buttonAuthors.BackColor = Color.FromArgb(41, 2, 71);
            buttonAuthors.Cursor = Cursors.Hand;
            buttonAuthors.FlatStyle = FlatStyle.Flat;
            buttonAuthors.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAuthors.ForeColor = SystemColors.Window;
            buttonAuthors.Location = new Point(453, 114);
            buttonAuthors.Name = "buttonAuthors";
            buttonAuthors.Size = new Size(218, 50);
            buttonAuthors.TabIndex = 6;
            buttonAuthors.Text = "Авторы книг";
            buttonAuthors.UseVisualStyleBackColor = false;
            buttonAuthors.Click += buttonAuthors_Click;
            // 
            // buttonCategories
            // 
            buttonCategories.BackColor = Color.FromArgb(41, 2, 71);
            buttonCategories.Cursor = Cursors.Hand;
            buttonCategories.FlatStyle = FlatStyle.Flat;
            buttonCategories.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCategories.ForeColor = SystemColors.Window;
            buttonCategories.Location = new Point(133, 207);
            buttonCategories.Name = "buttonCategories";
            buttonCategories.Size = new Size(218, 50);
            buttonCategories.TabIndex = 7;
            buttonCategories.Text = "Категории";
            buttonCategories.UseVisualStyleBackColor = false;
            buttonCategories.Click += buttonCategories_Click;
            // 
            // buttonPublishers
            // 
            buttonPublishers.BackColor = Color.FromArgb(41, 2, 71);
            buttonPublishers.Cursor = Cursors.Hand;
            buttonPublishers.FlatStyle = FlatStyle.Flat;
            buttonPublishers.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPublishers.ForeColor = SystemColors.Window;
            buttonPublishers.Location = new Point(453, 207);
            buttonPublishers.Name = "buttonPublishers";
            buttonPublishers.Size = new Size(218, 50);
            buttonPublishers.TabIndex = 8;
            buttonPublishers.Text = "Издатели";
            buttonPublishers.UseVisualStyleBackColor = false;
            buttonPublishers.Click += buttonPublishers_Click;
            // 
            // buttonWarehouses
            // 
            buttonWarehouses.BackColor = Color.FromArgb(41, 2, 71);
            buttonWarehouses.Cursor = Cursors.Hand;
            buttonWarehouses.FlatStyle = FlatStyle.Flat;
            buttonWarehouses.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonWarehouses.ForeColor = SystemColors.Window;
            buttonWarehouses.Location = new Point(133, 295);
            buttonWarehouses.Name = "buttonWarehouses";
            buttonWarehouses.Size = new Size(218, 50);
            buttonWarehouses.TabIndex = 9;
            buttonWarehouses.Text = "Склады";
            buttonWarehouses.UseVisualStyleBackColor = false;
            buttonWarehouses.Click += buttonWarehouses_Click;
            // 
            // buttonBookWarehouses
            // 
            buttonBookWarehouses.BackColor = Color.FromArgb(41, 2, 71);
            buttonBookWarehouses.Cursor = Cursors.Hand;
            buttonBookWarehouses.FlatStyle = FlatStyle.Flat;
            buttonBookWarehouses.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonBookWarehouses.ForeColor = SystemColors.Window;
            buttonBookWarehouses.Location = new Point(453, 295);
            buttonBookWarehouses.Name = "buttonBookWarehouses";
            buttonBookWarehouses.Size = new Size(218, 50);
            buttonBookWarehouses.TabIndex = 10;
            buttonBookWarehouses.Text = "Книги на складе";
            buttonBookWarehouses.UseVisualStyleBackColor = false;
            buttonBookWarehouses.Click += buttonBookWarehouses_Click;
            // 
            // buttonApp
            // 
            buttonApp.BackColor = Color.FromArgb(41, 2, 71);
            buttonApp.Cursor = Cursors.Hand;
            buttonApp.FlatStyle = FlatStyle.Flat;
            buttonApp.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonApp.ForeColor = SystemColors.Window;
            buttonApp.Location = new Point(562, 414);
            buttonApp.Name = "buttonApp";
            buttonApp.Size = new Size(226, 33);
            buttonApp.TabIndex = 11;
            buttonApp.Text = "Перейти в приложение";
            buttonApp.UseVisualStyleBackColor = false;
            buttonApp.Click += buttonApp_Click;
            // 
            // FormManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonApp);
            Controls.Add(buttonBookWarehouses);
            Controls.Add(buttonWarehouses);
            Controls.Add(buttonPublishers);
            Controls.Add(buttonCategories);
            Controls.Add(buttonAuthors);
            Controls.Add(buttonBooks);
            Controls.Add(labelManagement);
            Name = "FormManagement";
            Text = "Управление системой";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelManagement;
        private Button buttonBooks;
        private Button buttonAuthors;
        private Button buttonCategories;
        private Button buttonPublishers;
        private Button buttonWarehouses;
        private Button buttonBookWarehouses;
        private Button buttonApp;
    }
}