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
using GMS_Desktop.Properties;
using System.IO;

namespace GMS_Desktop
{
    public partial class frmAddEditClient : Form
    {
        private enum enMode { AddNew = 1, Edit = 2 };
        private enMode _Mode;

        private Client _Client = new Client();
        private int _ClientId = -1;

        public frmAddEditClient()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditClient(int clientId)
        {
            InitializeComponent();
            _ClientId = clientId;
            _Mode = enMode.Edit;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _ResetDefaultData()
        {
            lblClientID.Text = "[???]";
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
        }

        private void _LoadData()
        {
            _Client = Client.find(_ClientId);

            if (_Client == null)
            {
                MessageBox.Show($"No Client with ID = {_ClientId}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultData();
                Close();
                return;
            }

            lblClientID.Text = _ClientId.ToString();
            txtFirstName.Text = _Client.FirstName;
            txtSecondName.Text = _Client.SecondName;
            txtThirdName.Text = _Client.ThirdName;
            txtLastName.Text = _Client.LastName;
            if (_Client.Gendor == 0)
                rbMale.Checked = true;
            else
                rbMale.Checked = true;
            dtpDateOfBirth.Value = _Client.DateOfBirth;
            txtAddress.Text = _Client.Address;
            txtPhone.Text = _Client.Phone;
            txtEmail.Text = _Client.Email;

            if (_Client.ImagePath != null)
            {
                pbImage.ImageLocation = _Client.ImagePath;
                llRemove.Visible = true;
            }
            else
            {
                if (_Client.Gendor == 0)
                {
                    pbImage.Image = Resources.Male_512;
                }
                else
                {
                    pbImage.Image = Resources.Female_512;
                }

                llRemove.Visible = false;
            }

        }

        private void frmAddEditClient_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Client";
                lblTitle.Text = this.Text;
                _ResetDefaultData();
            }
            else
            {
                this.Text = "Edit Client's Info";
                lblTitle.Text = this.Text;
                _LoadData();
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Client.FirstName = txtFirstName.Text.Trim();
            _Client.SecondName = txtSecondName.Text.Trim();
            _Client.ThirdName = txtThirdName.Text.Trim();
            _Client.LastName = txtLastName.Text.Trim();
            if (rbMale.Checked)
                _Client.Gendor = 0;
            else
                _Client.Gendor = 1;
            _Client.DateOfBirth = dtpDateOfBirth.Value;
            _Client.Address = txtAddress.Text.Trim();
            _Client.Phone = txtPhone.Text.Trim();
            _Client.Email = txtEmail.Text.Trim();
            if (pbImage.Image == Resources.Male_512 || pbImage.Image == Resources.Female_512)
                _Client.ImagePath = string.Empty;
            else
                _Client.ImagePath = pbImage.ImageLocation;
            _Client.RoleId = 3;


            if (MessageBox.Show("Are you sure want to save data?", "Are You Sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;


            if (_Mode == enMode.AddNew)
            {
                int clientId = _Client.add(_Client);

                if (clientId == -1)
                {
                    MessageBox.Show("Faild adding client", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Data saved successfully", "Added successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblClientID.Text = clientId.ToString();
            }
            else
            {
                if (!_Client.update(_Client))
                {
                    MessageBox.Show("Faild adding client", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Data saved successfully", "Added successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ValidateEmptyTextBoxes(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                txtFirstName.Focus();
                e.Cancel = true;
                errorProvider1.SetError(temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        
        private void txtPhone_Validating(object sender, CancelEventArgs e)
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

            if (!clsValidation.IsNumber(txtPhone.Text))
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == string.Empty)
                return;

            if (!clsValidation.validateEmail(txtEmail.Text))
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
    }
}
