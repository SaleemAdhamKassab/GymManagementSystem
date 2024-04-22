namespace GMS_Desktop
{
    partial class frmAddEditCategory
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
            lblName = new Label();
            txtName = new TextBox();
            label2 = new Label();
            lblID = new Label();
            btnClose = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20F);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(43, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(242, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Category";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 15F);
            lblName.Location = new Point(10, 145);
            lblName.Name = "lblName";
            lblName.Size = new Size(70, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(86, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 21);
            txtName.TabIndex = 2;
            txtName.Validating += txtName_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F);
            label2.Location = new Point(43, 94);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 3;
            label2.Text = "ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Microsoft Sans Serif", 15F);
            lblID.Location = new Point(86, 94);
            lblID.Name = "lblID";
            lblID.Size = new Size(23, 25);
            lblID.TabIndex = 4;
            lblID.Text = "#";
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(195, 238);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(129, 41);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(24, 238);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 41);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddNewCategory
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(347, 306);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblID);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddNewCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Category";
            Load += frmAddNewCategory_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label label2;
        private Label lblID;
        private Button btnClose;
        private Button btnSave;
        private ErrorProvider errorProvider1;
    }
}