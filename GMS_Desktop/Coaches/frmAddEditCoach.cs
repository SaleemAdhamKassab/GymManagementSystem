using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using GMS_BusinessLogic;
using GMS_BusinessLogic.Categories;
using GMS_Desktop.Properties;

namespace GMS_Desktop.Coaches
{
    public partial class frmAddEditCoach : Form
    {
        private enum enMode { AddNew = 1, Edit = 2 };
        private enMode _Mode = enMode.AddNew;

        private Coach _Coach;
        private int _CoachId;

        private ClassCategory _ClassCategory;
        private ClassType _ClassType;
        public frmAddEditCoach()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditCoach(int coachId)
        {
            InitializeComponent();
            _CoachId = coachId;

            _Mode = enMode.Edit;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _ResetDefaultData()
        {
            lblCoachId.Text = "[???]";
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
            txtAchAndAwards.Text = string.Empty;
            cbCategories.Items.Clear();
            cbClasses.Items.Clear();

            _FillComboBoxWithCategories();

            if (_Mode == enMode.AddNew)
            {
                Text = "Add New Coach";
                lblTitle.Text = Text;
            }
            else
            {
                Text = "Edit Coach";
                lblTitle.Text = Text;
                _LoadData();
            }
        }

        private void _LoadData()
        {
            _Coach = Coach.findById(_CoachId);

            if (_Coach == null)
            {
                MessageBox.Show("No coach with Id = " + _CoachId.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lblCoachId.Text = _Coach.Id.ToString();
            txtFirstName.Text = _Coach.FirstName;
            txtSecondName.Text = _Coach.SecondName;
            txtThirdName.Text = _Coach.ThirdName;
            txtLastName.Text = _Coach.LastName;
            rbMale.Checked = _Coach.Gendor == 0 ? true : false;
            rbFemale.Checked = _Coach.Gendor == 1 ? true : false;
            dtpDateOfBirth.Value = _Coach.DateOfBirth;
            txtEmail.Text = _Coach.Email;
            txtAddress.Text = _Coach.Address;
            txtPhone.Text = _Coach.Phone;
            if (_Coach.ImagePath != null)
            {
                pbImage.ImageLocation = _Coach.ImagePath;
                llRemove.Visible = true;
            }
            else
            {
                pbImage.Image = _Coach.Gendor == 0 ? Resources.Male_512 : Resources.Female_512;
                llRemove.Visible = false;
            }
            txtAchAndAwards.Text = _Coach.AchievementsAndAwards;
            cbCategories.SelectedIndex = cbCategories.FindString(_Coach.ClassTypeInfo.CategoryInfo.Name);
            cbClasses.SelectedIndex = cbClasses.FindString(_Coach.ClassTypeInfo.Name);
            ckbIsActive.Checked = _Coach.IsActive ? true : false;
        }

        private void _FillComboBoxWithCategories()
        {
            _ClassCategory = new ClassCategory();

            DataTable dt = _ClassCategory.get();

            foreach (DataRow row in dt.Rows)
            {
                cbCategories.Items.Add(row["Name"]);
            }
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClasses.Enabled = cbCategories.SelectedIndex != -1;
            cbClasses.Items.Clear();

            _ClassCategory = new ClassCategory();

            DataTable dt = _ClassCategory.getClassTypesByClassCategoryName(cbCategories.Text);

            foreach (DataRow row in dt.Rows)
            {
                cbClasses.Items.Add(row["Name"]);
            }
        }

        private void frmAddEditCoach_Load(object sender, EventArgs e)
        {
            _ResetDefaultData();
        }

        private void _AddNewCoach()
        {
            if (MessageBox.Show("Are you sure you want to perform this operation ?", "Are You Sure ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            _Coach = new Coach();

            _Coach.FirstName = txtFirstName.Text.Trim();
            _Coach.SecondName = txtSecondName.Text.Trim();
            _Coach.ThirdName = txtThirdName.Text.Trim();
            _Coach.LastName = txtLastName.Text.Trim();
            _Coach.Gendor = rbMale.Checked ? (byte)0 : (byte)1;
            _Coach.DateOfBirth = dtpDateOfBirth.Value;
            _Coach.Address = txtAddress.Text.Trim();
            _Coach.Phone = txtPhone.Text.Trim();
            _Coach.Email = txtEmail.Text.Trim();
            _Coach.ImagePath = (pbImage.Image == Resources.Male_512 ||
            pbImage.Image == Resources.Female_512) ? null : pbImage.ImageLocation;
            _Coach.RoleId = 4;
            _Coach.AchievementsAndAwards = txtAchAndAwards.Text.Trim();
            _Coach.IsActive = ckbIsActive.Checked;
            _Coach.ClassTypeId = ClassType.find(cbClasses.Text).Id;

            if (_Coach.add(_Coach) != -1)
            {
                lblCoachId.Text = _Coach.Id.ToString();
                MessageBox.Show($"Data saved successfully in the system with Id = {_Coach.Id}", "Saved Successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultData();
                Close();
                return;
            }

            MessageBox.Show($"Faild perform this operation", "Faild performing",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _Edit()
        {
            if (MessageBox.Show("Are you sure you want to perform this operation ?", "Are You Sure ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            _Coach.FirstName = txtFirstName.Text.Trim();
            _Coach.SecondName = txtSecondName.Text.Trim();
            _Coach.ThirdName = txtThirdName.Text.Trim();
            _Coach.LastName = txtLastName.Text.Trim();
            _Coach.Gendor = rbMale.Checked ? (byte)0 : (byte)1;
            _Coach.DateOfBirth = dtpDateOfBirth.Value;
            _Coach.Address = txtAddress.Text.Trim();
            _Coach.Phone = txtPhone.Text.Trim();
            _Coach.Email = txtEmail.Text.Trim();
            _Coach.ImagePath = (pbImage.Image == Resources.Male_512 ||
            pbImage.Image == Resources.Female_512) ? null : pbImage.ImageLocation;
            _Coach.RoleId = 4;
            _Coach.AchievementsAndAwards = txtAchAndAwards.Text.Trim();
            _Coach.IsActive = ckbIsActive.Checked;
            _Coach.ClassTypeId = ClassType.find(cbClasses.Text).Id;

            if (_Coach.update(_Coach))
            {
                MessageBox.Show($"Data saved successfully in the system with Id = {_Coach.Id}", "Saved Successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultData();
                Close();
                return;
            }

            MessageBox.Show($"Faild perform this operation", "Faild performing",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                _AddNewCoach();

            else
                _Edit();
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

        private void PhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
        private void Email_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == string.Empty)
                return;

            if (!Global.clsValidation.validateEmail(txtEmail.Text))
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

        private void dtpDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDateOfBirth.Value > DateTime.Now.AddYears(-18))
            {
                e.Cancel = true;
                dtpDateOfBirth.Focus();
                errorProvider1.SetError(dtpDateOfBirth, "The coach's age should be 18 or greater.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtpDateOfBirth, null);
            }
        }

        private void cbCategories_Validating(object sender, CancelEventArgs e)
        {
            if (cbCategories.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbCategories.Focus();
                errorProvider1.SetError(cbCategories, "This fieled is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbCategories, null);
            }
        }

        private void cbClasses_Validating(object sender, CancelEventArgs e)
        {
            if (cbClasses.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbClasses.Focus();
                errorProvider1.SetError(cbClasses, "This fieled is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbClasses, null);
            }
        }
    }
}
