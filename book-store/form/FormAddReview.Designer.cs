namespace book_store.form
{
    partial class FormAddReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddReview));
            labelBookName = new Label();
            labelAuthor = new Label();
            labelAuthorValue = new Label();
            tbReviewContent = new TextBox();
            buttonPublish = new Button();
            buttonCancel = new Button();
            pbStar1 = new PictureBox();
            pbStar2 = new PictureBox();
            pbStar3 = new PictureBox();
            pbStar4 = new PictureBox();
            pbStar5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbStar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar5).BeginInit();
            SuspendLayout();
            // 
            // labelBookName
            // 
            labelBookName.AutoSize = true;
            labelBookName.Font = new Font("Philosopher", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBookName.Location = new Point(73, 23);
            labelBookName.Name = "labelBookName";
            labelBookName.Size = new Size(278, 37);
            labelBookName.TabIndex = 0;
            labelBookName.Text = "Crime and Punishment";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Philosopher", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAuthor.Location = new Point(81, 71);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(59, 20);
            labelAuthor.TabIndex = 1;
            labelAuthor.Text = "Автор: ";
            // 
            // labelAuthorValue
            // 
            labelAuthorValue.AutoSize = true;
            labelAuthorValue.Font = new Font("Philosopher", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAuthorValue.Location = new Point(132, 71);
            labelAuthorValue.Name = "labelAuthorValue";
            labelAuthorValue.Size = new Size(134, 20);
            labelAuthorValue.TabIndex = 2;
            labelAuthorValue.Text = "Fyodor Dostoevsky";
            // 
            // tbReviewContent
            // 
            tbReviewContent.BorderStyle = BorderStyle.None;
            tbReviewContent.Font = new Font("Philosopher", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbReviewContent.Location = new Point(80, 109);
            tbReviewContent.Multiline = true;
            tbReviewContent.Name = "tbReviewContent";
            tbReviewContent.ScrollBars = ScrollBars.Vertical;
            tbReviewContent.Size = new Size(545, 162);
            tbReviewContent.TabIndex = 3;
            // 
            // buttonPublish
            // 
            buttonPublish.BackColor = Color.FromArgb(41, 2, 71);
            buttonPublish.Cursor = Cursors.Hand;
            buttonPublish.FlatStyle = FlatStyle.Flat;
            buttonPublish.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPublish.ForeColor = SystemColors.Window;
            buttonPublish.Location = new Point(195, 321);
            buttonPublish.Name = "buttonPublish";
            buttonPublish.Size = new Size(182, 36);
            buttonPublish.TabIndex = 27;
            buttonPublish.Text = "Опубликовать";
            buttonPublish.UseVisualStyleBackColor = false;
            buttonPublish.Click += buttonPublish_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(99, 108, 116);
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = SystemColors.Window;
            buttonCancel.Location = new Point(383, 321);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(133, 36);
            buttonCancel.TabIndex = 28;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // pbStar1
            // 
            pbStar1.Cursor = Cursors.Hand;
            pbStar1.Image = (Image)resources.GetObject("pbStar1.Image");
            pbStar1.Location = new Point(273, 277);
            pbStar1.Name = "pbStar1";
            pbStar1.Size = new Size(24, 24);
            pbStar1.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar1.TabIndex = 29;
            pbStar1.TabStop = false;
            // 
            // pbStar2
            // 
            pbStar2.Cursor = Cursors.Hand;
            pbStar2.Image = (Image)resources.GetObject("pbStar2.Image");
            pbStar2.Location = new Point(300, 277);
            pbStar2.Name = "pbStar2";
            pbStar2.Size = new Size(24, 24);
            pbStar2.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar2.TabIndex = 30;
            pbStar2.TabStop = false;
            // 
            // pbStar3
            // 
            pbStar3.Cursor = Cursors.Hand;
            pbStar3.Image = (Image)resources.GetObject("pbStar3.Image");
            pbStar3.Location = new Point(327, 277);
            pbStar3.Name = "pbStar3";
            pbStar3.Size = new Size(24, 24);
            pbStar3.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar3.TabIndex = 31;
            pbStar3.TabStop = false;
            // 
            // pbStar4
            // 
            pbStar4.Cursor = Cursors.Hand;
            pbStar4.Image = (Image)resources.GetObject("pbStar4.Image");
            pbStar4.Location = new Point(355, 277);
            pbStar4.Name = "pbStar4";
            pbStar4.Size = new Size(24, 24);
            pbStar4.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar4.TabIndex = 32;
            pbStar4.TabStop = false;
            // 
            // pbStar5
            // 
            pbStar5.Cursor = Cursors.Hand;
            pbStar5.Image = (Image)resources.GetObject("pbStar5.Image");
            pbStar5.Location = new Point(383, 277);
            pbStar5.Name = "pbStar5";
            pbStar5.Size = new Size(24, 24);
            pbStar5.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar5.TabIndex = 33;
            pbStar5.TabStop = false;
            // 
            // FormAddReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 369);
            Controls.Add(pbStar5);
            Controls.Add(pbStar4);
            Controls.Add(pbStar3);
            Controls.Add(pbStar2);
            Controls.Add(pbStar1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonPublish);
            Controls.Add(tbReviewContent);
            Controls.Add(labelAuthorValue);
            Controls.Add(labelAuthor);
            Controls.Add(labelBookName);
            Name = "FormAddReview";
            Text = "Написать отзыв";
            ((System.ComponentModel.ISupportInitialize)pbStar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBookName;
        private Label labelAuthor;
        private Label labelAuthorValue;
        private TextBox tbReviewContent;
        private Button buttonPublish;
        private Button buttonCancel;
        private PictureBox pbStar1;
        private PictureBox pbStar2;
        private PictureBox pbStar3;
        private PictureBox pbStar4;
        private PictureBox pbStar5;
    }
}