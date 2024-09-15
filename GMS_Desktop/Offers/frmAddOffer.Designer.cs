namespace GMS_Desktop
{
    partial class frmAddOffer
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
            pbClassImage = new PictureBox();
            label2 = new Label();
            txtOfferName = new TextBox();
            label3 = new Label();
            cbClassTypes = new ComboBox();
            label4 = new Label();
            dtpStartDate = new DateTimePicker();
            label5 = new Label();
            dtpEndDate = new DateTimePicker();
            label6 = new Label();
            lblOriginalPrice = new Label();
            label8 = new Label();
            nudDiscount = new NumericUpDown();
            lblAfterDiscount = new Label();
            label10 = new Label();
            nudDuration = new NumericUpDown();
            label11 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            cbCategories = new ComboBox();
            label12 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbClassImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(12, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(764, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add/Edit Offer";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbClassImage
            // 
            pbClassImage.Image = Properties.Resources.cateogry_Default;
            pbClassImage.Location = new Point(535, 99);
            pbClassImage.Name = "pbClassImage";
            pbClassImage.Size = new Size(241, 249);
            pbClassImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClassImage.TabIndex = 12;
            pbClassImage.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 102);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 13;
            label2.Text = "Name:";
            // 
            // txtOfferName
            // 
            txtOfferName.Location = new Point(175, 99);
            txtOfferName.Name = "txtOfferName";
            txtOfferName.Size = new Size(291, 26);
            txtOfferName.TabIndex = 0;
            txtOfferName.Validating += txtOfferName_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 206);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 15;
            label3.Text = "Class:";
            // 
            // cbClassTypes
            // 
            cbClassTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClassTypes.FormattingEnabled = true;
            cbClassTypes.Location = new Point(175, 203);
            cbClassTypes.Name = "cbClassTypes";
            cbClassTypes.Size = new Size(291, 28);
            cbClassTypes.TabIndex = 2;
            cbClassTypes.SelectedIndexChanged += cbClassTypes_SelectedIndexChanged;
            cbClassTypes.Validating += ComboBoxes_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 267);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 17;
            label4.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(175, 262);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(291, 26);
            dtpStartDate.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 327);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 19;
            label5.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(175, 322);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(291, 26);
            dtpEndDate.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(535, 375);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 21;
            label6.Text = "Original Price:";
            // 
            // lblOriginalPrice
            // 
            lblOriginalPrice.AutoSize = true;
            lblOriginalPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOriginalPrice.Location = new Point(661, 375);
            lblOriginalPrice.Name = "lblOriginalPrice";
            lblOriginalPrice.Size = new Size(29, 20);
            lblOriginalPrice.TabIndex = 22;
            lblOriginalPrice.Text = "0$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 430);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 23;
            label8.Text = "Discount:";
            // 
            // nudDiscount
            // 
            nudDiscount.Location = new Point(175, 428);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(291, 26);
            nudDiscount.TabIndex = 6;
            nudDiscount.ValueChanged += nudDiscount_ValueChanged;
            // 
            // lblAfterDiscount
            // 
            lblAfterDiscount.AutoSize = true;
            lblAfterDiscount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAfterDiscount.Location = new Point(423, 505);
            lblAfterDiscount.Name = "lblAfterDiscount";
            lblAfterDiscount.Size = new Size(29, 20);
            lblAfterDiscount.TabIndex = 26;
            lblAfterDiscount.Text = "0$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(287, 505);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 25;
            label10.Text = "After Discount:";
            // 
            // nudDuration
            // 
            nudDuration.Location = new Point(175, 375);
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(291, 26);
            nudDuration.TabIndex = 7;
            nudDuration.ValueChanged += nudDuration_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(21, 377);
            label11.Name = "label11";
            label11.Size = new Size(83, 20);
            label11.TabIndex = 27;
            label11.Text = "Duration:";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(212, 606);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 43);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(405, 606);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(162, 43);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(175, 148);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(291, 28);
            cbCategories.TabIndex = 1;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            cbCategories.Validating += ComboBoxes_Validating;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(21, 151);
            label12.Name = "label12";
            label12.Size = new Size(86, 20);
            label12.TabIndex = 31;
            label12.Text = "Category:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddOffer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(788, 661);
            Controls.Add(cbCategories);
            Controls.Add(label12);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(nudDuration);
            Controls.Add(label11);
            Controls.Add(lblAfterDiscount);
            Controls.Add(label10);
            Controls.Add(nudDiscount);
            Controls.Add(label8);
            Controls.Add(lblOriginalPrice);
            Controls.Add(label6);
            Controls.Add(dtpEndDate);
            Controls.Add(label5);
            Controls.Add(dtpStartDate);
            Controls.Add(label4);
            Controls.Add(cbClassTypes);
            Controls.Add(label3);
            Controls.Add(txtOfferName);
            Controls.Add(label2);
            Controls.Add(pbClassImage);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmAddOffer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Offer";
            Load += frmAddOffer_Load;
            ((System.ComponentModel.ISupportInitialize)pbClassImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pbClassImage;
        private Label label2;
        private TextBox txtOfferName;
        private Label label3;
        private ComboBox cbClassTypes;
        private Label label4;
        private DateTimePicker dtpStartDate;
        private Label label5;
        private DateTimePicker dtpEndDate;
        private Label label6;
        private Label lblOriginalPrice;
        private Label label8;
        private NumericUpDown nudDiscount;
        private Label lblAfterDiscount;
        private Label label10;
        private NumericUpDown nudDuration;
        private Label label11;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cbCategories;
        private Label label12;
        private ErrorProvider errorProvider1;
    }
}