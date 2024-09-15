namespace GMS_Desktop.Login
{
    partial class frmLoginScreen
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
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ckbRemainderMe = new CheckBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            lblDay = new Label();
            label4 = new Label();
            lblDate = new Label();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.closeBlack32;
            btnClose.Location = new Point(542, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 41);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(197, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(572, 37);
            label1.TabIndex = 1;
            label1.Text = "Welcome To Fitness Gym";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckbRemainderMe);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(60, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 217);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login to your account";
            // 
            // ckbRemainderMe
            // 
            ckbRemainderMe.AutoSize = true;
            ckbRemainderMe.Checked = true;
            ckbRemainderMe.CheckState = CheckState.Checked;
            ckbRemainderMe.Location = new Point(185, 171);
            ckbRemainderMe.Name = "ckbRemainderMe";
            ckbRemainderMe.Size = new Size(144, 24);
            ckbRemainderMe.TabIndex = 3;
            ckbRemainderMe.Text = "Remainder me";
            ckbRemainderMe.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(185, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(249, 26);
            txtPassword.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(185, 64);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(249, 26);
            txtUserName.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Password_32;
            pictureBox3.Location = new Point(137, 121);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Person_32;
            pictureBox2.Location = new Point(137, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 130);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 67);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 0;
            label2.Text = "User Name:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblDay);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblDate);
            panel1.Location = new Point(60, 298);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 42);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 11);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 3;
            label5.Text = "Day:";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDay.Location = new Point(87, 11);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(44, 20);
            lblDay.TabIndex = 2;
            lblDay.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(215, 11);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 1;
            label4.Text = "Date:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(274, 11);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 20);
            lblDate.TabIndex = 0;
            lblDate.Text = "[???]";
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Image = Properties.Resources.sign_out_32__2;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(408, 595);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 42);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLoginScreen
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(600, 649);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmLoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoginScreen";
            FormClosing += frmLoginScreen_FormClosing;
            Load += frmLoginScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label5;
        private Label lblDay;
        private Label label4;
        private Label lblDate;
        private Button btnLogin;
        private CheckBox ckbRemainderMe;
    }
}