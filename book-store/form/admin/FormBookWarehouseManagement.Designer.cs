namespace book_store.form.admin
{
    partial class FormBookWarehouseManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookWarehouseManagement));
            buttonCreate = new Button();
            pbBack = new PictureBox();
            dgvBookWarehouses = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            BookId = new DataGridViewTextBoxColumn();
            WarehouseId = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            labelManagement = new Label();
            labelWarehouse = new Label();
            cbWarehouse = new ComboBox();
            labelBook = new Label();
            cbBook = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookWarehouses).BeginInit();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(41, 2, 71);
            buttonCreate.Cursor = Cursors.Hand;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCreate.ForeColor = SystemColors.Window;
            buttonCreate.Location = new Point(37, 405);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(195, 36);
            buttonCreate.TabIndex = 102;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(22, 31);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 101;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // dgvBookWarehouses
            // 
            dgvBookWarehouses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookWarehouses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookWarehouses.Columns.AddRange(new DataGridViewColumn[] { Id, BookId, WarehouseId, Quantity });
            dgvBookWarehouses.Location = new Point(37, 108);
            dgvBookWarehouses.Name = "dgvBookWarehouses";
            dgvBookWarehouses.ReadOnly = true;
            dgvBookWarehouses.Size = new Size(742, 291);
            dgvBookWarehouses.TabIndex = 98;
            dgvBookWarehouses.DoubleClick += dgvBookWarehouses_DoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // BookId
            // 
            BookId.HeaderText = "Книга";
            BookId.Name = "BookId";
            BookId.ReadOnly = true;
            // 
            // WarehouseId
            // 
            WarehouseId.HeaderText = "Склад";
            WarehouseId.Name = "WarehouseId";
            WarehouseId.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Количество";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManagement.Location = new Point(152, 9);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(519, 48);
            labelManagement.TabIndex = 97;
            labelManagement.Text = "Управление книгами на складе";
            // 
            // labelWarehouse
            // 
            labelWarehouse.AutoSize = true;
            labelWarehouse.Font = new Font("Philosopher", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWarehouse.Location = new Point(274, 74);
            labelWarehouse.Name = "labelWarehouse";
            labelWarehouse.Size = new Size(74, 28);
            labelWarehouse.TabIndex = 106;
            labelWarehouse.Text = "Склад:";
            // 
            // cbWarehouse
            // 
            cbWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWarehouse.FormattingEnabled = true;
            cbWarehouse.Items.AddRange(new object[] { "По умолчанию", "Высокий", "Низкий" });
            cbWarehouse.Location = new Point(369, 79);
            cbWarehouse.Name = "cbWarehouse";
            cbWarehouse.Size = new Size(121, 23);
            cbWarehouse.TabIndex = 105;
            cbWarehouse.SelectedIndexChanged += cbWarehouse_SelectedIndexChanged;
            // 
            // labelBook
            // 
            labelBook.AutoSize = true;
            labelBook.Font = new Font("Philosopher", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBook.Location = new Point(38, 74);
            labelBook.Name = "labelBook";
            labelBook.Size = new Size(79, 28);
            labelBook.TabIndex = 104;
            labelBook.Text = "Книга: ";
            // 
            // cbBook
            // 
            cbBook.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBook.FormattingEnabled = true;
            cbBook.Items.AddRange(new object[] { "По умолчанию", "Сначала новые", "Сначала старые" });
            cbBook.Location = new Point(123, 79);
            cbBook.Name = "cbBook";
            cbBook.Size = new Size(121, 23);
            cbBook.TabIndex = 103;
            cbBook.SelectedIndexChanged += cbBook_SelectedIndexChanged;
            // 
            // FormBookWarehouseManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelWarehouse);
            Controls.Add(cbWarehouse);
            Controls.Add(labelBook);
            Controls.Add(cbBook);
            Controls.Add(buttonCreate);
            Controls.Add(pbBack);
            Controls.Add(dgvBookWarehouses);
            Controls.Add(labelManagement);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBookWarehouseManagement";
            Text = "Управление книгами на складе";
            Load += FormBookWarehouseManagement_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookWarehouses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private PictureBox pbBack;
        private DataGridView dgvBookWarehouses;
        private Label labelManagement;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn WarehouseId;
        private DataGridViewTextBoxColumn Quantity;
        private Label labelWarehouse;
        private ComboBox cbWarehouse;
        private Label labelBook;
        private ComboBox cbBook;
    }
}