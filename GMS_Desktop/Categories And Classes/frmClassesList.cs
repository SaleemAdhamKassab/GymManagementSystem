using System;
using System.Data;
using GMS_BusinessLogic;
using GMS_Desktop.Categories_And_Classes;

namespace GMS_Desktop.Classes
{
    public partial class frmClassesList : Form
    {
        private ClassType _ClassType;
        private DataTable _dtClassTypes;

        public frmClassesList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmClassesList_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;

            _ClassType = new ClassType();

            _dtClassTypes = _ClassType.get();
            dgvClassesList.DataSource = _dtClassTypes;

            if (dgvClassesList.Rows.Count > 0)
            {
                dgvClassesList.Columns[0].HeaderText = "Id";
                dgvClassesList.Columns[0].Width = 90;

                dgvClassesList.Columns[1].HeaderText = "Class Name";
                dgvClassesList.Columns[1].Width = 250;

                dgvClassesList.Columns[2].HeaderText = "Fees";
                dgvClassesList.Columns[2].Width = 150;

                dgvClassesList.Columns[3].HeaderText = "Category Name";
                dgvClassesList.Columns[3].Width = 250;

                dgvClassesList.Columns[4].HeaderText = "Allow Freeze";
                dgvClassesList.Columns[4].Width = 120;
            }

            lblRecordsCount.Text = dgvClassesList.Rows.Count.ToString();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Allow Freeze")
            {
                txtFilterValue.Visible = false;
                cbAllowFreeze.Visible = true;
                cbAllowFreeze.Focus();
                cbAllowFreeze.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (txtFilterValue.Text != "None");
                cbAllowFreeze.Visible = false;
                txtFilterValue.Visible = (cbFilterBy.Text != "None");
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

                case "Class Name":
                    FilterColumn = "ClassName";
                    break;

                case "Category Name":
                    FilterColumn = "CategoryName";
                    break;

                case "Allow Freeze":
                    FilterColumn = "AllowFreeze";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "None" || txtFilterValue.Text.Trim() == string.Empty)
            {
                _dtClassTypes.DefaultView.RowFilter = string.Empty;
                lblRecordsCount.Text = dgvClassesList.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "Id")
            {
                _dtClassTypes.DefaultView.RowFilter = string.Format("[{0}] = {1}",
                    FilterColumn, txtFilterValue.Text.Trim());
            }
            else
            {
                _dtClassTypes.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'",
                    FilterColumn, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvClassesList.Rows.Count.ToString();
        }

        private void cbAllowFreeze_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterCloumn = "AllowFreeze";
            string AllowFreezeValue = cbAllowFreeze.Text;

            switch (AllowFreezeValue)
            {
                case "All":
                    break;

                case "Yes":
                    AllowFreezeValue = "1";
                    break;

                case "No":
                    AllowFreezeValue = "0";
                    break;
            }

            if (AllowFreezeValue == "All")
                _dtClassTypes.DefaultView.RowFilter = string.Empty;
            else
                _dtClassTypes.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterCloumn,
                    AllowFreezeValue);

            lblRecordsCount.Text = dgvClassesList.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            frmAddUpdateClass frm = new frmAddUpdateClass();
            frm.ShowDialog();
            frmClassesList_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateClass frm = new frmAddUpdateClass((int)dgvClassesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmClassesList_Load(null, null);
        }

        private void ManageCategories_Click(object sender, EventArgs e)
        {
            frmManageCategories frm = new frmManageCategories();
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this class ?", "Are You Sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            ClassType classType = ClassType.find((int)dgvClassesList.CurrentRow.Cells[0].Value);

            if (classType == null) return;

            if (classType.delete(classType))
                MessageBox.Show("Class Deleted successfuly in the system", "Deleted Successfully.",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmClassesList_Load(null, null);
        }
    }
}
