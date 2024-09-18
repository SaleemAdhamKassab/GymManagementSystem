namespace GMS_Desktop.Coaches
{
    partial class frmAddEditCoach
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
            txtThirdName = new TextBox();
            txtSecondName = new TextBox();
            txtFirstName = new TextBox();
            lblCoachId = new Label();
            label7 = new Label();
            pbImage = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            llRemove = new LinkLabel();
            llSetImage = new LinkLabel();
            dtpDateOfBirth = new DateTimePicker();
            label10 = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtAddress = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            txtAchAndAwards = new TextBox();
            label11 = new Label();
            label12 = new Label();
            cbClasses = new ComboBox();
            tbCoach = new TabControl();
            tpPersonalInfo = new TabPage();
            tpCoachInfo = new TabPage();
            label13 = new Label();
            cbCategories = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ckbIsActive = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            tbCoach.SuspendLayout();
            tpPersonalInfo.SuspendLayout();
            tpCoachInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(873, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add/Edit Coach";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(245, 237);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(313, 26);
            txtLastName.TabIndex = 3;
            txtLastName.Validating += TextBoxes_Validating;
            // 
            // txtThirdName
            // 
            txtThirdName.Location = new Point(245, 191);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(313, 26);
            txtThirdName.TabIndex = 2;
            txtThirdName.Validating += TextBoxes_Validating;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(245, 147);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(313, 26);
            txtSecondName.TabIndex = 1;
            txtSecondName.Validating += TextBoxes_Validating;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(245, 102);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(313, 26);
            txtFirstName.TabIndex = 0;
            txtFirstName.Validating += TextBoxes_Validating;
            // 
            // lblCoachId
            // 
            lblCoachId.AutoSize = true;
            lblCoachId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoachId.Location = new Point(115, 54);
            lblCoachId.Name = "lblCoachId";
            lblCoachId.Size = new Size(49, 20);
            lblCoachId.TabIndex = 23;
            lblCoachId.Text = "[???]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 54);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 22;
            label7.Text = "Coach ID:";
            // 
            // pbImage
            // 
            pbImage.Image = Properties.Resources.Male_512;
            pbImage.Location = new Point(651, 54);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(209, 196);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 21;
            pbImage.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 240);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 20;
            label4.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 194);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 19;
            label3.Text = "Third Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 150);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 17;
            label2.Text = "Second Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 105);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 15;
            label1.Text = "First Name:";
            // 
            // llRemove
            // 
            llRemove.AutoSize = true;
            llRemove.Location = new Point(651, 293);
            llRemove.Name = "llRemove";
            llRemove.Size = new Size(68, 20);
            llRemove.TabIndex = 12;
            llRemove.TabStop = true;
            llRemove.Text = "Remove";
            llRemove.Visible = false;
            llRemove.LinkClicked += llRemove_LinkClicked;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Location = new Point(651, 263);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(83, 20);
            llSetImage.TabIndex = 11;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(249, 328);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(313, 26);
            dtpDateOfBirth.TabIndex = 7;
            dtpDateOfBirth.Validating += dtpDateOfBirth_Validating;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(29, 334);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 36;
            label10.Text = "Date Of Birth:";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(346, 290);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(86, 24);
            rbFemale.TabIndex = 6;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(249, 290);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(65, 24);
            rbMale.TabIndex = 5;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(249, 373);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(313, 26);
            txtAddress.TabIndex = 8;
            txtAddress.Validating += TextBoxes_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(65, 377);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 35;
            label9.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(71, 293);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 34;
            label8.Text = "Gendor:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(249, 466);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(313, 26);
            txtEmail.TabIndex = 10;
            txtEmail.Validating += Email_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(249, 419);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(313, 26);
            txtPhone.TabIndex = 9;
            txtPhone.Validating += PhoneNumber_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 470);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 30;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 423);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 28;
            label5.Text = "Phone:";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(738, 639);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 37);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(584, 639);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 37);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtAchAndAwards
            // 
            txtAchAndAwards.Location = new Point(244, 170);
            txtAchAndAwards.Multiline = true;
            txtAchAndAwards.Name = "txtAchAndAwards";
            txtAchAndAwards.Size = new Size(373, 93);
            txtAchAndAwards.TabIndex = 15;
            txtAchAndAwards.Validating += TextBoxes_Validating;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(5, 173);
            label11.Name = "label11";
            label11.Size = new Size(214, 24);
            label11.TabIndex = 39;
            label11.Text = "Achievements And Awards:";
            label11.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(161, 94);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 41;
            label12.Text = "Class:";
            // 
            // cbClasses
            // 
            cbClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClasses.FormattingEnabled = true;
            cbClasses.Location = new Point(244, 94);
            cbClasses.Name = "cbClasses";
            cbClasses.Size = new Size(313, 28);
            cbClasses.TabIndex = 14;
            cbClasses.Validating += cbClasses_Validating;
            // 
            // tbCoach
            // 
            tbCoach.Controls.Add(tpPersonalInfo);
            tbCoach.Controls.Add(tpCoachInfo);
            tbCoach.Location = new Point(10, 70);
            tbCoach.Name = "tbCoach";
            tbCoach.SelectedIndex = 0;
            tbCoach.Size = new Size(879, 567);
            tbCoach.TabIndex = 42;
            // 
            // tpPersonalInfo
            // 
            tpPersonalInfo.Controls.Add(txtLastName);
            tpPersonalInfo.Controls.Add(label1);
            tpPersonalInfo.Controls.Add(label2);
            tpPersonalInfo.Controls.Add(dtpDateOfBirth);
            tpPersonalInfo.Controls.Add(label3);
            tpPersonalInfo.Controls.Add(label10);
            tpPersonalInfo.Controls.Add(label4);
            tpPersonalInfo.Controls.Add(rbFemale);
            tpPersonalInfo.Controls.Add(label7);
            tpPersonalInfo.Controls.Add(rbMale);
            tpPersonalInfo.Controls.Add(lblCoachId);
            tpPersonalInfo.Controls.Add(txtAddress);
            tpPersonalInfo.Controls.Add(txtFirstName);
            tpPersonalInfo.Controls.Add(label9);
            tpPersonalInfo.Controls.Add(txtSecondName);
            tpPersonalInfo.Controls.Add(label8);
            tpPersonalInfo.Controls.Add(txtEmail);
            tpPersonalInfo.Controls.Add(txtThirdName);
            tpPersonalInfo.Controls.Add(txtPhone);
            tpPersonalInfo.Controls.Add(llRemove);
            tpPersonalInfo.Controls.Add(label6);
            tpPersonalInfo.Controls.Add(pbImage);
            tpPersonalInfo.Controls.Add(label5);
            tpPersonalInfo.Controls.Add(llSetImage);
            tpPersonalInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tpPersonalInfo.Location = new Point(4, 29);
            tpPersonalInfo.Name = "tpPersonalInfo";
            tpPersonalInfo.Padding = new Padding(3);
            tpPersonalInfo.Size = new Size(871, 534);
            tpPersonalInfo.TabIndex = 0;
            tpPersonalInfo.Text = "Personal Info";
            tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // tpCoachInfo
            // 
            tpCoachInfo.Controls.Add(ckbIsActive);
            tpCoachInfo.Controls.Add(label13);
            tpCoachInfo.Controls.Add(cbCategories);
            tpCoachInfo.Controls.Add(label12);
            tpCoachInfo.Controls.Add(txtAchAndAwards);
            tpCoachInfo.Controls.Add(label11);
            tpCoachInfo.Controls.Add(cbClasses);
            tpCoachInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tpCoachInfo.ForeColor = Color.Black;
            tpCoachInfo.Location = new Point(4, 29);
            tpCoachInfo.Name = "tpCoachInfo";
            tpCoachInfo.Padding = new Padding(3);
            tpCoachInfo.Size = new Size(871, 534);
            tpCoachInfo.TabIndex = 1;
            tpCoachInfo.Text = "Coach Info";
            tpCoachInfo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(133, 28);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 43;
            label13.Text = "Category:";
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(244, 25);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(313, 28);
            cbCategories.TabIndex = 13;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            cbCategories.Validating += cbCategories_Validating;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ckbIsActive
            // 
            ckbIsActive.AutoSize = true;
            ckbIsActive.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbIsActive.Location = new Point(244, 323);
            ckbIsActive.Name = "ckbIsActive";
            ckbIsActive.Size = new Size(97, 24);
            ckbIsActive.TabIndex = 44;
            ckbIsActive.Text = "Is Active";
            ckbIsActive.UseVisualStyleBackColor = true;
            // 
            // frmAddEditCoach
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(893, 684);
            Controls.Add(tbCoach);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmAddEditCoach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Edit Coach";
            Load += frmAddEditCoach_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            tbCoach.ResumeLayout(false);
            tpPersonalInfo.ResumeLayout(false);
            tpPersonalInfo.PerformLayout();
            tpCoachInfo.ResumeLayout(false);
            tpCoachInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TextBox txtLastName;
        private TextBox txtThirdName;
        private TextBox txtSecondName;
        private TextBox txtFirstName;
        private Label lblCoachId;
        private Label label7;
        private PictureBox pbImage;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel llRemove;
        private LinkLabel llSetImage;
        private DateTimePicker dtpDateOfBirth;
        private Label label10;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtAddress;
        private Label label9;
        private Label label8;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label label6;
        private Label label5;
        private Button btnSave;
        private Button btnClose;
        private TextBox txtAchAndAwards;
        private Label label11;
        private Label label12;
        private ComboBox cbClasses;
        private TabControl tbCoach;
        private TabPage tpPersonalInfo;
        private TabPage tpCoachInfo;
        private Label label13;
        private ComboBox cbCategories;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
        private CheckBox ckbIsActive;
    }
}