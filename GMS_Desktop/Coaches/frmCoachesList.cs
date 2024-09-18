using System;
using System.Data;
using GMS_BusinessLogic;

namespace GMS_Desktop.Coaches
{
    public partial class frmCoachesList : Form
    {
        private Coach _Coach;
        private DataTable _dtCoachesList;

        public frmCoachesList()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCoachesList_Load(object sender, EventArgs e)
        {
            cbSearchBy.SelectedIndex = 0;

            _Coach = new Coach();

            _dtCoachesList = _Coach.get();

            dgvCoachesList.DataSource = _dtCoachesList;

            if (dgvCoachesList.Rows.Count > 0)
            {
                dgvCoachesList.Columns[0].HeaderText = "Id";
                dgvCoachesList.Columns[0].Width = 120;

                dgvCoachesList.Columns[1].HeaderText = "Coach Name";
                dgvCoachesList.Columns[1].Width = 300;

                dgvCoachesList.Columns[2].HeaderText = "Achievement and awards";
                dgvCoachesList.Columns[2].Width = 400;

                dgvCoachesList.Columns[3].HeaderText = "Class Name";
                dgvCoachesList.Columns[3].Width = 150;

                dgvCoachesList.Columns[4].HeaderText = "Is Active";
                dgvCoachesList.Columns[4].Width = 100;
            }

            lblRecordsCount.Text = dgvCoachesList.Rows.Count.ToString();
        }

        private void btnAddNewCoach_Click(object sender, EventArgs e)
        {
            frmAddEditCoach frm = new frmAddEditCoach();
            frm.ShowDialog();
            frmCoachesList_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCoach frm = new frmAddEditCoach((int)dgvCoachesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmCoachesList_Load(null, null);
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchBy.Text == "Is Active")
            {
                txtSearchValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }

            else
            {
                txtSearchValue.Visible = (cbSearchBy.Text != "None");
                cbIsActive.Visible = false;
                txtSearchValue.Text = string.Empty;
                txtSearchValue.Focus();
            }
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbSearchBy.Text)
            {
                case "Id":
                    FilterColumn = "Id";
                    break;

                case "Coach Name":
                    FilterColumn = "CoachName";
                    break;

                case "Class Name":
                    FilterColumn = "ClassName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (cbSearchBy.Text == "None" || txtSearchValue.Text.Trim() == string.Empty)
            {
                _dtCoachesList.DefaultView.RowFilter = string.Empty;
                lblRecordsCount.Text = dgvCoachesList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Id")
                _dtCoachesList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn,
                    txtSearchValue.Text.Trim());
            else
                _dtCoachesList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn,
                    txtSearchValue.Text.Trim());

            lblRecordsCount.Text = dgvCoachesList.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
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
                _dtCoachesList.DefaultView.RowFilter = string.Empty;
            else
                _dtCoachesList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, IsActiveValue);

            lblRecordsCount.Text = dgvCoachesList.Rows.Count.ToString();
        }
        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbSearchBy.Text == "Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowCoachDetails frm = new frmShowCoachDetails((int)dgvCoachesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dgvCoachesList_DoubleClick(object sender, EventArgs e)
        {
            frmShowCoachDetails frm = new frmShowCoachDetails((int)dgvCoachesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void addToAnotherClassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
