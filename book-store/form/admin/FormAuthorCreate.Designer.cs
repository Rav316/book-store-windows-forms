namespace book_store.form.admin
{
    partial class FormAuthorCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorCreate));
            dtpDeathDate = new DateTimePicker();
            dtpBirthDate = new DateTimePicker();
            buttonCreate = new Button();
            tbNationality = new TextBox();
            labelNationality = new Label();
            labelDeathDate = new Label();
            labelBirthDate = new Label();
            tbLastName = new TextBox();
            labelLastName = new Label();
            tbMidName = new TextBox();
            labelMidName = new Label();
            tbFirstName = new TextBox();
            labelFirstName = new Label();
            pbBack = new PictureBox();
            labelAuthor = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // dtpDeathDate
            // 
            dtpDeathDate.Location = new Point(264, 249);
            dtpDeathDate.Name = "dtpDeathDate";
            dtpDeathDate.Size = new Size(223, 23);
            dtpDeathDate.TabIndex = 134;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(264, 209);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(223, 23);
            dtpBirthDate.TabIndex = 133;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(41, 2, 71);
            buttonCreate.Cursor = Cursors.Hand;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCreate.ForeColor = SystemColors.Window;
            buttonCreate.Location = new Point(57, 350);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(430, 43);
            buttonCreate.TabIndex = 131;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // tbNationality
            // 
            tbNationality.BackColor = Color.FromArgb(224, 224, 224);
            tbNationality.BorderStyle = BorderStyle.None;
            tbNationality.Font = new Font("Philosopher", 11.25F);
            tbNationality.Location = new Point(264, 295);
            tbNationality.MaxLength = 127;
            tbNationality.MinimumSize = new Size(223, 22);
            tbNationality.Name = "tbNationality";
            tbNationality.Size = new Size(223, 22);
            tbNationality.TabIndex = 130;
            // 
            // labelNationality
            // 
            labelNationality.AutoSize = true;
            labelNationality.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNationality.ForeColor = Color.Black;
            labelNationality.Location = new Point(57, 295);
            labelNationality.Name = "labelNationality";
            labelNationality.Size = new Size(134, 21);
            labelNationality.TabIndex = 129;
            labelNationality.Text = "Национальность:";
            // 
            // labelDeathDate
            // 
            labelDeathDate.AutoSize = true;
            labelDeathDate.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDeathDate.ForeColor = Color.Black;
            labelDeathDate.Location = new Point(57, 249);
            labelDeathDate.Name = "labelDeathDate";
            labelDeathDate.Size = new Size(105, 21);
            labelDeathDate.TabIndex = 128;
            labelDeathDate.Text = "Дата смерти:";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBirthDate.ForeColor = Color.Black;
            labelBirthDate.Location = new Point(57, 209);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(124, 21);
            labelBirthDate.TabIndex = 127;
            labelBirthDate.Text = "Дата рождения:";
            // 
            // tbLastName
            // 
            tbLastName.BackColor = Color.FromArgb(224, 224, 224);
            tbLastName.BorderStyle = BorderStyle.None;
            tbLastName.Font = new Font("Philosopher", 11.25F);
            tbLastName.Location = new Point(264, 161);
            tbLastName.MaxLength = 127;
            tbLastName.MinimumSize = new Size(223, 22);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(223, 22);
            tbLastName.TabIndex = 126;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLastName.ForeColor = Color.Black;
            labelLastName.Location = new Point(57, 161);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 21);
            labelLastName.TabIndex = 125;
            labelLastName.Text = "Фамилия:";
            // 
            // tbMidName
            // 
            tbMidName.BackColor = Color.FromArgb(224, 224, 224);
            tbMidName.BorderStyle = BorderStyle.None;
            tbMidName.Font = new Font("Philosopher", 11.25F);
            tbMidName.Location = new Point(264, 118);
            tbMidName.MaxLength = 127;
            tbMidName.MinimumSize = new Size(223, 22);
            tbMidName.Name = "tbMidName";
            tbMidName.Size = new Size(223, 22);
            tbMidName.TabIndex = 124;
            // 
            // labelMidName
            // 
            labelMidName.AutoSize = true;
            labelMidName.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMidName.ForeColor = Color.Black;
            labelMidName.Location = new Point(57, 118);
            labelMidName.Name = "labelMidName";
            labelMidName.Size = new Size(82, 21);
            labelMidName.TabIndex = 123;
            labelMidName.Text = "Отчество:";
            // 
            // tbFirstName
            // 
            tbFirstName.BackColor = Color.FromArgb(224, 224, 224);
            tbFirstName.BorderStyle = BorderStyle.None;
            tbFirstName.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbFirstName.Location = new Point(264, 78);
            tbFirstName.MaxLength = 127;
            tbFirstName.MinimumSize = new Size(223, 22);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(223, 22);
            tbFirstName.TabIndex = 122;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFirstName.ForeColor = Color.Black;
            labelFirstName.Location = new Point(57, 78);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(43, 21);
            labelFirstName.TabIndex = 121;
            labelFirstName.Text = "Имя:";
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(20, 22);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 20);
            pbBack.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBack.TabIndex = 118;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAuthor.Location = new Point(136, 9);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(290, 48);
            labelAuthor.TabIndex = 117;
            labelAuthor.Text = "Создание автора";
            // 
            // FormAuthorCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 426);
            Controls.Add(dtpDeathDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(buttonCreate);
            Controls.Add(tbNationality);
            Controls.Add(labelNationality);
            Controls.Add(labelDeathDate);
            Controls.Add(labelBirthDate);
            Controls.Add(tbLastName);
            Controls.Add(labelLastName);
            Controls.Add(tbMidName);
            Controls.Add(labelMidName);
            Controls.Add(tbFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(pbBack);
            Controls.Add(labelAuthor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAuthorCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание автора";
            Load += FormAuthorCreate_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDeathDate;
        private DateTimePicker dtpBirthDate;
        private Button buttonCreate;
        private TextBox tbNationality;
        private Label labelNationality;
        private Label labelDeathDate;
        private Label labelBirthDate;
        private TextBox tbLastName;
        private Label labelLastName;
        private TextBox tbMidName;
        private Label labelMidName;
        private TextBox tbFirstName;
        private Label labelFirstName;
        private PictureBox pbBack;
        private Label labelAuthor;
    }
}