using System;
using System.Data;
using GMS_BusinessLogic;

namespace GMS_Desktop.Categories_And_Classes
{
    public partial class frmAddEditClassCategory : Form
    {
        private enum enMode { AddNew = 1, Edit = 2 }
        private enMode _Mode = enMode.AddNew;

        private ClassCategory _ClassCategory;
        private int _ID;
        public frmAddEditClassCategory()
        {
            InitializeComponent();
            Text = "Add New Category";
            lblTitle.Text = Text;

            _Mode = enMode.AddNew;
        }

        public frmAddEditClassCategory(int ID)
        {
            InitializeComponent();
            _ID = ID;
            Text = "Edit Category";
            lblTitle.Text = Text;

            _Mode = enMode.Edit;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _ResetDefaultData()
        {
            txtName.Text = string.Empty;
        }

        private void _LoadCategoryInfo()
        {
            _ClassCategory = ClassCategory.find(_ID);

            if (_ClassCategory == null)
            {
                MessageBox.Show("No category with Id = " + _ClassCategory.Id.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            txtName.Text = _ClassCategory.Name;
        }

        private void frmAddEditClassCategory_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _ResetDefaultData();
            }
            else
            {
                _LoadCategoryInfo();
            }
        }

        private void _AddNewCategory()
        {
            _ClassCategory = new ClassCategory();

            _ClassCategory.Name = txtName.Text.Trim();

            if (_ClassCategory.add(_ClassCategory) != -1)
            {
                MessageBox.Show($"Data saved successfully in the system with Id = {_ClassCategory.Id}.", "Data Saved Successfully",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            MessageBox.Show("Faild adding category.", "Faild adding category",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _AddNewCategory();
                return;
            }
            _ClassCategory.Name = txtName.Text;

            if (_ClassCategory.update(_ClassCategory))
            {
                MessageBox.Show($"Data saved successfully in the system with Id = {_ClassCategory.Id}.", "Data Saved Successfully",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            MessageBox.Show("Faild updating category.", "Faild updating category",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                txtName.Focus();
                e.Cancel = true;
                errorProvider1.SetError(txtName, "This Field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, null);
            }
        }
    }
}
