namespace book_store.form.admin
{
    partial class FormAuthorInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorInfo));
            pbBack = new PictureBox();
            labelAuthor = new Label();
            labelDeathDate = new Label();
            labelBirthDate = new Label();
            tbLastName = new TextBox();
            labelLastName = new Label();
            tbMidName = new TextBox();
            labelMidName = new Label();
            tbFirstName = new TextBox();
            labelFirstName = new Label();
            tbId = new TextBox();
            labelId = new Label();
            tbNationality = new TextBox();
            labelNationality = new Label();
            buttonSaveChanges = new Button();
            buttonDelete = new Button();
            dtpBirthDate = new DateTimePicker();
            dtpDeathDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(22, 28);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 78;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAuthor.Location = new Point(81, 9);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(391, 48);
            labelAuthor.TabIndex = 77;
            labelAuthor.Text = "Информация об авторе";
            // 
            // labelDeathDate
            // 
            labelDeathDate.AutoSize = true;
            labelDeathDate.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDeathDate.ForeColor = Color.Black;
            labelDeathDate.Location = new Point(59, 290);
            labelDeathDate.Name = "labelDeathDate";
            labelDeathDate.Size = new Size(105, 21);
            labelDeathDate.TabIndex = 109;
            labelDeathDate.Text = "Дата смерти:";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBirthDate.ForeColor = Color.Black;
            labelBirthDate.Location = new Point(59, 250);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(124, 21);
            labelBirthDate.TabIndex = 107;
            labelBirthDate.Text = "Дата рождения:";
            // 
            // tbLastName
            // 
            tbLastName.BackColor = Color.FromArgb(224, 224, 224);
            tbLastName.BorderStyle = BorderStyle.None;
            tbLastName.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbLastName.Location = new Point(266, 202);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(223, 22);
            tbLastName.TabIndex = 106;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLastName.ForeColor = Color.Black;
            labelLastName.Location = new Point(59, 202);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 21);
            labelLastName.TabIndex = 105;
            labelLastName.Text = "Фамилия:";
            // 
            // tbMidName
            // 
            tbMidName.BackColor = Color.FromArgb(224, 224, 224);
            tbMidName.BorderStyle = BorderStyle.None;
            tbMidName.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbMidName.Location = new Point(266, 159);
            tbMidName.Name = "tbMidName";
            tbMidName.Size = new Size(223, 22);
            tbMidName.TabIndex = 104;
            // 
            // labelMidName
            // 
            labelMidName.AutoSize = true;
            labelMidName.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMidName.ForeColor = Color.Black;
            labelMidName.Location = new Point(59, 159);
            labelMidName.Name = "labelMidName";
            labelMidName.Size = new Size(82, 21);
            labelMidName.TabIndex = 103;
            labelMidName.Text = "Отчество:";
            // 
            // tbFirstName
            // 
            tbFirstName.BackColor = Color.FromArgb(224, 224, 224);
            tbFirstName.BorderStyle = BorderStyle.None;
            tbFirstName.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbFirstName.Location = new Point(266, 119);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(223, 22);
            tbFirstName.TabIndex = 102;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFirstName.ForeColor = Color.Black;
            labelFirstName.Location = new Point(59, 119);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(43, 21);
            labelFirstName.TabIndex = 101;
            labelFirstName.Text = "Имя:";
            // 
            // tbId
            // 
            tbId.BackColor = Color.FromArgb(224, 224, 224);
            tbId.BorderStyle = BorderStyle.None;
            tbId.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbId.Location = new Point(266, 82);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(223, 22);
            tbId.TabIndex = 100;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelId.ForeColor = Color.Black;
            labelId.Location = new Point(59, 82);
            labelId.Name = "labelId";
            labelId.Size = new Size(26, 21);
            labelId.TabIndex = 99;
            labelId.Text = "id:";
            // 
            // tbNationality
            // 
            tbNationality.BackColor = Color.FromArgb(224, 224, 224);
            tbNationality.BorderStyle = BorderStyle.None;
            tbNationality.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbNationality.Location = new Point(266, 336);
            tbNationality.Name = "tbNationality";
            tbNationality.Size = new Size(223, 22);
            tbNationality.TabIndex = 112;
            // 
            // labelNationality
            // 
            labelNationality.AutoSize = true;
            labelNationality.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNationality.ForeColor = Color.Black;
            labelNationality.Location = new Point(59, 336);
            labelNationality.Name = "labelNationality";
            labelNationality.Size = new Size(134, 21);
            labelNationality.TabIndex = 111;
            labelNationality.Text = "Национальность:";
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.FromArgb(41, 2, 71);
            buttonSaveChanges.Cursor = Cursors.Hand;
            buttonSaveChanges.FlatStyle = FlatStyle.Flat;
            buttonSaveChanges.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSaveChanges.ForeColor = SystemColors.Window;
            buttonSaveChanges.Location = new Point(59, 383);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(430, 43);
            buttonSaveChanges.TabIndex = 113;
            buttonSaveChanges.Text = "Сохранить изменения";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelete.ForeColor = SystemColors.Window;
            buttonDelete.Location = new Point(59, 433);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(430, 43);
            buttonDelete.TabIndex = 114;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(266, 250);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(223, 23);
            dtpBirthDate.TabIndex = 115;
            // 
            // dtpDeathDate
            // 
            dtpDeathDate.Location = new Point(266, 290);
            dtpDeathDate.Name = "dtpDeathDate";
            dtpDeathDate.Size = new Size(223, 23);
            dtpDeathDate.TabIndex = 116;
            // 
            // FormAuthorInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 488);
            Controls.Add(dtpDeathDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSaveChanges);
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
            Controls.Add(tbId);
            Controls.Add(labelId);
            Controls.Add(pbBack);
            Controls.Add(labelAuthor);
            Name = "FormAuthorInfo";
            Text = "Информация об авторе";
            Load += FormAuthorInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBack;
        private Label labelAuthor;
        private Label labelDeathDate;
        private Label labelBirthDate;
        private TextBox tbLastName;
        private Label labelLastName;
        private TextBox tbMidName;
        private Label labelMidName;
        private TextBox tbFirstName;
        private Label labelFirstName;
        private TextBox tbId;
        private Label labelId;
        private TextBox tbNationality;
        private Label labelNationality;
        private Button buttonSaveChanges;
        private Button buttonDelete;
        private DateTimePicker dtpBirthDate;
        private DateTimePicker dtpDeathDate;
    }
}