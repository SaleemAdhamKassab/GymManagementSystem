using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMS_BusinessLogic;

namespace GMS_Desktop
{
    public partial class frmPurchaseOrders : Form
    {
        Order _Order = new Order();
        DataTable _dtPurchaseOrdersList;

        public frmPurchaseOrders()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrders_Load(object sender, EventArgs e)
        {
            _dtPurchaseOrdersList = _Order.get(string.Empty);

            dgvPurchaseOrdersList.DataSource = _dtPurchaseOrdersList;
            lblPurchaseOrdersCount.Text = dgvPurchaseOrdersList.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

            if (dgvPurchaseOrdersList.Rows.Count > 0)
            {
                dgvPurchaseOrdersList.Columns[0].HeaderText = "Order ID";
                dgvPurchaseOrdersList.Columns[0].Width = 100;

                dgvPurchaseOrdersList.Columns[1].HeaderText = "Date";
                dgvPurchaseOrdersList.Columns[1].Width = 200;

                dgvPurchaseOrdersList.Columns[2].HeaderText = "User Name";
                dgvPurchaseOrdersList.Columns[2].Width = 150;

                dgvPurchaseOrdersList.Columns[3].HeaderText = "Suppler";
                dgvPurchaseOrdersList.Columns[3].Width = 220;

                dgvPurchaseOrdersList.Columns[4].HeaderText = "Amount";
                dgvPurchaseOrdersList.Columns[4].Width = 120;

                dgvPurchaseOrdersList.Columns[5].HeaderText = "Discount";
                dgvPurchaseOrdersList.Columns[5].Width = 120;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = string.Empty;
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbFilterBy.Text)
            {
                case "Order ID":
                    FilterColumn = "OrderId";
                    break;

                case "User Name":
                    FilterColumn = "UserName";
                    break;

                case "Supplier":
                    FilterColumn = "Supplier";
                    break;
            }

            if (txtFilterValue.Text.Trim() == string.Empty || FilterColumn == "None")
            {
                _dtPurchaseOrdersList.DefaultView.RowFilter = string.Empty;
                lblPurchaseOrdersCount.Text = dgvPurchaseOrdersList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "OrderId")
                _dtPurchaseOrdersList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtPurchaseOrdersList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblPurchaseOrdersCount.Text = dgvPurchaseOrdersList.Rows.Count.ToString();

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Order ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            frmPurchases frm = new frmPurchases();
            frm.ShowDialog();
            frmPurchaseOrders_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this order?", "Are You Sure ?",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            _Order.delete((int)dgvPurchaseOrdersList.CurrentRow.Cells[0].Value);

            MessageBox.Show("Order deleted successfully in the system.", "Deleted",
             MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmPurchaseOrders_Load(null, null);
        }

        private void addNewPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchases frm = new frmPurchases();
            frm.ShowDialog();
            frmPurchaseOrders_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPurchaseOrder frm = new frmShowPurchaseOrder((int)dgvPurchaseOrdersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dgvPurchaseOrdersList_DoubleClick(object sender, EventArgs e)
        {
            frmShowPurchaseOrder frm = new frmShowPurchaseOrder((int)dgvPurchaseOrdersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
