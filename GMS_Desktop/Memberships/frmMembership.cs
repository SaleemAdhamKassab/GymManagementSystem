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
    public partial class frmMembership : Form
    {
        private Membership _Membership;
        private ClassSubscription _ClassSubscription;
        DataTable _dtMembershipsList;
        DataTable _dtMembershipsExpireSoonList;

        public frmMembership()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _LoadExpireSoonListToDataGridView()
        {
            _ClassSubscription = new ClassSubscription();

            _dtMembershipsExpireSoonList = _ClassSubscription.getExpiredSoonList();

            dgvMembershipsExpireSoon.DataSource = _dtMembershipsExpireSoonList;

            if (dgvMembershipsExpireSoon.Rows.Count > 0)
            {
                dgvMembershipsExpireSoon.Columns[0].HeaderText = "Id";
                dgvMembershipsExpireSoon.Columns[0].Width = 120;

                dgvMembershipsExpireSoon.Columns[1].HeaderText = "Membership Name";
                dgvMembershipsExpireSoon.Columns[1].Width = 250;

                dgvMembershipsExpireSoon.Columns[2].HeaderText = "Class Name";
                dgvMembershipsExpireSoon.Columns[2].Width = 150;

                dgvMembershipsExpireSoon.Columns[3].HeaderText = "Phone";
                dgvMembershipsExpireSoon.Columns[3].Width = 150;

                dgvMembershipsExpireSoon.Columns[4].HeaderText = "Start Date";
                dgvMembershipsExpireSoon.Columns[4].Width = 150;

                dgvMembershipsExpireSoon.Columns[5].HeaderText = "Expired Date";
                dgvMembershipsExpireSoon.Columns[5].Width = 150;
            }

            lblExpireSoonRecordsCount.Text = dgvMembershipsExpireSoon.Rows.Count.ToString();
        }

        private void frmMembership_Load(object sender, EventArgs e)
        {
            _Membership = new Membership();

            _dtMembershipsList = _Membership.get();

            dgvMembershipList.DataSource = _dtMembershipsList;

            cbFilterBy.SelectedIndex = 0;

            if (dgvMembershipList.Rows.Count > 0)
            {
                dgvMembershipList.Columns[0].HeaderText = "Id";
                dgvMembershipList.Columns[0].Width = 120;

                dgvMembershipList.Columns[1].HeaderText = "Membership Name";
                dgvMembershipList.Columns[1].Width = 300;

                dgvMembershipList.Columns[2].HeaderText = "Data Of Belong";
                dgvMembershipList.Columns[2].Width = 150;

                dgvMembershipList.Columns[3].HeaderText = "Gendor";
                dgvMembershipList.Columns[3].Width = 100;

                dgvMembershipList.Columns[4].HeaderText = "Phone";
                dgvMembershipList.Columns[4].Width = 150;

                dgvMembershipList.Columns[5].HeaderText = "Is Active";
                dgvMembershipList.Columns[5].Width = 90;
            }

            lblRecordsCount.Text = dgvMembershipList.Rows.Count.ToString();

            _LoadExpireSoonListToDataGridView();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;
                txtFilterValue.Enabled = (cbFilterBy.Text != "None");
                txtFilterValue.Text = string.Empty;
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbFilterBy.Text)
            {
                case "Id":
                    FilterColumn = "Id";
                    break;

                case "Membership Name":
                    FilterColumn = "ClientName";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Gendor":
                    FilterColumn = "Gendor";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == string.Empty || txtFilterValue.Text == "None")
            {
                _dtMembershipsList.DefaultView.RowFilter = string.Empty;
                lblRecordsCount.Text = dgvMembershipList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Id")
            {
                _dtMembershipsList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            }

            else
            {
                _dtMembershipsList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvMembershipList.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string isActiveValue = cbIsActive.Text;

            switch (isActiveValue)
            {
                case "All":
                    break;

                case "Yes":
                    isActiveValue = "1";
                    break;

                case "No":
                    isActiveValue = "0";
                    break;
            }

            if (isActiveValue == "All")
                _dtMembershipsList.DefaultView.RowFilter = string.Empty;
            else
                _dtMembershipsList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, isActiveValue);

            lblRecordsCount.Text = dgvMembershipList.Rows.Count.ToString();
        }

        private void subscipeToClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMembershipList.Rows.Count == 0) return;

            int membershipId = (int)dgvMembershipList.CurrentRow.Cells[0].Value;

            Membership membership = Membership.find(membershipId);

            if (membership == null)
            {
                MessageBox.Show("No Membership with Id = " + membershipId.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowMembershipDetails frm = new frmShowMembershipDetails(membership);
            frm.ShowDialog();

            frmMembership_Load(null, null);
        }

        private void dgvMembershipList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMembershipList.Rows.Count == 0) return;

            int membershipId = (int)dgvMembershipList.CurrentRow.Cells[0].Value;

            Membership membership = Membership.find(membershipId);

            if (membership == null)
            {
                MessageBox.Show("No Membership with Id = " + membershipId.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowMembershipDetails frm = new frmShowMembershipDetails(membership);
            frm.ShowDialog();

            frmMembership_Load(null, null);
        }

        private void addNewSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMembershipList.Rows.Count == 0) return;

            int membershipId = (int)dgvMembershipList.CurrentRow.Cells[0].Value;
            Membership membership = Membership.find(membershipId);

            if (membership == null)
            {
                MessageBox.Show("No Membership with Id = " + membershipId.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAddMembership frm = new frmAddMembership(membership);
            frm.ShowDialog();
            frmMembership_Load(null, null);
        }

        private void showMembershipDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int membershipId = (int)dgvMembershipList.CurrentRow.Cells[0].Value;

            Membership membership = Membership.find(membershipId);

            if (membership == null)
            {
                MessageBox.Show("No Membership with Id = " + membershipId.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowClientInfo frm = new frmShowClientInfo(membership.ClientInfo.ClientId);
            frm.ShowDialog();
        }
    }
}
