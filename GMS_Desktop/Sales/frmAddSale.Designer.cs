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
            tcProducts = new TabControl();
            tpClientOrder = new TabPage();
            comboBox1 = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            numericUpDown2 = new NumericUpDown();
            comboBox2 = new ComboBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            cbProducts = new ComboBox();
            tpCart = new TabPage();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            btnClose = new Button();
            tcProducts.SuspendLayout();
            tpClientOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tpCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tcProducts
            // 
            tcProducts.Controls.Add(tpClientOrder);
            tcProducts.Controls.Add(tpCart);
            tcProducts.Location = new Point(1, 0);
            tcProducts.Name = "tcProducts";
            tcProducts.SelectedIndex = 0;
            tcProducts.Size = new Size(689, 492);
            tcProducts.TabIndex = 1;
            // 
            // tpClientOrder
            // 
            tpClientOrder.Controls.Add(comboBox1);
            tpClientOrder.Controls.Add(label11);
            tpClientOrder.Controls.Add(label10);
            tpClientOrder.Controls.Add(label9);
            tpClientOrder.Controls.Add(button1);
            tpClientOrder.Controls.Add(label8);
            tpClientOrder.Controls.Add(label7);
            tpClientOrder.Controls.Add(numericUpDown2);
            tpClientOrder.Controls.Add(comboBox2);
            tpClientOrder.Controls.Add(label6);
            tpClientOrder.Controls.Add(pictureBox1);
            tpClientOrder.Controls.Add(label5);
            tpClientOrder.Controls.Add(label4);
            tpClientOrder.Controls.Add(label3);
            tpClientOrder.Controls.Add(numericUpDown1);
            tpClientOrder.Controls.Add(label2);
            tpClientOrder.Controls.Add(cbProducts);
            tpClientOrder.Location = new Point(4, 29);
            tpClientOrder.Name = "tpClientOrder";
            tpClientOrder.Padding = new Padding(3);
            tpClientOrder.Size = new Size(681, 459);
            tpClientOrder.TabIndex = 0;
            tpClientOrder.Text = "Client Order";
            tpClientOrder.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(130, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 28);
            comboBox1.TabIndex = 17;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(147, 297);
            label10.Name = "label10";
            label10.Size = new Size(29, 20);
            label10.TabIndex = 15;
            label10.Text = "0$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 297);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 14;
            label9.Text = "Total Amount:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._6126815_200;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(30, 387);
            button1.Name = "button1";
            button1.Size = new Size(75, 59);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 364);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 12;
            label8.Text = "Add To Cart";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 246);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 11;
            label7.Text = "Discount:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(130, 240);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(197, 26);
            numericUpDown2.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(130, 34);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(197, 28);
            comboBox2.TabIndex = 9;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Add_category;
            pictureBox1.Location = new Point(392, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(480, 297);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 6;
            label5.Text = "0$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(417, 297);
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(130, 188);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(197, 26);
            numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 146);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Product:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(130, 138);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(197, 28);
            cbProducts.TabIndex = 1;
            // 
            // tpCart
            // 
            tpCart.Controls.Add(label1);
            tpCart.Controls.Add(dataGridView1);
            tpCart.Location = new Point(4, 29);
            tpCart.Name = "tpCart";
            tpCart.Padding = new Padding(3);
            tpCart.Size = new Size(681, 459);
            tpCart.TabIndex = 1;
            tpCart.Text = "Cart";
            tpCart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 21);
            label1.Name = "label1";
            label1.Size = new Size(180, 33);
            label1.TabIndex = 1;
            label1.Text = "Cart Details";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(667, 292);
            dataGridView1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(546, 506);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 39);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(407, 506);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(133, 39);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(692, 557);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tpCart.ResumeLayout(false);
            tpCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tcProducts;
        private TabPage tpClientOrder;
        private TabPage tpCart;
        private Button btnSave;
        private Button btnClose;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private ComboBox cbProducts;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label7;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox2;
        private Label label6;
        private Label label8;
        private Button button1;
        private Label label10;
        private Label label9;
        private ComboBox comboBox1;
        private Label label11;
        private Label label1;
        private DataGridView dataGridView1;
    }
}