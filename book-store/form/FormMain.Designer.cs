namespace book_store.form
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tbUsername = new TextBox();
            labelSearch = new Label();
            labelFavorites = new Label();
            labelCart = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            cbCategory = new ComboBox();
            labelCategory = new Label();
            textBox1 = new TextBox();
            labelAuthor = new Label();
            gbFilters = new GroupBox();
            labelPublisher = new Label();
            tbPublisher = new TextBox();
            cbLanguage = new ComboBox();
            labelLanguage = new Label();
            comboBox1 = new ComboBox();
            labelCoverType = new Label();
            dgvBooks = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            BookImage = new DataGridViewImageColumn();
            Price = new DataGridViewTextBoxColumn();
            IsInFavorites = new DataGridViewCheckBoxColumn();
            IsInCart = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(224, 224, 224);
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Philosopher", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbUsername.Location = new Point(182, 29);
            tbUsername.MinimumSize = new Size(300, 35);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(395, 36);
            tbUsername.TabIndex = 2;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Philosopher", 9.749999F);
            labelSearch.Location = new Point(182, 9);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(43, 17);
            labelSearch.TabIndex = 7;
            labelSearch.Text = "Поиск";
            // 
            // labelFavorites
            // 
            labelFavorites.AutoSize = true;
            labelFavorites.Font = new Font("Philosopher", 9.749999F);
            labelFavorites.Location = new Point(611, 49);
            labelFavorites.Name = "labelFavorites";
            labelFavorites.Size = new Size(70, 17);
            labelFavorites.TabIndex = 9;
            labelFavorites.Text = "Избранное";
            // 
            // labelCart
            // 
            labelCart.AutoSize = true;
            labelCart.Font = new Font("Philosopher", 9.749999F);
            labelCart.Location = new Point(704, 49);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(57, 17);
            labelCart.TabIndex = 10;
            labelCart.Text = "Корзина";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(626, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(710, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(6, 49);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 23);
            cbCategory.TabIndex = 13;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Philosopher", 9.749999F);
            labelCategory.Location = new Point(6, 29);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(69, 17);
            labelCategory.TabIndex = 14;
            labelCategory.Text = "Категория";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 15;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Philosopher", 9.749999F);
            labelAuthor.Location = new Point(6, 83);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(43, 17);
            labelAuthor.TabIndex = 16;
            labelAuthor.Text = "Автор";
            // 
            // gbFilters
            // 
            gbFilters.BackColor = Color.Transparent;
            gbFilters.Controls.Add(labelPublisher);
            gbFilters.Controls.Add(tbPublisher);
            gbFilters.Controls.Add(cbLanguage);
            gbFilters.Controls.Add(labelLanguage);
            gbFilters.Controls.Add(comboBox1);
            gbFilters.Controls.Add(labelCoverType);
            gbFilters.Controls.Add(cbCategory);
            gbFilters.Controls.Add(labelAuthor);
            gbFilters.Controls.Add(labelCategory);
            gbFilters.Controls.Add(textBox1);
            gbFilters.Location = new Point(12, 26);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(144, 395);
            gbFilters.TabIndex = 17;
            gbFilters.TabStop = false;
            gbFilters.Text = "фильтры";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Font = new Font("Philosopher", 9.749999F);
            labelPublisher.Location = new Point(6, 242);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(43, 17);
            labelPublisher.TabIndex = 23;
            labelPublisher.Text = "Автор";
            // 
            // tbPublisher
            // 
            tbPublisher.Location = new Point(6, 262);
            tbPublisher.Name = "tbPublisher";
            tbPublisher.Size = new Size(121, 23);
            tbPublisher.TabIndex = 22;
            // 
            // cbLanguage
            // 
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Location = new Point(6, 210);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(121, 23);
            cbLanguage.TabIndex = 21;
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.Font = new Font("Philosopher", 9.749999F);
            labelLanguage.Location = new Point(6, 190);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(37, 17);
            labelLanguage.TabIndex = 20;
            labelLanguage.Text = "Язык";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 19;
            // 
            // labelCoverType
            // 
            labelCoverType.AutoSize = true;
            labelCoverType.Font = new Font("Philosopher", 9.749999F);
            labelCoverType.Location = new Point(6, 137);
            labelCoverType.Name = "labelCoverType";
            labelCoverType.Size = new Size(83, 17);
            labelCoverType.TabIndex = 18;
            labelCoverType.Text = "Тип обложки";
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Id, BookName, Author, BookImage, Price, IsInFavorites, IsInCart });
            dgvBooks.Location = new Point(182, 83);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowTemplate.Height = 136;
            dgvBooks.Size = new Size(569, 338);
            dgvBooks.TabIndex = 18;
            dgvBooks.CellFormatting += dgvBooks_CellFormatting;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // BookName
            // 
            BookName.HeaderText = "Название книги";
            BookName.Name = "BookName";
            BookName.ReadOnly = true;
            // 
            // Author
            // 
            Author.HeaderText = "Автор";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // BookImage
            // 
            BookImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BookImage.HeaderText = "Изображение";
            BookImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            BookImage.Name = "BookImage";
            BookImage.ReadOnly = true;
            BookImage.Resizable = DataGridViewTriState.True;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // IsInFavorites
            // 
            IsInFavorites.HeaderText = "В избранном";
            IsInFavorites.Name = "IsInFavorites";
            IsInFavorites.ReadOnly = true;
            // 
            // IsInCart
            // 
            IsInCart.HeaderText = "В корзине";
            IsInCart.Name = "IsInCart";
            IsInCart.ReadOnly = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBooks);
            Controls.Add(gbFilters);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelCart);
            Controls.Add(labelFavorites);
            Controls.Add(labelSearch);
            Controls.Add(tbUsername);
            Name = "FormMain";
            Text = "Главная";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsername;
        private Label labelSearch;
        private Label labelFavorites;
        private Label labelCart;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox cbCategory;
        private Label labelCategory;
        private TextBox textBox1;
        private Label labelAuthor;
        private GroupBox gbFilters;
        private Label labelPublisher;
        private TextBox tbPublisher;
        private ComboBox cbLanguage;
        private Label labelLanguage;
        private ComboBox comboBox1;
        private Label labelCoverType;
        private DataGridView dgvBooks;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewImageColumn BookImage;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewCheckBoxColumn IsInFavorites;
        private DataGridViewCheckBoxColumn IsInCart;
    }
}