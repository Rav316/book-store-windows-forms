namespace book_store.form
{
    partial class FormBookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookInfo));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            labelBookInfo = new Label();
            pbBookImage = new PictureBox();
            labelBookName = new Label();
            labelAuthor = new Label();
            labelId = new Label();
            labelIdValue = new Label();
            label3 = new Label();
            label4 = new Label();
            labelPublisherValue = new Label();
            labelPublisher = new Label();
            label7 = new Label();
            labelYearOfPublishingValue = new Label();
            labelYearOfPublishing = new Label();
            label10 = new Label();
            labelSeriesValue = new Label();
            labelSeries = new Label();
            label13 = new Label();
            labelCoverTypeValue = new Label();
            labelCoverType = new Label();
            label16 = new Label();
            labelSizeValue = new Label();
            labelSize = new Label();
            label19 = new Label();
            labelNumberOfPagesValue = new Label();
            labelNumberOfPages = new Label();
            label22 = new Label();
            labelIsbnValue = new Label();
            labelIsbn = new Label();
            label25 = new Label();
            labelAgeRestrictionValue = new Label();
            labelAgeRestriction = new Label();
            label28 = new Label();
            labelWeightValue = new Label();
            labelWeight = new Label();
            label31 = new Label();
            labelCirculationValue = new Label();
            labelCirculation = new Label();
            tbBookDescription = new TextBox();
            panel1 = new Panel();
            pbInFavorites = new PictureBox();
            buttonInCart = new Button();
            labelPrice = new Label();
            labelReviews = new Label();
            label2 = new Label();
            buttonAddReview = new Button();
            cbOrderByDate = new ComboBox();
            dgvReviews = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            UserAvatar = new DataGridViewImageColumn();
            Content = new DataGridViewTextBoxColumn();
            Rating = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            labelDateFilter = new Label();
            labelRating = new Label();
            cbOrderByRating = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBookImage).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbInFavorites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReviews).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 10);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // labelBookInfo
            // 
            labelBookInfo.AutoSize = true;
            labelBookInfo.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBookInfo.Location = new Point(63, 6);
            labelBookInfo.Name = "labelBookInfo";
            labelBookInfo.Size = new Size(355, 48);
            labelBookInfo.TabIndex = 22;
            labelBookInfo.Text = "Информация о книге";
            // 
            // pbBookImage
            // 
            pbBookImage.Image = (Image)resources.GetObject("pbBookImage.Image");
            pbBookImage.Location = new Point(21, 65);
            pbBookImage.Name = "pbBookImage";
            pbBookImage.Size = new Size(286, 447);
            pbBookImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbBookImage.TabIndex = 23;
            pbBookImage.TabStop = false;
            // 
            // labelBookName
            // 
            labelBookName.AutoSize = true;
            labelBookName.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBookName.ForeColor = Color.FromArgb(41, 2, 71);
            labelBookName.Location = new Point(342, 65);
            labelBookName.Name = "labelBookName";
            labelBookName.Size = new Size(437, 25);
            labelBookName.TabIndex = 24;
            labelBookName.Text = "Лягушка, слон и брокколи. Как жить и как не надо";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Philosopher", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 204);
            labelAuthor.ForeColor = Color.FromArgb(41, 2, 71);
            labelAuthor.Location = new Point(342, 90);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(112, 21);
            labelAuthor.TabIndex = 25;
            labelAuthor.Text = "Алекс Марков";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelId.ForeColor = Color.FromArgb(41, 2, 71);
            labelId.Location = new Point(342, 125);
            labelId.Name = "labelId";
            labelId.Size = new Size(79, 21);
            labelId.TabIndex = 26;
            labelId.Text = "ID товара";
            // 
            // labelIdValue
            // 
            labelIdValue.AutoSize = true;
            labelIdValue.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelIdValue.ForeColor = Color.FromArgb(41, 2, 71);
            labelIdValue.Location = new Point(644, 125);
            labelIdValue.Name = "labelIdValue";
            labelIdValue.Size = new Size(73, 21);
            labelIdValue.TabIndex = 27;
            labelIdValue.Text = "2892673 ";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(41, 2, 71);
            label3.Location = new Point(342, 149);
            label3.Name = "label3";
            label3.Size = new Size(561, 2);
            label3.TabIndex = 28;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(41, 2, 71);
            label4.Location = new Point(342, 186);
            label4.Name = "label4";
            label4.Size = new Size(561, 2);
            label4.TabIndex = 31;
            // 
            // labelPublisherValue
            // 
            labelPublisherValue.AutoSize = true;
            labelPublisherValue.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPublisherValue.ForeColor = Color.FromArgb(41, 2, 71);
            labelPublisherValue.Location = new Point(644, 162);
            labelPublisherValue.Name = "labelPublisherValue";
            labelPublisherValue.Size = new Size(40, 21);
            labelPublisherValue.TabIndex = 30;
            labelPublisherValue.Text = "ACT";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPublisher.ForeColor = Color.FromArgb(41, 2, 71);
            labelPublisher.Location = new Point(342, 162);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(110, 21);
            labelPublisher.TabIndex = 29;
            labelPublisher.Text = "Издательство";
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.FromArgb(41, 2, 71);
            label7.Location = new Point(342, 258);
            label7.Name = "label7";
            label7.Size = new Size(561, 2);
            label7.TabIndex = 37;
            // 
            // labelYearOfPublishingValue
            // 
            labelYearOfPublishingValue.AutoSize = true;
            labelYearOfPublishingValue.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelYearOfPublishingValue.ForeColor = Color.FromArgb(41, 2, 71);
            labelYearOfPublishingValue.Location = new Point(644, 234);
            labelYearOfPublishingValue.Name = "labelYearOfPublishingValue";
            labelYearOfPublishingValue.Size = new Size(47, 21);
            labelYearOfPublishingValue.TabIndex = 36;
            labelYearOfPublishingValue.Text = "2022 ";
            // 
            // labelYearOfPublishing
            // 
            labelYearOfPublishing.AutoSize = true;
            labelYearOfPublishing.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelYearOfPublishing.ForeColor = Color.FromArgb(41, 2, 71);
            labelYearOfPublishing.Location = new Point(342, 234);
            labelYearOfPublishing.Name = "labelYearOfPublishing";
            labelYearOfPublishing.Size = new Size(99, 21);
            labelYearOfPublishing.TabIndex = 35;
            labelYearOfPublishing.Text = "Год издания";
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.FromArgb(41, 2, 71);
            label10.Location = new Point(342, 221);
            label10.Name = "label10";
            label10.Size = new Size(561, 2);
            label10.TabIndex = 34;
            // 
            // labelSeriesValue
            // 
            labelSeriesValue.AutoSize = true;
            labelSeriesValue.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSeriesValue.ForeColor = Color.FromArgb(41, 2, 71);
            labelSeriesValue.Location = new Point(644, 197);
            labelSeriesValue.Name = "labelSeriesValue";
            labelSeriesValue.Size = new Size(129, 21);
            labelSeriesValue.TabIndex = 33;
            labelSeriesValue.Text = "Звезда нофикшн";
            // 
            // labelSeries
            // 
            labelSeries.AutoSize = true;
            labelSeries.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSeries.ForeColor = Color.FromArgb(41, 2, 71);
            labelSeries.Location = new Point(342, 197);
            labelSeries.Name = "labelSeries";
            labelSeries.Size = new Size(55, 21);
            labelSeries.TabIndex = 32;
            labelSeries.Text = "Серия";
            // 
            // label13
            // 
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.ForeColor = Color.FromArgb(41, 2, 71);
            label13.Location = new Point(342, 402);
            label13.Name = "label13";
            label13.Size = new Size(561, 2);
            label13.TabIndex = 49;
            // 
            // labelCoverTypeValue
            // 
            labelCoverTypeValue.AutoSize = true;
            labelCoverTypeValue.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCoverTypeValue.ForeColor = Color.FromArgb(41, 2, 71);
            labelCoverTypeValue.Location = new Point(644, 378);
            labelCoverTypeValue.Name = "labelCoverTypeValue";
            labelCoverTypeValue.Size = new Size(145, 21);
            labelCoverTypeValue.TabIndex = 48;
            labelCoverTypeValue.Text = "Твердый переплёт";
            // 
            // labelCoverType
            // 
            labelCoverType.AutoSize = true;
            labelCoverType.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCoverType.ForeColor = Color.FromArgb(41, 2, 71);
            labelCoverType.Location = new Point(342, 378);
            labelCoverType.Name = "labelCoverType";
            labelCoverType.Size = new Size(102, 21);
            labelCoverType.TabIndex = 47;
            labelCoverType.Text = "Тип обложки";
            // 
            // label16
            // 
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label16.ForeColor = Color.FromArgb(41, 2, 71);
            label16.Location = new Point(342, 365);
            label16.Name = "label16";
            label16.Size = new Size(561, 2);
            label16.TabIndex = 46;
            // 
            // labelSizeValue
            // 
            labelSizeValue.AutoSize = true;
            labelSizeValue.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSizeValue.ForeColor = Color.FromArgb(41, 2, 71);
            labelSizeValue.Location = new Point(644, 341);
            labelSizeValue.Name = "labelSizeValue";
            labelSizeValue.Size = new Size(103, 21);
            labelSizeValue.TabIndex = 45;
            labelSizeValue.Text = "20.7x13.3x1.91";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSize.ForeColor = Color.FromArgb(41, 2, 71);
            labelSize.Location = new Point(342, 341);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(61, 21);
            labelSize.TabIndex = 44;
            labelSize.Text = "Размер";
            // 
            // label19
            // 
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label19.ForeColor = Color.FromArgb(41, 2, 71);
            label19.Location = new Point(342, 330);
            label19.Name = "label19";
            label19.Size = new Size(561, 2);
            label19.TabIndex = 43;
            // 
            // labelNumberOfPagesValue
            // 
            labelNumberOfPagesValue.AutoSize = true;
            labelNumberOfPagesValue.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumberOfPagesValue.ForeColor = Color.FromArgb(41, 2, 71);
            labelNumberOfPagesValue.Location = new Point(644, 306);
            labelNumberOfPagesValue.Name = "labelNumberOfPagesValue";
            labelNumberOfPagesValue.Size = new Size(35, 21);
            labelNumberOfPagesValue.TabIndex = 42;
            labelNumberOfPagesValue.Text = "320";
            // 
            // labelNumberOfPages
            // 
            labelNumberOfPages.AutoSize = true;
            labelNumberOfPages.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumberOfPages.ForeColor = Color.FromArgb(41, 2, 71);
            labelNumberOfPages.Location = new Point(342, 306);
            labelNumberOfPages.Name = "labelNumberOfPages";
            labelNumberOfPages.Size = new Size(160, 21);
            labelNumberOfPages.TabIndex = 41;
            labelNumberOfPages.Text = "Количество страниц";
            // 
            // label22
            // 
            label22.BorderStyle = BorderStyle.Fixed3D;
            label22.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label22.ForeColor = Color.FromArgb(41, 2, 71);
            label22.Location = new Point(342, 295);
            label22.Name = "label22";
            label22.Size = new Size(561, 2);
            label22.TabIndex = 40;
            // 
            // labelIsbnValue
            // 
            labelIsbnValue.AutoSize = true;
            labelIsbnValue.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelIsbnValue.ForeColor = Color.FromArgb(41, 2, 71);
            labelIsbnValue.Location = new Point(644, 269);
            labelIsbnValue.Name = "labelIsbnValue";
            labelIsbnValue.Size = new Size(137, 21);
            labelIsbnValue.TabIndex = 39;
            labelIsbnValue.Text = "978-5-17-148025-7";
            // 
            // labelIsbn
            // 
            labelIsbn.AutoSize = true;
            labelIsbn.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelIsbn.ForeColor = Color.FromArgb(41, 2, 71);
            labelIsbn.Location = new Point(342, 269);
            labelIsbn.Name = "labelIsbn";
            labelIsbn.Size = new Size(45, 21);
            labelIsbn.TabIndex = 38;
            labelIsbn.Text = "ISBN";
            // 
            // label25
            // 
            label25.BorderStyle = BorderStyle.Fixed3D;
            label25.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label25.ForeColor = Color.FromArgb(41, 2, 71);
            label25.Location = new Point(342, 510);
            label25.Name = "label25";
            label25.Size = new Size(561, 2);
            label25.TabIndex = 58;
            // 
            // labelAgeRestrictionValue
            // 
            labelAgeRestrictionValue.AutoSize = true;
            labelAgeRestrictionValue.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAgeRestrictionValue.ForeColor = Color.FromArgb(41, 2, 71);
            labelAgeRestrictionValue.Location = new Point(644, 486);
            labelAgeRestrictionValue.Name = "labelAgeRestrictionValue";
            labelAgeRestrictionValue.Size = new Size(32, 21);
            labelAgeRestrictionValue.TabIndex = 57;
            labelAgeRestrictionValue.Text = "16+";
            // 
            // labelAgeRestriction
            // 
            labelAgeRestriction.AutoSize = true;
            labelAgeRestriction.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAgeRestriction.ForeColor = Color.FromArgb(41, 2, 71);
            labelAgeRestriction.Location = new Point(342, 486);
            labelAgeRestriction.Name = "labelAgeRestriction";
            labelAgeRestriction.Size = new Size(193, 21);
            labelAgeRestriction.TabIndex = 56;
            labelAgeRestriction.Text = "Возрастные ограничения";
            // 
            // label28
            // 
            label28.BorderStyle = BorderStyle.Fixed3D;
            label28.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label28.ForeColor = Color.FromArgb(41, 2, 71);
            label28.Location = new Point(342, 473);
            label28.Name = "label28";
            label28.Size = new Size(561, 2);
            label28.TabIndex = 55;
            // 
            // labelWeightValue
            // 
            labelWeightValue.AutoSize = true;
            labelWeightValue.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWeightValue.ForeColor = Color.FromArgb(41, 2, 71);
            labelWeightValue.Location = new Point(644, 449);
            labelWeightValue.Name = "labelWeightValue";
            labelWeightValue.Size = new Size(32, 21);
            labelWeightValue.TabIndex = 54;
            labelWeightValue.Text = "310";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWeight.ForeColor = Color.FromArgb(41, 2, 71);
            labelWeight.Location = new Point(342, 449);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(51, 21);
            labelWeight.TabIndex = 53;
            labelWeight.Text = "Вес, г";
            // 
            // label31
            // 
            label31.BorderStyle = BorderStyle.Fixed3D;
            label31.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label31.ForeColor = Color.FromArgb(41, 2, 71);
            label31.Location = new Point(342, 438);
            label31.Name = "label31";
            label31.Size = new Size(561, 2);
            label31.TabIndex = 52;
            // 
            // labelCirculationValue
            // 
            labelCirculationValue.AutoSize = true;
            labelCirculationValue.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCirculationValue.ForeColor = Color.FromArgb(41, 2, 71);
            labelCirculationValue.Location = new Point(644, 414);
            labelCirculationValue.Name = "labelCirculationValue";
            labelCirculationValue.Size = new Size(45, 21);
            labelCirculationValue.TabIndex = 51;
            labelCirculationValue.Text = "5000";
            // 
            // labelCirculation
            // 
            labelCirculation.AutoSize = true;
            labelCirculation.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCirculation.ForeColor = Color.FromArgb(41, 2, 71);
            labelCirculation.Location = new Point(342, 414);
            labelCirculation.Name = "labelCirculation";
            labelCirculation.Size = new Size(56, 21);
            labelCirculation.TabIndex = 50;
            labelCirculation.Text = "Тираж";
            // 
            // tbBookDescription
            // 
            tbBookDescription.BorderStyle = BorderStyle.None;
            tbBookDescription.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbBookDescription.ForeColor = Color.FromArgb(41, 2, 71);
            tbBookDescription.Location = new Point(21, 538);
            tbBookDescription.Multiline = true;
            tbBookDescription.Name = "tbBookDescription";
            tbBookDescription.ReadOnly = true;
            tbBookDescription.Size = new Size(890, 172);
            tbBookDescription.TabIndex = 59;
            tbBookDescription.Text = resources.GetString("tbBookDescription.Text");
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pbInFavorites);
            panel1.Controls.Add(buttonInCart);
            panel1.Controls.Add(labelPrice);
            panel1.Location = new Point(942, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 339);
            panel1.TabIndex = 60;
            // 
            // pbInFavorites
            // 
            pbInFavorites.Cursor = Cursors.Hand;
            pbInFavorites.Image = (Image)resources.GetObject("pbInFavorites.Image");
            pbInFavorites.Location = new Point(308, 79);
            pbInFavorites.Name = "pbInFavorites";
            pbInFavorites.Size = new Size(50, 50);
            pbInFavorites.SizeMode = PictureBoxSizeMode.Zoom;
            pbInFavorites.TabIndex = 62;
            pbInFavorites.TabStop = false;
            pbInFavorites.Click += pbInFavorites_Click;
            // 
            // buttonInCart
            // 
            buttonInCart.BackColor = Color.FromArgb(41, 2, 71);
            buttonInCart.Cursor = Cursors.Hand;
            buttonInCart.FlatStyle = FlatStyle.Flat;
            buttonInCart.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonInCart.ForeColor = SystemColors.Window;
            buttonInCart.Location = new Point(14, 79);
            buttonInCart.Name = "buttonInCart";
            buttonInCart.Size = new Size(288, 50);
            buttonInCart.TabIndex = 61;
            buttonInCart.Text = "Добавить в корзину";
            buttonInCart.UseVisualStyleBackColor = false;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrice.ForeColor = Color.FromArgb(41, 2, 71);
            labelPrice.Location = new Point(3, 24);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(106, 48);
            labelPrice.TabIndex = 61;
            labelPrice.Text = "525 ₽";
            // 
            // labelReviews
            // 
            labelReviews.AutoSize = true;
            labelReviews.Font = new Font("Philosopher", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelReviews.Location = new Point(63, 713);
            labelReviews.Name = "labelReviews";
            labelReviews.Size = new Size(120, 40);
            labelReviews.TabIndex = 61;
            labelReviews.Text = "Отзывы";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(41, 2, 71);
            label2.Location = new Point(21, 704);
            label2.Name = "label2";
            label2.Size = new Size(1312, 2);
            label2.TabIndex = 62;
            // 
            // buttonAddReview
            // 
            buttonAddReview.BackColor = Color.FromArgb(41, 2, 71);
            buttonAddReview.Cursor = Cursors.Hand;
            buttonAddReview.FlatStyle = FlatStyle.Flat;
            buttonAddReview.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddReview.ForeColor = SystemColors.Window;
            buttonAddReview.Location = new Point(1027, 718);
            buttonAddReview.Name = "buttonAddReview";
            buttonAddReview.Size = new Size(288, 41);
            buttonAddReview.TabIndex = 63;
            buttonAddReview.Text = "Написать отзыв";
            buttonAddReview.UseVisualStyleBackColor = false;
            // 
            // cbOrderByDate
            // 
            cbOrderByDate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrderByDate.FormattingEnabled = true;
            cbOrderByDate.Items.AddRange(new object[] { "По умолчанию", "Сначала новые", "Сначала старые" });
            cbOrderByDate.Location = new Point(425, 724);
            cbOrderByDate.Name = "cbOrderByDate";
            cbOrderByDate.Size = new Size(121, 23);
            cbOrderByDate.TabIndex = 64;
            // 
            // dgvReviews
            // 
            dgvReviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReviews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReviews.Columns.AddRange(new DataGridViewColumn[] { Id, Username, UserAvatar, Content, Rating, CreatedAt });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReviews.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReviews.Location = new Point(21, 765);
            dgvReviews.Name = "dgvReviews";
            dgvReviews.RowTemplate.Height = 136;
            dgvReviews.Size = new Size(1294, 287);
            dgvReviews.TabIndex = 65;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Username
            // 
            Username.HeaderText = "Имя пользователя";
            Username.Name = "Username";
            // 
            // UserAvatar
            // 
            UserAvatar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserAvatar.HeaderText = "Аватар пользователя";
            UserAvatar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            UserAvatar.Name = "UserAvatar";
            UserAvatar.Resizable = DataGridViewTriState.True;
            // 
            // Content
            // 
            Content.HeaderText = "Контент";
            Content.Name = "Content";
            // 
            // Rating
            // 
            Rating.HeaderText = "Рейтинг";
            Rating.Name = "Rating";
            // 
            // CreatedAt
            // 
            CreatedAt.HeaderText = "оставлен в";
            CreatedAt.Name = "CreatedAt";
            // 
            // labelDateFilter
            // 
            labelDateFilter.AutoSize = true;
            labelDateFilter.Font = new Font("Philosopher", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDateFilter.Location = new Point(352, 719);
            labelDateFilter.Name = "labelDateFilter";
            labelDateFilter.Size = new Size(66, 28);
            labelDateFilter.TabIndex = 66;
            labelDateFilter.Text = "Дата: ";
            // 
            // labelRating
            // 
            labelRating.AutoSize = true;
            labelRating.Font = new Font("Philosopher", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRating.Location = new Point(577, 719);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(99, 28);
            labelRating.TabIndex = 68;
            labelRating.Text = "Рейтинг: ";
            // 
            // cbOrderByRating
            // 
            cbOrderByRating.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrderByRating.FormattingEnabled = true;
            cbOrderByRating.Items.AddRange(new object[] { "По умолчанию", "Высокий", "Низкий" });
            cbOrderByRating.Location = new Point(683, 724);
            cbOrderByRating.Name = "cbOrderByRating";
            cbOrderByRating.Size = new Size(121, 23);
            cbOrderByRating.TabIndex = 67;
            // 
            // FormBookInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1327, 1061);
            Controls.Add(labelRating);
            Controls.Add(cbOrderByRating);
            Controls.Add(labelDateFilter);
            Controls.Add(dgvReviews);
            Controls.Add(cbOrderByDate);
            Controls.Add(buttonAddReview);
            Controls.Add(label2);
            Controls.Add(labelReviews);
            Controls.Add(panel1);
            Controls.Add(tbBookDescription);
            Controls.Add(label25);
            Controls.Add(labelAgeRestrictionValue);
            Controls.Add(labelAgeRestriction);
            Controls.Add(label28);
            Controls.Add(labelWeightValue);
            Controls.Add(labelWeight);
            Controls.Add(label31);
            Controls.Add(labelCirculationValue);
            Controls.Add(labelCirculation);
            Controls.Add(label13);
            Controls.Add(labelCoverTypeValue);
            Controls.Add(labelCoverType);
            Controls.Add(label16);
            Controls.Add(labelSizeValue);
            Controls.Add(labelSize);
            Controls.Add(label19);
            Controls.Add(labelNumberOfPagesValue);
            Controls.Add(labelNumberOfPages);
            Controls.Add(label22);
            Controls.Add(labelIsbnValue);
            Controls.Add(labelIsbn);
            Controls.Add(label7);
            Controls.Add(labelYearOfPublishingValue);
            Controls.Add(labelYearOfPublishing);
            Controls.Add(label10);
            Controls.Add(labelSeriesValue);
            Controls.Add(labelSeries);
            Controls.Add(label4);
            Controls.Add(labelPublisherValue);
            Controls.Add(labelPublisher);
            Controls.Add(label3);
            Controls.Add(labelIdValue);
            Controls.Add(labelId);
            Controls.Add(labelAuthor);
            Controls.Add(labelBookName);
            Controls.Add(pbBookImage);
            Controls.Add(labelBookInfo);
            Controls.Add(pictureBox2);
            Name = "FormBookInfo";
            Text = "Информация о книге";
            Load += FormBookInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBookImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbInFavorites).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReviews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label labelBookInfo;
        private PictureBox pbBookImage;
        private Label labelBookName;
        private Label labelAuthor;
        private Label labelId;
        private Label labelIdValue;
        private Label label3;
        private Label label4;
        private Label labelPublisherValue;
        private Label labelPublisher;
        private Label label7;
        private Label labelYearOfPublishingValue;
        private Label labelYearOfPublishing;
        private Label label10;
        private Label labelSeriesValue;
        private Label labelSeries;
        private Label label13;
        private Label labelCoverTypeValue;
        private Label labelCoverType;
        private Label label16;
        private Label labelSizeValue;
        private Label labelSize;
        private Label label19;
        private Label labelNumberOfPagesValue;
        private Label labelNumberOfPages;
        private Label label22;
        private Label labelIsbnValue;
        private Label labelIsbn;
        private Label label25;
        private Label labelAgeRestrictionValue;
        private Label labelAgeRestriction;
        private Label label28;
        private Label labelWeightValue;
        private Label labelWeight;
        private Label label31;
        private Label labelCirculationValue;
        private Label labelCirculation;
        private TextBox tbBookDescription;
        private Panel panel1;
        private Label labelPrice;
        private Button buttonInCart;
        private PictureBox pbInFavorites;
        private Label labelReviews;
        private Label label2;
        private Button buttonAddReview;
        private ComboBox cbOrderByDate;
        private DataGridView dgvReviews;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewImageColumn UserAvatar;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewTextBoxColumn Rating;
        private DataGridViewTextBoxColumn CreatedAt;
        private Label labelDateFilter;
        private Label labelRating;
        private ComboBox cbOrderByRating;
    }
}