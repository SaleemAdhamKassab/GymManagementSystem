namespace GMS_Desktop.Offers
{
    partial class frmOfferSubscripersList
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
            dgvOfferSubscribersList = new DataGridView();
            label2 = new Label();
            lblRecordsCount = new Label();
            btnClose = new Button();
            label3 = new Label();
            cbFilterBy = new ComboBox();
            txtSearchValue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOfferSubscribersList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(943, 37);
            label1.TabIndex = 0;
            label1.Text = "Offer Subscribers List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvOfferSubscribersList
            // 
            dgvOfferSubscribersList.AllowUserToAddRows = false;
            dgvOfferSubscribersList.AllowUserToDeleteRows = false;
            dgvOfferSubscribersList.AllowUserToOrderColumns = true;
            dgvOfferSubscribersList.BackgroundColor = Color.White;
            dgvOfferSubscribersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOfferSubscribersList.Location = new Point(12, 144);
            dgvOfferSubscribersList.Name = "dgvOfferSubscribersList";
            dgvOfferSubscribersList.ReadOnly = true;
            dgvOfferSubscribersList.Size = new Size(937, 389);
            dgvOfferSubscribersList.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 557);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Location = new Point(114, 557);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(27, 20);
            lblRecordsCount.TabIndex = 3;
            lblRecordsCount.Text = "??";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(797, 547);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(152, 41);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 103);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "Find By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Id", "Membership Name", "Subscripe Status" });
            cbFilterBy.Location = new Point(105, 100);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(211, 28);
            cbFilterBy.TabIndex = 6;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(322, 100);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(215, 26);
            txtSearchValue.TabIndex = 7;
            txtSearchValue.Visible = false;
            txtSearchValue.TextChanged += txtSearchValue_TextChanged;
            txtSearchValue.KeyPress += txtSearchValue_KeyPress;
            // 
            // frmOfferSubscripersList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(954, 600);
            Controls.Add(txtSearchValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(dgvOfferSubscribersList);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmOfferSubscripersList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Offer Subscripers List";
            Load += frmOfferSubscripersList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOfferSubscribersList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvOfferSubscribersList;
        private Label label2;
        private Label lblRecordsCount;
        private Button btnClose;
        private Label label3;
        private ComboBox cbFilterBy;
        private TextBox txtSearchValue;
    }
}