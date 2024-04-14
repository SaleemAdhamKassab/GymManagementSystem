using GMS_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS_Desktop
{
    public partial class frmAddNewCategory : Form
    {
        private enum enMode { addNew = 1, update = 2 }
        private enMode _mode = enMode.addNew;

        private Category _category;
        private int _categoryID;

        public frmAddNewCategory(int id)
        {
            InitializeComponent();
            _categoryID = id;
            _mode = enMode.update;
        }

        public frmAddNewCategory()
        {
            InitializeComponent();
            _mode = enMode.addNew;
        }

        private void _ResetForm()
        {
            //if (_mode == enMode.addNew)
            //{
            //    lblTitle.Text = "Add New Category";
            //    this.Text = "Add New Category";
            //    _category = new Category();
            //}
            //else
            //{
            //    lblTitle.Text = "Update Category";
            //    this.Text = "Update Category";
            //    _category = Category.find(_categoryID);
            //    if (_category != null)
            //    {
            //        txtName.Text = _category.name;
            //    }
            //    else
            //    {
            //        MessageBox.Show("The category is not Found!", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        this.Close();
            //    }
            //}
        }

        private void frmAddNewCategory_Load(object sender, EventArgs e)
        {
            _ResetForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //_category.name = txtName.Text;

            //if (_category.Save())
            //{
            //    lblID.Text = _category.id.ToString();

            //    MessageBox.Show($"Category data saved successfully in the system with ID = {_category.id}", "Success",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //else
            //{
            //    MessageBox.Show("Faild saved", "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                btnSave.Enabled = false;
                txtName.Focus();
                errorProvider1.SetError(txtName, "You have to set the category's name.");
            }
            else
            {
                btnSave.Enabled = true;
                errorProvider1.SetError(txtName, null);
            }
        }
    }
}
