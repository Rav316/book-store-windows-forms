namespace book_store.form.admin
{
    partial class FormBookInfoAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookInfoAdmin));
            buttonSaveChanges = new Button();
            tbYearOfPublishing = new TextBox();
            labelYearOfPublishing = new Label();
            tbSeries = new TextBox();
            labelSeries = new Label();
            tbPrice = new TextBox();
            labelPrice = new Label();
            labelAuthor = new Label();
            tbTitle = new TextBox();
            labelTitle = new Label();
            tbId = new TextBox();
            labelId = new Label();
            pbBack = new PictureBox();
            labelBook = new Label();
            tbSize = new TextBox();
            labelSize = new Label();
            tbNumberOfPages = new TextBox();
            labelNumberOfPages = new Label();
            tbIsbn = new TextBox();
            labelIsbn = new Label();
            tbAgeRestrictions = new TextBox();
            labelAgeRestrictions = new Label();
            tbWeight = new TextBox();
            labelWeight = new Label();
            tbCirculation = new TextBox();
            labelCirculation = new Label();
            labelLanguage = new Label();
            labelCoverType = new Label();
            labelPublisher = new Label();
            tbDescription = new TextBox();
            labelDescription = new Label();
            labelCategory = new Label();
            cbAuthor = new ComboBox();
            cbCategory = new ComboBox();
            cbPublisher = new ComboBox();
            cbCoverType = new ComboBox();
            cbLanguage = new ComboBox();
            buttonEditImage = new Button();
            pbBookImage = new PictureBox();
            buttonDeleteBook = new Button();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBookImage).BeginInit();
            SuspendLayout();
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.FromArgb(41, 2, 71);
            buttonSaveChanges.Cursor = Cursors.Hand;
            buttonSaveChanges.FlatStyle = FlatStyle.Flat;
            buttonSaveChanges.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSaveChanges.ForeColor = SystemColors.Window;
            buttonSaveChanges.Location = new Point(16, 579);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(253, 50);
            buttonSaveChanges.TabIndex = 90;
            buttonSaveChanges.Text = "Сохранить изменения";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // tbYearOfPublishing
            // 
            tbYearOfPublishing.BackColor = Color.FromArgb(224, 224, 224);
            tbYearOfPublishing.BorderStyle = BorderStyle.None;
            tbYearOfPublishing.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbYearOfPublishing.Location = new Point(265, 283);
            tbYearOfPublishing.MaxLength = 10;
            tbYearOfPublishing.Name = "tbYearOfPublishing";
            tbYearOfPublishing.Size = new Size(223, 22);
            tbYearOfPublishing.TabIndex = 89;
            // 
            // labelYearOfPublishing
            // 
            labelYearOfPublishing.AutoSize = true;
            labelYearOfPublishing.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelYearOfPublishing.ForeColor = Color.Black;
            labelYearOfPublishing.Location = new Point(58, 283);
            labelYearOfPublishing.Name = "labelYearOfPublishing";
            labelYearOfPublishing.Size = new Size(103, 21);
            labelYearOfPublishing.TabIndex = 88;
            labelYearOfPublishing.Text = "Год издания:";
            // 
            // tbSeries
            // 
            tbSeries.BackColor = Color.FromArgb(224, 224, 224);
            tbSeries.BorderStyle = BorderStyle.None;
            tbSeries.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSeries.Location = new Point(265, 243);
            tbSeries.MaxLength = 32;
            tbSeries.Name = "tbSeries";
            tbSeries.Size = new Size(223, 22);
            tbSeries.TabIndex = 87;
            // 
            // labelSeries
            // 
            labelSeries.AutoSize = true;
            labelSeries.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSeries.ForeColor = Color.Black;
            labelSeries.Location = new Point(58, 243);
            labelSeries.Name = "labelSeries";
            labelSeries.Size = new Size(59, 21);
            labelSeries.TabIndex = 86;
            labelSeries.Text = "Серия:";
            // 
            // tbPrice
            // 
            tbPrice.BackColor = Color.FromArgb(224, 224, 224);
            tbPrice.BorderStyle = BorderStyle.None;
            tbPrice.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPrice.Location = new Point(265, 206);
            tbPrice.MaxLength = 10;
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(223, 22);
            tbPrice.TabIndex = 85;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.ForeColor = Color.Black;
            labelPrice.Location = new Point(58, 206);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(50, 21);
            labelPrice.TabIndex = 84;
            labelPrice.Text = "Цена:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAuthor.ForeColor = Color.Black;
            labelAuthor.Location = new Point(58, 164);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(57, 21);
            labelAuthor.TabIndex = 82;
            labelAuthor.Text = "Автор:";
            // 
            // tbTitle
            // 
            tbTitle.BackColor = Color.FromArgb(224, 224, 224);
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbTitle.Location = new Point(265, 126);
            tbTitle.MaxLength = 1000;
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(223, 22);
            tbTitle.TabIndex = 81;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(58, 126);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(82, 21);
            labelTitle.TabIndex = 80;
            labelTitle.Text = "Название:";
            // 
            // tbId
            // 
            tbId.BackColor = Color.FromArgb(224, 224, 224);
            tbId.BorderStyle = BorderStyle.None;
            tbId.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbId.Location = new Point(265, 88);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(223, 22);
            tbId.TabIndex = 79;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelId.ForeColor = Color.Black;
            labelId.Location = new Point(58, 88);
            labelId.Name = "labelId";
            labelId.Size = new Size(26, 21);
            labelId.TabIndex = 78;
            labelId.Text = "id:";
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(21, 28);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 76;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelBook
            // 
            labelBook.AutoSize = true;
            labelBook.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBook.Location = new Point(58, 9);
            labelBook.Name = "labelBook";
            labelBook.Size = new Size(355, 48);
            labelBook.TabIndex = 75;
            labelBook.Text = "Информация о книге";
            // 
            // tbSize
            // 
            tbSize.BackColor = Color.FromArgb(224, 224, 224);
            tbSize.BorderStyle = BorderStyle.None;
            tbSize.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSize.Location = new Point(265, 414);
            tbSize.MaxLength = 32;
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(223, 22);
            tbSize.TabIndex = 98;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSize.ForeColor = Color.Black;
            labelSize.Location = new Point(58, 414);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(65, 21);
            labelSize.TabIndex = 97;
            labelSize.Text = "Размер:";
            // 
            // tbNumberOfPages
            // 
            tbNumberOfPages.BackColor = Color.FromArgb(224, 224, 224);
            tbNumberOfPages.BorderStyle = BorderStyle.None;
            tbNumberOfPages.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbNumberOfPages.Location = new Point(265, 374);
            tbNumberOfPages.MaxLength = 10;
            tbNumberOfPages.Name = "tbNumberOfPages";
            tbNumberOfPages.Size = new Size(223, 22);
            tbNumberOfPages.TabIndex = 96;
            // 
            // labelNumberOfPages
            // 
            labelNumberOfPages.AutoSize = true;
            labelNumberOfPages.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumberOfPages.ForeColor = Color.Black;
            labelNumberOfPages.Location = new Point(58, 374);
            labelNumberOfPages.Name = "labelNumberOfPages";
            labelNumberOfPages.Size = new Size(164, 21);
            labelNumberOfPages.TabIndex = 95;
            labelNumberOfPages.Text = "Количество страниц:";
            // 
            // tbIsbn
            // 
            tbIsbn.BackColor = Color.FromArgb(224, 224, 224);
            tbIsbn.BorderStyle = BorderStyle.None;
            tbIsbn.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbIsbn.Location = new Point(265, 326);
            tbIsbn.MaxLength = 17;
            tbIsbn.Name = "tbIsbn";
            tbIsbn.Size = new Size(223, 22);
            tbIsbn.TabIndex = 94;
            // 
            // labelIsbn
            // 
            labelIsbn.AutoSize = true;
            labelIsbn.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelIsbn.ForeColor = Color.Black;
            labelIsbn.Location = new Point(58, 326);
            labelIsbn.Name = "labelIsbn";
            labelIsbn.Size = new Size(42, 21);
            labelIsbn.TabIndex = 93;
            labelIsbn.Text = "isbn:";
            // 
            // tbAgeRestrictions
            // 
            tbAgeRestrictions.BackColor = Color.FromArgb(224, 224, 224);
            tbAgeRestrictions.BorderStyle = BorderStyle.None;
            tbAgeRestrictions.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbAgeRestrictions.Location = new Point(740, 165);
            tbAgeRestrictions.MaxLength = 3;
            tbAgeRestrictions.Name = "tbAgeRestrictions";
            tbAgeRestrictions.Size = new Size(223, 22);
            tbAgeRestrictions.TabIndex = 104;
            // 
            // labelAgeRestrictions
            // 
            labelAgeRestrictions.AutoSize = true;
            labelAgeRestrictions.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAgeRestrictions.ForeColor = Color.Black;
            labelAgeRestrictions.Location = new Point(533, 165);
            labelAgeRestrictions.Name = "labelAgeRestrictions";
            labelAgeRestrictions.Size = new Size(197, 21);
            labelAgeRestrictions.TabIndex = 103;
            labelAgeRestrictions.Text = "Возрастные ограничения:";
            // 
            // tbWeight
            // 
            tbWeight.BackColor = Color.FromArgb(224, 224, 224);
            tbWeight.BorderStyle = BorderStyle.None;
            tbWeight.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbWeight.Location = new Point(740, 125);
            tbWeight.MaxLength = 10;
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(223, 22);
            tbWeight.TabIndex = 102;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWeight.ForeColor = Color.Black;
            labelWeight.Location = new Point(533, 125);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(44, 21);
            labelWeight.TabIndex = 101;
            labelWeight.Text = "Вес: ";
            // 
            // tbCirculation
            // 
            tbCirculation.BackColor = Color.FromArgb(224, 224, 224);
            tbCirculation.BorderStyle = BorderStyle.None;
            tbCirculation.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbCirculation.Location = new Point(740, 88);
            tbCirculation.MaxLength = 18;
            tbCirculation.Name = "tbCirculation";
            tbCirculation.Size = new Size(223, 22);
            tbCirculation.TabIndex = 100;
            // 
            // labelCirculation
            // 
            labelCirculation.AutoSize = true;
            labelCirculation.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCirculation.ForeColor = Color.Black;
            labelCirculation.Location = new Point(533, 88);
            labelCirculation.Name = "labelCirculation";
            labelCirculation.Size = new Size(64, 21);
            labelCirculation.TabIndex = 99;
            labelCirculation.Text = "Тираж: ";
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLanguage.ForeColor = Color.Black;
            labelLanguage.Location = new Point(533, 371);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(50, 21);
            labelLanguage.TabIndex = 113;
            labelLanguage.Text = "Язык:";
            // 
            // labelCoverType
            // 
            labelCoverType.AutoSize = true;
            labelCoverType.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCoverType.ForeColor = Color.Black;
            labelCoverType.Location = new Point(533, 331);
            labelCoverType.Name = "labelCoverType";
            labelCoverType.Size = new Size(106, 21);
            labelCoverType.TabIndex = 111;
            labelCoverType.Text = "Тип обложки:";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPublisher.ForeColor = Color.Black;
            labelPublisher.Location = new Point(533, 294);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(86, 21);
            labelPublisher.TabIndex = 109;
            labelPublisher.Text = "Издатель: ";
            // 
            // tbDescription
            // 
            tbDescription.BackColor = Color.FromArgb(224, 224, 224);
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbDescription.Location = new Point(740, 253);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(223, 22);
            tbDescription.TabIndex = 108;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDescription.ForeColor = Color.Black;
            labelDescription.Location = new Point(533, 253);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 21);
            labelDescription.TabIndex = 107;
            labelDescription.Text = "Описание:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCategory.ForeColor = Color.Black;
            labelCategory.Location = new Point(533, 213);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(94, 21);
            labelCategory.TabIndex = 105;
            labelCategory.Text = "Категория: ";
            // 
            // cbAuthor
            // 
            cbAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(265, 165);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(223, 23);
            cbAuthor.TabIndex = 115;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(740, 214);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(223, 23);
            cbCategory.TabIndex = 116;
            // 
            // cbPublisher
            // 
            cbPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPublisher.FormattingEnabled = true;
            cbPublisher.Location = new Point(740, 294);
            cbPublisher.Name = "cbPublisher";
            cbPublisher.Size = new Size(223, 23);
            cbPublisher.TabIndex = 117;
            // 
            // cbCoverType
            // 
            cbCoverType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCoverType.FormattingEnabled = true;
            cbCoverType.Location = new Point(740, 332);
            cbCoverType.Name = "cbCoverType";
            cbCoverType.Size = new Size(223, 23);
            cbCoverType.TabIndex = 118;
            // 
            // cbLanguage
            // 
            cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Location = new Point(740, 369);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(223, 23);
            cbLanguage.TabIndex = 119;
            // 
            // buttonEditImage
            // 
            buttonEditImage.BackColor = Color.FromArgb(41, 2, 71);
            buttonEditImage.Cursor = Cursors.Hand;
            buttonEditImage.FlatStyle = FlatStyle.Flat;
            buttonEditImage.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditImage.ForeColor = SystemColors.Window;
            buttonEditImage.Location = new Point(1046, 414);
            buttonEditImage.Name = "buttonEditImage";
            buttonEditImage.Size = new Size(253, 50);
            buttonEditImage.TabIndex = 121;
            buttonEditImage.Text = "Изменить фото книги";
            buttonEditImage.UseVisualStyleBackColor = false;
            buttonEditImage.Click += buttonEditImage_Click;
            // 
            // pbBookImage
            // 
            pbBookImage.Location = new Point(1046, 30);
            pbBookImage.Name = "pbBookImage";
            pbBookImage.Size = new Size(253, 362);
            pbBookImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbBookImage.TabIndex = 120;
            pbBookImage.TabStop = false;
            // 
            // buttonDeleteBook
            // 
            buttonDeleteBook.BackColor = Color.Red;
            buttonDeleteBook.Cursor = Cursors.Hand;
            buttonDeleteBook.FlatStyle = FlatStyle.Flat;
            buttonDeleteBook.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDeleteBook.ForeColor = SystemColors.Window;
            buttonDeleteBook.Location = new Point(1182, 597);
            buttonDeleteBook.Name = "buttonDeleteBook";
            buttonDeleteBook.Size = new Size(146, 32);
            buttonDeleteBook.TabIndex = 122;
            buttonDeleteBook.Text = "Удалить книгу";
            buttonDeleteBook.UseVisualStyleBackColor = false;
            buttonDeleteBook.Click += buttonDeleteBook_Click;
            // 
            // FormBookInfoAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 641);
            Controls.Add(buttonDeleteBook);
            Controls.Add(buttonEditImage);
            Controls.Add(pbBookImage);
            Controls.Add(cbLanguage);
            Controls.Add(cbCoverType);
            Controls.Add(cbPublisher);
            Controls.Add(cbCategory);
            Controls.Add(cbAuthor);
            Controls.Add(labelLanguage);
            Controls.Add(labelCoverType);
            Controls.Add(labelPublisher);
            Controls.Add(tbDescription);
            Controls.Add(labelDescription);
            Controls.Add(labelCategory);
            Controls.Add(tbAgeRestrictions);
            Controls.Add(labelAgeRestrictions);
            Controls.Add(tbWeight);
            Controls.Add(labelWeight);
            Controls.Add(tbCirculation);
            Controls.Add(labelCirculation);
            Controls.Add(tbSize);
            Controls.Add(labelSize);
            Controls.Add(tbNumberOfPages);
            Controls.Add(labelNumberOfPages);
            Controls.Add(tbIsbn);
            Controls.Add(labelIsbn);
            Controls.Add(buttonSaveChanges);
            Controls.Add(tbYearOfPublishing);
            Controls.Add(labelYearOfPublishing);
            Controls.Add(tbSeries);
            Controls.Add(labelSeries);
            Controls.Add(tbPrice);
            Controls.Add(labelPrice);
            Controls.Add(labelAuthor);
            Controls.Add(tbTitle);
            Controls.Add(labelTitle);
            Controls.Add(tbId);
            Controls.Add(labelId);
            Controls.Add(pbBack);
            Controls.Add(labelBook);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBookInfoAdmin";
            Text = "Информация о книге";
            Load += FormBookInfoAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBookImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSaveChanges;
        private TextBox tbYearOfPublishing;
        private Label labelYearOfPublishing;
        private TextBox tbSeries;
        private Label labelSeries;
        private TextBox tbPrice;
        private Label labelPrice;
        private Label labelAuthor;
        private TextBox tbTitle;
        private Label labelTitle;
        private TextBox tbId;
        private Label labelId;
        private PictureBox pbBack;
        private Label labelBook;
        private TextBox tbSize;
        private Label labelSize;
        private TextBox tbNumberOfPages;
        private Label labelNumberOfPages;
        private TextBox tbIsbn;
        private Label labelIsbn;
        private TextBox tbAgeRestrictions;
        private Label labelAgeRestrictions;
        private TextBox tbWeight;
        private Label labelWeight;
        private TextBox tbCirculation;
        private Label labelCirculation;
        private Label labelLanguage;
        private Label labelCoverType;
        private Label labelPublisher;
        private TextBox tbDescription;
        private Label labelDescription;
        private Label labelCategory;
        private ComboBox cbAuthor;
        private ComboBox cbCategory;
        private ComboBox cbPublisher;
        private ComboBox cbCoverType;
        private ComboBox cbLanguage;
        private Button buttonEditImage;
        private PictureBox pbBookImage;
        private Button buttonDeleteBook;
    }
}