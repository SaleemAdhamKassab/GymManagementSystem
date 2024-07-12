namespace GMS_Desktop
{
    partial class frmHealthInformation
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
            Label = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHealthIssue = new TextBox();
            txtEmergencyName = new TextBox();
            txtEmargencyPhone = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(585, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add/Update Health Information";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label.Location = new Point(12, 98);
            Label.Name = "Label";
            Label.Size = new Size(116, 20);
            Label.TabIndex = 1;
            Label.Text = "Health Issue:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 241);
            label2.Name = "label2";
            label2.Size = new Size(222, 20);
            label2.TabIndex = 2;
            label2.Text = "Emergency Contact Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 315);
            label3.Name = "label3";
            label3.Size = new Size(227, 20);
            label3.TabIndex = 3;
            label3.Text = "Emergency Contact Phone:";
            // 
            // txtHealthIssue
            // 
            txtHealthIssue.Location = new Point(280, 95);
            txtHealthIssue.Multiline = true;
            txtHealthIssue.Name = "txtHealthIssue";
            txtHealthIssue.Size = new Size(332, 96);
            txtHealthIssue.TabIndex = 4;
            txtHealthIssue.Validating += txtHealthIssue_Validating;
            // 
            // txtEmergencyName
            // 
            txtEmergencyName.Location = new Point(283, 238);
            txtEmergencyName.Name = "txtEmergencyName";
            txtEmergencyName.Size = new Size(332, 26);
            txtEmergencyName.TabIndex = 5;
            // 
            // txtEmargencyPhone
            // 
            txtEmargencyPhone.Location = new Point(284, 312);
            txtEmargencyPhone.Name = "txtEmargencyPhone";
            txtEmargencyPhone.Size = new Size(331, 26);
            txtEmargencyPhone.TabIndex = 6;
            txtEmargencyPhone.Validating += txtEmargencyPhone_Validating;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(146, 415);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 38);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(308, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 38);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmHealthInformation
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(634, 485);
            Controls.Add(txtHealthIssue);
            Controls.Add(Label);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(txtEmargencyPhone);
            Controls.Add(lblTitle);
            Controls.Add(txtEmergencyName);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmHealthInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Update Health Information";
            Load += frmHealthInformation_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label Label;
        private Label label2;
        private Label label3;
        private TextBox txtHealthIssue;
        private TextBox txtEmergencyName;
        private TextBox txtEmargencyPhone;
        private Button btnClose;
        private Button btnSave;
        private ErrorProvider errorProvider1;
    }
}