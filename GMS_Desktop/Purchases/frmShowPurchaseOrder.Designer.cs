namespace GMS_Desktop
{
    partial class frmShowPurchaseOrder
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
            btnClose = new Button();
            dgvOrderInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrderInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(786, 51);
            label1.TabIndex = 0;
            label1.Text = "Order Details";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(650, 310);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 38);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvOrderInfo
            // 
            dgvOrderInfo.AllowUserToAddRows = false;
            dgvOrderInfo.AllowUserToDeleteRows = false;
            dgvOrderInfo.AllowUserToOrderColumns = true;
            dgvOrderInfo.BackgroundColor = Color.White;
            dgvOrderInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderInfo.Location = new Point(12, 97);
            dgvOrderInfo.Name = "dgvOrderInfo";
            dgvOrderInfo.ReadOnly = true;
            dgvOrderInfo.Size = new Size(786, 192);
            dgvOrderInfo.TabIndex = 20;
            // 
            // frmShowPurchaseOrder
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(806, 369);
            Controls.Add(dgvOrderInfo);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmShowPurchaseOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Purchase Order";
            Load += frmShowPurchaseOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private DataGridView dgvOrderInfo;
    }
}