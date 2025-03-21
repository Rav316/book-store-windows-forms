
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tbSearch = new TextBox();
            labelSearch = new Label();
            labelFavorites = new Label();
            labelCart = new Label();
            pbFavorites = new PictureBox();
            pbCart = new PictureBox();
            cbCategory = new ComboBox();
            labelCategory = new Label();
            tbAuthor = new TextBox();
            labelAuthor = new Label();
            gbFilters = new GroupBox();
            labelMaxPrice = new Label();
            labelMinPrice = new Label();
            nudMaxPrice = new NumericUpDown();
            nudMinPrice = new NumericUpDown();
            labelPrice = new Label();
            labelPublisher = new Label();
            tbPublisher = new TextBox();
            cbLanguage = new ComboBox();
            labelLanguage = new Label();
            cbCoverType = new ComboBox();
            labelCoverType = new Label();
            dgvBooks = new DataGridView();
            pbProfile = new PictureBox();
            labelProfile = new Label();
            Id = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            BookImage = new DataGridViewImageColumn();
            Price = new DataGridViewTextBoxColumn();
            IsInFavorites = new DataGridViewCheckBoxColumn();
            IsInCart = new DataGridViewCheckBoxColumn();
            IsAvailable = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbFavorites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCart).BeginInit();
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(224, 224, 224);
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Philosopher", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSearch.Location = new Point(182, 29);
            tbSearch.MinimumSize = new Size(300, 35);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(329, 36);
            tbSearch.TabIndex = 2;
            tbSearch.TextChanged += tbUsername_TextChanged;
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
            labelFavorites.Location = new Point(527, 49);
            labelFavorites.Name = "labelFavorites";
            labelFavorites.Size = new Size(70, 17);
            labelFavorites.TabIndex = 9;
            labelFavorites.Text = "Избранное";
            // 
            // labelCart
            // 
            labelCart.AutoSize = true;
            labelCart.Font = new Font("Philosopher", 9.749999F);
            labelCart.Location = new Point(620, 49);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(57, 17);
            labelCart.TabIndex = 10;
            labelCart.Text = "Корзина";
            // 
            // pbFavorites
            // 
            pbFavorites.Cursor = Cursors.Hand;
            pbFavorites.Image = (Image)resources.GetObject("pbFavorites.Image");
            pbFavorites.Location = new Point(542, 26);
            pbFavorites.Name = "pbFavorites";
            pbFavorites.Size = new Size(41, 20);
            pbFavorites.SizeMode = PictureBoxSizeMode.Zoom;
            pbFavorites.TabIndex = 11;
            pbFavorites.TabStop = false;
            pbFavorites.Click += pbFavorites_Click;
            // 
            // pbCart
            // 
            pbCart.Cursor = Cursors.Hand;
            pbCart.Image = (Image)resources.GetObject("pbCart.Image");
            pbCart.Location = new Point(626, 26);
            pbCart.Name = "pbCart";
            pbCart.Size = new Size(41, 20);
            pbCart.SizeMode = PictureBoxSizeMode.Zoom;
            pbCart.TabIndex = 12;
            pbCart.TabStop = false;
            pbCart.Click += pbCart_Click;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(6, 49);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 23);
            cbCategory.TabIndex = 13;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
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
            // tbAuthor
            // 
            tbAuthor.Location = new Point(6, 103);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(121, 23);
            tbAuthor.TabIndex = 15;
            tbAuthor.TextChanged += tbAuthor_TextChanged;
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
            gbFilters.Controls.Add(labelMaxPrice);
            gbFilters.Controls.Add(labelMinPrice);
            gbFilters.Controls.Add(nudMaxPrice);
            gbFilters.Controls.Add(nudMinPrice);
            gbFilters.Controls.Add(labelPrice);
            gbFilters.Controls.Add(labelPublisher);
            gbFilters.Controls.Add(tbPublisher);
            gbFilters.Controls.Add(cbLanguage);
            gbFilters.Controls.Add(labelLanguage);
            gbFilters.Controls.Add(cbCoverType);
            gbFilters.Controls.Add(labelCoverType);
            gbFilters.Controls.Add(cbCategory);
            gbFilters.Controls.Add(labelAuthor);
            gbFilters.Controls.Add(labelCategory);
            gbFilters.Controls.Add(tbAuthor);
            gbFilters.Location = new Point(12, 26);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(144, 395);
            gbFilters.TabIndex = 17;
            gbFilters.TabStop = false;
            gbFilters.Text = "фильтры";
            // 
            // labelMaxPrice
            // 
            labelMaxPrice.AutoSize = true;
            labelMaxPrice.Font = new Font("Philosopher", 9.749999F);
            labelMaxPrice.Location = new Point(87, 367);
            labelMaxPrice.Name = "labelMaxPrice";
            labelMaxPrice.Size = new Size(40, 17);
            labelMaxPrice.TabIndex = 29;
            labelMaxPrice.Text = "Макс.";
            // 
            // labelMinPrice
            // 
            labelMinPrice.AutoSize = true;
            labelMinPrice.Font = new Font("Philosopher", 9.749999F);
            labelMinPrice.Location = new Point(6, 367);
            labelMinPrice.Name = "labelMinPrice";
            labelMinPrice.Size = new Size(36, 17);
            labelMinPrice.TabIndex = 28;
            labelMinPrice.Text = "Мин.";
            // 
            // nudMaxPrice
            // 
            nudMaxPrice.Location = new Point(85, 341);
            nudMaxPrice.Name = "nudMaxPrice";
            nudMaxPrice.Size = new Size(42, 23);
            nudMaxPrice.TabIndex = 27;
            nudMaxPrice.ValueChanged += nudMaxPrice_ValueChanged;
            // 
            // nudMinPrice
            // 
            nudMinPrice.Location = new Point(6, 341);
            nudMinPrice.Name = "nudMinPrice";
            nudMinPrice.Size = new Size(42, 23);
            nudMinPrice.TabIndex = 26;
            nudMinPrice.ValueChanged += nudMinPrice_ValueChanged;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Philosopher", 9.749999F);
            labelPrice.Location = new Point(7, 305);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(49, 17);
            labelPrice.TabIndex = 25;
            labelPrice.Text = "Цена, ₽";
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
            cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Location = new Point(6, 210);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(121, 23);
            cbLanguage.TabIndex = 21;
            cbLanguage.SelectedIndexChanged += cbLanguage_SelectedIndexChanged;
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
            // cbCoverType
            // 
            cbCoverType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCoverType.FormattingEnabled = true;
            cbCoverType.Location = new Point(6, 157);
            cbCoverType.Name = "cbCoverType";
            cbCoverType.Size = new Size(121, 23);
            cbCoverType.TabIndex = 19;
            cbCoverType.SelectedIndexChanged += cbCoverType_SelectedIndexChanged;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Philosopher", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Id, BookName, Author, BookImage, Price, IsInFavorites, IsInCart, IsAvailable });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Philosopher", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.Location = new Point(182, 83);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowTemplate.Height = 136;
            dgvBooks.Size = new Size(569, 338);
            dgvBooks.TabIndex = 18;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            dgvBooks.CellFormatting += dgvBooks_CellFormatting;
            dgvBooks.DoubleClick += dgvBooks_DoubleClick;
            // 
            // pbProfile
            // 
            pbProfile.Cursor = Cursors.Hand;
            pbProfile.Image = (Image)resources.GetObject("pbProfile.Image");
            pbProfile.Location = new Point(700, 26);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(41, 20);
            pbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfile.TabIndex = 20;
            pbProfile.TabStop = false;
            pbProfile.Click += pbProfile_Click;
            // 
            // labelProfile
            // 
            labelProfile.AutoSize = true;
            labelProfile.Font = new Font("Philosopher", 9.749999F);
            labelProfile.Location = new Point(691, 49);
            labelProfile.Name = "labelProfile";
            labelProfile.Size = new Size(60, 17);
            labelProfile.TabIndex = 19;
            labelProfile.Text = "Профиль";
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
            // IsAvailable
            // 
            IsAvailable.HeaderText = "есть ли на складе";
            IsAvailable.Name = "IsAvailable";
            IsAvailable.Visible = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbProfile);
            Controls.Add(labelProfile);
            Controls.Add(dgvBooks);
            Controls.Add(gbFilters);
            Controls.Add(pbCart);
            Controls.Add(pbFavorites);
            Controls.Add(labelCart);
            Controls.Add(labelFavorites);
            Controls.Add(labelSearch);
            Controls.Add(tbSearch);
            Name = "FormMain";
            Text = "Главная";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pbFavorites).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCart).EndInit();
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearch;
        private Label labelSearch;
        private Label labelFavorites;
        private Label labelCart;
        private PictureBox pbFavorites;
        private PictureBox pbCart;
        private ComboBox cbCategory;
        private Label labelCategory;
        private TextBox tbAuthor;
        private Label labelAuthor;
        private GroupBox gbFilters;
        private Label labelPublisher;
        private TextBox tbPublisher;
        private ComboBox cbLanguage;
        private Label labelLanguage;
        private ComboBox cbCoverType;
        private Label labelCoverType;
        private DataGridView dgvBooks;
        private Label labelPrice;
        private NumericUpDown nudMaxPrice;
        private NumericUpDown nudMinPrice;
        private Label labelMaxPrice;
        private Label labelMinPrice;
        private PictureBox pbProfile;
        private Label labelProfile;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewImageColumn BookImage;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewCheckBoxColumn IsInFavorites;
        private DataGridViewCheckBoxColumn IsInCart;
        private DataGridViewTextBoxColumn IsAvailable;
    }
}