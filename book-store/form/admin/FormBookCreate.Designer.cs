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
            tbWidth = new TextBox();
            labelWidth = new Label();
            tbLength = new TextBox();
            labelLength = new Label();
            tbHeight = new TextBox();
            labelHeight = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
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
            cbLanguage.Location = new Point(736, 405);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(223, 23);
            cbLanguage.TabIndex = 159;
            // 
            // cbCoverType
            // 
            cbCoverType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCoverType.FormattingEnabled = true;
            cbCoverType.Location = new Point(736, 368);
            cbCoverType.Name = "cbCoverType";
            cbCoverType.Size = new Size(223, 23);
            cbCoverType.TabIndex = 158;
            // 
            // cbPublisher
            // 
            cbPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPublisher.FormattingEnabled = true;
            cbPublisher.Location = new Point(736, 330);
            cbPublisher.Name = "cbPublisher";
            cbPublisher.Size = new Size(223, 23);
            cbPublisher.TabIndex = 157;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(736, 250);
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
            labelLanguage.Location = new Point(529, 407);
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
            labelCoverType.Location = new Point(529, 367);
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
            labelPublisher.Location = new Point(529, 330);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(86, 21);
            labelPublisher.TabIndex = 152;
            labelPublisher.Text = "Издатель: ";
            // 
            // tbDescription
            // 
            tbDescription.BackColor = Color.FromArgb(224, 224, 224);
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.Font = new Font("Philosopher", 11.25F);
            tbDescription.Location = new Point(736, 289);
            tbDescription.MinimumSize = new Size(223, 22);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(223, 22);
            tbDescription.TabIndex = 151;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDescription.ForeColor = Color.Black;
            labelDescription.Location = new Point(529, 289);
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
            labelCategory.Location = new Point(529, 249);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(94, 21);
            labelCategory.TabIndex = 149;
            labelCategory.Text = "Категория: ";
            // 
            // tbAgeRestrictions
            // 
            tbAgeRestrictions.BackColor = Color.FromArgb(224, 224, 224);
            tbAgeRestrictions.BorderStyle = BorderStyle.None;
            tbAgeRestrictions.Font = new Font("Philosopher", 11.25F);
            tbAgeRestrictions.Location = new Point(736, 201);
            tbAgeRestrictions.MaxLength = 3;
            tbAgeRestrictions.MinimumSize = new Size(223, 22);
            tbAgeRestrictions.Name = "tbAgeRestrictions";
            tbAgeRestrictions.Size = new Size(223, 22);
            tbAgeRestrictions.TabIndex = 148;
            // 
            // labelAgeRestrictions
            // 
            labelAgeRestrictions.AutoSize = true;
            labelAgeRestrictions.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAgeRestrictions.ForeColor = Color.Black;
            labelAgeRestrictions.Location = new Point(529, 201);
            labelAgeRestrictions.Name = "labelAgeRestrictions";
            labelAgeRestrictions.Size = new Size(197, 21);
            labelAgeRestrictions.TabIndex = 147;
            labelAgeRestrictions.Text = "Возрастные ограничения:";
            // 
            // tbWeight
            // 
            tbWeight.BackColor = Color.FromArgb(224, 224, 224);
            tbWeight.BorderStyle = BorderStyle.None;
            tbWeight.Font = new Font("Philosopher", 11.25F);
            tbWeight.Location = new Point(736, 161);
            tbWeight.MaxLength = 10;
            tbWeight.MinimumSize = new Size(223, 22);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(223, 22);
            tbWeight.TabIndex = 146;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWeight.ForeColor = Color.Black;
            labelWeight.Location = new Point(529, 161);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(44, 21);
            labelWeight.TabIndex = 145;
            labelWeight.Text = "Вес: ";
            // 
            // tbCirculation
            // 
            tbCirculation.BackColor = Color.FromArgb(224, 224, 224);
            tbCirculation.BorderStyle = BorderStyle.None;
            tbCirculation.Font = new Font("Philosopher", 11.25F);
            tbCirculation.Location = new Point(736, 124);
            tbCirculation.MaxLength = 18;
            tbCirculation.MinimumSize = new Size(223, 22);
            tbCirculation.Name = "tbCirculation";
            tbCirculation.Size = new Size(223, 22);
            tbCirculation.TabIndex = 144;
            // 
            // labelCirculation
            // 
            labelCirculation.AutoSize = true;
            labelCirculation.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCirculation.ForeColor = Color.Black;
            labelCirculation.Location = new Point(529, 124);
            labelCirculation.Name = "labelCirculation";
            labelCirculation.Size = new Size(64, 21);
            labelCirculation.TabIndex = 143;
            labelCirculation.Text = "Тираж: ";
            // 
            // tbNumberOfPages
            // 
            tbNumberOfPages.BackColor = Color.FromArgb(224, 224, 224);
            tbNumberOfPages.BorderStyle = BorderStyle.None;
            tbNumberOfPages.Font = new Font("Philosopher", 11.25F);
            tbNumberOfPages.Location = new Point(263, 332);
            tbNumberOfPages.MaxLength = 10;
            tbNumberOfPages.MinimumSize = new Size(223, 22);
            tbNumberOfPages.Name = "tbNumberOfPages";
            tbNumberOfPages.Size = new Size(223, 22);
            tbNumberOfPages.TabIndex = 140;
            // 
            // labelNumberOfPages
            // 
            labelNumberOfPages.AutoSize = true;
            labelNumberOfPages.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumberOfPages.ForeColor = Color.Black;
            labelNumberOfPages.Location = new Point(56, 332);
            labelNumberOfPages.Name = "labelNumberOfPages";
            labelNumberOfPages.Size = new Size(164, 21);
            labelNumberOfPages.TabIndex = 139;
            labelNumberOfPages.Text = "Количество страниц:";
            // 
            // tbIsbn
            // 
            tbIsbn.BackColor = Color.FromArgb(224, 224, 224);
            tbIsbn.BorderStyle = BorderStyle.None;
            tbIsbn.Font = new Font("Philosopher", 11.25F);
            tbIsbn.Location = new Point(263, 289);
            tbIsbn.MaxLength = 17;
            tbIsbn.MinimumSize = new Size(223, 22);
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
            tbYearOfPublishing.Font = new Font("Philosopher", 11.25F);
            tbYearOfPublishing.Location = new Point(263, 246);
            tbYearOfPublishing.MaxLength = 10;
            tbYearOfPublishing.MinimumSize = new Size(223, 22);
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
            tbSeries.Font = new Font("Philosopher", 11.25F);
            tbSeries.Location = new Point(263, 206);
            tbSeries.MaxLength = 32;
            tbSeries.MinimumSize = new Size(223, 22);
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
            tbPrice.Font = new Font("Philosopher", 11.25F);
            tbPrice.Location = new Point(263, 169);
            tbPrice.MaxLength = 10;
            tbPrice.MinimumSize = new Size(223, 22);
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
            tbTitle.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbTitle.Location = new Point(263, 89);
            tbTitle.MaxLength = 1000;
            tbTitle.MinimumSize = new Size(223, 22);
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
            pbBack.Location = new Point(19, 24);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 20);
            pbBack.SizeMode = PictureBoxSizeMode.CenterImage;
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
            // tbWidth
            // 
            tbWidth.BackColor = Color.FromArgb(224, 224, 224);
            tbWidth.BorderStyle = BorderStyle.None;
            tbWidth.Font = new Font("Philosopher", 11.25F);
            tbWidth.Location = new Point(263, 406);
            tbWidth.MaxLength = 10;
            tbWidth.MinimumSize = new Size(223, 22);
            tbWidth.Name = "tbWidth";
            tbWidth.Size = new Size(223, 22);
            tbWidth.TabIndex = 163;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWidth.ForeColor = Color.Black;
            labelWidth.Location = new Point(56, 406);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(73, 21);
            labelWidth.TabIndex = 162;
            labelWidth.Text = "Ширина:";
            // 
            // tbLength
            // 
            tbLength.BackColor = Color.FromArgb(224, 224, 224);
            tbLength.BorderStyle = BorderStyle.None;
            tbLength.Font = new Font("Philosopher", 11.25F);
            tbLength.Location = new Point(736, 86);
            tbLength.MaxLength = 10;
            tbLength.MinimumSize = new Size(223, 22);
            tbLength.Name = "tbLength";
            tbLength.Size = new Size(223, 22);
            tbLength.TabIndex = 165;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLength.ForeColor = Color.Black;
            labelLength.Location = new Point(529, 86);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(60, 21);
            labelLength.TabIndex = 164;
            labelLength.Text = "Длина:";
            // 
            // tbHeight
            // 
            tbHeight.BackColor = Color.FromArgb(224, 224, 224);
            tbHeight.BorderStyle = BorderStyle.None;
            tbHeight.Font = new Font("Philosopher", 11.25F);
            tbHeight.Location = new Point(263, 368);
            tbHeight.MaxLength = 10;
            tbHeight.MinimumSize = new Size(223, 22);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(223, 22);
            tbHeight.TabIndex = 167;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelHeight.ForeColor = Color.Black;
            labelHeight.Location = new Point(56, 367);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(67, 21);
            labelHeight.TabIndex = 166;
            labelHeight.Text = "Высота:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(491, 78);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 168;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(491, 158);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 169;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(492, 234);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 170;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(492, 276);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 171;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(492, 318);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 172;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(492, 356);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 173;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(492, 393);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 174;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(962, 74);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 175;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(962, 113);
            label9.Name = "label9";
            label9.Size = new Size(15, 20);
            label9.TabIndex = 176;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(962, 149);
            label10.Name = "label10";
            label10.Size = new Size(15, 20);
            label10.TabIndex = 177;
            label10.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(962, 189);
            label11.Name = "label11";
            label11.Size = new Size(15, 20);
            label11.TabIndex = 178;
            label11.Text = "*";
            // 
            // FormBookCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 641);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbHeight);
            Controls.Add(labelHeight);
            Controls.Add(tbLength);
            Controls.Add(labelLength);
            Controls.Add(tbWidth);
            Controls.Add(labelWidth);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBookCreate";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox tbWidth;
        private Label labelWidth;
        private TextBox tbLength;
        private Label labelLength;
        private TextBox tbHeight;
        private Label labelHeight;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}