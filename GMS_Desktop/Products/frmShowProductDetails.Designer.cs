namespace GMS_Desktop.Products
{
    partial class frmShowProductDetails
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
            pbProductImage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblProductName = new Label();
            lblCategoryName = new Label();
            lblQuantity = new Label();
            lblOriginalPrice = new Label();
            lblPriceWithProfit = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // pbProductImage
            // 
            pbProductImage.Image = Properties.Resources.cateogry_Default;
            pbProductImage.Location = new Point(518, 105);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(219, 235);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 0;
            pbProductImage.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(725, 44);
            label1.TabIndex = 1;
            label1.Text = "Show Product Details";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 105);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 211);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 263);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 4;
            label4.Text = "Original Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(64, 155);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 5;
            label5.Text = "Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 320);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 6;
            label6.Text = "Price with profit:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(182, 105);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(44, 20);
            lblProductName.TabIndex = 7;
            lblProductName.Text = "[???]";
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(182, 155);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(44, 20);
            lblCategoryName.TabIndex = 8;
            lblCategoryName.Text = "[???]";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(182, 211);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(44, 20);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "[???]";
            // 
            // lblOriginalPrice
            // 
            lblOriginalPrice.AutoSize = true;
            lblOriginalPrice.Location = new Point(182, 263);
            lblOriginalPrice.Name = "lblOriginalPrice";
            lblOriginalPrice.Size = new Size(40, 20);
            lblOriginalPrice.TabIndex = 10;
            lblOriginalPrice.Text = "0.0$";
            // 
            // lblPriceWithProfit
            // 
            lblPriceWithProfit.AutoSize = true;
            lblPriceWithProfit.Location = new Point(182, 320);
            lblPriceWithProfit.Name = "lblPriceWithProfit";
            lblPriceWithProfit.Size = new Size(40, 20);
            lblPriceWithProfit.TabIndex = 11;
            lblPriceWithProfit.Text = "0.0$";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(285, 404);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 41);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowProductDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(749, 457);
            Controls.Add(btnClose);
            Controls.Add(lblPriceWithProfit);
            Controls.Add(lblOriginalPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategoryName);
            Controls.Add(lblProductName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbProductImage);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmShowProductDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Product Details";
            Load += frmShowProductDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProductImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblProductName;
        private Label lblCategoryName;
        private Label lblQuantity;
        private Label lblOriginalPrice;
        private Label lblPriceWithProfit;
        private Button btnClose;
    }
}