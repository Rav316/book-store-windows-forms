namespace book_store.form
{
    partial class FormEditReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditReview));
            pbStar5 = new PictureBox();
            pbStar4 = new PictureBox();
            pbStar3 = new PictureBox();
            pbStar2 = new PictureBox();
            pbStar1 = new PictureBox();
            buttonCancel = new Button();
            buttonEdit = new Button();
            tbReviewContent = new TextBox();
            labelAuthorValue = new Label();
            labelAuthor = new Label();
            labelBookName = new Label();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pbStar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar1).BeginInit();
            SuspendLayout();
            // 
            // pbStar5
            // 
            pbStar5.Cursor = Cursors.Hand;
            pbStar5.Image = (Image)resources.GetObject("pbStar5.Image");
            pbStar5.Location = new Point(373, 273);
            pbStar5.Name = "pbStar5";
            pbStar5.Size = new Size(24, 24);
            pbStar5.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar5.TabIndex = 44;
            pbStar5.TabStop = false;
            // 
            // pbStar4
            // 
            pbStar4.Cursor = Cursors.Hand;
            pbStar4.Image = (Image)resources.GetObject("pbStar4.Image");
            pbStar4.Location = new Point(345, 273);
            pbStar4.Name = "pbStar4";
            pbStar4.Size = new Size(24, 24);
            pbStar4.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar4.TabIndex = 43;
            pbStar4.TabStop = false;
            // 
            // pbStar3
            // 
            pbStar3.Cursor = Cursors.Hand;
            pbStar3.Image = (Image)resources.GetObject("pbStar3.Image");
            pbStar3.Location = new Point(317, 273);
            pbStar3.Name = "pbStar3";
            pbStar3.Size = new Size(24, 24);
            pbStar3.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar3.TabIndex = 42;
            pbStar3.TabStop = false;
            // 
            // pbStar2
            // 
            pbStar2.Cursor = Cursors.Hand;
            pbStar2.Image = (Image)resources.GetObject("pbStar2.Image");
            pbStar2.Location = new Point(290, 273);
            pbStar2.Name = "pbStar2";
            pbStar2.Size = new Size(24, 24);
            pbStar2.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar2.TabIndex = 41;
            pbStar2.TabStop = false;
            // 
            // pbStar1
            // 
            pbStar1.Cursor = Cursors.Hand;
            pbStar1.Image = (Image)resources.GetObject("pbStar1.Image");
            pbStar1.Location = new Point(263, 273);
            pbStar1.Name = "pbStar1";
            pbStar1.Size = new Size(24, 24);
            pbStar1.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar1.TabIndex = 40;
            pbStar1.TabStop = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(99, 108, 116);
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = SystemColors.Window;
            buttonCancel.Location = new Point(302, 318);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(133, 36);
            buttonCancel.TabIndex = 39;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(41, 2, 71);
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEdit.ForeColor = SystemColors.Window;
            buttonEdit.Location = new Point(114, 318);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(182, 36);
            buttonEdit.TabIndex = 38;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // tbReviewContent
            // 
            tbReviewContent.BorderStyle = BorderStyle.None;
            tbReviewContent.Font = new Font("Philosopher", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbReviewContent.Location = new Point(70, 105);
            tbReviewContent.Multiline = true;
            tbReviewContent.Name = "tbReviewContent";
            tbReviewContent.ScrollBars = ScrollBars.Vertical;
            tbReviewContent.Size = new Size(545, 162);
            tbReviewContent.TabIndex = 37;
            // 
            // labelAuthorValue
            // 
            labelAuthorValue.AutoSize = true;
            labelAuthorValue.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAuthorValue.Location = new Point(122, 67);
            labelAuthorValue.Name = "labelAuthorValue";
            labelAuthorValue.Size = new Size(134, 20);
            labelAuthorValue.TabIndex = 36;
            labelAuthorValue.Text = "Fyodor Dostoevsky";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Philosopher", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAuthor.Location = new Point(71, 67);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(59, 20);
            labelAuthor.TabIndex = 35;
            labelAuthor.Text = "Автор: ";
            // 
            // labelBookName
            // 
            labelBookName.AutoSize = true;
            labelBookName.Font = new Font("Philosopher", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBookName.Location = new Point(63, 19);
            labelBookName.Name = "labelBookName";
            labelBookName.Size = new Size(278, 37);
            labelBookName.TabIndex = 34;
            labelBookName.Text = "Crime and Punishment";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelete.ForeColor = SystemColors.Window;
            buttonDelete.Location = new Point(441, 318);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(133, 36);
            buttonDelete.TabIndex = 45;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormEditReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 369);
            Controls.Add(buttonDelete);
            Controls.Add(pbStar5);
            Controls.Add(pbStar4);
            Controls.Add(pbStar3);
            Controls.Add(pbStar2);
            Controls.Add(pbStar1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonEdit);
            Controls.Add(tbReviewContent);
            Controls.Add(labelAuthorValue);
            Controls.Add(labelAuthor);
            Controls.Add(labelBookName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEditReview";
            Text = "FormEditReview";
            ((System.ComponentModel.ISupportInitialize)pbStar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbStar5;
        private PictureBox pbStar4;
        private PictureBox pbStar3;
        private PictureBox pbStar2;
        private PictureBox pbStar1;
        private Button buttonCancel;
        private Button buttonEdit;
        private TextBox tbReviewContent;
        private Label labelAuthorValue;
        private Label labelAuthor;
        private Label labelBookName;
        private Button buttonDelete;
    }
}