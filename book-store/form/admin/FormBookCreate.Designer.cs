namespace book_store.form.admin
{
    partial class FormBookCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookCreate));
            buttonEditImage = new Button();
            pbBookImage = new PictureBox();
            cbLanguage = new ComboBox();
            cbCoverType = new ComboBox();
            cbPublisher = new ComboBox();
            cbCategory = new ComboBox();
            cbAuthor = new ComboBox();
            labelLanguage = new Label();
            labelCoverType = new Label();
            labelPublisher = new Label();
            tbDescription = new TextBox();
            labelDescription = new Label();
            labelCategory = new Label();
            tbAgeRestrictions = new TextBox();
            labelAgeRestrictions = new Label();
            tbWeight = new TextBox();
            labelWeight = new Label();
            tbCirculation = new TextBox();
            labelCirculation = new Label();
            tbSize = new TextBox();
            labelSize = new Label();
            tbNumberOfPages = new TextBox();
            labelNumberOfPages = new Label();
            tbIsbn = new TextBox();
            labelIsbn = new Label();
            buttonCreate = new Button();
            tbYearOfPublishing = new TextBox();
            labelYearOfPublishing = new Label();
            tbSeries = new TextBox();
            labelSeries = new Label();
            tbPrice = new TextBox();
            labelPrice = new Label();
            labelAuthor = new Label();
            tbTitle = new TextBox();
            labelTitle = new Label();
            pbBack = new PictureBox();
            labelBook = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBookImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // buttonEditImage
            // 
            buttonEditImage.BackColor = Color.FromArgb(41, 2, 71);
            buttonEditImage.Cursor = Cursors.Hand;
            buttonEditImage.FlatStyle = FlatStyle.Flat;
            buttonEditImage.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditImage.ForeColor = SystemColors.Window;
            buttonEditImage.Location = new Point(1044, 415);
            buttonEditImage.Name = "buttonEditImage";
            buttonEditImage.Size = new Size(253, 50);
            buttonEditImage.TabIndex = 161;
            buttonEditImage.Text = "Изменить фото книги";
            buttonEditImage.UseVisualStyleBackColor = false;
            buttonEditImage.Click += buttonEditImage_Click;
            // 
            // pbBookImage
            // 
            pbBookImage.Location = new Point(1044, 31);
            pbBookImage.Name = "pbBookImage";
            pbBookImage.Size = new Size(253, 362);
            pbBookImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbBookImage.TabIndex = 160;
            pbBookImage.TabStop = false;
            // 
            // cbLanguage
            // 
            cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Location = new Point(738, 370);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(223, 23);
            cbLanguage.TabIndex = 159;
            // 
            // cbCoverType
            // 
            cbCoverType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCoverType.FormattingEnabled = true;
            cbCoverType.Location = new Point(738, 333);
            cbCoverType.Name = "cbCoverType";
            cbCoverType.Size = new Size(223, 23);
            cbCoverType.TabIndex = 158;
            // 
            // cbPublisher
            // 
            cbPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPublisher.FormattingEnabled = true;
            cbPublisher.Location = new Point(738, 295);
            cbPublisher.Name = "cbPublisher";
            cbPublisher.Size = new Size(223, 23);
            cbPublisher.TabIndex = 157;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(738, 215);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(223, 23);
            cbCategory.TabIndex = 156;
            // 
            // cbAuthor
            // 
            cbAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(263, 128);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(223, 23);
            cbAuthor.TabIndex = 155;
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLanguage.ForeColor = Color.Black;
            labelLanguage.Location = new Point(531, 372);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(50, 21);
            labelLanguage.TabIndex = 154;
            labelLanguage.Text = "Язык:";
            // 
            // labelCoverType
            // 
            labelCoverType.AutoSize = true;
            labelCoverType.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCoverType.ForeColor = Color.Black;
            labelCoverType.Location = new Point(531, 332);
            labelCoverType.Name = "labelCoverType";
            labelCoverType.Size = new Size(106, 21);
            labelCoverType.TabIndex = 153;
            labelCoverType.Text = "Тип обложки:";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPublisher.ForeColor = Color.Black;
            labelPublisher.Location = new Point(531, 295);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(86, 21);
            labelPublisher.TabIndex = 152;
            labelPublisher.Text = "Издатель: ";
            // 
            // tbDescription
            // 
            tbDescription.BackColor = Color.FromArgb(224, 224, 224);
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbDescription.Location = new Point(738, 254);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(223, 22);
            tbDescription.TabIndex = 151;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDescription.ForeColor = Color.Black;
            labelDescription.Location = new Point(531, 254);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 21);
            labelDescription.TabIndex = 150;
            labelDescription.Text = "Описание:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCategory.ForeColor = Color.Black;
            labelCategory.Location = new Point(531, 214);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(94, 21);
            labelCategory.TabIndex = 149;
            labelCategory.Text = "Категория: ";
            // 
            // tbAgeRestrictions
            // 
            tbAgeRestrictions.BackColor = Color.FromArgb(224, 224, 224);
            tbAgeRestrictions.BorderStyle = BorderStyle.None;
            tbAgeRestrictions.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbAgeRestrictions.Location = new Point(738, 166);
            tbAgeRestrictions.Name = "tbAgeRestrictions";
            tbAgeRestrictions.Size = new Size(223, 22);
            tbAgeRestrictions.TabIndex = 148;
            // 
            // labelAgeRestrictions
            // 
            labelAgeRestrictions.AutoSize = true;
            labelAgeRestrictions.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAgeRestrictions.ForeColor = Color.Black;
            labelAgeRestrictions.Location = new Point(531, 166);
            labelAgeRestrictions.Name = "labelAgeRestrictions";
            labelAgeRestrictions.Size = new Size(197, 21);
            labelAgeRestrictions.TabIndex = 147;
            labelAgeRestrictions.Text = "Возрастные ограничения:";
            // 
            // tbWeight
            // 
            tbWeight.BackColor = Color.FromArgb(224, 224, 224);
            tbWeight.BorderStyle = BorderStyle.None;
            tbWeight.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbWeight.Location = new Point(738, 126);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(223, 22);
            tbWeight.TabIndex = 146;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWeight.ForeColor = Color.Black;
            labelWeight.Location = new Point(531, 126);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(44, 21);
            labelWeight.TabIndex = 145;
            labelWeight.Text = "Вес: ";
            // 
            // tbCirculation
            // 
            tbCirculation.BackColor = Color.FromArgb(224, 224, 224);
            tbCirculation.BorderStyle = BorderStyle.None;
            tbCirculation.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbCirculation.Location = new Point(738, 89);
            tbCirculation.Name = "tbCirculation";
            tbCirculation.Size = new Size(223, 22);
            tbCirculation.TabIndex = 144;
            // 
            // labelCirculation
            // 
            labelCirculation.AutoSize = true;
            labelCirculation.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCirculation.ForeColor = Color.Black;
            labelCirculation.Location = new Point(531, 89);
            labelCirculation.Name = "labelCirculation";
            labelCirculation.Size = new Size(64, 21);
            labelCirculation.TabIndex = 143;
            labelCirculation.Text = "Тираж: ";
            // 
            // tbSize
            // 
            tbSize.BackColor = Color.FromArgb(224, 224, 224);
            tbSize.BorderStyle = BorderStyle.None;
            tbSize.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSize.Location = new Point(263, 377);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(223, 22);
            tbSize.TabIndex = 142;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSize.ForeColor = Color.Black;
            labelSize.Location = new Point(56, 377);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(65, 21);
            labelSize.TabIndex = 141;
            labelSize.Text = "Размер:";
            // 
            // tbNumberOfPages
            // 
            tbNumberOfPages.BackColor = Color.FromArgb(224, 224, 224);
            tbNumberOfPages.BorderStyle = BorderStyle.None;
            tbNumberOfPages.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbNumberOfPages.Location = new Point(263, 337);
            tbNumberOfPages.Name = "tbNumberOfPages";
            tbNumberOfPages.Size = new Size(223, 22);
            tbNumberOfPages.TabIndex = 140;
            // 
            // labelNumberOfPages
            // 
            labelNumberOfPages.AutoSize = true;
            labelNumberOfPages.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumberOfPages.ForeColor = Color.Black;
            labelNumberOfPages.Location = new Point(56, 337);
            labelNumberOfPages.Name = "labelNumberOfPages";
            labelNumberOfPages.Size = new Size(164, 21);
            labelNumberOfPages.TabIndex = 139;
            labelNumberOfPages.Text = "Количество страниц:";
            // 
            // tbIsbn
            // 
            tbIsbn.BackColor = Color.FromArgb(224, 224, 224);
            tbIsbn.BorderStyle = BorderStyle.None;
            tbIsbn.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbIsbn.Location = new Point(263, 289);
            tbIsbn.Name = "tbIsbn";
            tbIsbn.Size = new Size(223, 22);
            tbIsbn.TabIndex = 138;
            // 
            // labelIsbn
            // 
            labelIsbn.AutoSize = true;
            labelIsbn.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelIsbn.ForeColor = Color.Black;
            labelIsbn.Location = new Point(56, 289);
            labelIsbn.Name = "labelIsbn";
            labelIsbn.Size = new Size(42, 21);
            labelIsbn.TabIndex = 137;
            labelIsbn.Text = "isbn:";
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(41, 2, 71);
            buttonCreate.Cursor = Cursors.Hand;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCreate.ForeColor = SystemColors.Window;
            buttonCreate.Location = new Point(14, 580);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(253, 50);
            buttonCreate.TabIndex = 136;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // tbYearOfPublishing
            // 
            tbYearOfPublishing.BackColor = Color.FromArgb(224, 224, 224);
            tbYearOfPublishing.BorderStyle = BorderStyle.None;
            tbYearOfPublishing.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbYearOfPublishing.Location = new Point(263, 246);
            tbYearOfPublishing.Name = "tbYearOfPublishing";
            tbYearOfPublishing.Size = new Size(223, 22);
            tbYearOfPublishing.TabIndex = 135;
            // 
            // labelYearOfPublishing
            // 
            labelYearOfPublishing.AutoSize = true;
            labelYearOfPublishing.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelYearOfPublishing.ForeColor = Color.Black;
            labelYearOfPublishing.Location = new Point(56, 246);
            labelYearOfPublishing.Name = "labelYearOfPublishing";
            labelYearOfPublishing.Size = new Size(103, 21);
            labelYearOfPublishing.TabIndex = 134;
            labelYearOfPublishing.Text = "Год издания:";
            // 
            // tbSeries
            // 
            tbSeries.BackColor = Color.FromArgb(224, 224, 224);
            tbSeries.BorderStyle = BorderStyle.None;
            tbSeries.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSeries.Location = new Point(263, 206);
            tbSeries.Name = "tbSeries";
            tbSeries.Size = new Size(223, 22);
            tbSeries.TabIndex = 133;
            // 
            // labelSeries
            // 
            labelSeries.AutoSize = true;
            labelSeries.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSeries.ForeColor = Color.Black;
            labelSeries.Location = new Point(56, 206);
            labelSeries.Name = "labelSeries";
            labelSeries.Size = new Size(59, 21);
            labelSeries.TabIndex = 132;
            labelSeries.Text = "Серия:";
            // 
            // tbPrice
            // 
            tbPrice.BackColor = Color.FromArgb(224, 224, 224);
            tbPrice.BorderStyle = BorderStyle.None;
            tbPrice.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPrice.Location = new Point(263, 169);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(223, 22);
            tbPrice.TabIndex = 131;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.ForeColor = Color.Black;
            labelPrice.Location = new Point(56, 169);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(50, 21);
            labelPrice.TabIndex = 130;
            labelPrice.Text = "Цена:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAuthor.ForeColor = Color.Black;
            labelAuthor.Location = new Point(56, 127);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(57, 21);
            labelAuthor.TabIndex = 129;
            labelAuthor.Text = "Автор:";
            // 
            // tbTitle
            // 
            tbTitle.BackColor = Color.FromArgb(224, 224, 224);
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbTitle.Location = new Point(263, 89);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(223, 22);
            tbTitle.TabIndex = 128;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(56, 89);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(82, 21);
            labelTitle.TabIndex = 127;
            labelTitle.Text = "Название:";
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(19, 29);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 124;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelBook
            // 
            labelBook.AutoSize = true;
            labelBook.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBook.Location = new Point(56, 10);
            labelBook.Name = "labelBook";
            labelBook.Size = new Size(381, 48);
            labelBook.TabIndex = 123;
            labelBook.Text = "Создание новой книги";
            // 
            // FormBookCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 641);
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
            Controls.Add(buttonCreate);
            Controls.Add(tbYearOfPublishing);
            Controls.Add(labelYearOfPublishing);
            Controls.Add(tbSeries);
            Controls.Add(labelSeries);
            Controls.Add(tbPrice);
            Controls.Add(labelPrice);
            Controls.Add(labelAuthor);
            Controls.Add(tbTitle);
            Controls.Add(labelTitle);
            Controls.Add(pbBack);
            Controls.Add(labelBook);
            Name = "FormBookCreate";
            Text = "Создать новую книгу";
            Load += FormBookCreate_Load;
            ((System.ComponentModel.ISupportInitialize)pbBookImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDeleteBook;
        private Button buttonEditImage;
        private PictureBox pbBookImage;
        private ComboBox cbLanguage;
        private ComboBox cbCoverType;
        private ComboBox cbPublisher;
        private ComboBox cbCategory;
        private ComboBox cbAuthor;
        private Label labelLanguage;
        private Label labelCoverType;
        private Label labelPublisher;
        private TextBox tbDescription;
        private Label labelDescription;
        private Label labelCategory;
        private TextBox tbAgeRestrictions;
        private Label labelAgeRestrictions;
        private TextBox tbWeight;
        private Label labelWeight;
        private TextBox tbCirculation;
        private Label labelCirculation;
        private TextBox tbSize;
        private Label labelSize;
        private TextBox tbNumberOfPages;
        private Label labelNumberOfPages;
        private TextBox tbIsbn;
        private Label labelIsbn;
        private Button buttonCreate;
        private TextBox tbYearOfPublishing;
        private Label labelYearOfPublishing;
        private TextBox tbSeries;
        private Label labelSeries;
        private TextBox tbPrice;
        private Label labelPrice;
        private Label labelAuthor;
        private TextBox tbTitle;
        private Label labelTitle;
        private PictureBox pbBack;
        private Label labelBook;
    }
}