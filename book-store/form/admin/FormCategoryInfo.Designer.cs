namespace book_store.form.admin
{
    partial class FormCategoryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoryInfo));
            buttonDelete = new Button();
            buttonSaveChanges = new Button();
            tbName = new TextBox();
            labelName = new Label();
            tbId = new TextBox();
            labelId = new Label();
            pbBack = new PictureBox();
            labelCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelete.ForeColor = SystemColors.Window;
            buttonDelete.Location = new Point(81, 237);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(430, 43);
            buttonDelete.TabIndex = 132;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.FromArgb(41, 2, 71);
            buttonSaveChanges.Cursor = Cursors.Hand;
            buttonSaveChanges.FlatStyle = FlatStyle.Flat;
            buttonSaveChanges.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSaveChanges.ForeColor = SystemColors.Window;
            buttonSaveChanges.Location = new Point(81, 187);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(430, 43);
            buttonSaveChanges.TabIndex = 131;
            buttonSaveChanges.Text = "Сохранить изменения";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // tbName
            // 
            tbName.BackColor = Color.FromArgb(224, 224, 224);
            tbName.BorderStyle = BorderStyle.None;
            tbName.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbName.Location = new Point(288, 121);
            tbName.Name = "tbName";
            tbName.Size = new Size(223, 22);
            tbName.TabIndex = 122;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.ForeColor = Color.Black;
            labelName.Location = new Point(81, 121);
            labelName.Name = "labelName";
            labelName.Size = new Size(82, 21);
            labelName.TabIndex = 121;
            labelName.Text = "Название:";
            // 
            // tbId
            // 
            tbId.BackColor = Color.FromArgb(224, 224, 224);
            tbId.BorderStyle = BorderStyle.None;
            tbId.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbId.Location = new Point(288, 84);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(223, 22);
            tbId.TabIndex = 120;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelId.ForeColor = Color.Black;
            labelId.Location = new Point(81, 84);
            labelId.Name = "labelId";
            labelId.Size = new Size(26, 21);
            labelId.TabIndex = 119;
            labelId.Text = "id:";
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(44, 30);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 118;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategory.Location = new Point(84, 9);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(427, 48);
            labelCategory.TabIndex = 117;
            labelCategory.Text = "Информация о категории";
            // 
            // FormCategoryInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 326);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSaveChanges);
            Controls.Add(tbName);
            Controls.Add(labelName);
            Controls.Add(tbId);
            Controls.Add(labelId);
            Controls.Add(pbBack);
            Controls.Add(labelCategory);
            Name = "FormCategoryInfo";
            Text = "Информация о категории";
            Load += FormCategoryInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDelete;
        private Button buttonSaveChanges;
        private TextBox tbName;
        private Label labelName;
        private TextBox tbId;
        private Label labelId;
        private PictureBox pbBack;
        private Label labelCategory;
    }
}