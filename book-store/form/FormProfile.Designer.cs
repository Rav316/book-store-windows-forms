namespace book_store.form
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pbAvatar = new PictureBox();
            pbBack = new PictureBox();
            labelProfile = new Label();
            buttonEditAvatar = new Button();
            labelUsername = new Label();
            tbUsername = new TextBox();
            tbCurrentPassword = new TextBox();
            labelCurrentPassword = new Label();
            tbNewPassword = new TextBox();
            labelNewPassword = new Label();
            tbConfirmNewPassword = new TextBox();
            labelConfirmNewPassword = new Label();
            tbEmail = new TextBox();
            labelEmail = new Label();
            tbAddress = new TextBox();
            labelAddress = new Label();
            buttonSaveChanges = new Button();
            buttonDeleteAccount = new Button();
            labelReviews = new Label();
            dgvReviews = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            BookId = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            BookImage = new DataGridViewImageColumn();
            Content = new DataGridViewTextBoxColumn();
            Rating = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            labelOrders = new Label();
            dgvOrders = new DataGridView();
            OrderId = new DataGridViewTextBoxColumn();
            PaymentMethod = new DataGridViewTextBoxColumn();
            PaymentStatus = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            PaidIn = new DataGridViewTextBoxColumn();
            buttonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReviews).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(535, 12);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(253, 234);
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pbAvatar.TabIndex = 0;
            pbAvatar.TabStop = false;
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(21, 23);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 20);
            pbBack.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBack.TabIndex = 22;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelProfile
            // 
            labelProfile.AutoSize = true;
            labelProfile.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProfile.Location = new Point(63, 6);
            labelProfile.Name = "labelProfile";
            labelProfile.Size = new Size(166, 48);
            labelProfile.TabIndex = 21;
            labelProfile.Text = "Профиль";
            // 
            // buttonEditAvatar
            // 
            buttonEditAvatar.BackColor = Color.FromArgb(41, 2, 71);
            buttonEditAvatar.Cursor = Cursors.Hand;
            buttonEditAvatar.FlatStyle = FlatStyle.Flat;
            buttonEditAvatar.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditAvatar.ForeColor = SystemColors.Window;
            buttonEditAvatar.Location = new Point(535, 251);
            buttonEditAvatar.Name = "buttonEditAvatar";
            buttonEditAvatar.Size = new Size(253, 50);
            buttonEditAvatar.TabIndex = 25;
            buttonEditAvatar.Text = "Изменить фото профиля";
            buttonEditAvatar.UseVisualStyleBackColor = false;
            buttonEditAvatar.Click += buttonEditAvatar_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUsername.ForeColor = Color.Black;
            labelUsername.Location = new Point(63, 85);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(149, 21);
            labelUsername.TabIndex = 29;
            labelUsername.Text = "Имя пользователя: ";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(224, 224, 224);
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbUsername.Location = new Point(270, 85);
            tbUsername.MaxLength = 128;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(223, 22);
            tbUsername.TabIndex = 30;
            // 
            // tbCurrentPassword
            // 
            tbCurrentPassword.BackColor = Color.FromArgb(224, 224, 224);
            tbCurrentPassword.BorderStyle = BorderStyle.None;
            tbCurrentPassword.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbCurrentPassword.Location = new Point(270, 123);
            tbCurrentPassword.MaxLength = 256;
            tbCurrentPassword.Name = "tbCurrentPassword";
            tbCurrentPassword.PasswordChar = '•';
            tbCurrentPassword.Size = new Size(223, 22);
            tbCurrentPassword.TabIndex = 32;
            // 
            // labelCurrentPassword
            // 
            labelCurrentPassword.AutoSize = true;
            labelCurrentPassword.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCurrentPassword.ForeColor = Color.Black;
            labelCurrentPassword.Location = new Point(63, 123);
            labelCurrentPassword.Name = "labelCurrentPassword";
            labelCurrentPassword.Size = new Size(140, 21);
            labelCurrentPassword.TabIndex = 31;
            labelCurrentPassword.Text = "Текущий пароль:  ";
            // 
            // tbNewPassword
            // 
            tbNewPassword.BackColor = Color.FromArgb(224, 224, 224);
            tbNewPassword.BorderStyle = BorderStyle.None;
            tbNewPassword.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbNewPassword.Location = new Point(270, 161);
            tbNewPassword.MaxLength = 256;
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PasswordChar = '•';
            tbNewPassword.Size = new Size(223, 22);
            tbNewPassword.TabIndex = 34;
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNewPassword.ForeColor = Color.Black;
            labelNewPassword.Location = new Point(63, 161);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(124, 21);
            labelNewPassword.TabIndex = 33;
            labelNewPassword.Text = "Новый пароль:  ";
            // 
            // tbConfirmNewPassword
            // 
            tbConfirmNewPassword.BackColor = Color.FromArgb(224, 224, 224);
            tbConfirmNewPassword.BorderStyle = BorderStyle.None;
            tbConfirmNewPassword.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbConfirmNewPassword.Location = new Point(270, 203);
            tbConfirmNewPassword.MaxLength = 256;
            tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            tbConfirmNewPassword.PasswordChar = '•';
            tbConfirmNewPassword.Size = new Size(223, 22);
            tbConfirmNewPassword.TabIndex = 36;
            // 
            // labelConfirmNewPassword
            // 
            labelConfirmNewPassword.AutoSize = true;
            labelConfirmNewPassword.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelConfirmNewPassword.ForeColor = Color.Black;
            labelConfirmNewPassword.Location = new Point(63, 203);
            labelConfirmNewPassword.Name = "labelConfirmNewPassword";
            labelConfirmNewPassword.Size = new Size(203, 21);
            labelConfirmNewPassword.TabIndex = 35;
            labelConfirmNewPassword.Text = "Повторите новый пароль:  ";
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.FromArgb(224, 224, 224);
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbEmail.Location = new Point(270, 240);
            tbEmail.MaxLength = 320;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(223, 22);
            tbEmail.TabIndex = 38;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelEmail.ForeColor = Color.Black;
            labelEmail.Location = new Point(63, 240);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(159, 21);
            labelEmail.TabIndex = 37;
            labelEmail.Text = "Электронная почта: ";
            // 
            // tbAddress
            // 
            tbAddress.BackColor = Color.FromArgb(224, 224, 224);
            tbAddress.BorderStyle = BorderStyle.None;
            tbAddress.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbAddress.Location = new Point(270, 280);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(223, 22);
            tbAddress.TabIndex = 40;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAddress.ForeColor = Color.Black;
            labelAddress.Location = new Point(63, 280);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(62, 21);
            labelAddress.TabIndex = 39;
            labelAddress.Text = "Адрес: ";
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.FromArgb(41, 2, 71);
            buttonSaveChanges.Cursor = Cursors.Hand;
            buttonSaveChanges.FlatStyle = FlatStyle.Flat;
            buttonSaveChanges.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSaveChanges.ForeColor = SystemColors.Window;
            buttonSaveChanges.Location = new Point(63, 344);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(253, 50);
            buttonSaveChanges.TabIndex = 41;
            buttonSaveChanges.Text = "Сохранить изменения";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonDeleteAccount
            // 
            buttonDeleteAccount.BackColor = Color.Red;
            buttonDeleteAccount.Cursor = Cursors.Hand;
            buttonDeleteAccount.FlatStyle = FlatStyle.Flat;
            buttonDeleteAccount.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDeleteAccount.ForeColor = SystemColors.Window;
            buttonDeleteAccount.Location = new Point(1560, 736);
            buttonDeleteAccount.Name = "buttonDeleteAccount";
            buttonDeleteAccount.Size = new Size(146, 32);
            buttonDeleteAccount.TabIndex = 42;
            buttonDeleteAccount.Text = "Удалить аккаунт";
            buttonDeleteAccount.UseVisualStyleBackColor = false;
            buttonDeleteAccount.Click += buttonDeleteAccount_Click;
            // 
            // labelReviews
            // 
            labelReviews.AutoSize = true;
            labelReviews.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelReviews.Location = new Point(63, 429);
            labelReviews.Name = "labelReviews";
            labelReviews.Size = new Size(148, 32);
            labelReviews.TabIndex = 62;
            labelReviews.Text = "Мои отзывы";
            // 
            // dgvReviews
            // 
            dgvReviews.AllowUserToResizeColumns = false;
            dgvReviews.AllowUserToResizeRows = false;
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
            dgvReviews.Columns.AddRange(new DataGridViewColumn[] { Id, BookId, BookName, Author, BookImage, Content, Rating, CreatedAt });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReviews.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReviews.Location = new Point(63, 464);
            dgvReviews.Name = "dgvReviews";
            dgvReviews.RowTemplate.Height = 136;
            dgvReviews.Size = new Size(725, 281);
            dgvReviews.TabIndex = 70;
            dgvReviews.DoubleClick += dgvReviews_DoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // BookId
            // 
            BookId.HeaderText = "book id";
            BookId.Name = "BookId";
            BookId.Visible = false;
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
            BookImage.HeaderText = "Изображение книги";
            BookImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            BookImage.Name = "BookImage";
            BookImage.Resizable = DataGridViewTriState.True;
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
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOrders.Location = new Point(806, 12);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(142, 32);
            labelOrders.TabIndex = 71;
            labelOrders.Text = "Мои заказы";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToResizeColumns = false;
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { OrderId, PaymentMethod, PaymentStatus, OrderStatus, Cost, PaidIn });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle4;
            dgvOrders.Location = new Point(806, 63);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(882, 238);
            dgvOrders.TabIndex = 72;
            dgvOrders.CellFormatting += dgvOrders_CellFormatting;
            dgvOrders.CellMouseDoubleClick += dgvOrders_CellMouseDoubleClick;
            // 
            // OrderId
            // 
            OrderId.HeaderText = "Номер заказа";
            OrderId.Name = "OrderId";
            // 
            // PaymentMethod
            // 
            PaymentMethod.HeaderText = "Способ оплаты";
            PaymentMethod.Name = "PaymentMethod";
            // 
            // PaymentStatus
            // 
            PaymentStatus.HeaderText = "Статус оплаты";
            PaymentStatus.Name = "PaymentStatus";
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Статус заказа";
            OrderStatus.Name = "OrderStatus";
            // 
            // Cost
            // 
            Cost.HeaderText = "Стоимость";
            Cost.Name = "Cost";
            // 
            // PaidIn
            // 
            PaidIn.HeaderText = "Время оплаты";
            PaidIn.Name = "PaidIn";
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(41, 2, 71);
            buttonLogout.Cursor = Cursors.Hand;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogout.ForeColor = SystemColors.Window;
            buttonLogout.Location = new Point(642, 362);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(146, 32);
            buttonLogout.TabIndex = 73;
            buttonLogout.Text = "Выйти";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1718, 780);
            Controls.Add(buttonLogout);
            Controls.Add(dgvOrders);
            Controls.Add(labelOrders);
            Controls.Add(dgvReviews);
            Controls.Add(labelReviews);
            Controls.Add(buttonDeleteAccount);
            Controls.Add(buttonSaveChanges);
            Controls.Add(tbAddress);
            Controls.Add(labelAddress);
            Controls.Add(tbEmail);
            Controls.Add(labelEmail);
            Controls.Add(tbConfirmNewPassword);
            Controls.Add(labelConfirmNewPassword);
            Controls.Add(tbNewPassword);
            Controls.Add(labelNewPassword);
            Controls.Add(tbCurrentPassword);
            Controls.Add(labelCurrentPassword);
            Controls.Add(tbUsername);
            Controls.Add(labelUsername);
            Controls.Add(buttonEditAvatar);
            Controls.Add(pbBack);
            Controls.Add(labelProfile);
            Controls.Add(pbAvatar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Профиль";
            Load += FormProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReviews).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAvatar;
        private PictureBox pbBack;
        private Label labelProfile;
        private Button buttonEditAvatar;
        private Label labelUsername;
        private TextBox tbUsername;
        private TextBox tbCurrentPassword;
        private Label labelCurrentPassword;
        private TextBox tbNewPassword;
        private Label labelNewPassword;
        private TextBox tbConfirmNewPassword;
        private Label labelConfirmNewPassword;
        private TextBox tbEmail;
        private Label labelEmail;
        private TextBox tbAddress;
        private Label labelAddress;
        private Button buttonSaveChanges;
        private Button buttonDeleteAccount;
        private Label labelReviews;
        private DataGridView dgvReviews;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewImageColumn BookImage;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewTextBoxColumn Rating;
        private DataGridViewTextBoxColumn CreatedAt;
        private Label labelOrders;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn PaymentStatus;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn PaidIn;
        private Button buttonLogout;
    }
}