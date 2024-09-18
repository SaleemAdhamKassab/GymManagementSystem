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
            label2 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnCancle = new Button();
            cbCategories = new ComboBox();
            txtName = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            pbProductImage = new PictureBox();
            llSetImage = new LinkLabel();
            llRemove = new LinkLabel();
            openFileDialog1 = new OpenFileDialog();
            label3 = new Label();
            nudPriceWithProfit = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPriceWithProfit).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(13, 22);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(717, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add/Edit Product";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(5, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 26);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(5, 233);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 26);
            label4.TabIndex = 5;
            label4.Text = "Category:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Image = Properties.Resources.Save_321;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(186, 491);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 44);
            btnSave.TabIndex = 5;
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
            btnCancle.Location = new Point(387, 491);
            btnCancle.Margin = new Padding(4);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(176, 44);
            btnCancle.TabIndex = 6;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(186, 231);
            cbCategories.Margin = new Padding(4);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(257, 28);
            cbCategories.TabIndex = 1;
            cbCategories.Validating += cbCategories_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(186, 143);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(257, 26);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pbProductImage
            // 
            pbProductImage.Image = Properties.Resources.Add_new_item;
            pbProductImage.Location = new Point(524, 143);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(206, 208);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 6;
            pbProductImage.TabStop = false;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Location = new Point(524, 378);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(83, 20);
            llSetImage.TabIndex = 3;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // llRemove
            // 
            llRemove.AutoSize = true;
            llRemove.Location = new Point(524, 413);
            llRemove.Name = "llRemove";
            llRemove.Size = new Size(68, 20);
            llRemove.TabIndex = 4;
            llRemove.TabStop = true;
            llRemove.Text = "Remove";
            llRemove.Visible = false;
            llRemove.LinkClicked += llRemove_LinkClicked;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(5, 325);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 26);
            label3.TabIndex = 4;
            label3.Text = "Price with profit:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudPriceWithProfit
            // 
            nudPriceWithProfit.Location = new Point(186, 325);
            nudPriceWithProfit.Margin = new Padding(4);
            nudPriceWithProfit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPriceWithProfit.Name = "nudPriceWithProfit";
            nudPriceWithProfit.Size = new Size(257, 26);
            nudPriceWithProfit.TabIndex = 2;
            nudPriceWithProfit.Validating += nudPriceWithProfit_Validating;
            // 
            // frmAddEditProduct
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancle;
            ClientSize = new Size(738, 548);
            Controls.Add(llRemove);
            Controls.Add(llSetImage);
            Controls.Add(pbProductImage);
            Controls.Add(nudPriceWithProfit);
            Controls.Add(txtName);
            Controls.Add(cbCategories);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmAddEditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditProduct";
            Load += frmAddEditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPriceWithProfit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label2;
        private Label label4;
        private Button btnSave;
        private Button btnCancle;
        private ComboBox cbCategories;
        private TextBox txtName;
        private ErrorProvider errorProvider1;
        private PictureBox pbProductImage;
        private LinkLabel llRemove;
        private LinkLabel llSetImage;
        private OpenFileDialog openFileDialog1;
        private NumericUpDown nudPriceWithProfit;
        private Label label3;
    }
}