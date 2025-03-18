namespace book_store.form
{
    partial class FormCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCart));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pbBack = new PictureBox();
            labelCart = new Label();
            dgvBooks = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            BookImage = new DataGridViewImageColumn();
            Price = new DataGridViewTextBoxColumn();
            IsInFavorites = new DataGridViewCheckBoxColumn();
            IsInCart = new DataGridViewCheckBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            labelResult = new Label();
            labelTotalSum = new Label();
            buttonPlaceOrder = new Button();
            labelEmpty = new Label();
            buttonBackToMainForm = new Button();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(21, 28);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 22;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelCart
            // 
            labelCart.AutoSize = true;
            labelCart.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCart.Location = new Point(63, 6);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(156, 48);
            labelCart.TabIndex = 21;
            labelCart.Text = "Корзина";
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
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Id, BookName, Author, BookImage, Price, IsInFavorites, IsInCart, Quantity });
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
            dgvBooks.TabIndex = 23;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            dgvBooks.CellFormatting += dgvBooks_CellFormatting;
            dgvBooks.CellValueChanged += dgvBooks_CellValueChanged;
            dgvBooks.DataError += dgvBooks_DataError;
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
            // Quantity
            // 
            Quantity.HeaderText = "Количество";
            Quantity.Name = "Quantity";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(21, 468);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(103, 48);
            labelResult.TabIndex = 24;
            labelResult.Text = "Итог:";
            // 
            // labelTotalSum
            // 
            labelTotalSum.AutoSize = true;
            labelTotalSum.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalSum.Location = new Point(116, 468);
            labelTotalSum.Name = "labelTotalSum";
            labelTotalSum.Size = new Size(118, 48);
            labelTotalSum.TabIndex = 25;
            labelTotalSum.Text = "1234 ₽";
            // 
            // buttonPlaceOrder
            // 
            buttonPlaceOrder.BackColor = Color.FromArgb(41, 2, 71);
            buttonPlaceOrder.Cursor = Cursors.Hand;
            buttonPlaceOrder.FlatStyle = FlatStyle.Flat;
            buttonPlaceOrder.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlaceOrder.ForeColor = SystemColors.Window;
            buttonPlaceOrder.Location = new Point(582, 466);
            buttonPlaceOrder.Name = "buttonPlaceOrder";
            buttonPlaceOrder.Size = new Size(206, 50);
            buttonPlaceOrder.TabIndex = 26;
            buttonPlaceOrder.Text = "Оформить заказ";
            buttonPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // labelEmpty
            // 
            labelEmpty.AutoSize = true;
            labelEmpty.Font = new Font("Philosopher", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmpty.Location = new Point(229, 164);
            labelEmpty.Name = "labelEmpty";
            labelEmpty.Size = new Size(358, 44);
            labelEmpty.TabIndex = 27;
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
            buttonBackToMainForm.TabIndex = 28;
            buttonBackToMainForm.Text = "Вернуться на главную";
            buttonBackToMainForm.UseVisualStyleBackColor = false;
            buttonBackToMainForm.Click += buttonBackToMainForm_Click;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(buttonBackToMainForm);
            Controls.Add(labelEmpty);
            Controls.Add(buttonPlaceOrder);
            Controls.Add(labelTotalSum);
            Controls.Add(labelResult);
            Controls.Add(dgvBooks);
            Controls.Add(pbBack);
            Controls.Add(labelCart);
            Name = "FormCart";
            Text = "Корзина";
            Load += FormCart_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBack;
        private Label labelCart;
        private DataGridView dgvBooks;
        private Label labelResult;
        private Label labelTotalSum;
        private Button buttonPlaceOrder;
        private Label labelEmpty;
        private Button buttonBackToMainForm;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewImageColumn BookImage;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewCheckBoxColumn IsInFavorites;
        private DataGridViewCheckBoxColumn IsInCart;
        private DataGridViewTextBoxColumn Quantity;
    }
}