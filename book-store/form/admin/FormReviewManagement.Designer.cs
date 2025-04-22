namespace book_store.form.admin
{
    partial class FormReviewManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReviewManagement));
            dgvReviews = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            BookId = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            UserAvatar = new DataGridViewImageColumn();
            Content = new DataGridViewTextBoxColumn();
            Rating = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            labelAuthor = new Label();
            cbUser = new ComboBox();
            labelBook = new Label();
            cbBook = new ComboBox();
            pbBack = new PictureBox();
            labelManagement = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReviews).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
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
            dgvReviews.Columns.AddRange(new DataGridViewColumn[] { Id, UserId, BookId, Username, UserAvatar, Content, Rating, CreatedAt });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReviews.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReviews.Location = new Point(19, 149);
            dgvReviews.Name = "dgvReviews";
            dgvReviews.RowTemplate.Height = 136;
            dgvReviews.Size = new Size(1266, 398);
            dgvReviews.TabIndex = 70;
            dgvReviews.DoubleClick += dgvReviews_DoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // UserId
            // 
            UserId.HeaderText = "Id пользователя";
            UserId.Name = "UserId";
            UserId.Visible = false;
            // 
            // BookId
            // 
            BookId.HeaderText = "Id книги";
            BookId.Name = "BookId";
            BookId.Visible = false;
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
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Philosopher", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAuthor.Location = new Point(262, 73);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(146, 28);
            labelAuthor.TabIndex = 112;
            labelAuthor.Text = "Пользователь:";
            // 
            // cbUser
            // 
            cbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(410, 76);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(121, 23);
            cbUser.TabIndex = 111;
            cbUser.SelectedIndexChanged += cbUser_SelectedIndexChanged;
            // 
            // labelBook
            // 
            labelBook.AutoSize = true;
            labelBook.Font = new Font("Philosopher", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBook.Location = new Point(26, 73);
            labelBook.Name = "labelBook";
            labelBook.Size = new Size(79, 28);
            labelBook.TabIndex = 110;
            labelBook.Text = "Книга: ";
            // 
            // cbBook
            // 
            cbBook.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBook.FormattingEnabled = true;
            cbBook.Location = new Point(111, 78);
            cbBook.Name = "cbBook";
            cbBook.Size = new Size(121, 23);
            cbBook.TabIndex = 109;
            cbBook.SelectedIndexChanged += cbBook_SelectedIndexChanged;
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(29, 30);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 108;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManagement.Location = new Point(452, 9);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(376, 48);
            labelManagement.TabIndex = 107;
            labelManagement.Text = "Управление отзывами";
            // 
            // FormReviewManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 610);
            Controls.Add(labelAuthor);
            Controls.Add(cbUser);
            Controls.Add(labelBook);
            Controls.Add(cbBook);
            Controls.Add(pbBack);
            Controls.Add(labelManagement);
            Controls.Add(dgvReviews);
            Name = "FormReviewManagement";
            Text = "Управление отзывами";
            Load += FormReviewManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReviews).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReviews;
        private Label labelAuthor;
        private ComboBox cbUser;
        private Label labelBook;
        private ComboBox cbBook;
        private PictureBox pbBack;
        private Label labelManagement;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewImageColumn UserAvatar;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewTextBoxColumn Rating;
        private DataGridViewTextBoxColumn CreatedAt;
    }
}