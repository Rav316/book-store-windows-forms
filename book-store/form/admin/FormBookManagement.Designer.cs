namespace book_store.form.admin
{
    partial class FormBookManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookManagement));
            labelManagement = new Label();
            dgvBooks = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            labelSearch = new Label();
            tbSearch = new TextBox();
            pbBack = new PictureBox();
            buttonCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManagement.Location = new Point(230, 9);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(354, 48);
            labelManagement.TabIndex = 3;
            labelManagement.Text = "Управление книгами";
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Id, Title, Author });
            dgvBooks.Location = new Point(36, 132);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(742, 264);
            dgvBooks.TabIndex = 4;
            dgvBooks.DoubleClick += dgvBooks_DoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            // 
            // Title
            // 
            Title.HeaderText = "Название";
            Title.Name = "Title";
            // 
            // Author
            // 
            Author.HeaderText = "Автор";
            Author.Name = "Author";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Philosopher", 9.749999F);
            labelSearch.Location = new Point(36, 57);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(43, 17);
            labelSearch.TabIndex = 9;
            labelSearch.Text = "Поиск";
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(224, 224, 224);
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Philosopher", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSearch.Location = new Point(36, 77);
            tbSearch.MinimumSize = new Size(300, 35);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(329, 36);
            tbSearch.TabIndex = 8;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(21, 28);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 77;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(41, 2, 71);
            buttonCreate.Cursor = Cursors.Hand;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCreate.ForeColor = SystemColors.Window;
            buttonCreate.Location = new Point(36, 402);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(195, 36);
            buttonCreate.TabIndex = 78;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // FormBookManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreate);
            Controls.Add(pbBack);
            Controls.Add(labelSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvBooks);
            Controls.Add(labelManagement);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBookManagement";
            Text = "Управление книгами";
            Load += FormBookManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelManagement;
        private DataGridView dgvBooks;
        private Label labelSearch;
        private TextBox tbSearch;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private PictureBox pbBack;
        private Button buttonCreate;
    }
}