namespace GMS_Desktop
{
    partial class frmClientsList
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
            dgvClientsList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            assignMembershipToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            label3 = new Label();
            lblRecords = new Label();
            btnClose = new Button();
            btnAddNewClient = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientsList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1244, 47);
            label1.TabIndex = 0;
            label1.Text = "Clients List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvClientsList
            // 
            dgvClientsList.AllowUserToAddRows = false;
            dgvClientsList.AllowUserToDeleteRows = false;
            dgvClientsList.AllowUserToOrderColumns = true;
            dgvClientsList.BackgroundColor = Color.White;
            dgvClientsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientsList.ContextMenuStrip = contextMenuStrip1;
            dgvClientsList.Location = new Point(12, 194);
            dgvClientsList.Name = "dgvClientsList";
            dgvClientsList.ReadOnly = true;
            dgvClientsList.Size = new Size(1244, 417);
            dgvClientsList.TabIndex = 1;
            dgvClientsList.DoubleClick += dgvClientsList_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { assignMembershipToolStripMenuItem, editToolStripMenuItem, toolStripMenuItem1, deleteToolStripMenuItem, toolStripMenuItem2, showDetailsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(216, 112);
            // 
            // assignMembershipToolStripMenuItem
            // 
            assignMembershipToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignMembershipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            assignMembershipToolStripMenuItem.Name = "assignMembershipToolStripMenuItem";
            assignMembershipToolStripMenuItem.Size = new Size(215, 24);
            assignMembershipToolStripMenuItem.Text = "Assign Membership";
            assignMembershipToolStripMenuItem.Click += assignMembershipToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(215, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(212, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(215, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(212, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(215, 24);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 142);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Filter By:";
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(327, 139);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(207, 26);
            txtFilterValue.TabIndex = 3;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Client ID", "Full Name", "Phone", "Email" });
            cbFilterBy.Location = new Point(128, 139);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(193, 28);
            cbFilterBy.TabIndex = 4;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 628);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 5;
            label3.Text = "#Records:";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Location = new Point(137, 628);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(36, 20);
            lblRecords.TabIndex = 6;
            lblRecords.Text = "???";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1119, 619);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 38);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddNewClient
            // 
            btnAddNewClient.BackgroundImage = Properties.Resources.tranee;
            btnAddNewClient.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddNewClient.FlatStyle = FlatStyle.Popup;
            btnAddNewClient.Location = new Point(1181, 117);
            btnAddNewClient.Name = "btnAddNewClient";
            btnAddNewClient.Size = new Size(75, 71);
            btnAddNewClient.TabIndex = 8;
            btnAddNewClient.UseVisualStyleBackColor = true;
            btnAddNewClient.Click += btnAddNewClient_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(1181, 95);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 9;
            label4.Text = "Add Client";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmClientsList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1268, 667);
            Controls.Add(label4);
            Controls.Add(btnAddNewClient);
            Controls.Add(btnClose);
            Controls.Add(lblRecords);
            Controls.Add(label3);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label2);
            Controls.Add(dgvClientsList);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmClientsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clients List";
            Load += frmClientsList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientsList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvClientsList;
        private Label label2;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private Label label3;
        private Label lblRecords;
        private Button btnClose;
        private Button btnAddNewClient;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem assignMembershipToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
    }
}