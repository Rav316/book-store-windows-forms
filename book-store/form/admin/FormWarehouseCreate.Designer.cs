namespace book_store.form.admin
{
    partial class FormWarehouseCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWarehouseCreate));
            buttonCreate = new Button();
            tbName = new TextBox();
            labelName = new Label();
            pbBack = new PictureBox();
            labelWarehouse = new Label();
            tbAddress = new TextBox();
            labelAddress = new Label();
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
            buttonCreate.Location = new Point(78, 195);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(430, 43);
            buttonCreate.TabIndex = 152;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // tbName
            // 
            tbName.BackColor = Color.FromArgb(224, 224, 224);
            tbName.BorderStyle = BorderStyle.None;
            tbName.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbName.Location = new Point(285, 99);
            tbName.MaxLength = 127;
            tbName.Name = "tbName";
            tbName.Size = new Size(223, 22);
            tbName.TabIndex = 151;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.ForeColor = Color.Black;
            labelName.Location = new Point(78, 99);
            labelName.Name = "labelName";
            labelName.Size = new Size(82, 21);
            labelName.TabIndex = 150;
            labelName.Text = "Название:";
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(41, 44);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 10);
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.TabIndex = 149;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelWarehouse
            // 
            labelWarehouse.AutoSize = true;
            labelWarehouse.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWarehouse.Location = new Point(147, 23);
            labelWarehouse.Name = "labelWarehouse";
            labelWarehouse.Size = new Size(292, 48);
            labelWarehouse.TabIndex = 148;
            labelWarehouse.Text = "Создание склада";
            // 
            // tbAddress
            // 
            tbAddress.BackColor = Color.FromArgb(224, 224, 224);
            tbAddress.BorderStyle = BorderStyle.None;
            tbAddress.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbAddress.Location = new Point(285, 142);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(223, 22);
            tbAddress.TabIndex = 154;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAddress.ForeColor = Color.Black;
            labelAddress.Location = new Point(78, 142);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(58, 21);
            labelAddress.TabIndex = 153;
            labelAddress.Text = "Адрес:";
            // 
            // FormWarehouseCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 277);
            Controls.Add(tbAddress);
            Controls.Add(labelAddress);
            Controls.Add(buttonCreate);
            Controls.Add(tbName);
            Controls.Add(labelName);
            Controls.Add(pbBack);
            Controls.Add(labelWarehouse);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormWarehouseCreate";
            Text = "Создание склада";
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private TextBox tbName;
        private Label labelName;
        private PictureBox pbBack;
        private Label labelWarehouse;
        private TextBox tbAddress;
        private Label labelAddress;
    }
}