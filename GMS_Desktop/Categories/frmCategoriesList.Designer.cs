namespace GMS_Desktop
{
    partial class frmCategoriesList
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
            dgvCategoriesList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lblNumberOfCategories = new Label();
            button1 = new Button();
            btnAddCategory = new Button();
            txtFindByID_Name = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(139, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 33);
            label1.TabIndex = 1;
            label1.Text = "Categories List";
            // 
            // dgvCategoriesList
            // 
            dgvCategoriesList.AllowUserToAddRows = false;
            dgvCategoriesList.AllowUserToDeleteRows = false;
            dgvCategoriesList.AllowUserToOrderColumns = true;
            dgvCategoriesList.BackgroundColor = Color.White;
            dgvCategoriesList.BorderStyle = BorderStyle.None;
            dgvCategoriesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriesList.ContextMenuStrip = contextMenuStrip1;
            dgvCategoriesList.Location = new Point(66, 192);
            dgvCategoriesList.Margin = new Padding(4);
            dgvCategoriesList.Name = "dgvCategoriesList";
            dgvCategoriesList.ReadOnly = true;
            dgvCategoriesList.Size = new Size(362, 268);
            dgvCategoriesList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 510);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "# Records:";
            // 
            // lblNumberOfCategories
            // 
            lblNumberOfCategories.AutoSize = true;
            lblNumberOfCategories.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberOfCategories.Location = new Point(117, 510);
            lblNumberOfCategories.Margin = new Padding(4, 0, 4, 0);
            lblNumberOfCategories.Name = "lblNumberOfCategories";
            lblNumberOfCategories.Size = new Size(18, 20);
            lblNumberOfCategories.TabIndex = 4;
            lblNumberOfCategories.Text = "?";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.Close_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(332, 497);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(157, 47);
            button1.TabIndex = 5;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackgroundImage = Properties.Resources.images;
            btnAddCategory.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddCategory.Location = new Point(429, 111);
            btnAddCategory.Margin = new Padding(4);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(60, 58);
            btnAddCategory.TabIndex = 6;
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtFindByID_Name
            // 
            txtFindByID_Name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFindByID_Name.Location = new Point(13, 127);
            txtFindByID_Name.Margin = new Padding(4);
            txtFindByID_Name.Name = "txtFindByID_Name";
            txtFindByID_Name.Size = new Size(223, 26);
            txtFindByID_Name.TabIndex = 8;
            txtFindByID_Name.TextChanged += txtFindByID_Name_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 101);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 9;
            label4.Text = "Find Category";
            // 
            // frmCategoriesList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button1;
            ClientSize = new Size(498, 548);
            Controls.Add(label4);
            Controls.Add(txtFindByID_Name);
            Controls.Add(btnAddCategory);
            Controls.Add(button1);
            Controls.Add(lblNumberOfCategories);
            Controls.Add(label2);
            Controls.Add(dgvCategoriesList);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmCategoriesList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories List";
            Load += frmCategoriesList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvCategoriesList;
        private Label label2;
        private Label lblNumberOfCategories;
        private Button button1;
        private Button btnAddCategory;
        private TextBox txtFindByID_Name;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}