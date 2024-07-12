namespace GMS_Desktop
{
    partial class frmAddEditClient
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pbImage = new PictureBox();
            btnClose = new Button();
            btnSave = new Button();
            label7 = new Label();
            lblClientID = new Label();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            txtThirdName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            label8 = new Label();
            txtAddress = new TextBox();
            label9 = new Label();
            llSetImage = new LinkLabel();
            llRemove = new LinkLabel();
            openFileDialog1 = new OpenFileDialog();
            rbMale = new RadioButton();
            rdFemale = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            label10 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(716, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add/Edit Client";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 123);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 173);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 2;
            label2.Text = "Second Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 221);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 3;
            label3.Text = "Third Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 271);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 4;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 473);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 5;
            label5.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 528);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // pbImage
            // 
            pbImage.Image = Properties.Resources.Male_512;
            pbImage.Location = new Point(518, 123);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(209, 196);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 8;
            pbImage.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(427, 583);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 37);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(581, 583);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 37);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 75);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 11;
            label7.Text = "Client ID:";
            // 
            // lblClientID
            // 
            lblClientID.AutoSize = true;
            lblClientID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientID.Location = new Point(133, 75);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new Size(39, 20);
            lblClientID.TabIndex = 12;
            lblClientID.Text = "???";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(204, 120);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(256, 26);
            txtFirstName.TabIndex = 0;
            txtFirstName.Validating += ValidateEmptyTextBoxes;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(204, 170);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(256, 26);
            txtSecondName.TabIndex = 1;
            txtSecondName.Validating += ValidateEmptyTextBoxes;
            // 
            // txtThirdName
            // 
            txtThirdName.Location = new Point(204, 218);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(256, 26);
            txtThirdName.TabIndex = 2;
            txtThirdName.Validating += ValidateEmptyTextBoxes;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(204, 268);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(256, 26);
            txtLastName.TabIndex = 3;
            txtLastName.Validating += ValidateEmptyTextBoxes;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(204, 470);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(256, 26);
            txtPhone.TabIndex = 8;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(204, 525);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 26);
            txtEmail.TabIndex = 9;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(43, 323);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 19;
            label8.Text = "Gendor:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(204, 419);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(256, 26);
            txtAddress.TabIndex = 7;
            txtAddress.Validating += ValidateEmptyTextBoxes;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(43, 422);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 21;
            label9.Text = "Address:";
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Location = new Point(518, 328);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(83, 20);
            llSetImage.TabIndex = 10;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // llRemove
            // 
            llRemove.AutoSize = true;
            llRemove.Location = new Point(518, 358);
            llRemove.Name = "llRemove";
            llRemove.Size = new Size(68, 20);
            llRemove.TabIndex = 11;
            llRemove.TabStop = true;
            llRemove.Text = "Remove";
            llRemove.LinkClicked += llRemove_LinkClicked;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(204, 321);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(65, 24);
            rbMale.TabIndex = 4;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdFemale.Location = new Point(301, 321);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(86, 24);
            rdFemale.TabIndex = 5;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(43, 370);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 22;
            label10.Text = "Date Of Birth:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(204, 365);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(256, 26);
            dtpDateOfBirth.TabIndex = 6;
            // 
            // frmAddEditClient
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(739, 632);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label10);
            Controls.Add(rdFemale);
            Controls.Add(rbMale);
            Controls.Add(llRemove);
            Controls.Add(llSetImage);
            Controls.Add(txtAddress);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtThirdName);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirstName);
            Controls.Add(lblClientID);
            Controls.Add(label7);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(pbImage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmAddEditClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddNewClient";
            Load += frmAddEditClient_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pbImage;
        private Button btnClose;
        private Button btnSave;
        private Label label7;
        private Label lblClientID;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private TextBox txtThirdName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtAddress;
        private Label label9;
        private LinkLabel llSetImage;
        private LinkLabel llRemove;
        private OpenFileDialog openFileDialog1;
        private RadioButton rbMale;
        private RadioButton rdFemale;
        private ErrorProvider errorProvider1;
        private DateTimePicker dtpDateOfBirth;
        private Label label10;
    }
}