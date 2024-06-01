namespace GMS_Desktop
{
    partial class frmPurchaseOrders
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
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            dgvPurchaseOrdersList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            addNewPurchaseToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            lblPurchaseOrdersCount = new Label();
            btnClose = new Button();
            btnAddPurchase = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOrdersList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 22F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(973, 45);
            label1.TabIndex = 0;
            label1.Text = "Purchase Orders";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 101);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Order ID", "User Name", "Supplier" });
            cbFilterBy.Location = new Point(110, 98);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(178, 28);
            cbFilterBy.TabIndex = 2;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(294, 98);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(217, 26);
            txtFilterValue.TabIndex = 3;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // dgvPurchaseOrdersList
            // 
            dgvPurchaseOrdersList.AllowUserToAddRows = false;
            dgvPurchaseOrdersList.AllowUserToDeleteRows = false;
            dgvPurchaseOrdersList.AllowUserToOrderColumns = true;
            dgvPurchaseOrdersList.BackgroundColor = Color.White;
            dgvPurchaseOrdersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseOrdersList.ContextMenuStrip = contextMenuStrip1;
            dgvPurchaseOrdersList.Location = new Point(13, 158);
            dgvPurchaseOrdersList.Name = "dgvPurchaseOrdersList";
            dgvPurchaseOrdersList.ReadOnly = true;
            dgvPurchaseOrdersList.Size = new Size(973, 322);
            dgvPurchaseOrdersList.TabIndex = 4;
            dgvPurchaseOrdersList.DoubleClick += dgvPurchaseOrdersList_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, addNewPurchaseToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(214, 76);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(213, 24);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // addNewPurchaseToolStripMenuItem
            // 
            addNewPurchaseToolStripMenuItem.Name = "addNewPurchaseToolStripMenuItem";
            addNewPurchaseToolStripMenuItem.Size = new Size(213, 24);
            addNewPurchaseToolStripMenuItem.Text = "Add New Purchase";
            addNewPurchaseToolStripMenuItem.Click += addNewPurchaseToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(213, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 493);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 5;
            label3.Text = "# Records:";
            // 
            // lblPurchaseOrdersCount
            // 
            lblPurchaseOrdersCount.AutoSize = true;
            lblPurchaseOrdersCount.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPurchaseOrdersCount.Location = new Point(126, 496);
            lblPurchaseOrdersCount.Name = "lblPurchaseOrdersCount";
            lblPurchaseOrdersCount.Size = new Size(28, 16);
            lblPurchaseOrdersCount.TabIndex = 6;
            lblPurchaseOrdersCount.Text = "???";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(848, 486);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 34);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddPurchase
            // 
            btnAddPurchase.BackgroundImage = Properties.Resources._6764352_200;
            btnAddPurchase.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddPurchase.FlatStyle = FlatStyle.Popup;
            btnAddPurchase.Location = new Point(910, 80);
            btnAddPurchase.Name = "btnAddPurchase";
            btnAddPurchase.Size = new Size(75, 63);
            btnAddPurchase.TabIndex = 8;
            btnAddPurchase.UseVisualStyleBackColor = true;
            btnAddPurchase.Click += btnAddPurchase_Click;
            // 
            // frmPurchaseOrders
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(998, 532);
            Controls.Add(btnAddPurchase);
            Controls.Add(btnClose);
            Controls.Add(lblPurchaseOrdersCount);
            Controls.Add(label3);
            Controls.Add(dgvPurchaseOrdersList);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmPurchaseOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase Orders";
            Load += frmPurchaseOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOrdersList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private DataGridView dgvPurchaseOrdersList;
        private Label label3;
        private Label lblPurchaseOrdersCount;
        private Button btnClose;
        private Button btnAddPurchase;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewPurchaseToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}