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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvCategoriesList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lblNumberOfCategories = new Label();
            button1 = new Button();
            btnAddCategory = new Button();
            txtFindByID_Name = new TextBox();
            label4 = new Label();
            cbFilter = new ComboBox();
            btnFind = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Categories1;
            pictureBox1.Location = new Point(152, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(132, 125);
            label1.Name = "label1";
            label1.Size = new Size(196, 31);
            label1.TabIndex = 1;
            label1.Text = "Categories List";
            // 
            // dgvCategoriesList
            // 
            dgvCategoriesList.AllowUserToAddRows = false;
            dgvCategoriesList.AllowUserToDeleteRows = false;
            dgvCategoriesList.AllowUserToOrderColumns = true;
            dgvCategoriesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriesList.ContextMenuStrip = contextMenuStrip1;
            dgvCategoriesList.Location = new Point(23, 272);
            dgvCategoriesList.Name = "dgvCategoriesList";
            dgvCategoriesList.ReadOnly = true;
            dgvCategoriesList.Size = new Size(405, 165);
            dgvCategoriesList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(94, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 453);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Records:";
            // 
            // lblNumberOfCategories
            // 
            lblNumberOfCategories.AutoSize = true;
            lblNumberOfCategories.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberOfCategories.Location = new Point(110, 456);
            lblNumberOfCategories.Name = "lblNumberOfCategories";
            lblNumberOfCategories.Size = new Size(14, 16);
            lblNumberOfCategories.TabIndex = 4;
            lblNumberOfCategories.Text = "#";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.Close_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(306, 443);
            button1.Name = "button1";
            button1.Size = new Size(122, 35);
            button1.TabIndex = 5;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackgroundImage = Properties.Resources.Add_category;
            btnAddCategory.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddCategory.Location = new Point(394, 218);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(34, 36);
            btnAddCategory.TabIndex = 6;
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtFindByID_Name
            // 
            txtFindByID_Name.Font = new Font("Microsoft Sans Serif", 12F);
            txtFindByID_Name.Location = new Point(23, 218);
            txtFindByID_Name.Name = "txtFindByID_Name";
            txtFindByID_Name.Size = new Size(174, 26);
            txtFindByID_Name.TabIndex = 8;
            txtFindByID_Name.Visible = false;
            txtFindByID_Name.TextChanged += txtFindByID_Name_TextChanged;
            txtFindByID_Name.KeyPress += txtFindByID_Name_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.Location = new Point(23, 182);
            label4.Name = "label4";
            label4.Size = new Size(174, 17);
            label4.TabIndex = 9;
            label4.Text = "Find Category By ID/Name";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "ID", "Name" });
            cbFilter.Location = new Point(203, 221);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 10;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // btnFind
            // 
            btnFind.BackgroundImage = Properties.Resources.find;
            btnFind.BackgroundImageLayout = ImageLayout.Zoom;
            btnFind.Location = new Point(354, 218);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(34, 36);
            btnFind.TabIndex = 11;
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // frmCategoriesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button1;
            ClientSize = new Size(437, 490);
            Controls.Add(btnFind);
            Controls.Add(cbFilter);
            Controls.Add(label4);
            Controls.Add(txtFindByID_Name);
            Controls.Add(btnAddCategory);
            Controls.Add(button1);
            Controls.Add(lblNumberOfCategories);
            Controls.Add(label2);
            Controls.Add(dgvCategoriesList);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCategoriesList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories List";
            Load += frmCategoriesList_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvCategoriesList;
        private Label label2;
        private Label lblNumberOfCategories;
        private Button button1;
        private Button btnAddCategory;
        private TextBox txtFindByID_Name;
        private Label label4;
        private ComboBox cbFilter;
        private Button btnFind;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}