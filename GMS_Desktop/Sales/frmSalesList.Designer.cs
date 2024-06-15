namespace GMS_Desktop
{
    partial class frmSalesList
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
            label2 = new Label();
            txtSearchValue = new TextBox();
            cbFilterBy = new ComboBox();
            dgvSalesList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            lblRecordsCount = new Label();
            btnClose = new Button();
            btnAddSaleOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSalesList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 24F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(1010, 45);
            label1.TabIndex = 0;
            label1.Text = "Sales List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 139);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Search By:";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(309, 136);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(203, 26);
            txtSearchValue.TabIndex = 2;
            txtSearchValue.Visible = false;
            txtSearchValue.TextChanged += txtSearchValue_TextChanged;
            txtSearchValue.KeyPress += txtSearchValue_KeyPress;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Order ID", "Date", "Client", "User Name" });
            cbFilterBy.Location = new Point(112, 136);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(191, 28);
            cbFilterBy.TabIndex = 3;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // dgvSalesList
            // 
            dgvSalesList.AllowUserToAddRows = false;
            dgvSalesList.AllowUserToDeleteRows = false;
            dgvSalesList.AllowUserToOrderColumns = true;
            dgvSalesList.BackgroundColor = Color.White;
            dgvSalesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesList.ContextMenuStrip = contextMenuStrip1;
            dgvSalesList.Location = new Point(12, 188);
            dgvSalesList.Name = "dgvSalesList";
            dgvSalesList.ReadOnly = true;
            dgvSalesList.Size = new Size(1010, 400);
            dgvSalesList.TabIndex = 4;
            dgvSalesList.DoubleClick += dgvSalesList_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 86);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showDetailsToolStripMenuItem.Image = Properties.Resources._1051649_200;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(185, 38);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(182, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(185, 38);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 612);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 6;
            label3.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Location = new Point(125, 612);
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
            btnClose.Location = new Point(879, 602);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(143, 40);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddSaleOrder
            // 
            btnAddSaleOrder.BackgroundImage = Properties.Resources.Add_category;
            btnAddSaleOrder.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddSaleOrder.FlatStyle = FlatStyle.Popup;
            btnAddSaleOrder.Location = new Point(941, 106);
            btnAddSaleOrder.Name = "btnAddSaleOrder";
            btnAddSaleOrder.Size = new Size(81, 76);
            btnAddSaleOrder.TabIndex = 9;
            btnAddSaleOrder.UseVisualStyleBackColor = true;
            btnAddSaleOrder.Click += btnAddSaleOrder_Click;
            // 
            // frmSalesList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1034, 661);
            Controls.Add(btnAddSaleOrder);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(dgvSalesList);
            Controls.Add(cbFilterBy);
            Controls.Add(txtSearchValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmSalesList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sales List";
            Load += frmSalesList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalesList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchValue;
        private ComboBox cbFilterBy;
        private DataGridView dgvSalesList;
        private Label label3;
        private Label lblRecordsCount;
        private Button btnClose;
        private Button btnAddSaleOrder;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
    }
}