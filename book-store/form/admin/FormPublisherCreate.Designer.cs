namespace book_store.form.admin
{
    partial class FormPublisherCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPublisherCreate));
            buttonSaveChanges = new Button();
            tbName = new TextBox();
            labelName = new Label();
            pbBack = new PictureBox();
            labelPublisher = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.FromArgb(41, 2, 71);
            buttonSaveChanges.Cursor = Cursors.Hand;
            buttonSaveChanges.FlatStyle = FlatStyle.Flat;
            buttonSaveChanges.Font = new Font("Philosopher", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSaveChanges.ForeColor = SystemColors.Window;
            buttonSaveChanges.Location = new Point(69, 145);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(430, 43);
            buttonSaveChanges.TabIndex = 147;
            buttonSaveChanges.Text = "Сохранить изменения";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // tbName
            // 
            tbName.BackColor = Color.FromArgb(224, 224, 224);
            tbName.BorderStyle = BorderStyle.None;
            tbName.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbName.Location = new Point(276, 89);
            tbName.Name = "tbName";
            tbName.Size = new Size(223, 22);
            tbName.TabIndex = 146;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.ForeColor = Color.Black;
            labelName.Location = new Point(69, 89);
            labelName.Name = "labelName";
            labelName.Size = new Size(82, 21);
            labelName.TabIndex = 145;
            labelName.Text = "Название:";
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(32, 29);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 20);
            pbBack.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBack.TabIndex = 142;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPublisher.Location = new Point(128, 13);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(328, 48);
            labelPublisher.TabIndex = 141;
            labelPublisher.Text = "Создание издателя";
            // 
            // FormPublisherCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 228);
            Controls.Add(buttonSaveChanges);
            Controls.Add(tbName);
            Controls.Add(labelName);
            Controls.Add(pbBack);
            Controls.Add(labelPublisher);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPublisherCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создать издателя";
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSaveChanges;
        private TextBox tbName;
        private Label labelName;
        private PictureBox pbBack;
        private Label labelPublisher;
    }
}