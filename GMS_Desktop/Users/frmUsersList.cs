using System;
using System.Data;
using GMS_BusinessLogic;

namespace GMS_Desktop.Users
{
    public partial class frmUsersList : Form
    {
        private User _User;
        private DataTable _dtusersList;
        private bool _ShowScreen = false;

        public frmUsersList(bool isAdmin)
        {
            InitializeComponent();
            _ShowScreen = isAdmin;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            if (!_ShowScreen)
            {
                MessageBox.Show("Access denied!, you haven't permission in this screen Contact your Admin", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            cbSeachBy.SelectedIndex = 0;
            _User = new User();
            _dtusersList = _User.get();
            dgvUsersList.DataSource = _dtusersList;

            if (dgvUsersList.Rows.Count > 0)
            {
                dgvUsersList.Columns[0].HeaderText = "Id";
                dgvUsersList.Columns[0].Width = 100;

                dgvUsersList.Columns[1].HeaderText = "Name";
                dgvUsersList.Columns[1].Width = 300;

                dgvUsersList.Columns[2].HeaderText = "User Name";
                dgvUsersList.Columns[2].Width = 150;

                dgvUsersList.Columns[3].HeaderText = "Email";
                dgvUsersList.Columns[3].Width = 150;

                dgvUsersList.Columns[4].HeaderText = "Gendor";
                dgvUsersList.Columns[4].Width = 90;

                dgvUsersList.Columns[5].HeaderText = "Phone";
                dgvUsersList.Columns[5].Width = 120;

                dgvUsersList.Columns[6].HeaderText = "Address";
                dgvUsersList.Columns[6].Width = 150;

                dgvUsersList.Columns[7].HeaderText = "Role";
                dgvUsersList.Columns[7].Width = 120;

                dgvUsersList.Columns[8].HeaderText = "IsActive";
                dgvUsersList.Columns[8].Width = 90;

            }

            lblRecordsCount.Text = dgvUsersList.Rows.Count.ToString();
        }

        private void cbSeachBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSeachBy.Text == "Is Active")
            {
                txtSearchValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtSearchValue.Visible = (cbSeachBy.Text != "None");
                cbIsActive.Visible = false;
                txtSearchValue.Text = string.Empty;
                txtSearchValue.Focus();
            }
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbSeachBy.Text)
            {
                case "Id":
                    FilterColumn = "Id";
                    break;

                case "Name":
                    FilterColumn = "Name";
                    break;

                case "User Name":
                    FilterColumn = "UserName";
                    break;

                case "Role":
                    FilterColumn = "Role";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;
            }

            if (cbSeachBy.Text == "None" || txtSearchValue.Text.Trim() == string.Empty)
            {
                _dtusersList.DefaultView.RowFilter = string.Empty;
                lblRecordsCount.Text = dgvUsersList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Id")
                _dtusersList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn,
                    txtSearchValue.Text.Trim());

            else
                _dtusersList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn,
                    txtSearchValue.Text.Trim());

            lblRecordsCount.Text = dgvUsersList.Rows.Count.ToString();
        }

        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbSeachBy.Text == "Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterCloumn = "IsActive";
            string IsActiveValue = cbIsActive.Text;

            switch (IsActiveValue)
            {
                case "All":
                    break;

                case "Yes":
                    IsActiveValue = "1";
                    break;

                case "No":
                    IsActiveValue = "0";
                    break;
            }

            if (IsActiveValue == "All")
                _dtusersList.DefaultView.RowFilter = string.Empty;
            else
                _dtusersList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterCloumn, IsActiveValue);

            lblRecordsCount.Text = dgvUsersList.Rows.Count.ToString();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
            frmUsersList_Load(null, null);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmUsersList_Load(null, null);
        }

        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dgvUsersList_DoubleClick(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }
    }
}
