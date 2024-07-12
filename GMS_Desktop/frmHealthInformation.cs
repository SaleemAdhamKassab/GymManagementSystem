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

namespace GMS_Desktop
{
    public partial class frmHealthInformation : Form
    {
        private enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode = enMode.AddNew;


        private int _HealthInformationId = -1;
        private Membership _Membership;

        public HealthForm HealthForm { get; set; }
        public int MembershipId { get; set; }
        public bool IsSaved { get; set; }

        public frmHealthInformation(int membershipId)
        {
            InitializeComponent();
            MembershipId = membershipId;

            _Mode = enMode.AddNew;
            IsSaved = false;
        }

        public frmHealthInformation(int healthInformationId, int membershipId)
        {
            InitializeComponent();
            _HealthInformationId = healthInformationId;
            MembershipId = membershipId;

            _Mode = enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmHealthInformation_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                Text = "Add Health Issue";
                lblTitle.Text = Text;
            }
            else
            {
                Text = "Edit Health Issue";
                lblTitle.Text = Text;
            }
        }

        private void _FillHeathInfo()
        {
            HealthForm.HealthIssue = txtHealthIssue.Text;
            HealthForm.EmergencyContactName = txtEmergencyName.Text;
            HealthForm.EmergencyContactPhone = txtEmargencyPhone.Text;
            HealthForm.DateFilled = DateTime.Now;
            HealthForm.MembershipId = MembershipId;
        }

        public void ResetDefaultValues()
        {
            txtHealthIssue.Text = string.Empty;
            txtEmergencyName.Text = string.Empty;
            txtEmargencyPhone.Text = string.Empty;
            IsSaved = false;
            HealthForm = null;
            MembershipId = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field(s) are requored, put the mouse on the red icon.", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.AddNew)
            {
                HealthForm = new HealthForm();
                _FillHeathInfo();

                IsSaved = true;

                MessageBox.Show("The data has been filled. The system will save the health information when you click the Save button.",
                    "Data Filled",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                HealthForm = HealthForm.find(_HealthInformationId);

                if (HealthForm == null)
                {
                    MessageBox.Show("No Health Info with Id = " + _HealthInformationId.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _FillHeathInfo();
                if (HealthForm.update(HealthForm))
                {
                    MessageBox.Show("Faild updating health information.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void txtHealthIssue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtHealthIssue.Text))
            {
                txtHealthIssue.Focus();
                e.Cancel = true;
                errorProvider1.SetError(txtHealthIssue, "This field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtHealthIssue, null);
            }
        }

        private void txtEmargencyPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmergencyName.Text) &&
                !clsValidation.IsNumber(txtEmargencyPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmargencyPhone, "Invalid Number, you have to enter valid phone number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmargencyPhone, null);
            }
        }


    }
}
