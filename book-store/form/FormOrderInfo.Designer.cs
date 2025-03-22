namespace book_store.form
{
    partial class FormOrderInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderInfo));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pbBack = new PictureBox();
            labelOrder = new Label();
            dgvBooks = new DataGridView();
            labelOrderStatus = new Label();
            labelPaymentStatus = new Label();
            labelStatusValue = new Label();
            labelPaymentStatusValue = new Label();
            buttonPayOrder = new Button();
            buttonCancelOrder = new Button();
            Id = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            BookImage = new DataGridViewImageColumn();
            TotalQuantity = new DataGridViewTextBoxColumn();
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
            // labelOrder
            // 
            labelOrder.AutoSize = true;
            labelOrder.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOrder.Location = new Point(63, 6);
            labelOrder.Name = "labelOrder";
            labelOrder.Size = new Size(249, 48);
            labelOrder.TabIndex = 21;
            labelOrder.Text = "Заказ #123456";
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
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Id, BookName, Author, BookImage, TotalQuantity });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Philosopher", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.Location = new Point(21, 179);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowTemplate.Height = 136;
            dgvBooks.Size = new Size(767, 309);
            dgvBooks.TabIndex = 23;
            // 
            // labelOrderStatus
            // 
            labelOrderStatus.AutoSize = true;
            labelOrderStatus.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOrderStatus.Location = new Point(63, 63);
            labelOrderStatus.Name = "labelOrderStatus";
            labelOrderStatus.Size = new Size(81, 25);
            labelOrderStatus.TabIndex = 63;
            labelOrderStatus.Text = "Статус: ";
            // 
            // labelPaymentStatus
            // 
            labelPaymentStatus.AutoSize = true;
            labelPaymentStatus.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPaymentStatus.Location = new Point(63, 102);
            labelPaymentStatus.Name = "labelPaymentStatus";
            labelPaymentStatus.Size = new Size(147, 25);
            labelPaymentStatus.TabIndex = 64;
            labelPaymentStatus.Text = "Статус оплаты: ";
            // 
            // labelStatusValue
            // 
            labelStatusValue.AutoSize = true;
            labelStatusValue.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStatusValue.Location = new Point(138, 63);
            labelStatusValue.Name = "labelStatusValue";
            labelStatusValue.Size = new Size(111, 25);
            labelStatusValue.TabIndex = 65;
            labelStatusValue.Text = "в ожидании";
            // 
            // labelPaymentStatusValue
            // 
            labelPaymentStatusValue.AutoSize = true;
            labelPaymentStatusValue.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPaymentStatusValue.Location = new Point(206, 102);
            labelPaymentStatusValue.Name = "labelPaymentStatusValue";
            labelPaymentStatusValue.Size = new Size(106, 25);
            labelPaymentStatusValue.TabIndex = 66;
            labelPaymentStatusValue.Text = "не оплачен";
            // 
            // buttonPayOrder
            // 
            buttonPayOrder.BackColor = Color.FromArgb(41, 2, 71);
            buttonPayOrder.Cursor = Cursors.Hand;
            buttonPayOrder.FlatStyle = FlatStyle.Flat;
            buttonPayOrder.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPayOrder.ForeColor = SystemColors.Window;
            buttonPayOrder.Location = new Point(176, 516);
            buttonPayOrder.Name = "buttonPayOrder";
            buttonPayOrder.Size = new Size(206, 49);
            buttonPayOrder.TabIndex = 67;
            buttonPayOrder.Text = "Оплатить";
            buttonPayOrder.UseVisualStyleBackColor = false;
            buttonPayOrder.Click += buttonPayOrder_Click;
            // 
            // buttonCancelOrder
            // 
            buttonCancelOrder.BackColor = Color.Red;
            buttonCancelOrder.Cursor = Cursors.Hand;
            buttonCancelOrder.FlatStyle = FlatStyle.Flat;
            buttonCancelOrder.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancelOrder.ForeColor = SystemColors.Window;
            buttonCancelOrder.Location = new Point(418, 516);
            buttonCancelOrder.Name = "buttonCancelOrder";
            buttonCancelOrder.Size = new Size(206, 49);
            buttonCancelOrder.TabIndex = 68;
            buttonCancelOrder.Text = "Отменить заказ";
            buttonCancelOrder.UseVisualStyleBackColor = false;
            buttonCancelOrder.Click += buttonCancelOrder_Click;
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
            // TotalQuantity
            // 
            TotalQuantity.HeaderText = "Количество";
            TotalQuantity.Name = "TotalQuantity";
            // 
            // FormOrderInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 604);
            Controls.Add(buttonCancelOrder);
            Controls.Add(buttonPayOrder);
            Controls.Add(labelPaymentStatusValue);
            Controls.Add(labelStatusValue);
            Controls.Add(labelPaymentStatus);
            Controls.Add(labelOrderStatus);
            Controls.Add(dgvBooks);
            Controls.Add(pbBack);
            Controls.Add(labelOrder);
            Name = "FormOrderInfo";
            Text = "Информация о заказе";
            Load += FormOrderInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBack;
        private Label labelOrder;
        private DataGridView dgvBooks;
        private Label labelOrderStatus;
        private Label labelPaymentStatus;
        private Label labelStatusValue;
        private Label labelPaymentStatusValue;
        private Button buttonPayOrder;
        private Button buttonCancelOrder;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewImageColumn BookImage;
        private DataGridViewTextBoxColumn TotalQuantity;
    }
}