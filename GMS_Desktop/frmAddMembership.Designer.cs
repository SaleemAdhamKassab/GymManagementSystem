namespace GMS_Desktop
{
    partial class frmAddMembership
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblClientName = new Label();
            gbHealthInformation = new GroupBox();
            llHealthInforamtionLink = new LinkLabel();
            label9 = new Label();
            label11 = new Label();
            rbYesHealthInfo = new RadioButton();
            rbNoHealthInfo = new RadioButton();
            cbPaymentMothods = new ComboBox();
            label12 = new Label();
            btnAddClass = new Button();
            lblClassFees = new Label();
            label10 = new Label();
            lblTotalAmount = new Label();
            label8 = new Label();
            nudDuration = new NumericUpDown();
            pbClassImage = new PictureBox();
            label5 = new Label();
            cbCoaches = new ComboBox();
            label4 = new Label();
            cbClasses = new ComboBox();
            label3 = new Label();
            cbCategories = new ComboBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            lblRecordsCount = new Label();
            label7 = new Label();
            dgvMembershipDetails = new DataGridView();
            label6 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            gbHealthInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClassImage).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembershipDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(19, 26);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "Client:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(789, 642);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblClientName);
            tabPage1.Controls.Add(gbHealthInformation);
            tabPage1.Controls.Add(cbPaymentMothods);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(btnAddClass);
            tabPage1.Controls.Add(lblClassFees);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(lblTotalAmount);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(nudDuration);
            tabPage1.Controls.Add(pbClassImage);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(cbCoaches);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(cbClasses);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cbCategories);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(781, 609);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "subscription";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblClientName
            // 
            lblClientName.Location = new Point(184, 26);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(303, 28);
            lblClientName.TabIndex = 24;
            lblClientName.Text = "???";
            lblClientName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbHealthInformation
            // 
            gbHealthInformation.Controls.Add(llHealthInforamtionLink);
            gbHealthInformation.Controls.Add(label9);
            gbHealthInformation.Controls.Add(label11);
            gbHealthInformation.Controls.Add(rbYesHealthInfo);
            gbHealthInformation.Controls.Add(rbNoHealthInfo);
            gbHealthInformation.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbHealthInformation.Location = new Point(299, 429);
            gbHealthInformation.Name = "gbHealthInformation";
            gbHealthInformation.Size = new Size(474, 174);
            gbHealthInformation.TabIndex = 23;
            gbHealthInformation.TabStop = false;
            gbHealthInformation.Text = "Health Information";
            // 
            // llHealthInforamtionLink
            // 
            llHealthInforamtionLink.AutoSize = true;
            llHealthInforamtionLink.Enabled = false;
            llHealthInforamtionLink.Location = new Point(9, 145);
            llHealthInforamtionLink.Name = "llHealthInforamtionLink";
            llHealthInforamtionLink.Size = new Size(255, 20);
            llHealthInforamtionLink.TabIndex = 4;
            llHealthInforamtionLink.TabStop = true;
            llHealthInforamtionLink.Text = "Go to Health Information Form";
            llHealthInforamtionLink.LinkClicked += llHealthInforamtionLink_LinkClicked;
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(9, 28);
            label9.Name = "label9";
            label9.Size = new Size(459, 42);
            label9.TabIndex = 0;
            label9.Text = "Do you have any health issues or medical conditions we should be aware of?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(9, 115);
            label11.Name = "label11";
            label11.Size = new Size(275, 20);
            label11.TabIndex = 3;
            label11.Text = "If yes, please click the link below.";
            // 
            // rbYesHealthInfo
            // 
            rbYesHealthInfo.AutoSize = true;
            rbYesHealthInfo.FlatStyle = FlatStyle.Popup;
            rbYesHealthInfo.Location = new Point(9, 73);
            rbYesHealthInfo.Name = "rbYesHealthInfo";
            rbYesHealthInfo.Size = new Size(57, 24);
            rbYesHealthInfo.TabIndex = 1;
            rbYesHealthInfo.Text = "Yes";
            rbYesHealthInfo.UseVisualStyleBackColor = true;
            rbYesHealthInfo.CheckedChanged += rbYesHealthInfo_CheckedChanged;
            // 
            // rbNoHealthInfo
            // 
            rbNoHealthInfo.AutoSize = true;
            rbNoHealthInfo.Checked = true;
            rbNoHealthInfo.FlatStyle = FlatStyle.Popup;
            rbNoHealthInfo.Location = new Point(69, 73);
            rbNoHealthInfo.Name = "rbNoHealthInfo";
            rbNoHealthInfo.Size = new Size(48, 24);
            rbNoHealthInfo.TabIndex = 2;
            rbNoHealthInfo.TabStop = true;
            rbNoHealthInfo.Text = "No";
            rbNoHealthInfo.UseVisualStyleBackColor = true;
            // 
            // cbPaymentMothods
            // 
            cbPaymentMothods.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentMothods.FormattingEnabled = true;
            cbPaymentMothods.Location = new Point(184, 298);
            cbPaymentMothods.Name = "cbPaymentMothods";
            cbPaymentMothods.Size = new Size(303, 28);
            cbPaymentMothods.TabIndex = 5;
            cbPaymentMothods.SelectedIndexChanged += cbPaymentMothods_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label12.Location = new Point(19, 301);
            label12.Name = "label12";
            label12.Size = new Size(148, 20);
            label12.TabIndex = 22;
            label12.Text = "Payment Method:";
            // 
            // btnAddClass
            // 
            btnAddClass.BackgroundImage = Properties.Resources.enroll;
            btnAddClass.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddClass.FlatStyle = FlatStyle.Popup;
            btnAddClass.Location = new Point(19, 497);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(86, 77);
            btnAddClass.TabIndex = 6;
            btnAddClass.UseVisualStyleBackColor = true;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // lblClassFees
            // 
            lblClassFees.AutoSize = true;
            lblClassFees.Location = new Point(641, 280);
            lblClassFees.Name = "lblClassFees";
            lblClassFees.Size = new Size(27, 20);
            lblClassFees.TabIndex = 18;
            lblClassFees.Text = "0$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(532, 280);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 17;
            label10.Text = "Class Fees:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(150, 355);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(27, 20);
            lblTotalAmount.TabIndex = 16;
            lblTotalAmount.Text = "0$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 355);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 15;
            label8.Text = "Total Amount:";
            // 
            // nudDuration
            // 
            nudDuration.Location = new Point(184, 242);
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(303, 26);
            nudDuration.TabIndex = 4;
            // 
            // pbClassImage
            // 
            pbClassImage.Image = Properties.Resources.cateogry_Default;
            pbClassImage.Location = new Point(532, 24);
            pbClassImage.Name = "pbClassImage";
            pbClassImage.Size = new Size(241, 244);
            pbClassImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClassImage.TabIndex = 11;
            pbClassImage.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(19, 242);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Duration:";
            // 
            // cbCoaches
            // 
            cbCoaches.FormattingEnabled = true;
            cbCoaches.Items.AddRange(new object[] { "Coach 1 test" });
            cbCoaches.Location = new Point(184, 183);
            cbCoaches.Name = "cbCoaches";
            cbCoaches.Size = new Size(303, 28);
            cbCoaches.TabIndex = 3;
            cbCoaches.Validating += ValidateEmptyComboBoxes_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(19, 184);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 7;
            label4.Text = "Coach:";
            // 
            // cbClasses
            // 
            cbClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClasses.FormattingEnabled = true;
            cbClasses.Location = new Point(184, 128);
            cbClasses.Name = "cbClasses";
            cbClasses.Size = new Size(303, 28);
            cbClasses.TabIndex = 2;
            cbClasses.SelectedIndexChanged += cbClasses_SelectedIndexChanged;
            cbClasses.Validating += ValidateEmptyComboBoxes_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(19, 129);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Class:";
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(184, 76);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(303, 28);
            cbCategories.TabIndex = 1;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            cbCategories.Validating += ValidateEmptyComboBoxes_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(19, 77);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Category:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblRecordsCount);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dgvMembershipDetails);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(781, 614);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Membership Details";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Location = new Point(120, 502);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(36, 20);
            lblRecordsCount.TabIndex = 14;
            lblRecordsCount.Text = "???";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 502);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 2;
            label7.Text = "# Records:";
            // 
            // dgvMembershipDetails
            // 
            dgvMembershipDetails.AllowUserToAddRows = false;
            dgvMembershipDetails.AllowUserToDeleteRows = false;
            dgvMembershipDetails.AllowUserToOrderColumns = true;
            dgvMembershipDetails.BackgroundColor = Color.White;
            dgvMembershipDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembershipDetails.Location = new Point(67, 100);
            dgvMembershipDetails.Name = "dgvMembershipDetails";
            dgvMembershipDetails.ReadOnly = true;
            dgvMembershipDetails.Size = new Size(652, 350);
            dgvMembershipDetails.TabIndex = 1;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 13);
            label6.Name = "label6";
            label6.Size = new Size(775, 42);
            label6.TabIndex = 0;
            label6.Text = "Membership Details";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(625, 648);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(153, 41);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(466, 648);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(153, 41);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddMembership
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(790, 701);
            Controls.Add(tabControl1);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmAddMembership";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Membership";
            Load += frmAddMembership_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            gbHealthInformation.ResumeLayout(false);
            gbHealthInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClassImage).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembershipDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cbCoaches;
        private Label label4;
        private ComboBox cbClasses;
        private Label label3;
        private ComboBox cbCategories;
        private Label label2;
        private Label label5;
        private PictureBox pbClassImage;
        private Button btnSave;
        private Button btnClose;
        private NumericUpDown nudDuration;
        private DataGridView dgvMembershipDetails;
        private Label label6;
        private Label label7;
        private Label lblRecordsCount;
        private Label lblTotalAmount;
        private Label label8;
        private Label lblClassFees;
        private Label label10;
        private Button btnAddClass;
        private Label label12;
        private ComboBox cbPaymentMothods;
        private ErrorProvider errorProvider1;
        private GroupBox gbHealthInformation;
        private LinkLabel llHealthInforamtionLink;
        private Label label9;
        private Label label11;
        private RadioButton rbYesHealthInfo;
        private RadioButton rbNoHealthInfo;
        private Label lblClientName;
    }
}