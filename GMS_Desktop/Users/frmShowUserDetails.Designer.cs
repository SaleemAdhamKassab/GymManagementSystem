namespace GMS_Desktop.Users
{
    partial class frmShowUserDetails
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
            ctrlPersonCard1 = new Coaches.ctrlPersonCard();
            label1 = new Label();
            btnClose = new Button();
            label2 = new Label();
            lblUserName = new Label();
            lblIsActive = new Label();
            l = new Label();
            pictureBox7 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblRole = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(13, 89);
            ctrlPersonCard1.Margin = new Padding(4);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(741, 309);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(741, 41);
            label1.TabIndex = 1;
            label1.Text = "User Info";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(614, 535);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 39);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 402);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 0;
            label2.Text = "User Name:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(208, 402);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(44, 20);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "[???]";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(208, 486);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(44, 20);
            lblIsActive.TabIndex = 6;
            lblIsActive.Text = "[???]";
            // 
            // l
            // 
            l.AutoSize = true;
            l.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l.Location = new Point(28, 486);
            l.Name = "l";
            l.Size = new Size(83, 20);
            l.TabIndex = 5;
            l.Text = "Is Active:";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.User_32__2;
            pictureBox7.Location = new Point(173, 402);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(29, 26);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 19;
            pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Is_Active;
            pictureBox1.Location = new Point(173, 486);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User_role;
            pictureBox2.Location = new Point(173, 444);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(208, 444);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(44, 20);
            lblRole.TabIndex = 22;
            lblRole.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 444);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 21;
            label4.Text = "Role:";
            // 
            // frmShowUserDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(769, 586);
            Controls.Add(pictureBox2);
            Controls.Add(lblRole);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox7);
            Controls.Add(lblIsActive);
            Controls.Add(l);
            Controls.Add(lblUserName);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ctrlPersonCard1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmShowUserDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show User Details";
            Load += frmShowUserDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Coaches.ctrlPersonCard ctrlPersonCard1;
        private Label label1;
        private Label label2;
        private Button btnClose;
        private Label lblUserName;
        private Label lblIsActive;
        private Label l;
        private PictureBox pictureBox7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblRole;
        private Label label4;
    }
}