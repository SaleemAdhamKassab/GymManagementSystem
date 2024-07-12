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

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsList frm = new frmProductsList();
            frm.ShowDialog();

        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrders frm = new frmPurchaseOrders();
            frm.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesList frm = new frmSalesList();
            frm.ShowDialog();
        }

        private void clentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientsList frm = new frmClientsList();
            frm.ShowDialog();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembership frm = new frmMembership();
            frm.ShowDialog();
        }
    }
}
