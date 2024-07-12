namespace GMS_Desktop
{
    partial class frmShowDetails
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
            label1 = new Label();
            dgvCartDetails = new DataGridView();
            btnClose = new Button();
            lblItemsCount = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCartDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 21);
            label1.Name = "label1";
            label1.Size = new Size(755, 33);
            label1.TabIndex = 3;
            label1.Text = "Order Details";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCartDetails
            // 
            dgvCartDetails.AllowUserToAddRows = false;
            dgvCartDetails.AllowUserToDeleteRows = false;
            dgvCartDetails.AllowUserToOrderColumns = true;
            dgvCartDetails.BackgroundColor = Color.White;
            dgvCartDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCartDetails.Location = new Point(7, 73);
            dgvCartDetails.Name = "dgvCartDetails";
            dgvCartDetails.ReadOnly = true;
            dgvCartDetails.Size = new Size(761, 292);
            dgvCartDetails.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(635, 378);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(133, 39);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblItemsCount
            // 
            lblItemsCount.AutoSize = true;
            lblItemsCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemsCount.Location = new Point(102, 387);
            lblItemsCount.Name = "lblItemsCount";
            lblItemsCount.Size = new Size(36, 20);
            lblItemsCount.TabIndex = 12;
            lblItemsCount.Text = "???";
            lblItemsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 387);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 11;
            label5.Text = "# Items:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmShowDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(774, 429);
            Controls.Add(lblItemsCount);
            Controls.Add(label5);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(dgvCartDetails);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmShowDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Show Order Details";
            Load += frmShowDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCartDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCartDetails;
        private Button btnClose;
        private Label lblItemsCount;
        private Label label5;
    }
}