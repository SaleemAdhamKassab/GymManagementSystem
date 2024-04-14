using GMS_BusinessLogic;
using System;

namespace GMS_Desktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void categoriesToolStripMenuItem_Click_3(object sender, EventArgs e)
        {
            frmCategoriesList frm = new frmCategoriesList();
            frm.ShowDialog();
        }
    }
}
