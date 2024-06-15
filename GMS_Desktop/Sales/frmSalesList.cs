using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMS_BusinessLogic;

namespace GMS_Desktop
{
    public partial class frmSalesList : Form
    {
        public DataTable _dtSalesList;
        public SalesOrder _SalesOrder;

        public frmSalesList()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSalesList_Load(object sender, EventArgs e)
        {
            _SalesOrder = new SalesOrder();

            _dtSalesList = _SalesOrder.get(string.Empty);

            dgvSalesList.DataSource = _dtSalesList;

            if (dgvSalesList.Rows.Count > 0)
            {
                dgvSalesList.Columns[0].HeaderText = "Order ID";
                dgvSalesList.Columns[0].Width = 120;

                dgvSalesList.Columns[1].HeaderText = "Date";
                dgvSalesList.Columns[1].Width = 150;

                dgvSalesList.Columns[2].HeaderText = "Client";
                dgvSalesList.Columns[2].Width = 280;

                dgvSalesList.Columns[3].HeaderText = "User Name";
                dgvSalesList.Columns[3].Width = 150;

                dgvSalesList.Columns[4].HeaderText = "Amount";
                dgvSalesList.Columns[4].Width = 120;

                dgvSalesList.Columns[5].HeaderText = "Amount After Discount";
                dgvSalesList.Columns[5].Width = 120;
            }

            lblRecordsCount.Text = dgvSalesList.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchValue.Visible = (cbFilterBy.Text != null);

            if (txtSearchValue.Visible)
            {
                txtSearchValue.Text = string.Empty;
                txtSearchValue.Focus();
            }
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbFilterBy.Text)
            {
                case "Order ID":
                    FilterColumn = "Id";
                    break;

                case "Date":
                    FilterColumn = "Date";
                    break;

                case "Client":
                    FilterColumn = "Client";
                    break;

                case "User Name":
                    FilterColumn = "UserName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtSearchValue.Text.Trim() == string.Empty || FilterColumn == "None")
            {
                _dtSalesList.DefaultView.RowFilter = string.Empty;
                lblRecordsCount.Text = dgvSalesList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Id")

                _dtSalesList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSearchValue.Text.Trim());

            else if (FilterColumn == "Date")
            {
                if (DateTime.TryParse(txtSearchValue.Text.Trim(), out DateTime date))
                {
                    _dtSalesList.DefaultView.RowFilter = string.Format("[{0}] = #{1}#", FilterColumn, date.ToString("dd/MM/yyyy"));
                }
                else
                {
                    _dtSalesList.DefaultView.RowFilter = string.Empty;
                }
            }

            else
            {
                string searchValue = txtSearchValue.Text.Trim().Replace("'", "''");
                _dtSalesList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, searchValue);
            }

            lblRecordsCount.Text = dgvSalesList.Rows.Count.ToString();
        }

        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Order ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddSaleOrder_Click(object sender, EventArgs e)
        {
            frmSales frm = new frmSales();
            frm.ShowDialog();
            frmSalesList_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this order?", "Are You Sure?",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;

            int orderId = (int)dgvSalesList.CurrentRow.Cells[0].Value;

            if (_SalesOrder.delete(orderId))
                MessageBox.Show("Order deleted successfully in the system", "Deleted Successfully",
             MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmSalesList_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDetails frm = new frmShowDetails((int)dgvSalesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dgvSalesList_DoubleClick(object sender, EventArgs e)
        {
            frmShowDetails frm = new frmShowDetails((int)dgvSalesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
