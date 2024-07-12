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
    public partial class frmClientsList : Form
    {
        private Client _Client;
        private DataTable _dtClientsList;
        public frmClientsList()
        {
            InitializeComponent();
        }

        private void frmClientsList_Load(object sender, EventArgs e)
        {
            _Client = new Client();

            cbFilterBy.SelectedIndex = 0;
            _dtClientsList = _Client.get(string.Empty);
            dgvClientsList.DataSource = _dtClientsList;

            if (dgvClientsList.Rows.Count > 0)
            {
                dgvClientsList.Columns[0].HeaderText = "Client ID";
                dgvClientsList.Columns[0].Width = 110;

                dgvClientsList.Columns[1].HeaderText = "Full Name";
                dgvClientsList.Columns[1].Width = 350;

                dgvClientsList.Columns[2].HeaderText = "Gendor";
                dgvClientsList.Columns[2].Width = 90;

                dgvClientsList.Columns[3].HeaderText = "Date Of Birth";
                dgvClientsList.Columns[3].Width = 150;

                dgvClientsList.Columns[4].HeaderText = "Phone";
                dgvClientsList.Columns[4].Width = 150;

                dgvClientsList.Columns[5].HeaderText = "Address";
                dgvClientsList.Columns[5].Width = 150;

                dgvClientsList.Columns[6].HeaderText = "Email";
                dgvClientsList.Columns[6].Width = 200;

            }

            lblRecords.Text = dgvClientsList.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = cbFilterBy.SelectedIndex != 0;

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
                case "Client ID":
                    FilterColumn = "Id";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text == string.Empty || FilterColumn == "None")
            {
                _dtClientsList.DefaultView.RowFilter = string.Empty;
                lblRecords.Text = dgvClientsList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Id")
                _dtClientsList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtClientsList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecords.Text = dgvClientsList.Rows.Count.ToString();
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient();
            frm.ShowDialog();
            frmClientsList_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient((int)dgvClientsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmClientsList_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this client?", "Are You Sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            int clientId = (int)dgvClientsList.CurrentRow.Cells[0].Value;
            Client client = Client.find(clientId);

            if (client == null)
            {
                MessageBox.Show($"No client with ID = ", "Are You Sure?",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Client.delete(client))
            {
                MessageBox.Show("Client deleted successfully", "Deleted Successfully",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmClientsList_Load(null, null);
            }
        }

        private void assignMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMembership frm = new frmAddMembership((int)dgvClientsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowClientInfo frm = new frmShowClientInfo((int)dgvClientsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dgvClientsList_DoubleClick(object sender, EventArgs e)
        {
            frmShowClientInfo frm = new frmShowClientInfo((int)dgvClientsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
