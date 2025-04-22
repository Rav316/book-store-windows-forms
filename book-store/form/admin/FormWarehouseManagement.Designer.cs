namespace book_store.form.admin
{
    partial class FormWarehouseManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWarehouseManagement));
            buttonCreate = new Button();
            pbBack = new PictureBox();
            labelSearch = new Label();
            tbSearch = new TextBox();
            dgvWarehouses = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            labelManagement = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWarehouses).BeginInit();
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
            buttonCreate.TabIndex = 96;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(22, 26);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 20);
            pbBack.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBack.TabIndex = 95;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Philosopher", 9.749999F);
            labelSearch.Location = new Point(37, 60);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(43, 17);
            labelSearch.TabIndex = 94;
            labelSearch.Text = "Поиск";
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(224, 224, 224);
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Philosopher", 18.75F);
            tbSearch.Location = new Point(37, 80);
            tbSearch.MinimumSize = new Size(300, 35);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(329, 35);
            tbSearch.TabIndex = 93;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // dgvWarehouses
            // 
            dgvWarehouses.AllowUserToResizeColumns = false;
            dgvWarehouses.AllowUserToResizeRows = false;
            dgvWarehouses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWarehouses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWarehouses.Columns.AddRange(new DataGridViewColumn[] { Id, CategoryName, Address });
            dgvWarehouses.Location = new Point(37, 135);
            dgvWarehouses.Name = "dgvWarehouses";
            dgvWarehouses.Size = new Size(742, 264);
            dgvWarehouses.TabIndex = 92;
            dgvWarehouses.DoubleClick += dgvWarehouses_DoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // CategoryName
            // 
            CategoryName.HeaderText = "Название";
            CategoryName.Name = "CategoryName";
            // 
            // Address
            // 
            Address.HeaderText = "адрес";
            Address.Name = "Address";
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManagement.Location = new Point(224, 9);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(373, 48);
            labelManagement.TabIndex = 91;
            labelManagement.Text = "Управление складами";
            // 
            // FormWarehouseManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreate);
            Controls.Add(pbBack);
            Controls.Add(labelSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvWarehouses);
            Controls.Add(labelManagement);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormWarehouseManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление складами";
            Load += FormWarehouseManagement_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWarehouses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private PictureBox pbBack;
        private Label labelSearch;
        private TextBox tbSearch;
        private DataGridView dgvWarehouses;
        private Label labelManagement;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Address;
    }
}