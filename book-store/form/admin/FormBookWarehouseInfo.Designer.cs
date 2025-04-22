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
            labelWarehouse = new Label();
            labelBook = new Label();
            pbBack = new PictureBox();
            labelBookWarehouse = new Label();
            cbWarehouse = new ComboBox();
            tbBook = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // tbQuantity
            // 
            tbQuantity.BackColor = Color.FromArgb(224, 224, 224);
            tbQuantity.BorderStyle = BorderStyle.None;
            tbQuantity.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbQuantity.Location = new Point(334, 184);
            tbQuantity.MaxLength = 10;
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
            // labelWarehouse
            // 
            labelWarehouse.AutoSize = true;
            labelWarehouse.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWarehouse.ForeColor = Color.Black;
            labelWarehouse.Location = new Point(127, 140);
            labelWarehouse.Name = "labelWarehouse";
            labelWarehouse.Size = new Size(56, 21);
            labelWarehouse.TabIndex = 155;
            labelWarehouse.Text = "склад:";
            // 
            // labelBook
            // 
            labelBook.AutoSize = true;
            labelBook.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBook.ForeColor = Color.Black;
            labelBook.Location = new Point(127, 95);
            labelBook.Name = "labelBook";
            labelBook.Size = new Size(55, 21);
            labelBook.TabIndex = 153;
            labelBook.Text = "книга:";
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
            // cbWarehouse
            // 
            cbWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWarehouse.FormattingEnabled = true;
            cbWarehouse.Location = new Point(334, 138);
            cbWarehouse.Name = "cbWarehouse";
            cbWarehouse.Size = new Size(223, 23);
            cbWarehouse.TabIndex = 164;
            // 
            // tbBook
            // 
            tbBook.BackColor = Color.FromArgb(224, 224, 224);
            tbBook.BorderStyle = BorderStyle.None;
            tbBook.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbBook.Location = new Point(334, 92);
            tbBook.MaxLength = 10;
            tbBook.Name = "tbBook";
            tbBook.ReadOnly = true;
            tbBook.Size = new Size(223, 22);
            tbBook.TabIndex = 165;
            // 
            // FormBookWarehouseInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 385);
            Controls.Add(tbBook);
            Controls.Add(cbWarehouse);
            Controls.Add(tbQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSaveChanges);
            Controls.Add(labelWarehouse);
            Controls.Add(labelBook);
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
        private Label labelWarehouse;
        private Label labelBook;
        private PictureBox pbBack;
        private Label labelBookWarehouse;
        private ComboBox cbWarehouse;
        private TextBox tbBook;
    }
}