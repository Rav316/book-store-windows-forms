namespace book_store.form.admin
{
    partial class FormBookWarehouseCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookWarehouseCreate));
            labelWarehouse = new Label();
            buttonAdd = new Button();
            labelBook = new Label();
            pbBack = new PictureBox();
            labelBookWarehouse = new Label();
            tbQuantity = new TextBox();
            labelQuantity = new Label();
            cbBook = new ComboBox();
            cbWarehouse = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // labelWarehouse
            // 
            labelWarehouse.AutoSize = true;
            labelWarehouse.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWarehouse.ForeColor = Color.Black;
            labelWarehouse.Location = new Point(92, 150);
            labelWarehouse.Name = "labelWarehouse";
            labelWarehouse.Size = new Size(63, 21);
            labelWarehouse.TabIndex = 160;
            labelWarehouse.Text = "Склад: ";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(41, 2, 71);
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.ForeColor = SystemColors.Window;
            buttonAdd.Location = new Point(92, 248);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(430, 43);
            buttonAdd.TabIndex = 159;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelBook
            // 
            labelBook.AutoSize = true;
            labelBook.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBook.ForeColor = Color.Black;
            labelBook.Location = new Point(92, 107);
            labelBook.Name = "labelBook";
            labelBook.Size = new Size(62, 21);
            labelBook.TabIndex = 157;
            labelBook.Text = "Книга: ";
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(29, 25);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 20);
            pbBack.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBack.TabIndex = 156;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelBookWarehouse
            // 
            labelBookWarehouse.AutoSize = true;
            labelBookWarehouse.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBookWarehouse.Location = new Point(81, 9);
            labelBookWarehouse.Name = "labelBookWarehouse";
            labelBookWarehouse.Size = new Size(462, 48);
            labelBookWarehouse.TabIndex = 155;
            labelBookWarehouse.Text = "Добавление книги на склад";
            // 
            // tbQuantity
            // 
            tbQuantity.BackColor = Color.FromArgb(224, 224, 224);
            tbQuantity.BorderStyle = BorderStyle.None;
            tbQuantity.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbQuantity.Location = new Point(299, 201);
            tbQuantity.MaxLength = 10;
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(223, 22);
            tbQuantity.TabIndex = 163;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelQuantity.ForeColor = Color.Black;
            labelQuantity.Location = new Point(92, 201);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(104, 21);
            labelQuantity.TabIndex = 162;
            labelQuantity.Text = "Количество: ";
            // 
            // cbBook
            // 
            cbBook.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBook.FormattingEnabled = true;
            cbBook.Location = new Point(299, 108);
            cbBook.Name = "cbBook";
            cbBook.Size = new Size(223, 23);
            cbBook.TabIndex = 164;
            // 
            // cbWarehouse
            // 
            cbWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWarehouse.FormattingEnabled = true;
            cbWarehouse.Location = new Point(299, 151);
            cbWarehouse.Name = "cbWarehouse";
            cbWarehouse.Size = new Size(223, 23);
            cbWarehouse.TabIndex = 165;
            // 
            // FormBookWarehouseCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 340);
            Controls.Add(cbWarehouse);
            Controls.Add(cbBook);
            Controls.Add(tbQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(labelWarehouse);
            Controls.Add(buttonAdd);
            Controls.Add(labelBook);
            Controls.Add(pbBack);
            Controls.Add(labelBookWarehouse);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBookWarehouseCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление книги на склад";
            Load += FormBookWarehouseCreate_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWarehouse;
        private Button buttonAdd;
        private Label labelBook;
        private PictureBox pbBack;
        private Label labelBookWarehouse;
        private TextBox tbQuantity;
        private Label labelQuantity;
        private ComboBox cbBook;
        private ComboBox cbWarehouse;
    }
}