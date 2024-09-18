namespace GMS_Desktop
{
    partial class frmSales
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
            tcProducts = new TabControl();
            tpClientOrder = new TabPage();
            pnlProductPriceInfo = new Panel();
            lblTotalPrice = new Label();
            lblTotalPriceAfterDiscountVal = new Label();
            lblTotalPriceVal = new Label();
            lblTotalPriceAfterDiscount = new Label();
            label9 = new Label();
            lblTotalAmount = new Label();
            lblAfterDiscount = new Label();
            label10 = new Label();
            lblTotalAmountAfterDiscount = new Label();
            lblPriceAterDiscountVal = new Label();
            lblPriceAfterDiscountTxt = new Label();
            cbCategories = new ComboBox();
            label11 = new Label();
            btnAddToCart = new Button();
            label8 = new Label();
            label7 = new Label();
            nudDiscount = new NumericUpDown();
            cbClients = new ComboBox();
            label6 = new Label();
            pbProductImage = new PictureBox();
            lblOriginalPrice = new Label();
            label4 = new Label();
            label3 = new Label();
            nudQuantity = new NumericUpDown();
            label2 = new Label();
            cbProducts = new ComboBox();
            tpCart = new TabPage();
            label12 = new Label();
            lblTotalAmountCart = new Label();
            label14 = new Label();
            lblAfterDiscountCart = new Label();
            lblRecordsCount = new Label();
            label5 = new Label();
            label1 = new Label();
            dgvCartDetails = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            tcProducts.SuspendLayout();
            tpClientOrder.SuspendLayout();
            pnlProductPriceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            tpCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCartDetails).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tcProducts
            // 
            tcProducts.Controls.Add(tpClientOrder);
            tcProducts.Controls.Add(tpCart);
            tcProducts.Location = new Point(1, 0);
            tcProducts.Name = "tcProducts";
            tcProducts.SelectedIndex = 0;
            tcProducts.Size = new Size(747, 527);
            tcProducts.TabIndex = 7;
            // 
            // tpClientOrder
            // 
            tpClientOrder.Controls.Add(pnlProductPriceInfo);
            tpClientOrder.Controls.Add(label9);
            tpClientOrder.Controls.Add(lblTotalAmount);
            tpClientOrder.Controls.Add(lblAfterDiscount);
            tpClientOrder.Controls.Add(label10);
            tpClientOrder.Controls.Add(lblTotalAmountAfterDiscount);
            tpClientOrder.Controls.Add(lblPriceAterDiscountVal);
            tpClientOrder.Controls.Add(lblPriceAfterDiscountTxt);
            tpClientOrder.Controls.Add(cbCategories);
            tpClientOrder.Controls.Add(label11);
            tpClientOrder.Controls.Add(btnAddToCart);
            tpClientOrder.Controls.Add(label8);
            tpClientOrder.Controls.Add(label7);
            tpClientOrder.Controls.Add(nudDiscount);
            tpClientOrder.Controls.Add(cbClients);
            tpClientOrder.Controls.Add(label6);
            tpClientOrder.Controls.Add(pbProductImage);
            tpClientOrder.Controls.Add(lblOriginalPrice);
            tpClientOrder.Controls.Add(label4);
            tpClientOrder.Controls.Add(label3);
            tpClientOrder.Controls.Add(nudQuantity);
            tpClientOrder.Controls.Add(label2);
            tpClientOrder.Controls.Add(cbProducts);
            tpClientOrder.Location = new Point(4, 29);
            tpClientOrder.Name = "tpClientOrder";
            tpClientOrder.Padding = new Padding(3);
            tpClientOrder.Size = new Size(739, 494);
            tpClientOrder.TabIndex = 0;
            tpClientOrder.Text = "Client Order";
            tpClientOrder.UseVisualStyleBackColor = true;
            // 
            // pnlProductPriceInfo
            // 
            pnlProductPriceInfo.Controls.Add(lblTotalPrice);
            pnlProductPriceInfo.Controls.Add(lblTotalPriceAfterDiscountVal);
            pnlProductPriceInfo.Controls.Add(lblTotalPriceVal);
            pnlProductPriceInfo.Controls.Add(lblTotalPriceAfterDiscount);
            pnlProductPriceInfo.Location = new Point(479, 366);
            pnlProductPriceInfo.Name = "pnlProductPriceInfo";
            pnlProductPriceInfo.Size = new Size(216, 84);
            pnlProductPriceInfo.TabIndex = 29;
            pnlProductPriceInfo.Visible = false;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(14, 15);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(99, 20);
            lblTotalPrice.TabIndex = 25;
            lblTotalPrice.Text = "Total Price:";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPriceAfterDiscountVal
            // 
            lblTotalPriceAfterDiscountVal.AutoSize = true;
            lblTotalPriceAfterDiscountVal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPriceAfterDiscountVal.Location = new Point(144, 50);
            lblTotalPriceAfterDiscountVal.Name = "lblTotalPriceAfterDiscountVal";
            lblTotalPriceAfterDiscountVal.Size = new Size(19, 20);
            lblTotalPriceAfterDiscountVal.TabIndex = 28;
            lblTotalPriceAfterDiscountVal.Text = "0";
            // 
            // lblTotalPriceVal
            // 
            lblTotalPriceVal.AutoSize = true;
            lblTotalPriceVal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPriceVal.Location = new Point(119, 15);
            lblTotalPriceVal.Name = "lblTotalPriceVal";
            lblTotalPriceVal.Size = new Size(19, 20);
            lblTotalPriceVal.TabIndex = 26;
            lblTotalPriceVal.Text = "0";
            // 
            // lblTotalPriceAfterDiscount
            // 
            lblTotalPriceAfterDiscount.AutoSize = true;
            lblTotalPriceAfterDiscount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPriceAfterDiscount.Location = new Point(14, 50);
            lblTotalPriceAfterDiscount.Name = "lblTotalPriceAfterDiscount";
            lblTotalPriceAfterDiscount.Size = new Size(130, 20);
            lblTotalPriceAfterDiscount.TabIndex = 27;
            lblTotalPriceAfterDiscount.Text = "After Discount:";
            lblTotalPriceAfterDiscount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 297);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 14;
            label9.Text = "Total Amount:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(167, 297);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(19, 20);
            lblTotalAmount.TabIndex = 15;
            lblTotalAmount.Text = "0";
            // 
            // lblAfterDiscount
            // 
            lblAfterDiscount.AutoSize = true;
            lblAfterDiscount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAfterDiscount.Location = new Point(40, 331);
            lblAfterDiscount.Name = "lblAfterDiscount";
            lblAfterDiscount.Size = new Size(130, 20);
            lblAfterDiscount.TabIndex = 20;
            lblAfterDiscount.Text = "After Discount:";
            lblAfterDiscount.TextAlign = ContentAlignment.MiddleCenter;
            lblAfterDiscount.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(111, 245);
            label10.Name = "label10";
            label10.Size = new Size(19, 15);
            label10.TabIndex = 24;
            label10.Text = "%";
            // 
            // lblTotalAmountAfterDiscount
            // 
            lblTotalAmountAfterDiscount.AutoSize = true;
            lblTotalAmountAfterDiscount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmountAfterDiscount.Location = new Point(170, 331);
            lblTotalAmountAfterDiscount.Name = "lblTotalAmountAfterDiscount";
            lblTotalAmountAfterDiscount.Size = new Size(19, 20);
            lblTotalAmountAfterDiscount.TabIndex = 21;
            lblTotalAmountAfterDiscount.Text = "0";
            lblTotalAmountAfterDiscount.Visible = false;
            // 
            // lblPriceAterDiscountVal
            // 
            lblPriceAterDiscountVal.AutoSize = true;
            lblPriceAterDiscountVal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceAterDiscountVal.Location = new Point(623, 334);
            lblPriceAterDiscountVal.Name = "lblPriceAterDiscountVal";
            lblPriceAterDiscountVal.Size = new Size(19, 20);
            lblPriceAterDiscountVal.TabIndex = 23;
            lblPriceAterDiscountVal.Text = "0";
            lblPriceAterDiscountVal.Visible = false;
            // 
            // lblPriceAfterDiscountTxt
            // 
            lblPriceAfterDiscountTxt.AutoSize = true;
            lblPriceAfterDiscountTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceAfterDiscountTxt.Location = new Point(493, 334);
            lblPriceAfterDiscountTxt.Name = "lblPriceAfterDiscountTxt";
            lblPriceAfterDiscountTxt.Size = new Size(130, 20);
            lblPriceAfterDiscountTxt.TabIndex = 22;
            lblPriceAfterDiscountTxt.Text = "After Discount:";
            lblPriceAfterDiscountTxt.TextAlign = ContentAlignment.MiddleCenter;
            lblPriceAfterDiscountTxt.Visible = false;
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(130, 88);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(292, 28);
            cbCategories.TabIndex = 1;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            cbCategories.Validating += cbCategories_Validating;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(20, 91);
            label11.Name = "label11";
            label11.Size = new Size(101, 20);
            label11.TabIndex = 16;
            label11.Text = "Categories:";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackgroundImage = Properties.Resources._6126815_200;
            btnAddToCart.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddToCart.Enabled = false;
            btnAddToCart.FlatStyle = FlatStyle.Popup;
            btnAddToCart.Location = new Point(30, 417);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(75, 59);
            btnAddToCart.TabIndex = 6;
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 394);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 12;
            label8.Text = "Add To Cart";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 242);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 11;
            label7.Text = "Discount:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudDiscount
            // 
            nudDiscount.Location = new Point(130, 240);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(292, 26);
            nudDiscount.TabIndex = 4;
            nudDiscount.ValueChanged += nudDiscount_ValueChanged;
            // 
            // cbClients
            // 
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(130, 34);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(292, 28);
            cbClients.TabIndex = 0;
            cbClients.SelectedIndexChanged += cbClients_SelectedIndexChanged;
            cbClients.Validating += cbClients_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 37);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 8;
            label6.Text = "Client:";
            // 
            // pbProductImage
            // 
            pbProductImage.Image = Properties.Resources.images;
            pbProductImage.Location = new Point(468, 37);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(250, 232);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 7;
            pbProductImage.TabStop = false;
            // 
            // lblOriginalPrice
            // 
            lblOriginalPrice.AutoSize = true;
            lblOriginalPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOriginalPrice.Location = new Point(556, 300);
            lblOriginalPrice.Name = "lblOriginalPrice";
            lblOriginalPrice.Size = new Size(19, 20);
            lblOriginalPrice.TabIndex = 6;
            lblOriginalPrice.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(493, 300);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 5;
            label4.Text = "Price:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 190);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 4;
            label3.Text = "Quantity:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(130, 188);
            nudQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(292, 26);
            nudQuantity.TabIndex = 3;
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            nudQuantity.Validating += nudQuantity_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 141);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Product:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbProducts
            // 
            cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(130, 138);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(292, 28);
            cbProducts.TabIndex = 2;
            cbProducts.SelectedIndexChanged += cbProducts_SelectedIndexChanged;
            cbProducts.Validating += cbProducts_Validating;
            // 
            // tpCart
            // 
            tpCart.Controls.Add(label12);
            tpCart.Controls.Add(lblTotalAmountCart);
            tpCart.Controls.Add(label14);
            tpCart.Controls.Add(lblAfterDiscountCart);
            tpCart.Controls.Add(lblRecordsCount);
            tpCart.Controls.Add(label5);
            tpCart.Controls.Add(label1);
            tpCart.Controls.Add(dgvCartDetails);
            tpCart.Location = new Point(4, 29);
            tpCart.Name = "tpCart";
            tpCart.Padding = new Padding(3);
            tpCart.Size = new Size(739, 494);
            tpCart.TabIndex = 1;
            tpCart.Text = "Cart";
            tpCart.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(257, 418);
            label12.Name = "label12";
            label12.Size = new Size(121, 20);
            label12.TabIndex = 22;
            label12.Text = "Total Amount:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalAmountCart
            // 
            lblTotalAmountCart.AutoSize = true;
            lblTotalAmountCart.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmountCart.Location = new Point(384, 418);
            lblTotalAmountCart.Name = "lblTotalAmountCart";
            lblTotalAmountCart.Size = new Size(29, 20);
            lblTotalAmountCart.TabIndex = 23;
            lblTotalAmountCart.Text = "0$";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(471, 418);
            label14.Name = "label14";
            label14.Size = new Size(130, 20);
            label14.TabIndex = 24;
            label14.Text = "After Discount:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAfterDiscountCart
            // 
            lblAfterDiscountCart.AutoSize = true;
            lblAfterDiscountCart.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAfterDiscountCart.Location = new Point(601, 418);
            lblAfterDiscountCart.Name = "lblAfterDiscountCart";
            lblAfterDiscountCart.Size = new Size(29, 20);
            lblAfterDiscountCart.TabIndex = 25;
            lblAfterDiscountCart.Text = "0$";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(131, 418);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(36, 20);
            lblRecordsCount.TabIndex = 4;
            lblRecordsCount.Text = "???";
            lblRecordsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(51, 418);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 3;
            label5.Text = "# Items:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(726, 33);
            label1.TabIndex = 1;
            label1.Text = "Cart Details";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCartDetails
            // 
            dgvCartDetails.AllowUserToAddRows = false;
            dgvCartDetails.AllowUserToDeleteRows = false;
            dgvCartDetails.AllowUserToOrderColumns = true;
            dgvCartDetails.BackgroundColor = Color.White;
            dgvCartDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCartDetails.ContextMenuStrip = contextMenuStrip1;
            dgvCartDetails.Location = new Point(37, 108);
            dgvCartDetails.Name = "dgvCartDetails";
            dgvCartDetails.ReadOnly = true;
            dgvCartDetails.Size = new Size(667, 292);
            dgvCartDetails.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 50);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(611, 533);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 39);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(472, 533);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(133, 39);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(760, 584);
            Controls.Add(btnClose);
            Controls.Add(tcProducts);
            Controls.Add(btnSave);
            Font = new Font("Microsoft Sans Serif", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales";
            Load += frmSales_Load;
            tcProducts.ResumeLayout(false);
            tpClientOrder.ResumeLayout(false);
            tpClientOrder.PerformLayout();
            pnlProductPriceInfo.ResumeLayout(false);
            pnlProductPriceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            tpCart.ResumeLayout(false);
            tpCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCartDetails).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tcProducts;
        private TabPage tpClientOrder;
        private TabPage tpCart;
        private Button btnSave;
        private Button btnClose;
        private Label label3;
        private NumericUpDown nudQuantity;
        private Label label2;
        private ComboBox cbProducts;
        private Label lblOriginalPrice;
        private Label label4;
        private PictureBox pbProductImage;
        private Label label7;
        private NumericUpDown nudDiscount;
        private ComboBox cbClients;
        private Label label6;
        private Label label8;
        private Button btnAddToCart;
        private Label lblTotalAmount;
        private Label label9;
        private ComboBox cbCategories;
        private Label label11;
        private Label label1;
        private DataGridView dgvCartDetails;
        private Label lblRecordsCount;
        private Label label5;
        private Label lblTotalAmountAfterDiscount;
        private Label lblAfterDiscount;
        private Label lblPriceAterDiscountVal;
        private Label lblPriceAfterDiscountTxt;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ErrorProvider errorProvider1;
        private Label label10;
        private Label label12;
        private Label lblTotalAmountCart;
        private Label label14;
        private Label lblAfterDiscountCart;
        private Panel pnlProductPriceInfo;
        private Label lblTotalPrice;
        private Label lblTotalPriceAfterDiscountVal;
        private Label lblTotalPriceVal;
        private Label lblTotalPriceAfterDiscount;
    }
}