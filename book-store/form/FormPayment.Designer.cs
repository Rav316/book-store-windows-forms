namespace book_store.form
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            pbBack = new PictureBox();
            labelOrderInfo = new Label();
            labelPaymentDetails = new Label();
            label3 = new Label();
            labelCardNumber = new Label();
            tbCardNumber = new TextBox();
            tbMonth = new TextBox();
            labelExpirationDate = new Label();
            tbCode = new TextBox();
            labelCode = new Label();
            buttonCancel = new Button();
            buttonPay = new Button();
            tbYear = new TextBox();
            labelSlash = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(21, 23);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 20);
            pbBack.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBack.TabIndex = 24;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // labelOrderInfo
            // 
            labelOrderInfo.AutoSize = true;
            labelOrderInfo.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOrderInfo.Location = new Point(63, 6);
            labelOrderInfo.Name = "labelOrderInfo";
            labelOrderInfo.Size = new Size(647, 48);
            labelOrderInfo.TabIndex = 23;
            labelOrderInfo.Text = "Оплата заказа #123456 на сумму 1234 ₽";
            // 
            // labelPaymentDetails
            // 
            labelPaymentDetails.AutoSize = true;
            labelPaymentDetails.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPaymentDetails.Location = new Point(303, 72);
            labelPaymentDetails.Name = "labelPaymentDetails";
            labelPaymentDetails.Size = new Size(167, 25);
            labelPaymentDetails.TabIndex = 25;
            labelPaymentDetails.Text = "Реквизиты оплаты";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(41, 2, 71);
            label3.Location = new Point(-2, 108);
            label3.Name = "label3";
            label3.Size = new Size(804, 2);
            label3.TabIndex = 29;
            // 
            // labelCardNumber
            // 
            labelCardNumber.AutoSize = true;
            labelCardNumber.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCardNumber.Location = new Point(163, 122);
            labelCardNumber.Name = "labelCardNumber";
            labelCardNumber.Size = new Size(121, 25);
            labelCardNumber.TabIndex = 30;
            labelCardNumber.Text = "Номер карты";
            // 
            // tbCardNumber
            // 
            tbCardNumber.BorderStyle = BorderStyle.None;
            tbCardNumber.Font = new Font("Philosopher", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbCardNumber.Location = new Point(163, 159);
            tbCardNumber.MaxLength = 16;
            tbCardNumber.MinimumSize = new Size(452, 36);
            tbCardNumber.Name = "tbCardNumber";
            tbCardNumber.Size = new Size(452, 36);
            tbCardNumber.TabIndex = 31;
            // 
            // tbMonth
            // 
            tbMonth.BorderStyle = BorderStyle.None;
            tbMonth.Font = new Font("Philosopher", 20.25F);
            tbMonth.Location = new Point(163, 284);
            tbMonth.MaxLength = 2;
            tbMonth.MinimumSize = new Size(50, 36);
            tbMonth.Name = "tbMonth";
            tbMonth.Size = new Size(50, 36);
            tbMonth.TabIndex = 33;
            tbMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // labelExpirationDate
            // 
            labelExpirationDate.AutoSize = true;
            labelExpirationDate.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelExpirationDate.Location = new Point(163, 247);
            labelExpirationDate.Name = "labelExpirationDate";
            labelExpirationDate.Size = new Size(137, 25);
            labelExpirationDate.TabIndex = 32;
            labelExpirationDate.Text = "Срок действия";
            // 
            // tbCode
            // 
            tbCode.BorderStyle = BorderStyle.None;
            tbCode.Font = new Font("Philosopher", 20.25F);
            tbCode.Location = new Point(465, 284);
            tbCode.MaxLength = 3;
            tbCode.MinimumSize = new Size(150, 36);
            tbCode.Name = "tbCode";
            tbCode.Size = new Size(150, 36);
            tbCode.TabIndex = 35;
            tbCode.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Philosopher", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCode.Location = new Point(475, 247);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(140, 25);
            labelCode.TabIndex = 34;
            labelCode.Text = "CVC / CVV код";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(99, 108, 116);
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = SystemColors.Window;
            buttonCancel.Location = new Point(386, 370);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(182, 36);
            buttonCancel.TabIndex = 41;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonPay
            // 
            buttonPay.BackColor = Color.FromArgb(41, 2, 71);
            buttonPay.Cursor = Cursors.Hand;
            buttonPay.FlatStyle = FlatStyle.Flat;
            buttonPay.Font = new Font("Philosopher", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPay.ForeColor = SystemColors.Window;
            buttonPay.Location = new Point(198, 370);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(182, 36);
            buttonPay.TabIndex = 40;
            buttonPay.Text = "Оплатить";
            buttonPay.UseVisualStyleBackColor = false;
            buttonPay.Click += buttonPay_Click;
            // 
            // tbYear
            // 
            tbYear.BorderStyle = BorderStyle.None;
            tbYear.Font = new Font("Philosopher", 20.25F);
            tbYear.Location = new Point(250, 284);
            tbYear.MaxLength = 2;
            tbYear.MinimumSize = new Size(50, 36);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(50, 36);
            tbYear.TabIndex = 42;
            tbYear.TextAlign = HorizontalAlignment.Center;
            // 
            // labelSlash
            // 
            labelSlash.AutoSize = true;
            labelSlash.Font = new Font("Philosopher", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSlash.Location = new Point(217, 276);
            labelSlash.Name = "labelSlash";
            labelSlash.Size = new Size(37, 48);
            labelSlash.TabIndex = 43;
            labelSlash.Text = "/";
            // 
            // FormPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 450);
            Controls.Add(labelSlash);
            Controls.Add(tbYear);
            Controls.Add(buttonCancel);
            Controls.Add(buttonPay);
            Controls.Add(tbCode);
            Controls.Add(labelCode);
            Controls.Add(tbMonth);
            Controls.Add(labelExpirationDate);
            Controls.Add(tbCardNumber);
            Controls.Add(labelCardNumber);
            Controls.Add(label3);
            Controls.Add(labelPaymentDetails);
            Controls.Add(pbBack);
            Controls.Add(labelOrderInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оплата заказа";
            Load += FormPayment_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBack;
        private Label labelOrderInfo;
        private Label labelPaymentDetails;
        private Label label3;
        private Label labelCardNumber;
        private TextBox tbCardNumber;
        private TextBox tbMonth;
        private Label labelExpirationDate;
        private TextBox tbCode;
        private Label labelCode;
        private Button buttonCancel;
        private Button buttonPay;
        private TextBox tbYear;
        private Label labelSlash;
    }
}