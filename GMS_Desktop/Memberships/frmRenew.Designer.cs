namespace GMS_Desktop
{
    partial class frmRenew
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
            nudDuration = new NumericUpDown();
            label3 = new Label();
            lblFees = new Label();
            btnClose = new Button();
            btnSave = new Button();
            cbPaymentMothods = new ComboBox();
            label12 = new Label();
            errorProvider1 = new ErrorProvider(components);
            cbOffers = new ComboBox();
            lblOffers = new Label();
            lblAfterDiscountValue = new Label();
            lblAfterDiscountLabel = new Label();
            pnlOffer = new Panel();
            rbNo = new RadioButton();
            rbYes = new RadioButton();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            pnlOffer.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(220, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 33);
            label1.TabIndex = 0;
            label1.Text = "Renew";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 145);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Duration:";
            // 
            // nudDuration
            // 
            nudDuration.Location = new Point(199, 143);
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(315, 26);
            nudDuration.TabIndex = 1;
            nudDuration.ValueChanged += nudDuration_ValueChanged;
            nudDuration.Validating += nudDuration_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 269);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Fees:";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Location = new Point(125, 269);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(27, 20);
            lblFees.TabIndex = 5;
            lblFees.Text = "??";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(125, 322);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(151, 41);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(282, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 41);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbPaymentMothods
            // 
            cbPaymentMothods.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentMothods.FormattingEnabled = true;
            cbPaymentMothods.Location = new Point(199, 200);
            cbPaymentMothods.Name = "cbPaymentMothods";
            cbPaymentMothods.Size = new Size(315, 28);
            cbPaymentMothods.TabIndex = 2;
            cbPaymentMothods.Validating += cbPaymentMothods_Validating;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label12.Location = new Point(34, 203);
            label12.Name = "label12";
            label12.Size = new Size(148, 20);
            label12.TabIndex = 24;
            label12.Text = "Payment Method:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // cbOffers
            // 
            cbOffers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOffers.Enabled = false;
            cbOffers.FormattingEnabled = true;
            cbOffers.Location = new Point(177, 43);
            cbOffers.Name = "cbOffers";
            cbOffers.Size = new Size(315, 28);
            cbOffers.TabIndex = 0;
            cbOffers.SelectedIndexChanged += cbOffers_SelectedIndexChanged;
            // 
            // lblOffers
            // 
            lblOffers.AutoSize = true;
            lblOffers.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblOffers.Location = new Point(12, 46);
            lblOffers.Name = "lblOffers";
            lblOffers.Size = new Size(121, 20);
            lblOffers.TabIndex = 26;
            lblOffers.Text = "Choose Offer:";
            // 
            // lblAfterDiscountValue
            // 
            lblAfterDiscountValue.AutoSize = true;
            lblAfterDiscountValue.Location = new Point(430, 269);
            lblAfterDiscountValue.Name = "lblAfterDiscountValue";
            lblAfterDiscountValue.Size = new Size(27, 20);
            lblAfterDiscountValue.TabIndex = 28;
            lblAfterDiscountValue.Text = "??";
            lblAfterDiscountValue.Visible = false;
            // 
            // lblAfterDiscountLabel
            // 
            lblAfterDiscountLabel.AutoSize = true;
            lblAfterDiscountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAfterDiscountLabel.Location = new Point(282, 269);
            lblAfterDiscountLabel.Name = "lblAfterDiscountLabel";
            lblAfterDiscountLabel.Size = new Size(130, 20);
            lblAfterDiscountLabel.TabIndex = 27;
            lblAfterDiscountLabel.Text = "After Discount:";
            lblAfterDiscountLabel.Visible = false;
            // 
            // pnlOffer
            // 
            pnlOffer.Controls.Add(rbNo);
            pnlOffer.Controls.Add(rbYes);
            pnlOffer.Controls.Add(label4);
            pnlOffer.Controls.Add(lblOffers);
            pnlOffer.Controls.Add(cbOffers);
            pnlOffer.Location = new Point(22, 56);
            pnlOffer.Name = "pnlOffer";
            pnlOffer.Size = new Size(518, 75);
            pnlOffer.TabIndex = 0;
            pnlOffer.Visible = false;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Checked = true;
            rbNo.Location = new Point(434, 13);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(47, 24);
            rbNo.TabIndex = 29;
            rbNo.TabStop = true;
            rbNo.Text = "No";
            rbNo.UseVisualStyleBackColor = true;
            rbNo.CheckedChanged += rbNo_CheckedChanged;
            // 
            // rbYes
            // 
            rbYes.AutoSize = true;
            rbYes.Location = new Point(356, 13);
            rbYes.Name = "rbYes";
            rbYes.Size = new Size(55, 24);
            rbYes.TabIndex = 28;
            rbYes.Text = "Yes";
            rbYes.UseVisualStyleBackColor = true;
            rbYes.CheckedChanged += rbYes_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 13);
            label4.Name = "label4";
            label4.Size = new Size(335, 20);
            label4.TabIndex = 27;
            label4.Text = "Would you like to subscribe to this offer?";
            // 
            // frmRenew
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(565, 369);
            Controls.Add(nudDuration);
            Controls.Add(pnlOffer);
            Controls.Add(lblAfterDiscountValue);
            Controls.Add(lblAfterDiscountLabel);
            Controls.Add(cbPaymentMothods);
            Controls.Add(label12);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblFees);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmRenew";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Renew";
            Load += frmRenew_Load;
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            pnlOffer.ResumeLayout(false);
            pnlOffer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nudDuration;
        private Label label3;
        private Label lblFees;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cbPaymentMothods;
        private Label label12;
        private ErrorProvider errorProvider1;
        private Label lblAfterDiscountValue;
        private Label lblAfterDiscountLabel;
        private ComboBox cbOffers;
        private Label lblOffers;
        private Panel pnlOffer;
        private Label label4;
        private RadioButton rbNo;
        private RadioButton rbYes;
    }
}