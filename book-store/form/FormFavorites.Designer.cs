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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelFavorites = new Label();
            pbBack = new PictureBox();
            dgvBooks = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            BookImage = new DataGridViewImageColumn();
            Price = new DataGridViewTextBoxColumn();
            IsInFavorites = new DataGridViewCheckBoxColumn();
            IsInCart = new DataGridViewCheckBoxColumn();
            CartItemId = new DataGridViewTextBoxColumn();
            labelEmpty = new Label();
            buttonBackToMainForm = new Button();
            buttonClearFavorites = new Button();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
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
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(21, 28);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 20;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Philosopher", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Id, BookName, Author, BookImage, Price, IsInFavorites, IsInCart, CartItemId });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Philosopher", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.Location = new Point(21, 67);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowTemplate.Height = 136;
            dgvBooks.Size = new Size(767, 361);
            dgvBooks.TabIndex = 21;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            dgvBooks.CellFormatting += dgvBooks_CellFormatting;
            dgvBooks.DoubleClick += dgvBooks_DoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // BookName
            // 
            BookName.HeaderText = "Название книги";
            BookName.Name = "BookName";
            // 
            // Author
            // 
            Author.HeaderText = "Автор";
            Author.Name = "Author";
            // 
            // BookImage
            // 
            BookImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BookImage.HeaderText = "Изображение";
            BookImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            BookImage.Name = "BookImage";
            BookImage.Resizable = DataGridViewTriState.True;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.Name = "Price";
            // 
            // IsInFavorites
            // 
            IsInFavorites.HeaderText = "В избранном";
            IsInFavorites.Name = "IsInFavorites";
            // 
            // IsInCart
            // 
            IsInCart.HeaderText = "В корзине";
            IsInCart.Name = "IsInCart";
            // 
            // CartItemId
            // 
            CartItemId.HeaderText = "cartItemId";
            CartItemId.Name = "CartItemId";
            CartItemId.Visible = false;
            // 
            // labelEmpty
            // 
            labelEmpty.AutoSize = true;
            labelEmpty.Font = new Font("Philosopher", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmpty.Location = new Point(229, 164);
            labelEmpty.Name = "labelEmpty";
            labelEmpty.Size = new Size(358, 44);
            labelEmpty.TabIndex = 22;
            labelEmpty.Text = "Пока что здесь пусто :(";
            // 
            // buttonBackToMainForm
            // 
            buttonBackToMainForm.BackColor = Color.FromArgb(41, 2, 71);
            buttonBackToMainForm.Cursor = Cursors.Hand;
            buttonBackToMainForm.FlatStyle = FlatStyle.Flat;
            buttonBackToMainForm.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonBackToMainForm.ForeColor = SystemColors.Window;
            buttonBackToMainForm.Location = new Point(307, 227);
            buttonBackToMainForm.Name = "buttonBackToMainForm";
            buttonBackToMainForm.Size = new Size(206, 50);
            buttonBackToMainForm.TabIndex = 23;
            buttonBackToMainForm.Text = "Вернуться на главную";
            buttonBackToMainForm.UseVisualStyleBackColor = false;
            buttonBackToMainForm.Click += buttonBackToMainForm_Click;
            // 
            // buttonClearFavorites
            // 
            buttonClearFavorites.BackColor = Color.FromArgb(41, 2, 71);
            buttonClearFavorites.Cursor = Cursors.Hand;
            buttonClearFavorites.FlatStyle = FlatStyle.Flat;
            buttonClearFavorites.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClearFavorites.ForeColor = SystemColors.Window;
            buttonClearFavorites.Location = new Point(582, 11);
            buttonClearFavorites.Name = "buttonClearFavorites";
            buttonClearFavorites.Size = new Size(206, 50);
            buttonClearFavorites.TabIndex = 24;
            buttonClearFavorites.Text = "Очистить";
            buttonClearFavorites.UseVisualStyleBackColor = false;
            buttonClearFavorites.Click += buttonClearFavorites_Click;
            // 
            // FormFavorites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClearFavorites);
            Controls.Add(buttonBackToMainForm);
            Controls.Add(labelEmpty);
            Controls.Add(dgvBooks);
            Controls.Add(pbBack);
            Controls.Add(labelFavorites);
            Name = "FormFavorites";
            Text = "Избранное";
            Load += FormFavorites_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFavorites;
        private PictureBox pbBack;
        private DataGridView dgvBooks;
        private Label labelEmpty;
        private Button buttonBackToMainForm;
        private Button buttonClearFavorites;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewImageColumn BookImage;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewCheckBoxColumn IsInFavorites;
        private DataGridViewCheckBoxColumn IsInCart;
        private DataGridViewTextBoxColumn CartItemId;
    }
}