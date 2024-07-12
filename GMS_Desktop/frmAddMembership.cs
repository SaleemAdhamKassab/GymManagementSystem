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

namespace GMS_Desktop
{
    public partial class frmAddMembership : Form
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;

        private Client _Client;
        private int _ClientId = -1;
        private ClassCategory _ClassCategory;
        private ClassType _ClassType;
        private Membership _Membership;
        private PaymentMethod _PaymentMethod;
        private int _MembershipId;
        private float _TotalAmount = 0.0f;
        private List<ClassSubscription> lClassSubscriptions;
        private frmHealthInformation _FrmHealthInfo;

        public frmAddMembership(int clientId)
        {
            InitializeComponent();
            _ClientId = clientId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _ResetDefaulValues()
        {
            cbCategories.SelectedIndex = -1;
            cbClasses.SelectedIndex = -1;
            cbCoaches.SelectedIndex = -1;
            cbPaymentMothods.SelectedIndex = -1;
            nudDuration.Value = 0.0m;
            pbClassImage.Image = Resources.cateogry_Default;
            lblTotalAmount.Text = "0$";
            lblClassFees.Text = "0$";
            rbNoHealthInfo.Checked = true;
            llHealthInforamtionLink.Enabled = false;
            lblRecordsCount.Text = "0";
            dgvMembershipDetails.Rows.Clear();

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

        private void _FillComboBoxWithPaymentMethods()
        {
            _PaymentMethod = new PaymentMethod();

            DataTable dt = _PaymentMethod.get();

            foreach (DataRow row in dt.Rows)
            {
                cbPaymentMothods.Items.Add(row["Name"]);
            }
        }

        private void frmAddMembership_Load(object sender, EventArgs e)
        {
            _FillComboBoxWithCategories();
            _FillComboBoxWithPaymentMethods();
            _IntializeDataGridView();

            _Client = Client.find(_ClientId);

            if (_Client == null)
            {
                MessageBox.Show("No client with Id = " + _ClientId, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            Membership membership = Membership.findByClientId(_ClientId);

            if (membership != null)
            {
                MessageBox.Show("The client already has membership with Id = " + membership.Id, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lblClientName.Text = _Client.FullName;
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClasses.Enabled = cbCategories.SelectedIndex != -1;
            cbClasses.Items.Clear();
            DataTable dt = _ClassCategory.getClassTypesByClassCategorName(cbCategories.Text);

            foreach (DataRow row in dt.Rows)
            {
                cbClasses.Items.Add(row["Name"]);
            }
        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCoaches.Enabled = cbClasses.Text != string.Empty;
            _ClassType = ClassType.find(cbClasses.Text);

            if (_ClassType == null)
            {
                MessageBox.Show($"No {cbClasses.Text} Class avalable.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pbClassImage.ImageLocation = _ClassType.ImagePath;
            lblClassFees.Text = _ClassType.Fees.ToString() + "$";
            nudDuration.Value = 1;
        }

        private void cbPaymentMothods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaymentMothods.SelectedIndex == -1)
                return;

            _PaymentMethod = PaymentMethod.find(cbPaymentMothods.Text);

            if (_PaymentMethod == null)
            {
                MessageBox.Show("No Payment method with name = " + cbPaymentMothods.Text, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _IntializeDataGridView()
        {
            dgvMembershipDetails.Columns.Add("ClassName", "Class Name");
            dgvMembershipDetails.Columns.Add("Duration", "Duration");
            dgvMembershipDetails.Columns.Add("Fees", "Fees");

            dgvMembershipDetails.Columns[0].Width = 300;
            dgvMembershipDetails.Columns[1].Width = 150;
            dgvMembershipDetails.Columns[2].Width = 150;
        }

        private int _GetMembershipID()
        {
            _Membership = new Membership();

            _Membership.DateOfBelong = DateTime.Now;

            _Membership.ClientId = _Client.ClientId;
            int membershipId = _Membership.add(_Membership);

            if (membershipId == -1)
            {
                MessageBox.Show("An error occourred while add membership!", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            return membershipId;
        }

        private ClassSubscription _GetSubscriptionObject(string className, byte duration, int paymentId, int membershipId)
        {
            ClassSubscription classSubscription = new ClassSubscription();

            classSubscription.StartDate = DateTime.Now;
            classSubscription.ExpireDate = DateTime.Now.AddMonths(duration);
            classSubscription.PaymentId = paymentId;

            ClassType classType = ClassType.find(className);

            classSubscription.ClassTypeId = classType.Id;
            classSubscription.MembershipId = membershipId;

            int classSubscripId = classSubscription.add(classSubscription);

            if (classSubscripId == -1)
            {
                MessageBox.Show("An error occured while subscription", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return classSubscription;
        }

        private Payment _GetPaymentObject(float amount)
        {
            Payment payment = new Payment();

            payment.Amount = amount;
            payment.Date = DateTime.Now;

            payment.PaymentMethodId = _PaymentMethod.Id;

            int paymentId = payment.add(payment);

            if (paymentId == -1)
            {
                MessageBox.Show("An Error occurred when adding payment", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return payment;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon(s) to see the error", "Validation Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_IsSameClass(_ClassType.Name))
            {
                MessageBox.Show($"The membership already enrolled to the {_ClassType.Name}.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float fees = _ClassType.Fees;
            _TotalAmount += fees;
            dgvMembershipDetails.Rows.Add(_ClassType.Name, nudDuration.Value, fees);
            lblRecordsCount.Text = dgvMembershipDetails.Rows.Count.ToString();
            lblTotalAmount.Text = _TotalAmount.ToString() + "$";
            _ResetAfterEnrollementToClass();
        }

        private void _ResetAfterEnrollementToClass()
        {
            cbCategories.SelectedIndex = -1;
            cbClasses.SelectedIndex = -1;
            cbCoaches.SelectedIndex = -1;
            nudDuration.Value = 0.0m;
            pbClassImage.Image = Resources.cateogry_Default;
            lblClassFees.Text = "0$";
        }


        private bool _IsSameClass(string className)
        {
            foreach (DataGridViewRow row in dgvMembershipDetails.Rows)
            {
                if (row.Cells["ClassName"].Value != null
                    && row.Cells["ClassName"].Value.ToString() == className)
                    return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to add membership?", "Are You Sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (dgvMembershipDetails.Rows.Count == 0)
            {
                MessageBox.Show("You are not enrolled in any classes. Please select a class to enroll.",
                    "Enrollment Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cbPaymentMothods.Text.Trim()))
            {
                MessageBox.Show("Please select the payment method",
                    "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbPaymentMothods.Focus();
                return;
            }

            _MembershipId = _GetMembershipID();

            if (_FrmHealthInfo != null && _FrmHealthInfo.IsSaved)
            {
                _FrmHealthInfo.HealthForm.MembershipId = _MembershipId;
                int healthInfoId = -1;
                healthInfoId = _FrmHealthInfo.HealthForm.add(_FrmHealthInfo.HealthForm);

                if (healthInfoId == -1)
                {
                    _Membership.delete(_Membership);
                    MessageBox.Show("Faild adding Infomation health", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _FrmHealthInfo.ResetDefaultValues();
            }

            lClassSubscriptions = _LoadSubscriptionClassesFromDataGridView();

            if (lClassSubscriptions != null)
            {
                if (MessageBox.Show($"The membership added successfully in the system with Id = {_MembershipId}", "Information Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Close();
                }
                if (_FrmHealthInfo != null)
                    _ResetDefaulValues();
            }
            else
            {
                MessageBox.Show("Faild adding membership", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private List<ClassSubscription> _LoadSubscriptionClassesFromDataGridView()
        {
            List<ClassSubscription> classSubscriptions = new List<ClassSubscription>();

            foreach (DataGridViewRow row in dgvMembershipDetails.Rows)
            {
                if (row.Cells["ClassName"].Value != null &&
                    row.Cells["Duration"].Value != null &&
                    row.Cells["Fees"].Value != null)
                {
                    string className = row.Cells["ClassName"].Value.ToString();
                    byte duration = Convert.ToByte(row.Cells["Duration"].Value);
                    float fees = Convert.ToSingle(row.Cells["Fees"].Value);
                    Payment payment = _GetPaymentObject(fees);
                    ClassSubscription classSubscription = _GetSubscriptionObject(className, duration, payment.Id, _MembershipId);

                    classSubscriptions.Add(classSubscription);
                }
            }

            return classSubscriptions;
        }

        private void ValidateEmptyComboBoxes_Validating(object sender, CancelEventArgs e)
        {
            ComboBox temp = (ComboBox)sender;

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(temp, null);
            }
        }

        private void llHealthInforamtionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _FrmHealthInfo = new frmHealthInformation(_MembershipId);
            _FrmHealthInfo.ShowDialog();
            llHealthInforamtionLink.Enabled = !_FrmHealthInfo.IsSaved;
            rbNoHealthInfo.Enabled = !_FrmHealthInfo.IsSaved;
        }

        private void rbYesHealthInfo_CheckedChanged(object sender, EventArgs e)
        {
            llHealthInforamtionLink.Enabled = rbYesHealthInfo.Checked;
        }
    }
}
