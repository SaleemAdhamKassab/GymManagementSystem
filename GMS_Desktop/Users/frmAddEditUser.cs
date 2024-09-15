using System;
using System.Data;
using System.Windows.Forms;
using GMS_BusinessLogic;
using GMS_Desktop.Properties;

namespace GMS_Desktop.Users
{
    public partial class frmAddEditUser : Form
    {
        private enum enMode { AddNew = 1, Edit = 2 }
        private enMode _Mode = enMode.AddNew;

        private User _User;
        private int _UserId;

        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditUser(int userId)
        {
            InitializeComponent();
            _UserId = userId;

            _Mode = enMode.Edit;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _ResetDefaulValues()
        {
            txtFirstName.Text = string.Empty;
            txtSecondName.Text = string.Empty;
            txtThirdName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            rbMale.Checked = true;
            dtpDateOfBirth.Value = DateTime.Now;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            pbImage.Image = Resources.Male_512;
            llRemove.Visible = false;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            rbIsAdminNo.Checked = true;
            rbIsAdminYes.Checked = false;
            if (_Mode == enMode.AddNew)
            {
                Text = "Add New User";
                lblTitle.Text = Text;
            }
            else
            {
                Text = "Edit User";
                lblTitle.Text = Text;
                _LoadDate();
            }
        }

        private void _LoadDate()
        {
            _User = User.findByUserId(_UserId);

            if (_User == null)
            {
                MessageBox.Show("No User with Id = " + _UserId.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            txtFirstName.Text = _User.FirstName;
            txtSecondName.Text = _User.SecondName;
            txtThirdName.Text = _User.ThirdName;
            txtLastName.Text = _User.LastName;
            rbMale.Checked = _User.Gendor == 0 ? true : false;
            rbFemale.Checked = _User.Gendor == 1 ? true : false;
            dtpDateOfBirth.Value = _User.DateOfBirth;
            txtEmail.Text = _User.Email;
            txtAddress.Text = _User.Address;
            txtPhone.Text = _User.Phone;
            if (_User.ImagePath != null)
            {
                llRemove.Visible = true;
                pbImage.ImageLocation = _User.ImagePath;
            }
            else
            {
                llRemove.Visible = false;
                pbImage.Image = _User.Gendor == 0 ? Resources.Male_512 : Resources.Female_512;
            }

            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            if (_User.IsAdmin)
                rbIsAdminYes.Checked = true;
            else
                rbIsAdminNo.Checked = false;
            ckbIsActive.Checked = _User.IsActive;
        }



        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefaulValues();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbImage.Load(selectedFilePath);
                llRemove.Visible = true;
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = string.Empty;

            if (rbMale.Checked)
                pbImage.Image = Resources.Male_512;
            else
                pbImage.Image = Resources.Female_512;

            llRemove.Visible = false;
        }

        private void _EditUser()
        {
            if (MessageBox.Show("Are you sure you want to perform this transaction ?", "Are You Sure?",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            _User.FirstName = txtFirstName.Text.Trim();
            _User.SecondName = txtSecondName.Text.Trim();
            _User.ThirdName = txtThirdName.Text.Trim();
            _User.LastName = txtLastName.Text.Trim();
            _User.Gendor = rbMale.Checked ? (byte)0 : (byte)1;
            _User.DateOfBirth = dtpDateOfBirth.Value;
            _User.Address = txtAddress.Text.Trim();
            _User.Phone = txtPhone.Text.Trim();
            _User.Email = txtEmail.Text.Trim();
            _User.ImagePath = (pbImage.Image == Resources.Male_512 ||
            pbImage.Image == Resources.Female_512) ? null : pbImage.ImageLocation;
            _User.UserName = txtUserName.Text.Trim();
            _User.IsAdmin = false;
            _User.Password = txtConfirmPassword.Text.Trim();
            _User.IsAdmin = rbIsAdminYes.Checked ? true : false;
            _User.IsActive = ckbIsActive.Checked;
            if (_User.update(_User))
            {
                MessageBox.Show("Data saved successfully in the system", "Data Saved Successfully",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            else
            {
                MessageBox.Show("An error occured while updating data", "Faild Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _AddNew()
        {
            if (MessageBox.Show("Are you sure you want to perform this transaction ?", "Are You Sure?",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            _User = new User();

            _User.FirstName = txtFirstName.Text.Trim();
            _User.SecondName = txtSecondName.Text.Trim();
            _User.ThirdName = txtThirdName.Text.Trim();
            _User.LastName = txtLastName.Text.Trim();
            _User.Gendor = rbMale.Checked ? (byte)0 : (byte)1;
            _User.DateOfBirth = dtpDateOfBirth.Value;
            _User.Address = txtAddress.Text.Trim();
            _User.Phone = txtPhone.Text.Trim();
            _User.Email = txtEmail.Text.Trim();
            _User.ImagePath = (pbImage.Image == Resources.Male_512 ||
            pbImage.Image == Resources.Female_512) ? null : pbImage.ImageLocation;
            _User.UserName = txtUserName.Text.Trim();
            _User.IsAdmin = rbIsAdminYes.Checked ? true : false;
            _User.Password = txtConfirmPassword.Text.Trim();
            _User.IsActive = ckbIsActive.Checked;

            if (_User.add(_User) != -1)
            {
                MessageBox.Show("Data saved successfully in the system", "Data Saved Successfully",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("An error occured while adding the user", "Faild Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field(s) are invalid, put the mouse on the red icon to show the error.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.AddNew)
                _AddNew();
            else
                _EditUser();
        }

        private void TextBoxes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, "This fieled is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, null);
            }
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == string.Empty)
                return;

            if (!Global.clsValidation.validateEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Invalid email address format");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                txtPhone.Focus();
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "This field is requird!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, null);
            }

            if (!Global.clsValidation.IsNumber(txtPhone.Text))
            {
                txtPhone.Focus();
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "Invalid phone number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, null);
            }
        }

        private void dtpDateOfBirth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dtpDateOfBirth.Value > DateTime.Now.AddYears(-18))
            {
                e.Cancel = true;
                dtpDateOfBirth.Focus();
                errorProvider1.SetError(dtpDateOfBirth, "The user's age should be 18 or greater.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtpDateOfBirth, null);
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "This field is required!");
            }
            else
            {
                e.Cancel = false;  
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "The password confirmation field should be maching with password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError (txtConfirmPassword, null);
            }

        }
    }
}
