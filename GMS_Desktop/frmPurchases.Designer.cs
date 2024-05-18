namespace GMS_Desktop
{
    partial class frmPurchases
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
            lblPurchases = new Label();
            btnCreateOrder = new Button();
            dtpOrderDate = new DateTimePicker();
            cbSuppliers = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dgvOrderProducts = new DataGridView();
            btnAddProduct = new Button();
            btnDelete = new Button();
            cmsPurchases = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvOrderProducts).BeginInit();
            cmsPurchases.SuspendLayout();
            SuspendLayout();
            // 
            // lblPurchases
            // 
            lblPurchases.AutoSize = true;
            lblPurchases.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            lblPurchases.Location = new Point(155, 9);
            lblPurchases.Name = "lblPurchases";
            lblPurchases.Size = new Size(362, 36);
            lblPurchases.TabIndex = 0;
            lblPurchases.Text = "Create Purchase Invoice";
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.BackColor = Color.Blue;
            btnCreateOrder.FlatStyle = FlatStyle.Popup;
            btnCreateOrder.Location = new Point(40, 412);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(95, 35);
            btnCreateOrder.TabIndex = 8;
            btnCreateOrder.Text = "Purchase";
            btnCreateOrder.UseVisualStyleBackColor = false;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(71, 130);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(200, 20);
            dtpOrderDate.TabIndex = 9;
            // 
            // cbSuppliers
            // 
            cbSuppliers.FormattingEnabled = true;
            cbSuppliers.Location = new Point(376, 129);
            cbSuppliers.Name = "cbSuppliers";
            cbSuppliers.Size = new Size(205, 21);
            cbSuppliers.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 130);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 11;
            label1.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(290, 129);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 12;
            label2.Text = "Supplier:";
            // 
            // dgvOrderProducts
            // 
            dgvOrderProducts.AllowUserToOrderColumns = true;
            dgvOrderProducts.BackgroundColor = Color.White;
            dgvOrderProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderProducts.ContextMenuStrip = cmsPurchases;
            dgvOrderProducts.Location = new Point(112, 234);
            dgvOrderProducts.Name = "dgvOrderProducts";
            dgvOrderProducts.Size = new Size(405, 164);
            dgvOrderProducts.TabIndex = 13;
            dgvOrderProducts.CellClick += dgvOrderProducts_CellClick;
            dgvOrderProducts.CellFormatting += dgvOrderProducts_CellFormatting;
            dgvOrderProducts.RowEnter += dgvOrderProducts_RowEnter;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Green;
            btnAddProduct.FlatStyle = FlatStyle.Popup;
            btnAddProduct.Location = new Point(40, 176);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(95, 35);
            btnAddProduct.TabIndex = 14;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Location = new Point(541, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 35);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmsPurchases
            // 
            cmsPurchases.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            cmsPurchases.Name = "contextMenuStrip1";
            cmsPurchases.Size = new Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // frmPurchases
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 459);
            Controls.Add(btnDelete);
            Controls.Add(btnAddProduct);
            Controls.Add(dgvOrderProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSuppliers);
            Controls.Add(dtpOrderDate);
            Controls.Add(btnCreateOrder);
            Controls.Add(lblPurchases);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmPurchases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchases";
            Load += frmPurchases_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderProducts).EndInit();
            cmsPurchases.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPurchases;
        private Button btnCreateOrder;
        private DateTimePicker dtpOrderDate;
        private ComboBox cbSuppliers;
        private Label label1;
        private Label label2;
        private DataGridView dgvOrderProducts;
        private Button btnAddProduct;
        private Button btnDelete;
        private ContextMenuStrip cmsPurchases;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}