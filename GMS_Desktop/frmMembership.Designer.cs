namespace GMS_Desktop
{
    partial class frmMembership
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
            tcMembershipsTabs = new TabControl();
            tbMembershipList = new TabPage();
            cbIsActive = new ComboBox();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label3 = new Label();
            lblRecordsCount = new Label();
            label1 = new Label();
            dgvMembershipList = new DataGridView();
            tbExpireSoon = new TabPage();
            lblExpireSoonRecordsCount = new Label();
            label4 = new Label();
            dgvMembershipsExpireSoon = new DataGridView();
            btnClose = new Button();
            tcMembershipsTabs.SuspendLayout();
            tbMembershipList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembershipList).BeginInit();
            tbExpireSoon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembershipsExpireSoon).BeginInit();
            SuspendLayout();
            // 
            // tcMembershipsTabs
            // 
            tcMembershipsTabs.Controls.Add(tbMembershipList);
            tcMembershipsTabs.Controls.Add(tbExpireSoon);
            tcMembershipsTabs.Location = new Point(1, 0);
            tcMembershipsTabs.Name = "tcMembershipsTabs";
            tcMembershipsTabs.SelectedIndex = 0;
            tcMembershipsTabs.Size = new Size(1048, 588);
            tcMembershipsTabs.TabIndex = 0;
            // 
            // tbMembershipList
            // 
            tbMembershipList.Controls.Add(cbIsActive);
            tbMembershipList.Controls.Add(cbFilterBy);
            tbMembershipList.Controls.Add(txtFilterValue);
            tbMembershipList.Controls.Add(label3);
            tbMembershipList.Controls.Add(lblRecordsCount);
            tbMembershipList.Controls.Add(label1);
            tbMembershipList.Controls.Add(dgvMembershipList);
            tbMembershipList.Location = new Point(4, 29);
            tbMembershipList.Name = "tbMembershipList";
            tbMembershipList.Padding = new Padding(3);
            tbMembershipList.Size = new Size(1040, 555);
            tbMembershipList.TabIndex = 0;
            tbMembershipList.Text = "Membership List";
            tbMembershipList.UseVisualStyleBackColor = true;
            // 
            // cbIsActive
            // 
            cbIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new Point(302, 41);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(137, 28);
            cbIsActive.TabIndex = 13;
            cbIsActive.Visible = false;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Id", "Membership Name", "Phone", "Gendor", "Is Active" });
            cbFilterBy.Location = new Point(94, 41);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(202, 28);
            cbFilterBy.TabIndex = 12;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(302, 41);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(264, 26);
            txtFilterValue.TabIndex = 11;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 44);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 10;
            label3.Text = "Filter By:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(130, 514);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(18, 20);
            lblRecordsCount.TabIndex = 8;
            lblRecordsCount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 514);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 7;
            label1.Text = "# Records:";
            // 
            // dgvMembershipList
            // 
            dgvMembershipList.AllowUserToAddRows = false;
            dgvMembershipList.AllowUserToDeleteRows = false;
            dgvMembershipList.AllowUserToOrderColumns = true;
            dgvMembershipList.BackgroundColor = Color.White;
            dgvMembershipList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembershipList.Location = new Point(28, 93);
            dgvMembershipList.Name = "dgvMembershipList";
            dgvMembershipList.ReadOnly = true;
            dgvMembershipList.Size = new Size(967, 405);
            dgvMembershipList.TabIndex = 6;
            // 
            // tbExpireSoon
            // 
            tbExpireSoon.Controls.Add(lblExpireSoonRecordsCount);
            tbExpireSoon.Controls.Add(label4);
            tbExpireSoon.Controls.Add(dgvMembershipsExpireSoon);
            tbExpireSoon.Location = new Point(4, 29);
            tbExpireSoon.Name = "tbExpireSoon";
            tbExpireSoon.Padding = new Padding(3);
            tbExpireSoon.Size = new Size(1040, 555);
            tbExpireSoon.TabIndex = 1;
            tbExpireSoon.Text = "Expire Soon";
            tbExpireSoon.UseVisualStyleBackColor = true;
            // 
            // lblExpireSoonRecordsCount
            // 
            lblExpireSoonRecordsCount.AutoSize = true;
            lblExpireSoonRecordsCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpireSoonRecordsCount.Location = new Point(110, 518);
            lblExpireSoonRecordsCount.Name = "lblExpireSoonRecordsCount";
            lblExpireSoonRecordsCount.Size = new Size(18, 20);
            lblExpireSoonRecordsCount.TabIndex = 10;
            lblExpireSoonRecordsCount.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 518);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 9;
            label4.Text = "# Records:";
            // 
            // dgvMembershipsExpireSoon
            // 
            dgvMembershipsExpireSoon.AllowUserToAddRows = false;
            dgvMembershipsExpireSoon.AllowUserToDeleteRows = false;
            dgvMembershipsExpireSoon.AllowUserToOrderColumns = true;
            dgvMembershipsExpireSoon.BackgroundColor = Color.White;
            dgvMembershipsExpireSoon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembershipsExpireSoon.Location = new Point(6, 93);
            dgvMembershipsExpireSoon.Name = "dgvMembershipsExpireSoon";
            dgvMembershipsExpireSoon.ReadOnly = true;
            dgvMembershipsExpireSoon.Size = new Size(1026, 407);
            dgvMembershipsExpireSoon.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(883, 591);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(154, 43);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMembership
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1049, 646);
            Controls.Add(tcMembershipsTabs);
            Controls.Add(btnClose);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmMembership";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memberships";
            Load += frmMembership_Load;
            tcMembershipsTabs.ResumeLayout(false);
            tbMembershipList.ResumeLayout(false);
            tbMembershipList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembershipList).EndInit();
            tbExpireSoon.ResumeLayout(false);
            tbExpireSoon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembershipsExpireSoon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMembershipsTabs;
        private TabPage tbMembershipList;
        private Label lblRecordsCount;
        private Label label1;
        private DataGridView dgvMembershipList;
        private TabPage tbExpireSoon;
        private Button btnClose;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private Label label3;
        private ComboBox cbIsActive;
        private Label lblExpireSoonRecordsCount;
        private Label label4;
        private DataGridView dgvMembershipsExpireSoon;
    }
}