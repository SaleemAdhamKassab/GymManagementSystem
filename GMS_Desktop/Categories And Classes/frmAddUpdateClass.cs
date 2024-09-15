using System;
using System.Data;
using GMS_BusinessLogic;
using GMS_Desktop.Properties;

namespace GMS_Desktop.Classes
{
    public partial class frmAddUpdateClass : Form
    {
        private enum enMode { AddNew = 1, Edit = 2 }
        private enMode _Mode = enMode.AddNew;
        private ClassType _ClassType;
        private int _Id = -1;

        public frmAddUpdateClass()
        {
            InitializeComponent();

            Text = "Add New Class";
            lblTitle.Text = Text;

            _Mode = enMode.AddNew;
        }
        public frmAddUpdateClass(int Id)
        {
            InitializeComponent();
            _Id = Id;

            Text = "Edit Class Info";
            lblTitle.Text = Text;

            _Mode = enMode.Edit;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _FillCategories()
        {
            ClassCategory category = new ClassCategory();
            DataTable dt = category.get();

            foreach (DataRow row in dt.Rows)
            {
                cbCategories.Items.Add(row["Name"]);
            }
        }

        private void _LoadClassInfo()
        {
            _ClassType = ClassType.find(_Id);

            if (_ClassType == null)
            {
                MessageBox.Show("No class with Id = " + _Id.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            _FillCategories();
            cbCategories.SelectedIndex = cbCategories.FindString(_ClassType.CategoryInfo.Name);
            txtClassName.Text = _ClassType.Name;
            nudFees.Value = (decimal)_ClassType.Fees;
            rbYes.Checked = _ClassType.AllowFreeze ? true : false;
            rbNo.Checked = _ClassType.AllowFreeze ? false : true;
            if (_ClassType.ImagePath == null)
            {
                pbClassImage.Image = Resources.cateogry_Default;
                llRemove.Visible = false;
            }
            else
            {
                pbClassImage.ImageLocation = _ClassType.ImagePath;
                llRemove.Visible = true;
            }
        }

        private void _ResetDefaulInfo()
        {
            _FillCategories();
            txtClassName.Text = string.Empty;
            nudFees.Value = 0.0m;
            rbYes.Checked = false;
            rbNo.Checked = true;
            pbClassImage.Image = Resources.cateogry_Default;
            llRemove.Visible = false;
        }

        private void frmAddUpdateClass_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _ResetDefaulInfo();
            }
            else
            {
                _LoadClassInfo();
            }
        }

        private void _AddNewClass()
        {
            _ClassType = new ClassType();

            _ClassType.CategoryId = ClassCategory.find(cbCategories.Text.Trim()).Id;
            _ClassType.Name = txtClassName.Text.Trim();
            _ClassType.Fees = (float)nudFees.Value;
            _ClassType.AllowFreeze = rbYes.Checked ? true : false;
            if (pbClassImage.Image == Resources.cateogry_Default)
                _ClassType.ImagePath = null;
            else
                _ClassType.ImagePath = pbClassImage.ImageLocation;

            if (_ClassType.add(_ClassType) == -1)
            {
                MessageBox.Show("Filed adding class.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Class added successfully in the system with Id = " +
                _ClassType.Id.ToString(), "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            _ResetDefaulInfo();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some field(s) are valid!, put the mouse on the red icon to show the error.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.AddNew)
            {
                _AddNewClass();
                return;
            }

            _ClassType.CategoryId = ClassCategory.find(cbCategories.Text.Trim()).Id;
            _ClassType.Name = txtClassName.Text.Trim();
            _ClassType.Fees = (float)nudFees.Value;
            _ClassType.AllowFreeze = rbYes.Checked ? true : false;
            if (pbClassImage.Image == Resources.cateogry_Default)
                _ClassType.ImagePath = null;
            else
                _ClassType.ImagePath = pbClassImage.ImageLocation;

            if (_ClassType.update(_ClassType))
            {
                MessageBox.Show("Data saved successfully in the system with Id = " + _ClassType.Id.ToString(), "Saved successfully",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            MessageBox.Show("Failed updating info with Id = " + _ClassType.Id.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
            return;
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbClassImage.Load(selectedFilePath);
                llRemove.Visible = true;
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbClassImage.Image = Resources.cateogry_Default;
            llRemove.Visible = false;
        }

        private void cbCategories_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbCategories.SelectedIndex == -1)
            {
                cbCategories.Focus();
                e.Cancel = true;
                errorProvider1.SetError(cbCategories, "This fieled is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbCategories, null);
            }
        }

        private void txtClassName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassName.Text))
            {
                txtClassName.Focus();
                e.Cancel = true;
                errorProvider1.SetError(txtClassName, "This fieled is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtClassName, null);
            }
        }

        private void nudFees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (nudFees.Value == 0)
            {
                nudFees.Focus();
                e.Cancel = true;
                errorProvider1.SetError(nudFees, "This fieled is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nudFees, null);
            }
        }
    }
}
