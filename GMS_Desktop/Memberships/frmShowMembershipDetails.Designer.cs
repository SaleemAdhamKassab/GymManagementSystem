namespace GMS_Desktop
{
    partial class frmShowMembershipDetails
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
            dgvShowSubscribstions = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            renewToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            lblRecordsCounts = new Label();
            btnClose = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShowSubscribstions).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvShowSubscribstions
            // 
            dgvShowSubscribstions.AllowUserToAddRows = false;
            dgvShowSubscribstions.AllowUserToDeleteRows = false;
            dgvShowSubscribstions.AllowUserToOrderColumns = true;
            dgvShowSubscribstions.BackgroundColor = Color.White;
            dgvShowSubscribstions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowSubscribstions.ContextMenuStrip = contextMenuStrip1;
            dgvShowSubscribstions.Location = new Point(12, 126);
            dgvShowSubscribstions.Name = "dgvShowSubscribstions";
            dgvShowSubscribstions.ReadOnly = true;
            dgvShowSubscribstions.Size = new Size(1056, 416);
            dgvShowSubscribstions.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { renewToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(129, 28);
            // 
            // renewToolStripMenuItem
            // 
            renewToolStripMenuItem.Name = "renewToolStripMenuItem";
            renewToolStripMenuItem.Size = new Size(128, 24);
            renewToolStripMenuItem.Text = "Renew";
            renewToolStripMenuItem.Click += renewToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 564);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "# Records:";
            // 
            // lblRecordsCounts
            // 
            lblRecordsCounts.AutoSize = true;
            lblRecordsCounts.Location = new Point(148, 564);
            lblRecordsCounts.Name = "lblRecordsCounts";
            lblRecordsCounts.Size = new Size(36, 20);
            lblRecordsCounts.TabIndex = 2;
            lblRecordsCounts.Text = "???";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(908, 551);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(153, 46);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(1056, 47);
            label2.TabIndex = 4;
            label2.Text = "Show Subscriptions Details";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmShowMembershipDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1073, 603);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCounts);
            Controls.Add(label1);
            Controls.Add(dgvShowSubscribstions);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmShowMembershipDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Membership Details";
            Load += frmShowMembershipDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowSubscribstions).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowSubscribstions;
        private Label label1;
        private Label lblRecordsCounts;
        private Button btnClose;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem renewToolStripMenuItem;
    }
}