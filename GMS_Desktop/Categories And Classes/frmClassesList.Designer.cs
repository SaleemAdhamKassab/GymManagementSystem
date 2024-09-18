namespace GMS_Desktop.Classes
{
    partial class frmClassesList
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
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            dgvClassesList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            lblRecordsCount = new Label();
            btnClose = new Button();
            btnAddNewClass = new Button();
            cbAllowFreeze = new ComboBox();
            btnManageCategories = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClassesList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(907, 45);
            label1.TabIndex = 0;
            label1.Text = "Classes List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Search By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Id", "Class Name", "Category Name", "Allow Freeze" });
            cbFilterBy.Location = new Point(114, 163);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(228, 28);
            cbFilterBy.TabIndex = 2;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(348, 163);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(226, 26);
            txtFilterValue.TabIndex = 3;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // dgvClassesList
            // 
            dgvClassesList.AllowUserToAddRows = false;
            dgvClassesList.AllowUserToDeleteRows = false;
            dgvClassesList.AllowUserToOrderColumns = true;
            dgvClassesList.BackgroundColor = Color.White;
            dgvClassesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClassesList.ContextMenuStrip = contextMenuStrip1;
            dgvClassesList.Location = new Point(12, 226);
            dgvClassesList.Name = "dgvClassesList";
            dgvClassesList.ReadOnly = true;
            dgvClassesList.Size = new Size(907, 364);
            dgvClassesList.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 74);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(12, 607);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 5;
            label3.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.Blue;
            lblRecordsCount.Location = new Point(114, 607);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(39, 20);
            lblRecordsCount.TabIndex = 6;
            lblRecordsCount.Text = "???";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(768, 596);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(151, 42);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddNewClass
            // 
            btnAddNewClass.BackgroundImage = Properties.Resources.Add_new_class;
            btnAddNewClass.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewClass.FlatStyle = FlatStyle.Popup;
            btnAddNewClass.Location = new Point(833, 132);
            btnAddNewClass.Name = "btnAddNewClass";
            btnAddNewClass.Size = new Size(86, 88);
            btnAddNewClass.TabIndex = 8;
            btnAddNewClass.UseVisualStyleBackColor = true;
            btnAddNewClass.Click += btnAddNewClass_Click;
            // 
            // cbAllowFreeze
            // 
            cbAllowFreeze.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAllowFreeze.FormattingEnabled = true;
            cbAllowFreeze.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbAllowFreeze.Location = new Point(348, 163);
            cbAllowFreeze.Name = "cbAllowFreeze";
            cbAllowFreeze.Size = new Size(121, 28);
            cbAllowFreeze.TabIndex = 9;
            cbAllowFreeze.Visible = false;
            cbAllowFreeze.SelectedIndexChanged += cbAllowFreeze_SelectedIndexChanged;
            // 
            // btnManageCategories
            // 
            btnManageCategories.BackgroundImage = Properties.Resources.Categories;
            btnManageCategories.BackgroundImageLayout = ImageLayout.Zoom;
            btnManageCategories.FlatStyle = FlatStyle.Popup;
            btnManageCategories.Location = new Point(722, 132);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(86, 88);
            btnManageCategories.TabIndex = 10;
            btnManageCategories.UseVisualStyleBackColor = true;
            btnManageCategories.Click += ManageCategories_Click;
            // 
            // frmClassesList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(926, 650);
            Controls.Add(btnManageCategories);
            Controls.Add(cbAllowFreeze);
            Controls.Add(btnAddNewClass);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(dgvClassesList);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmClassesList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Classes List";
            Load += frmClassesList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClassesList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private DataGridView dgvClassesList;
        private Label label3;
        private Label lblRecordsCount;
        private Button btnClose;
        private Button btnAddNewClass;
        private ComboBox cbAllowFreeze;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button btnManageCategories;
    }
}