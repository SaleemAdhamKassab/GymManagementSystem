namespace GMS_Desktop.Users
{
    partial class frmUsersList
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
            dgvUsersList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showUserDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            cbSeachBy = new ComboBox();
            txtSearchValue = new TextBox();
            cbIsActive = new ComboBox();
            label3 = new Label();
            lblRecordsCount = new Label();
            btnClose = new Button();
            btnAddNewUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1317, 40);
            label1.TabIndex = 0;
            label1.Text = "Users List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvUsersList
            // 
            dgvUsersList.AllowUserToAddRows = false;
            dgvUsersList.AllowUserToDeleteRows = false;
            dgvUsersList.AllowUserToOrderColumns = true;
            dgvUsersList.BackgroundColor = Color.White;
            dgvUsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsersList.ContextMenuStrip = contextMenuStrip1;
            dgvUsersList.Location = new Point(12, 169);
            dgvUsersList.Name = "dgvUsersList";
            dgvUsersList.ReadOnly = true;
            dgvUsersList.Size = new Size(1317, 444);
            dgvUsersList.TabIndex = 1;
            dgvUsersList.DoubleClick += dgvUsersList_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showUserDetailsToolStripMenuItem, toolStripMenuItem1, editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(210, 58);
            // 
            // showUserDetailsToolStripMenuItem
            // 
            showUserDetailsToolStripMenuItem.Name = "showUserDetailsToolStripMenuItem";
            showUserDetailsToolStripMenuItem.Size = new Size(209, 24);
            showUserDetailsToolStripMenuItem.Text = "Show User Details";
            showUserDetailsToolStripMenuItem.Click += showUserDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(206, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(209, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 122);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Search By:";
            // 
            // cbSeachBy
            // 
            cbSeachBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSeachBy.FormattingEnabled = true;
            cbSeachBy.Items.AddRange(new object[] { "None", "Id", "Name", "User Name", "Role", "Is Active" });
            cbSeachBy.Location = new Point(132, 119);
            cbSeachBy.Name = "cbSeachBy";
            cbSeachBy.Size = new Size(229, 28);
            cbSeachBy.TabIndex = 3;
            cbSeachBy.SelectedIndexChanged += cbSeachBy_SelectedIndexChanged;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(367, 119);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(209, 26);
            txtSearchValue.TabIndex = 4;
            txtSearchValue.TextChanged += txtSearchValue_TextChanged;
            txtSearchValue.KeyPress += txtSearchValue_KeyPress;
            // 
            // cbIsActive
            // 
            cbIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new Point(367, 119);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(104, 28);
            cbIsActive.TabIndex = 5;
            cbIsActive.Visible = false;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 635);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 6;
            label3.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Location = new Point(124, 635);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(36, 20);
            lblRecordsCount.TabIndex = 7;
            lblRecordsCount.Text = "???";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1183, 626);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 39);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.FlatStyle = FlatStyle.Popup;
            btnAddNewUser.Image = Properties.Resources.Add_New_User_32;
            btnAddNewUser.Location = new Point(1255, 98);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(74, 68);
            btnAddNewUser.TabIndex = 9;
            btnAddNewUser.UseVisualStyleBackColor = true;
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // frmUsersList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1341, 674);
            Controls.Add(btnAddNewUser);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(cbIsActive);
            Controls.Add(txtSearchValue);
            Controls.Add(cbSeachBy);
            Controls.Add(label2);
            Controls.Add(dgvUsersList);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmUsersList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users List";
            Load += frmUsersList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvUsersList;
        private Label label2;
        private ComboBox cbSeachBy;
        private TextBox txtSearchValue;
        private ComboBox cbIsActive;
        private Label label3;
        private Label lblRecordsCount;
        private Button btnClose;
        private Button btnAddNewUser;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showUserDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}