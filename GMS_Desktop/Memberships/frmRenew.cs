using GMS_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS_Desktop
{
    public partial class frmRenew : Form
    {
        private int _ClassSubscriptionId = -1;
        private ClassSubscription _ClassSubscription;
        private Payment _Payment;
        private ClassType _ClassType;
        private PaymentMethod _PaymentMethod;
        private float _Fees;
        private Offer _Offer;
        private float _AfterDiscount = 0.0f;
        private int _OfferId = -1;

        public frmRenew(int classSubscriptionId)
        {
            InitializeComponent();
            _ClassSubscriptionId = classSubscriptionId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private bool _CheckIsThereOffers()
        {
            cbOffers.Items.Clear();
            cbOffers.Text = string.Empty;

            _Offer = new Offer();

            DataTable dt = _Offer.getOfferByClassName(_ClassSubscription.CoachInfo.ClassTypeInfo.Name);

            if (dt.Rows.Count == 0) return false;

            foreach (DataRow row in dt.Rows)
            {
                cbOffers.Items.Add(row["Name"]);
            }

            return true;
        }

        private void frmRenew_Load(object sender, EventArgs e)
        {
            _ClassSubscription = ClassSubscription.findById(_ClassSubscriptionId);

            if (_ClassSubscription == null)
            {
                MessageBox.Show("No Class subscriotion with Id = " + _ClassSubscriptionId.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            _FillComboBoxWithPaymentMethods();

            pnlOffer.Visible = _CheckIsThereOffers() ? true : false;
        }

        private void cbOffers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbNo.Checked)
                return;

            _Offer = Offer.find(cbOffers.Text);

            if (_Offer == null)
            {
                MessageBox.Show("No Offer With Name " + cbOffers.Text, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAfterDiscountLabel.Visible = true;
            lblAfterDiscountValue.Visible = true;
            lblAfterDiscountValue.Text = _Offer.FeeAfterDicount.ToString() + "$";
            _AfterDiscount = _Offer.FeeAfterDicount;
            _OfferId = _Offer.Id;
            nudDuration.Value = _Offer.Duration;
            nudDuration.Enabled = false;
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            cbOffers.Enabled = true;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            cbOffers.SelectedIndex = -1;
            cbOffers.Enabled = false;
            nudDuration.Value = 0;
            nudDuration.Enabled = true;
        }

        private void nudDuration_ValueChanged(object sender, EventArgs e)
        {
            if (nudDuration.Value == 0)
                return;

            _ClassType = ClassType.find(_ClassSubscription.CoachId);

            _Fees = _ClassType.Fees * (int)nudDuration.Value;

            lblFees.Text = _Fees.ToString() + "$";


        }

        private int _GetPaymentId()
        {
            int paymentId = -1;

            _Payment = new Payment();
            _Payment.Date = DateTime.Now;
            _Payment.Amount = _ClassType.Fees * (int)nudDuration.Value;

            _PaymentMethod = PaymentMethod.find(cbPaymentMothods.Text);

            if (_PaymentMethod == null)
            {
                MessageBox.Show("No Method name " + cbPaymentMothods.Text, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            _Payment.PaymentMethodId = _PaymentMethod.Id;

            paymentId = _Payment.add(_Payment);

            if (paymentId == -1)
            {
                MessageBox.Show("Faild adding payment", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            return paymentId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fieled(s) are not valid, put the mouse on the red icon to see the error.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to renewal?", "Are You Sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                return;
            }

            _ClassSubscription.StartDate = DateTime.Now;
            _ClassSubscription.ExpireDate = DateTime.Now.AddMonths((int)nudDuration.Value);
            _ClassSubscription.PaymentId = _GetPaymentId();
            _ClassSubscription.MembershipInfo.activatie();

            if (_ClassSubscription.renew(_ClassSubscription))
            {
                _AddNewOfferSubscription();
                MessageBox.Show("The class subscription has been successfully renewed. Subscription ID: " + _ClassSubscriptionId.ToString(), "Renewal Successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred during the class subscription renewal process.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool _AddNewOfferSubscription()
        {

            OfferClassSubscription offerClassSubscription = new OfferClassSubscription();

            offerClassSubscription.SubscriptionDate = DateTime.Now;
            offerClassSubscription.PaidAmount = _AfterDiscount;
            offerClassSubscription.ClassSubscriptionId = _ClassSubscriptionId;
            offerClassSubscription.OfferId = _OfferId;

            offerClassSubscription.add(offerClassSubscription);

            if (offerClassSubscription.Id == -1)
            {
                MessageBox.Show("An error occured while adding the offer subscription", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void nudDuration_Validating(object sender, CancelEventArgs e)
        {
            if (nudDuration.Value == 0)
            {
                e.Cancel = true;
                nudDuration.Focus();
                errorProvider1.SetError(nudDuration, "You have to set the duration of month");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nudDuration, null);
            }
        }

        private void cbPaymentMothods_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbPaymentMothods.Text))
            {
                e.Cancel = true;
                cbPaymentMothods.Focus();
                errorProvider1.SetError(cbPaymentMothods, "This fieled is required, please select the method of payment");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbPaymentMothods, null);
            }
        }

        
    }
}
