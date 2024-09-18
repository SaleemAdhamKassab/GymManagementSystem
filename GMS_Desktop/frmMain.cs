using GMS_BusinessLogic;
using GMS_Desktop.Classes;
using GMS_Desktop.Coaches;
using GMS_Desktop.Global;
using GMS_Desktop.Offers;
using GMS_Desktop.Report;
using GMS_Desktop.Users;
using System;

namespace GMS_Desktop
{
    public partial class frmMain : Form
    {
        private bool _IsCurrentUserAdmin = clsGlobal.currentUser.IsAdmin;

        public frmMain()
        {
            InitializeComponent();
        }

        private void categoriesToolStripMenuItem_Click_3(object sender, EventArgs e)
        {
            frmCategoriesList frm = new frmCategoriesList(_IsCurrentUserAdmin);
            frm.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsList frm = new frmProductsList(_IsCurrentUserAdmin);
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

        private void offersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOffersList frm = new frmOffersList(_IsCurrentUserAdmin);
            frm.ShowDialog();
        }

        private void manageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassesList frm = new frmClassesList();
            frm.ShowDialog();
        }

        private void coachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoachesList frm = new frmCoachesList();
            frm.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersList frm = new frmUsersList(_IsCurrentUserAdmin);
            frm.ShowDialog();
        }
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
