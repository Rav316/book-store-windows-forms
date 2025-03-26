namespace book_store.form.admin
{
    partial class FormBookWarehouseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookWarehouseInfo));
            tbQuantity = new TextBox();
            labelQuantity = new Label();
            buttonDelete = new Button();
            buttonSaveChanges = new Button();
            labelWarehouseId = new Label();
            labelBookId = new Label();
            pbBack = new PictureBox();
            labelBookWarehouse = new Label();
            tbBook = new TextBox();
            tbWarehouse = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // tbQuantity
            // 
            tbQuantity.BackColor = Color.FromArgb(224, 224, 224);
            tbQuantity.BorderStyle = BorderStyle.None;
            tbQuantity.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbQuantity.Location = new Point(334, 184);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(223, 22);
            tbQuantity.TabIndex = 160;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelQuantity.ForeColor = Color.Black;
            labelQuantity.Location = new Point(127, 185);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(100, 21);
            labelQuantity.TabIndex = 159;
            labelQuantity.Text = "Количество:";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelete.ForeColor = SystemColors.Window;
            buttonDelete.Location = new Point(127, 292);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(430, 43);
            buttonDelete.TabIndex = 158;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.FromArgb(41, 2, 71);
            buttonSaveChanges.Cursor = Cursors.Hand;
            buttonSaveChanges.FlatStyle = FlatStyle.Flat;
            buttonSaveChanges.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSaveChanges.ForeColor = SystemColors.Window;
            buttonSaveChanges.Location = new Point(127, 242);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(430, 43);
            buttonSaveChanges.TabIndex = 157;
            buttonSaveChanges.Text = "Сохранить изменения";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // labelWarehouseId
            // 
            labelWarehouseId.AutoSize = true;
            labelWarehouseId.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWarehouseId.ForeColor = Color.Black;
            labelWarehouseId.Location = new Point(127, 140);
            labelWarehouseId.Name = "labelWarehouseId";
            labelWarehouseId.Size = new Size(80, 21);
            labelWarehouseId.TabIndex = 155;
            labelWarehouseId.Text = "id склада:";
            // 
            // labelBookId
            // 
            labelBookId.AutoSize = true;
            labelBookId.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBookId.ForeColor = Color.Black;
            labelBookId.Location = new Point(127, 95);
            labelBookId.Name = "labelBookId";
            labelBookId.Size = new Size(72, 21);
            labelBookId.TabIndex = 153;
            labelBookId.Text = "id книги:";
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(37, 45);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 152;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelBookWarehouse
            // 
            labelBookWarehouse.AutoSize = true;
            labelBookWarehouse.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBookWarehouse.Location = new Point(86, 24);
            labelBookWarehouse.Name = "labelBookWarehouse";
            labelBookWarehouse.Size = new Size(520, 48);
            labelBookWarehouse.TabIndex = 151;
            labelBookWarehouse.Text = "Информация о книге на складе";
            // 
            // tbBook
            // 
            tbBook.BackColor = Color.FromArgb(224, 224, 224);
            tbBook.BorderStyle = BorderStyle.None;
            tbBook.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbBook.Location = new Point(334, 92);
            tbBook.Name = "tbBook";
            tbBook.ReadOnly = true;
            tbBook.Size = new Size(223, 22);
            tbBook.TabIndex = 161;
            // 
            // tbWarehouse
            // 
            tbWarehouse.BackColor = Color.FromArgb(224, 224, 224);
            tbWarehouse.BorderStyle = BorderStyle.None;
            tbWarehouse.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbWarehouse.Location = new Point(334, 137);
            tbWarehouse.Name = "tbWarehouse";
            tbWarehouse.ReadOnly = true;
            tbWarehouse.Size = new Size(223, 22);
            tbWarehouse.TabIndex = 162;
            // 
            // FormBookWarehouseInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 385);
            Controls.Add(tbWarehouse);
            Controls.Add(tbBook);
            Controls.Add(tbQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSaveChanges);
            Controls.Add(labelWarehouseId);
            Controls.Add(labelBookId);
            Controls.Add(pbBack);
            Controls.Add(labelBookWarehouse);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBookWarehouseInfo";
            Text = "Информация о книге на складе";
            Load += FormBookWarehouseInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbQuantity;
        private Label labelQuantity;
        private Button buttonDelete;
        private Button buttonSaveChanges;
        private Label labelWarehouseId;
        private Label labelBookId;
        private PictureBox pbBack;
        private Label labelBookWarehouse;
        private TextBox tbBook;
        private TextBox tbWarehouse;
    }
}