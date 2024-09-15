using System;
using System.Data;
using GMS_BusinessLogic;

namespace GMS_Desktop.Categories_And_Classes
{
    public partial class frmManageCategories : Form
    {
        private ClassCategory _ClassCategories;
        private DataTable _dtCategoriesList;

        public frmManageCategories()
        {
            InitializeComponent();
        }

        private void frmManageCategories_Load(object sender, EventArgs e)
        {
            _ClassCategories = new ClassCategory();
            _dtCategoriesList = _ClassCategories.get();

            dgvCategoriesList.DataSource = _dtCategoriesList;

            if (dgvCategoriesList.Rows.Count > 0)
            {
                dgvCategoriesList.Columns[0].HeaderText = "Id";
                dgvCategoriesList.Columns[0].Width = 100;

                dgvCategoriesList.Columns[1].HeaderText = "Name";
                dgvCategoriesList.Columns[1].Width = 300;
            }

            lblRecordsCount.Text = dgvCategoriesList.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            frmAddEditClassCategory frm = new frmAddEditClassCategory();
            frm.ShowDialog();
            frmManageCategories_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditClassCategory frm = new frmAddEditClassCategory((int)dgvCategoriesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageCategories_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this category ?", "Are You Sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            ClassCategory classCategory = ClassCategory.find((int)dgvCategoriesList.CurrentRow.Cells[0].Value);
            if (classCategory.delete(classCategory.Id))
            {
                MessageBox.Show("The category deleted successfully in the system", "Deleted Successfully.",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmManageCategories_Load(null, null);
                return;
            }

            MessageBox.Show("Faild deleting the category.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
