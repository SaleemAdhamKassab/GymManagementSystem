namespace GMS_Desktop
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            manageCategoriesToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            purchasesToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            clentsToolStripMenuItem = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            offersToolStripMenuItem = new ToolStripMenuItem();
            coachToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { categoriesToolStripMenuItem, manageCategoriesToolStripMenuItem, productToolStripMenuItem, purchasesToolStripMenuItem, salesToolStripMenuItem, clentsToolStripMenuItem, memberToolStripMenuItem, offersToolStripMenuItem, coachToolStripMenuItem, userToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1029, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Checked = true;
            categoriesToolStripMenuItem.CheckState = CheckState.Checked;
            categoriesToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(98, 24);
            categoriesToolStripMenuItem.Text = "Categories";
            categoriesToolStripMenuItem.Click += categoriesToolStripMenuItem_Click_3;
            // 
            // manageCategoriesToolStripMenuItem
            // 
            manageCategoriesToolStripMenuItem.Name = "manageCategoriesToolStripMenuItem";
            manageCategoriesToolStripMenuItem.Size = new Size(139, 24);
            manageCategoriesToolStripMenuItem.Text = "Manage Classes";
            manageCategoriesToolStripMenuItem.Click += manageCategoriesToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(76, 24);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // purchasesToolStripMenuItem
            // 
            purchasesToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            purchasesToolStripMenuItem.Name = "purchasesToolStripMenuItem";
            purchasesToolStripMenuItem.Size = new Size(96, 24);
            purchasesToolStripMenuItem.Text = "Purchases";
            purchasesToolStripMenuItem.Click += purchasesToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(61, 24);
            salesToolStripMenuItem.Text = "Sales";
            salesToolStripMenuItem.Click += salesToolStripMenuItem_Click;
            // 
            // clentsToolStripMenuItem
            // 
            clentsToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clentsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            clentsToolStripMenuItem.Name = "clentsToolStripMenuItem";
            clentsToolStripMenuItem.Size = new Size(69, 24);
            clentsToolStripMenuItem.Text = "Clients";
            clentsToolStripMenuItem.Click += clentsToolStripMenuItem_Click;
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(116, 24);
            memberToolStripMenuItem.Text = "Memberships";
            memberToolStripMenuItem.Click += memberToolStripMenuItem_Click;
            // 
            // offersToolStripMenuItem
            // 
            offersToolStripMenuItem.Name = "offersToolStripMenuItem";
            offersToolStripMenuItem.Size = new Size(65, 24);
            offersToolStripMenuItem.Text = "Offers";
            offersToolStripMenuItem.Click += offersToolStripMenuItem_Click;
            // 
            // coachToolStripMenuItem
            // 
            coachToolStripMenuItem.Name = "coachToolStripMenuItem";
            coachToolStripMenuItem.Size = new Size(67, 24);
            coachToolStripMenuItem.Text = "Coach";
            coachToolStripMenuItem.Click += coachToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(55, 24);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(566, 50);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(78, 24);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 600);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem purchasesToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem clentsToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem offersToolStripMenuItem;
        private ToolStripMenuItem manageCategoriesToolStripMenuItem;
        private ToolStripMenuItem coachToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
    }
}
