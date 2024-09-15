namespace GMS_Desktop.Categories_And_Classes
{
    partial class frmManageCategories
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
            lable1 = new Label();
            dgvCategoriesList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnClose = new Button();
            btnAddNewClass = new Button();
            label1 = new Label();
            lblRecordsCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lable1
            // 
            lable1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable1.ForeColor = Color.Blue;
            lable1.Location = new Point(12, 19);
            lable1.Name = "lable1";
            lable1.Size = new Size(448, 38);
            lable1.TabIndex = 0;
            lable1.Text = "Categories List";
            lable1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCategoriesList
            // 
            dgvCategoriesList.AllowUserToAddRows = false;
            dgvCategoriesList.AllowUserToDeleteRows = false;
            dgvCategoriesList.AllowUserToOrderColumns = true;
            dgvCategoriesList.BackgroundColor = Color.White;
            dgvCategoriesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriesList.ContextMenuStrip = contextMenuStrip1;
            dgvCategoriesList.Location = new Point(12, 163);
            dgvCategoriesList.Name = "dgvCategoriesList";
            dgvCategoriesList.ReadOnly = true;
            dgvCategoriesList.Size = new Size(448, 281);
            dgvCategoriesList.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(126, 52);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(125, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(125, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.Blue;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(316, 460);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 46);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddNewClass
            // 
            btnAddNewClass.BackgroundImage = Properties.Resources.Add_category;
            btnAddNewClass.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewClass.FlatStyle = FlatStyle.Popup;
            btnAddNewClass.Location = new Point(388, 90);
            btnAddNewClass.Name = "btnAddNewClass";
            btnAddNewClass.Size = new Size(72, 67);
            btnAddNewClass.TabIndex = 3;
            btnAddNewClass.UseVisualStyleBackColor = true;
            btnAddNewClass.Click += btnAddNewClass_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 473);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 4;
            label1.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.Blue;
            lblRecordsCount.Location = new Point(114, 473);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(36, 20);
            lblRecordsCount.TabIndex = 5;
            lblRecordsCount.Text = "???";
            // 
            // frmManageCategories
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(476, 518);
            Controls.Add(lblRecordsCount);
            Controls.Add(label1);
            Controls.Add(btnAddNewClass);
            Controls.Add(btnClose);
            Controls.Add(dgvCategoriesList);
            Controls.Add(lable1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "frmManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Categories";
            Load += frmManageCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lable1;
        private DataGridView dgvCategoriesList;
        private Button btnClose;
        private Button btnAddNewClass;
        private Label label1;
        private Label lblRecordsCount;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}