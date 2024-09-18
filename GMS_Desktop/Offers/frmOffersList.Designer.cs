namespace GMS_Desktop.Offers
{
    partial class frmOffersList
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
            lblTitle = new Label();
            dgvOffersList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editOfferToolStripMenuItem = new ToolStripMenuItem();
            showOfferSubscripersToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            label2 = new Label();
            lblRecordsCount = new Label();
            btnClose = new Button();
            btnAddOffer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOffersList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1315, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Offers List";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvOffersList
            // 
            dgvOffersList.AllowUserToAddRows = false;
            dgvOffersList.AllowUserToDeleteRows = false;
            dgvOffersList.AllowUserToOrderColumns = true;
            dgvOffersList.BackgroundColor = Color.White;
            dgvOffersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOffersList.ContextMenuStrip = contextMenuStrip1;
            dgvOffersList.Location = new Point(12, 159);
            dgvOffersList.Name = "dgvOffersList";
            dgvOffersList.ReadOnly = true;
            dgvOffersList.Size = new Size(1315, 390);
            dgvOffersList.TabIndex = 1;
            dgvOffersList.CellDoubleClick += dgvOffersList_CellDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showOfferSubscripersToolStripMenuItem, editOfferToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(247, 52);
            // 
            // editOfferToolStripMenuItem
            // 
            editOfferToolStripMenuItem.Name = "editOfferToolStripMenuItem";
            editOfferToolStripMenuItem.Size = new Size(246, 24);
            editOfferToolStripMenuItem.Text = "Edit Offer";
            editOfferToolStripMenuItem.Click += editOfferToolStripMenuItem_Click;
            // 
            // showOfferSubscripersToolStripMenuItem
            // 
            showOfferSubscripersToolStripMenuItem.Name = "showOfferSubscripersToolStripMenuItem";
            showOfferSubscripersToolStripMenuItem.Size = new Size(246, 24);
            showOfferSubscripersToolStripMenuItem.Text = "Show Offer Subscripers";
            showOfferSubscripersToolStripMenuItem.Click += showOfferSubscripersToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 124);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Filter By:";
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(346, 121);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(231, 26);
            txtFilterValue.TabIndex = 3;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Id", "Offer Name", "Class Name" });
            cbFilterBy.Location = new Point(107, 121);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(233, 28);
            cbFilterBy.TabIndex = 4;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 565);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 5;
            label2.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(123, 565);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(27, 20);
            lblRecordsCount.TabIndex = 6;
            lblRecordsCount.Text = "??";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1164, 556);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(163, 39);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddOffer
            // 
            btnAddOffer.BackgroundImage = Properties.Resources.offer1;
            btnAddOffer.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddOffer.FlatStyle = FlatStyle.Popup;
            btnAddOffer.Location = new Point(1258, 83);
            btnAddOffer.Name = "btnAddOffer";
            btnAddOffer.Size = new Size(69, 64);
            btnAddOffer.TabIndex = 8;
            btnAddOffer.UseVisualStyleBackColor = true;
            btnAddOffer.Click += btnAddOffer_Click;
            // 
            // frmOffersList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1339, 607);
            Controls.Add(btnAddOffer);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label1);
            Controls.Add(dgvOffersList);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmOffersList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Offers List";
            Load += frmOffersList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOffersList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvOffersList;
        private Label label1;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private Label label2;
        private Label lblRecordsCount;
        private Button btnClose;
        private Button btnAddOffer;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editOfferToolStripMenuItem;
        private ToolStripMenuItem showOfferSubscripersToolStripMenuItem;
    }
}