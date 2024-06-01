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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblPurchases = new Label();
            btnCreateOrder = new Button();
            dtpOrderDate = new DateTimePicker();
            cbSuppliers = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dgvOrderProducts = new DataGridView();
            cmsPurchases = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnClose = new Button();
            label3 = new Label();
            nudDiscount = new NumericUpDown();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvOrderProducts).BeginInit();
            cmsPurchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            btnCreateOrder.BackColor = Color.White;
            btnCreateOrder.FlatStyle = FlatStyle.Popup;
            btnCreateOrder.Font = new Font("Microsoft Sans Serif", 12F);
            btnCreateOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateOrder.Location = new Point(518, 407);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(130, 40);
            btnCreateOrder.TabIndex = 5;
            btnCreateOrder.Text = "Purchase";
            btnCreateOrder.UseVisualStyleBackColor = false;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Font = new Font("Microsoft Sans Serif", 12F);
            dtpOrderDate.Location = new Point(71, 82);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(265, 26);
            dtpOrderDate.TabIndex = 1;
            // 
            // cbSuppliers
            // 
            cbSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuppliers.Font = new Font("Microsoft Sans Serif", 12F);
            cbSuppliers.FormattingEnabled = true;
            cbSuppliers.Location = new Point(462, 79);
            cbSuppliers.Name = "cbSuppliers";
            cbSuppliers.Size = new Size(205, 28);
            cbSuppliers.TabIndex = 2;
            cbSuppliers.Validating += cbSuppliers_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 11;
            label1.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(376, 82);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 12;
            label2.Text = "Supplier:";
            // 
            // dgvOrderProducts
            // 
            dgvOrderProducts.AllowUserToOrderColumns = true;
            dgvOrderProducts.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrderProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrderProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderProducts.ContextMenuStrip = cmsPurchases;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvOrderProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvOrderProducts.Location = new Point(86, 176);
            dgvOrderProducts.Name = "dgvOrderProducts";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvOrderProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvOrderProducts.Size = new Size(496, 212);
            dgvOrderProducts.TabIndex = 4;
            dgvOrderProducts.RowValidating += dgvOrderProducts_RowValidating;
            // 
            // cmsPurchases
            // 
            cmsPurchases.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmsPurchases.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            cmsPurchases.Name = "contextMenuStrip1";
            cmsPurchases.Size = new Size(181, 50);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(376, 407);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 40);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(151, 134);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 15;
            label3.Text = "Discount:";
            // 
            // nudDiscount
            // 
            nudDiscount.Font = new Font("Microsoft Sans Serif", 12F);
            errorProvider1.SetIconPadding(nudDiscount, 3);
            nudDiscount.Location = new Point(259, 132);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(172, 26);
            nudDiscount.TabIndex = 16;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPurchases
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(686, 459);
            Controls.Add(nudDiscount);
            Controls.Add(label3);
            Controls.Add(btnClose);
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
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private ContextMenuStrip cmsPurchases;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button btnClose;
        private Label label3;
        private NumericUpDown nudDiscount;
        private ErrorProvider errorProvider1;
    }
}