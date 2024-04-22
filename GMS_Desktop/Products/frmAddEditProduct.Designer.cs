namespace GMS_Desktop
{
    partial class frmAddEditProduct
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
            label1 = new Label();
            lblProductID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnCancle = new Button();
            cbCategories = new ComboBox();
            txtName = new TextBox();
            nudQuantity = new NumericUpDown();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(166, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add/Edit Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(26, 119);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Product ID:";
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Microsoft Sans Serif", 12F);
            lblProductID.Location = new Point(121, 119);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(18, 20);
            lblProductID.TabIndex = 2;
            lblProductID.Text = "?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(424, 96);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(57, 249);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(206, 175);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 5;
            label4.Text = "Chose Category";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Image = Properties.Resources.Save_321;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(140, 338);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 39);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.FlatStyle = FlatStyle.Popup;
            btnCancle.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancle.Image = Properties.Resources.Close_32;
            btnCancle.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancle.Location = new Point(296, 338);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(121, 39);
            btnCancle.TabIndex = 5;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(187, 198);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(169, 23);
            cbCategories.TabIndex = 2;
            cbCategories.Validating += cbCategories_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(379, 119);
            txtName.Name = "txtName";
            txtName.Size = new Size(143, 21);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(26, 272);
            nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(129, 21);
            nudQuantity.TabIndex = 3;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Validating += nudQuantity_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEditProduct
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancle;
            ClientSize = new Size(540, 394);
            Controls.Add(nudQuantity);
            Controls.Add(txtName);
            Controls.Add(cbCategories);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblProductID);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddEditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditProduct";
            Load += frmAddEditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lblProductID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private Button btnCancle;
        private ComboBox cbCategories;
        private TextBox txtName;
        private NumericUpDown nudQuantity;
        private ErrorProvider errorProvider1;
    }
}