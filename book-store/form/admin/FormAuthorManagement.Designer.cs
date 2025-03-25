namespace book_store.form.admin
{
    partial class FormAuthorManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorManagement));
            buttonCreate = new Button();
            pbBack = new PictureBox();
            labelSearch = new Label();
            tbSearch = new TextBox();
            dgvAuthors = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MidName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            labelManagement = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(41, 2, 71);
            buttonCreate.Cursor = Cursors.Hand;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCreate.ForeColor = SystemColors.Window;
            buttonCreate.Location = new Point(37, 404);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(195, 36);
            buttonCreate.TabIndex = 84;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(22, 30);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 83;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Philosopher", 9.749999F);
            labelSearch.Location = new Point(37, 59);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(43, 17);
            labelSearch.TabIndex = 82;
            labelSearch.Text = "Поиск";
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(224, 224, 224);
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Philosopher", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSearch.Location = new Point(37, 79);
            tbSearch.MinimumSize = new Size(300, 35);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(329, 36);
            tbSearch.TabIndex = 81;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // dgvAuthors
            // 
            dgvAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, MidName, LastName });
            dgvAuthors.Location = new Point(37, 134);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.Size = new Size(742, 264);
            dgvAuthors.TabIndex = 80;
            dgvAuthors.DoubleClick += dgvAuthors_DoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Имя";
            FirstName.Name = "FirstName";
            // 
            // MidName
            // 
            MidName.HeaderText = "Отчество";
            MidName.Name = "MidName";
            // 
            // LastName
            // 
            LastName.HeaderText = "Фамилия";
            LastName.Name = "LastName";
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManagement.Location = new Point(180, 9);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(453, 48);
            labelManagement.TabIndex = 79;
            labelManagement.Text = "Управление авторами книг";
            // 
            // FormAuthorManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreate);
            Controls.Add(pbBack);
            Controls.Add(labelSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvAuthors);
            Controls.Add(labelManagement);
            Name = "FormAuthorManagement";
            Text = "Управление авторами книг";
            Load += FormAuthorManagement_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private PictureBox pbBack;
        private Label labelSearch;
        private TextBox tbSearch;
        private DataGridView dgvAuthors;
        private Label labelManagement;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MidName;
        private DataGridViewTextBoxColumn LastName;
    }
}