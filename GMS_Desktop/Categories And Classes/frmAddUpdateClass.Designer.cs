namespace GMS_Desktop.Classes
{
    partial class frmAddUpdateClass
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pbClassImage = new PictureBox();
            txtClassName = new TextBox();
            nudFees = new NumericUpDown();
            rbYes = new RadioButton();
            rbNo = new RadioButton();
            cbCategories = new ComboBox();
            btnClose = new Button();
            btnSave = new Button();
            llSetImage = new LinkLabel();
            llRemove = new LinkLabel();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbClassImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(12, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(780, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add/Edit Class";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(44, 185);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(44, 245);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Fees:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(44, 305);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 3;
            label3.Text = "Allow Freeze:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(44, 124);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "Cateogry:";
            // 
            // pbClassImage
            // 
            pbClassImage.Image = Properties.Resources.cateogry_Default;
            pbClassImage.Location = new Point(593, 121);
            pbClassImage.Name = "pbClassImage";
            pbClassImage.Size = new Size(199, 204);
            pbClassImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbClassImage.TabIndex = 5;
            pbClassImage.TabStop = false;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(235, 182);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(264, 26);
            txtClassName.TabIndex = 1;
            txtClassName.Text = " ";
            txtClassName.Validating += txtClassName_Validating;
            // 
            // nudFees
            // 
            nudFees.Location = new Point(235, 243);
            nudFees.Name = "nudFees";
            nudFees.Size = new Size(264, 26);
            nudFees.TabIndex = 2;
            nudFees.Validating += nudFees_Validating;
            // 
            // rbYes
            // 
            rbYes.AutoSize = true;
            rbYes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbYes.ForeColor = Color.Blue;
            rbYes.Location = new Point(235, 301);
            rbYes.Name = "rbYes";
            rbYes.Size = new Size(58, 24);
            rbYes.TabIndex = 3;
            rbYes.Text = "Yes";
            rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Checked = true;
            rbNo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbNo.ForeColor = Color.Blue;
            rbNo.Location = new Point(324, 301);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(49, 24);
            rbNo.TabIndex = 4;
            rbNo.TabStop = true;
            rbNo.Text = "No";
            rbNo.UseVisualStyleBackColor = true;
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(235, 121);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(264, 28);
            cbCategories.TabIndex = 0;
            cbCategories.Validating += cbCategories_Validating;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.Blue;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(205, 470);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 41);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.Blue;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(397, 470);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 41);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Location = new Point(593, 341);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(83, 20);
            llSetImage.TabIndex = 5;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // llRemove
            // 
            llRemove.AutoSize = true;
            llRemove.Location = new Point(593, 377);
            llRemove.Name = "llRemove";
            llRemove.Size = new Size(77, 20);
            llRemove.TabIndex = 6;
            llRemove.TabStop = true;
            llRemove.Text = "Remaove";
            llRemove.LinkClicked += llRemove_LinkClicked;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateClass
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(798, 523);
            Controls.Add(llRemove);
            Controls.Add(llSetImage);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(cbCategories);
            Controls.Add(rbNo);
            Controls.Add(rbYes);
            Controls.Add(nudFees);
            Controls.Add(txtClassName);
            Controls.Add(pbClassImage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmAddUpdateClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUpdateClass";
            Load += frmAddUpdateClass_Load;
            ((System.ComponentModel.ISupportInitialize)pbClassImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFees).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pbClassImage;
        private TextBox txtClassName;
        private NumericUpDown nudFees;
        private RadioButton rbYes;
        private RadioButton rbNo;
        private ComboBox cbCategories;
        private Button btnClose;
        private Button btnSave;
        private LinkLabel llSetImage;
        private LinkLabel llRemove;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}