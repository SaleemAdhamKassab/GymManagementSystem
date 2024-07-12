namespace GMS_Desktop
{
    partial class frmShowClientInfo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pbImage = new PictureBox();
            lblName = new Label();
            lblGendor = new Label();
            lblDateOfBirth = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(666, 42);
            label1.TabIndex = 0;
            label1.Text = "Client Info";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 101);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 150);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Gendor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 202);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 3;
            label4.Text = "Date Of Birth:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 257);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 309);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 5;
            label6.Text = "Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 361);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 6;
            label7.Text = "Email:";
            // 
            // pbImage
            // 
            pbImage.Image = Properties.Resources.Male_512;
            pbImage.Location = new Point(473, 136);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(188, 193);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 7;
            pbImage.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(185, 101);
            lblName.Name = "lblName";
            lblName.Size = new Size(44, 20);
            lblName.TabIndex = 8;
            lblName.Text = "[???]";
            // 
            // lblGendor
            // 
            lblGendor.AutoSize = true;
            lblGendor.Location = new Point(185, 150);
            lblGendor.Name = "lblGendor";
            lblGendor.Size = new Size(44, 20);
            lblGendor.TabIndex = 9;
            lblGendor.Text = "[???]";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(185, 202);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(44, 20);
            lblDateOfBirth.TabIndex = 10;
            lblDateOfBirth.Text = "[???]";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(185, 257);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(44, 20);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "[???]";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(185, 309);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 20);
            lblPhone.TabIndex = 12;
            lblPhone.Text = "[???]";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(185, 361);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 20);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "[???]";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(491, 392);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 40);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowClientInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(673, 444);
            Controls.Add(btnClose);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblGendor);
            Controls.Add(lblName);
            Controls.Add(pbImage);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmShowClientInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client Info";
            Load += frmShowClientInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pbImage;
        private Label lblName;
        private Label lblGendor;
        private Label lblDateOfBirth;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblEmail;
        private Button btnClose;
    }
}