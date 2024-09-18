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
        private enum enMode { AddNew = 1, AddSubscription = 2 }
        private enMode _Mode = enMode.AddNew;

        private Client _Client;
        private int _ClientId = -1;
        private ClassCategory _ClassCategory;
        private ClassType _ClassType;
        private Coach _Coach;
        private Membership _Membership;
        private PaymentMethod _PaymentMethod;
        private int _MembershipId;
        private float _TotalAmount = 0.0f;
        private List<ClassSubscription> lClassSubscriptions;
        private frmHealthInformation _FrmHealthInfo;
        private Offer _Offer;
        private List<OfferClassSubscription> lOfferClassSubscriptions;
        private float _FeeAfterDiscount = 0.0f;
        private float _TotalAmountAfterDiscount = 0.0f;

        public frmAddMembership(int clientId)
        {
            InitializeComponent();
            _ClientId = clientId;

            _Mode = enMode.AddNew;
        }

        public frmAddMembership(Membership membership)
        {
            InitializeComponent();
            _Membership = membership;
            _MembershipId = _Membership.Id;

            _Mode = enMode.AddSubscription;
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
            if (_Mode == enMode.AddNew)
                this.Text = "Add New Membership";
            else
                this.Text = "Add Subscription";

            _FillComboBoxWithCategories();
            _FillComboBoxWithPaymentMethods();
            _IntializeDataGridView();

            if (_Mode == enMode.AddNew)
            {
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
            }

            else
            {
                _Client = _Membership.ClientInfo;
            }

            lblClientName.Text = _Client.FullName;
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClasses.Enabled = cbCategories.SelectedIndex != -1;
            cbClasses.Items.Clear();
            DataTable dt = _ClassCategory.getClassTypesByClassCategoryName(cbCategories.Text);

            foreach (DataRow row in dt.Rows)
            {
                cbClasses.Items.Add(row["Name"]);
            }
        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClasses.SelectedIndex == -1) return;

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

            _FillComboBoxWithCoaches();
            _FillComboBoxWithOffers();
        }

        private void _FillComboBoxWithCoaches()
        {
            cbCoaches.Items.Clear();
            cbCoaches.Text = string.Empty;

            _Coach = new Coach();
            DataTable dt = _Coach.getAllCoachesWithOneClassByClassName(cbClasses.Text);

            if (dt.Rows.Count == 0)
                cbCoaches.Items.Add("No coach available.");

            btnAddClass.Enabled = dt.Rows.Count > 0;

            foreach (DataRow row in dt.Rows)
            {
                cbCoaches.Items.Add(row["CoachName"]);
            }
        }

        private void _FillComboBoxWithOffers()
        {
            cbOffers.Items.Clear();
            cbOffers.Text = string.Empty;
            nudDuration.Enabled = true;

            _Offer = new Offer();
            DataTable dt = _Offer.getOfferByClassName(cbClasses.Text.Trim());

            lblOffer.Visible = dt.Rows.Count > 0;
            cbOffers.Visible = lblOffer.Visible;

            if (dt.Rows.Count == 0) return;
            foreach (DataRow row in dt.Rows)
            {
                cbOffers.Items.Add(row["Name"]);
            }
        }

        private bool _IsOfferClass = false;

        private void cbOffers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOffers.SelectedIndex == -1) return;

            _Offer = Offer.find(cbOffers.Text);

            if (_Offer == null)
            {
                MessageBox.Show("No Offer with name " + cbOffers.Text, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nudDuration.Enabled = false;
            nudDuration.Value = _Offer.Duration;
            lblAfterDiscountLablel.Visible = true;
            lblAfterDiscount.Visible = true;
            _FeeAfterDiscount = _Offer.FeeAfterDicount;
            lblAfterDiscount.Text = _FeeAfterDiscount.ToString() + "$";
            _IsOfferClass = true;
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
            dgvMembershipDetails.Columns.Add("Offer", "Offer");
            dgvMembershipDetails.Columns.Add("AfterDiscount", "After Discount");
            dgvMembershipDetails.Columns.Add("CoachName", "Coach Name");

            dgvMembershipDetails.Columns[0].Width = 200;
            dgvMembershipDetails.Columns[1].Width = 150;
            dgvMembershipDetails.Columns[2].Width = 120;
            dgvMembershipDetails.Columns[3].Width = 250;
            dgvMembershipDetails.Columns[4].Width = 150;
            dgvMembershipDetails.Columns[5].Width = 300;
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

        private ClassSubscription _GetSubscriptionObject(byte duration, int paymentId, int membershipId, string coachName)
        {
            ClassSubscription classSubscription = new ClassSubscription();

            classSubscription.StartDate = DateTime.Now;
            classSubscription.ExpireDate = DateTime.Now.AddMonths(duration);
            classSubscription.PaymentId = paymentId;

            string[] splitName = coachName.Split(' ');

            _Coach = Coach.findByFullName(splitName[0], splitName[1], splitName[2], splitName[3]);
            if (_Coach == null)
            {
                MessageBox.Show($"No coach with name {coachName}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            classSubscription.CoachId = _Coach.Id;
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

        private Payment _GetPaymentObject(float amount, byte duration)
        {
            Payment payment = new Payment();

            float fees = amount * duration;

            payment.Amount = fees;
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

            if (!_IsSameClass(_ClassType.Name) || ClassSubscription.isMembershipSubscriped(_MembershipId, _ClassType.Id))
            {
                MessageBox.Show($"The membership already enrolled to the {_ClassType.Name}.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float finalFees = 0.0f;

            finalFees = cbOffers.Visible ? _FeeAfterDiscount : _ClassType.Fees;
            _TotalAmountAfterDiscount += cbOffers.Visible ? finalFees : finalFees * (int)nudDuration.Value;
            string coachName = cbCoaches.Text;

            _ShowCalculatedByLabelsAndDisplayDataGridView(finalFees, _ClassType.Fees, (int)nudDuration.Value, coachName);
            _ResetAfterEnrollementToClass();
        }

        private void _ShowCalculatedByLabelsAndDisplayDataGridView(float finalFees, float fees, int duration, string coachName)
        {
            string offerName = cbOffers.Visible ? $"{_Offer.Name} {_Offer.Discount}%" : "No offer";

            if (_IsOfferClass)
            {
                lblTotalAfterDiscount.Visible = true;
                lblTotalAfterDiscountLabel.Visible = true;
                lblAfterDisDetails.Visible = true;
                lblAfterDisDetailsLabel.Visible = true;
            }

            dgvMembershipDetails.Rows.Add(_ClassType.Name, duration.ToString() + " month",
                fees.ToString() + "$", offerName, finalFees.ToString() + "$", coachName);

            _TotalAmount += fees * duration;
            lblTotalAmount.Text = _TotalAmount.ToString() + "$";
            lblTotalAfterDiscount.Text = _TotalAmountAfterDiscount.ToString() + "$";
            lblRecordsCount.Text = dgvMembershipDetails.Rows.Count.ToString();

            lblTotalAmountDetails.Text = lblTotalAmount.Text;
            lblAfterDisDetails.Text = lblTotalAfterDiscount.Text;
        }

        private void _ResetAfterEnrollementToClass()
        {
            cbCategories.SelectedIndex = -1;
            cbClasses.SelectedIndex = -1;
            cbCoaches.SelectedIndex = -1;
            nudDuration.Value = 0.0m;
            pbClassImage.Image = Resources.cateogry_Default;
            lblClassFees.Text = "0$";
            cbOffers.Items.Clear();
            cbOffers.Text = string.Empty;
            lblOffer.Visible = false;
            cbOffers.Visible = false;
            nudDuration.Enabled = true;
            lblAfterDiscount.Visible = false;
            lblAfterDiscountLablel.Visible = false;
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
            if (MessageBox.Show("Are you sure want to add membership ?", "Are You Sure?",
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

            if (_Mode == enMode.AddNew)
                _MembershipId = _GetMembershipID();
            else
                _Membership.activatie();

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
            lOfferClassSubscriptions = new List<OfferClassSubscription>();
            string className = string.Empty, durationString = string.Empty, feesString = string.Empty,
                AfterDiscountString = string.Empty, offerName = string.Empty, coachName = string.Empty;
            byte duration = 0;
            float fees = 0.0f, feesAfterDiscount = 0.0f;
            Payment payment;
            ClassSubscription classSubscription;
            OfferClassSubscription offerClassSubscription;

            foreach (DataGridViewRow row in dgvMembershipDetails.Rows)
            {
                if (row.Cells["ClassName"].Value != null &&
                    row.Cells["Duration"].Value != null &&
                    row.Cells["Fees"].Value != null &&
                    (row.Cells["Offer"].Value != null && row.Cells["Offer"].Value.ToString() != "No offer") &&
                    row.Cells["AfterDiscount"].Value != null &&
                    row.Cells["CoachName"].Value != null)
                {
                    className = row.Cells["ClassName"].Value.ToString();
                    durationString = row.Cells["Duration"].Value.ToString().Split(' ')[0];
                    duration = byte.Parse(durationString);
                    feesString = row.Cells["Fees"].Value.ToString();
                    string feeModify = feesString.Replace("$", string.Empty);
                    fees = float.Parse(feeModify);
                    AfterDiscountString = row.Cells["AfterDiscount"].Value.ToString();
                    string afterDiscountModify = AfterDiscountString.Replace("$", string.Empty);
                    feesAfterDiscount = float.Parse(afterDiscountModify);
                    payment = _GetPaymentObject(feesAfterDiscount, duration);
                    coachName = row.Cells["CoachName"].Value.ToString();
                    classSubscription = _GetSubscriptionObject(duration, payment.Id, _MembershipId, coachName);
                    offerName = row.Cells["Offer"].Value.ToString();
                    int lastSpace = offerName.LastIndexOf(' ');
                    string offerNameModified = lastSpace != -1 ? offerName.Substring(0, lastSpace) : offerName;
                    _Offer = Offer.find(offerNameModified.Trim());
                    classSubscriptions.Add(classSubscription);

                    offerClassSubscription = getOfferClassSubscription(feesAfterDiscount, classSubscription.Id, _Offer.Id);

                    lOfferClassSubscriptions.Add(offerClassSubscription);
                }
                else
                {
                    className = row.Cells["ClassName"].Value.ToString();
                    durationString = row.Cells["Duration"].Value.ToString().Split(' ')[0];
                    duration = byte.Parse(durationString);
                    feesString = row.Cells["Fees"].Value.ToString();
                    string feeModify = feesString.Replace("$", string.Empty);
                    fees = float.Parse(feeModify);
                    payment = _GetPaymentObject(fees, duration);
                    coachName = row.Cells["coachName"].Value.ToString();
                    classSubscription = _GetSubscriptionObject(duration, payment.Id, _MembershipId, coachName);
                    classSubscriptions.Add(classSubscription);
                }
            }

            return classSubscriptions;
        }

        private OfferClassSubscription getOfferClassSubscription(float paidAmount, int classSubscriptionId, int offerId)
        {
            OfferClassSubscription offerClassSubscription = new OfferClassSubscription();

            offerClassSubscription.SubscriptionDate = DateTime.Now;
            offerClassSubscription.PaidAmount = paidAmount;
            offerClassSubscription.ClassSubscriptionId = classSubscriptionId;
            offerClassSubscription.OfferId = offerId;

            int id = -1;
            id = offerClassSubscription.add(offerClassSubscription);

            if (id == -1)
            {
                MessageBox.Show("An error occured while adding offer class subsciption", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return offerClassSubscription;
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

        private void nudDuration_Validating(object sender, CancelEventArgs e)
        {
            if (nudDuration.Value == 0)
            {
                e.Cancel = true;
                nudDuration.Focus();
                errorProvider1.SetError(nudDuration, "This field is required, set the duration");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nudDuration, null);
            }
        }

    }
}
