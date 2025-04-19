namespace book_store.form.admin
{
    partial class FormCategoryCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoryCreate));
            buttonCreate = new Button();
            tbName = new TextBox();
            labelName = new Label();
            pbBack = new PictureBox();
            labelCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(41, 2, 71);
            buttonCreate.Cursor = Cursors.Hand;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCreate.ForeColor = SystemColors.Window;
            buttonCreate.Location = new Point(78, 144);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(430, 43);
            buttonCreate.TabIndex = 139;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // tbName
            // 
            tbName.BackColor = Color.FromArgb(224, 224, 224);
            tbName.BorderStyle = BorderStyle.None;
            tbName.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbName.Location = new Point(285, 91);
            tbName.MaxLength = 32;
            tbName.Name = "tbName";
            tbName.Size = new Size(223, 22);
            tbName.TabIndex = 138;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.ForeColor = Color.Black;
            labelName.Location = new Point(78, 91);
            labelName.Name = "labelName";
            labelName.Size = new Size(82, 21);
            labelName.TabIndex = 137;
            labelName.Text = "Название:";
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(41, 30);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 134;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategory.Location = new Point(131, 9);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(346, 48);
            labelCategory.TabIndex = 133;
            labelCategory.Text = "Создание категории";
            // 
            // FormCategoryCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 228);
            Controls.Add(buttonCreate);
            Controls.Add(tbName);
            Controls.Add(labelName);
            Controls.Add(pbBack);
            Controls.Add(labelCategory);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCategoryCreate";
            Text = "Создать категорию";
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDelete;
        private Button buttonCreate;
        private TextBox tbName;
        private Label labelName;
        private PictureBox pbBack;
        private Label labelCategory;
    }
}