namespace GMS_Desktop
{
    partial class frmProductsList
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
            dgvProductsList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            lblRecords = new Label();
            btnClose = new Button();
            lblTitle = new Label();
            label4 = new Label();
            txtFind = new TextBox();
            btnAddNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductsList
            // 
            dgvProductsList.AllowUserToAddRows = false;
            dgvProductsList.AllowUserToDeleteRows = false;
            dgvProductsList.AllowUserToOrderColumns = true;
            dgvProductsList.BackgroundColor = Color.White;
            dgvProductsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductsList.ContextMenuStrip = contextMenuStrip1;
            dgvProductsList.Location = new Point(12, 120);
            dgvProductsList.Name = "dgvProductsList";
            dgvProductsList.ReadOnly = true;
            dgvProductsList.Size = new Size(437, 270);
            dgvProductsList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 410);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Records:";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(94, 413);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(14, 16);
            lblRecords.TabIndex = 2;
            lblRecords.Text = "#";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(327, 403);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 35);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20F);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(132, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 31);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Products List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.Location = new Point(11, 69);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 11;
            label4.Text = "Find Product";
            // 
            // txtFind
            // 
            txtFind.Font = new Font("Microsoft Sans Serif", 12F);
            txtFind.Location = new Point(12, 88);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(174, 26);
            txtFind.TabIndex = 10;
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // btnAddNew
            // 
            btnAddNew.BackgroundImage = Properties.Resources.add_item1;
            btnAddNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNew.Location = new Point(404, 69);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(45, 45);
            btnAddNew.TabIndex = 12;
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // frmProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(462, 450);
            Controls.Add(btnAddNew);
            Controls.Add(label4);
            Controls.Add(txtFind);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(dgvProductsList);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmProductsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products List";
            Load += frmProductsList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductsList;
        private Label label1;
        private Label lblRecords;
        private Button btnClose;
        private Label lblTitle;
        private Label label4;
        private TextBox txtFind;
        private Button btnAddNew;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}