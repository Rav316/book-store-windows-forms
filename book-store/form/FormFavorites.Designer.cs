namespace book_store.form
{
    partial class FormFavorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFavorites));
            labelFavorites = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            dgvBooks = new DataGridView();
            pictureBox1 = new PictureBox();
            Id = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            BookImage = new DataGridViewImageColumn();
            Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelFavorites
            // 
            labelFavorites.AutoSize = true;
            labelFavorites.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFavorites.Location = new Point(63, 6);
            labelFavorites.Name = "labelFavorites";
            labelFavorites.Size = new Size(194, 48);
            labelFavorites.TabIndex = 1;
            labelFavorites.Text = "Избранное";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(88, 3, 154);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = SystemColors.Window;
            buttonSave.Location = new Point(582, 6);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(206, 50);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(88, 3, 154);
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = SystemColors.Window;
            buttonCancel.Location = new Point(357, 6);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(206, 50);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отменить изменения";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Id, BookName, Author, BookImage, Price });
            dgvBooks.Location = new Point(12, 63);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowTemplate.Height = 136;
            dgvBooks.Size = new Size(776, 375);
            dgvBooks.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 10);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // BookName
            // 
            BookName.HeaderText = "Название книги";
            BookName.Name = "BookName";
            BookName.ReadOnly = true;
            // 
            // Author
            // 
            Author.HeaderText = "Автор";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // BookImage
            // 
            BookImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BookImage.HeaderText = "Изображение";
            BookImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            BookImage.Name = "BookImage";
            BookImage.ReadOnly = true;
            BookImage.Resizable = DataGridViewTriState.True;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // FormFavorites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(dgvBooks);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelFavorites);
            Name = "FormFavorites";
            Text = "Избранное";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFavorites;
        private Button buttonSave;
        private Button buttonCancel;
        private DataGridView dgvBooks;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewImageColumn BookImage;
        private DataGridViewTextBoxColumn Price;
    }
}