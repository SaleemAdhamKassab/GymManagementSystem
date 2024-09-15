namespace GMS_Desktop.Users
{
    partial class frmAddEditUser
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label3 = new Label();
            label10 = new Label();
            label4 = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtAddress = new TextBox();
            txtFirstName = new TextBox();
            label9 = new Label();
            txtSecondName = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            txtThirdName = new TextBox();
            txtPhone = new TextBox();
            llRemove = new LinkLabel();
            label6 = new Label();
            pbImage = new PictureBox();
            label5 = new Label();
            llSetImage = new LinkLabel();
            label7 = new Label();
            label11 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            ckbIsActive = new CheckBox();
            btnClose = new Button();
            btnSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtConfirmPassword = new TextBox();
            label12 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            rbIsAdminNo = new RadioButton();
            rbIsAdminYes = new RadioButton();
            label13 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(944, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add/Edit User";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(277, 197);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(313, 26);
            txtLastName.TabIndex = 3;
            txtLastName.Validating += TextBoxes_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 71;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 96);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 72;
            label2.Text = "Second Name:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(277, 301);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(313, 26);
            dtpDateOfBirth.TabIndex = 6;
            dtpDateOfBirth.Validating += dtpDateOfBirth_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 148);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 73;
            label3.Text = "Third Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(30, 306);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 80;
            label10.Text = "Date Of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 200);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 74;
            label4.Text = "Last Name:";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(375, 250);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(86, 24);
            rbFemale.TabIndex = 5;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(278, 250);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(65, 24);
            rbMale.TabIndex = 4;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(277, 360);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(313, 26);
            txtAddress.TabIndex = 7;
            txtAddress.Validating += TextBoxes_Validating;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(277, 38);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(313, 26);
            txtFirstName.TabIndex = 0;
            txtFirstName.Validating += TextBoxes_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(30, 360);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 79;
            label9.Text = "Address:";
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(277, 93);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(313, 26);
            txtSecondName.TabIndex = 1;
            txtSecondName.Validating += TextBoxes_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 252);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 78;
            label8.Text = "Gendor:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(277, 475);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(313, 26);
            txtEmail.TabIndex = 9;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtThirdName
            // 
            txtThirdName.Location = new Point(277, 145);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(313, 26);
            txtThirdName.TabIndex = 2;
            txtThirdName.Validating += TextBoxes_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(277, 418);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(313, 26);
            txtPhone.TabIndex = 8;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // llRemove
            // 
            llRemove.AutoSize = true;
            llRemove.Location = new Point(703, 317);
            llRemove.Name = "llRemove";
            llRemove.Size = new Size(68, 20);
            llRemove.TabIndex = 11;
            llRemove.TabStop = true;
            llRemove.Text = "Remove";
            llRemove.Visible = false;
            llRemove.LinkClicked += llRemove_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 478);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 77;
            label6.Text = "Email:";
            // 
            // pbImage
            // 
            pbImage.Image = Properties.Resources.Male_512;
            pbImage.Location = new Point(703, 78);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(209, 196);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 75;
            pbImage.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 421);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 76;
            label5.Text = "Phone:";
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Location = new Point(703, 287);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(83, 20);
            llSetImage.TabIndex = 10;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 70);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 81;
            label7.Text = "User Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(43, 142);
            label11.Name = "label11";
            label11.Size = new Size(91, 20);
            label11.TabIndex = 82;
            label11.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(248, 67);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(313, 26);
            txtUserName.TabIndex = 12;
            txtUserName.Validating += TextBoxes_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(248, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(313, 26);
            txtPassword.TabIndex = 13;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // ckbIsActive
            // 
            ckbIsActive.AutoSize = true;
            ckbIsActive.Checked = true;
            ckbIsActive.CheckState = CheckState.Checked;
            ckbIsActive.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbIsActive.Location = new Point(248, 398);
            ckbIsActive.Name = "ckbIsActive";
            ckbIsActive.Size = new Size(97, 24);
            ckbIsActive.TabIndex = 16;
            ckbIsActive.Text = "Is Active";
            ckbIsActive.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(674, 644);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 37);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(818, 644);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 37);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(248, 217);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(313, 26);
            txtConfirmPassword.TabIndex = 14;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(43, 223);
            label12.Name = "label12";
            label12.Size = new Size(158, 20);
            label12.TabIndex = 89;
            label12.Text = "Confirm Password:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(944, 562);
            tabControl1.TabIndex = 91;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(llRemove);
            tabPage1.Controls.Add(pbImage);
            tabPage1.Controls.Add(llSetImage);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtPhone);
            tabPage1.Controls.Add(txtThirdName);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtSecondName);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtFirstName);
            tabPage1.Controls.Add(txtLastName);
            tabPage1.Controls.Add(txtAddress);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(rbMale);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(rbFemale);
            tabPage1.Controls.Add(dtpDateOfBirth);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label10);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(936, 529);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personal Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rbIsAdminNo);
            tabPage2.Controls.Add(rbIsAdminYes);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(txtUserName);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtPassword);
            tabPage2.Controls.Add(txtConfirmPassword);
            tabPage2.Controls.Add(ckbIsActive);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(936, 529);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "User Info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbIsAdminNo
            // 
            rbIsAdminNo.AutoSize = true;
            rbIsAdminNo.Checked = true;
            rbIsAdminNo.Location = new Point(325, 305);
            rbIsAdminNo.Name = "rbIsAdminNo";
            rbIsAdminNo.Size = new Size(47, 24);
            rbIsAdminNo.TabIndex = 16;
            rbIsAdminNo.TabStop = true;
            rbIsAdminNo.Text = "No";
            rbIsAdminNo.UseVisualStyleBackColor = true;
            // 
            // rbIsAdminYes
            // 
            rbIsAdminYes.AutoSize = true;
            rbIsAdminYes.Location = new Point(248, 305);
            rbIsAdminYes.Name = "rbIsAdminYes";
            rbIsAdminYes.Size = new Size(55, 24);
            rbIsAdminYes.TabIndex = 15;
            rbIsAdminYes.Text = "Yes";
            rbIsAdminYes.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(43, 307);
            label13.Name = "label13";
            label13.Size = new Size(84, 20);
            label13.TabIndex = 90;
            label13.Text = "Is Admin:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(968, 693);
            Controls.Add(tabControl1);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmAddEditUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Edit User";
            Load += frmAddEditUser_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpDateOfBirth;
        private Label label3;
        private Label label10;
        private Label label4;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtAddress;
        private TextBox txtFirstName;
        private Label label9;
        private TextBox txtSecondName;
        private Label label8;
        private TextBox txtEmail;
        private TextBox txtThirdName;
        private TextBox txtPhone;
        private LinkLabel llRemove;
        private Label label6;
        private PictureBox pbImage;
        private Label label5;
        private LinkLabel llSetImage;
        private Label label7;
        private Label label11;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private CheckBox ckbIsActive;
        private Button btnClose;
        private Button btnSave;
        private OpenFileDialog openFileDialog1;
        private TextBox txtConfirmPassword;
        private Label label12;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ErrorProvider errorProvider1;
        private Label label13;
        private RadioButton rbIsAdminNo;
        private RadioButton rbIsAdminYes;
    }
}