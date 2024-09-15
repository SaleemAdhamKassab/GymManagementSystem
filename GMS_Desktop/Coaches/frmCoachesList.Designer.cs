namespace GMS_Desktop.Coaches
{
    partial class frmCoachesList
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
            dgvCoachesList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            label2 = new Label();
            txtSearchValue = new TextBox();
            cbSearchBy = new ComboBox();
            btnAddNewCoach = new Button();
            label3 = new Label();
            lblRecordsCount = new Label();
            btnClose = new Button();
            cbIsActive = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCoachesList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(1129, 39);
            label1.TabIndex = 0;
            label1.Text = "Coaches List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCoachesList
            // 
            dgvCoachesList.AllowUserToAddRows = false;
            dgvCoachesList.AllowUserToDeleteRows = false;
            dgvCoachesList.AllowUserToOrderColumns = true;
            dgvCoachesList.BackgroundColor = Color.White;
            dgvCoachesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoachesList.ContextMenuStrip = contextMenuStrip1;
            dgvCoachesList.Location = new Point(12, 180);
            dgvCoachesList.Name = "dgvCoachesList";
            dgvCoachesList.ReadOnly = true;
            dgvCoachesList.Size = new Size(1122, 411);
            dgvCoachesList.TabIndex = 1;
            dgvCoachesList.DoubleClick += dgvCoachesList_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, editToolStripMenuItem, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(172, 64);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(171, 24);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(168, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(171, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(168, 6);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(24, 125);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Search By:";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(392, 122);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(238, 26);
            txtSearchValue.TabIndex = 3;
            txtSearchValue.Visible = false;
            txtSearchValue.TextChanged += txtSearchValue_TextChanged;
            txtSearchValue.KeyPress += txtSearchValue_KeyPress;
            // 
            // cbSearchBy
            // 
            cbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchBy.FormattingEnabled = true;
            cbSearchBy.Items.AddRange(new object[] { "None", "Id", "Coach Name", "Class Name", "Is Active" });
            cbSearchBy.Location = new Point(126, 122);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Size = new Size(250, 28);
            cbSearchBy.TabIndex = 4;
            cbSearchBy.SelectedIndexChanged += cbSearchBy_SelectedIndexChanged;
            // 
            // btnAddNewCoach
            // 
            btnAddNewCoach.BackgroundImage = Properties.Resources.add_new_coach;
            btnAddNewCoach.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewCoach.FlatStyle = FlatStyle.Popup;
            btnAddNewCoach.Location = new Point(1053, 94);
            btnAddNewCoach.Name = "btnAddNewCoach";
            btnAddNewCoach.Size = new Size(81, 82);
            btnAddNewCoach.TabIndex = 5;
            btnAddNewCoach.UseVisualStyleBackColor = true;
            btnAddNewCoach.Click += btnAddNewCoach_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(24, 614);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 6;
            label3.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.Blue;
            lblRecordsCount.Location = new Point(126, 614);
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
            btnClose.Location = new Point(981, 606);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(153, 37);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbIsActive
            // 
            cbIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new Point(392, 122);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(121, 28);
            cbIsActive.TabIndex = 9;
            cbIsActive.Visible = false;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // frmCoachesList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1146, 655);
            Controls.Add(cbIsActive);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(btnAddNewCoach);
            Controls.Add(cbSearchBy);
            Controls.Add(txtSearchValue);
            Controls.Add(label2);
            Controls.Add(dgvCoachesList);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmCoachesList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coaches List";
            Load += frmCoachesList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCoachesList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCoachesList;
        private Label label2;
        private TextBox txtSearchValue;
        private ComboBox cbSearchBy;
        private Button btnAddNewCoach;
        private Label label3;
        private Label lblRecordsCount;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ComboBox cbIsActive;
    }
}