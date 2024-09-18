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

namespace GMS_Desktop.Offers
{
    public partial class frmOfferSubscripersList : Form
    {
        private int _OfferId = -1;
        private Offer _Offer;
        private OfferClassSubscription _OfferSubscriber = new OfferClassSubscription();
        private DataTable _dtOfferSubscribersList;

        public frmOfferSubscripersList(int offerId)
        {
            InitializeComponent();
            _OfferId = offerId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOfferSubscripersList_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;

            _OfferSubscriber = OfferClassSubscription.findByOfferId(_OfferId);

            if (_OfferSubscriber == null)
            {
                MessageBox.Show("No Subscsribers with this offer " + _OfferId.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            _dtOfferSubscribersList = _OfferSubscriber.getOfferSubscripers(_OfferSubscriber);

            dgvOfferSubscribersList.DataSource = _dtOfferSubscribersList;

            if (dgvOfferSubscribersList.Rows.Count > 0)
            {
                dgvOfferSubscribersList.Columns[0].HeaderText = "Id";
                dgvOfferSubscribersList.Columns[0].Width = 120;

                dgvOfferSubscribersList.Columns[1].HeaderText = "Membership Name";
                dgvOfferSubscribersList.Columns[1].Width = 300;

                dgvOfferSubscribersList.Columns[2].HeaderText = "Subscripe Date";
                dgvOfferSubscribersList.Columns[2].Width = 150;

                dgvOfferSubscribersList.Columns[3].HeaderText = "Paid Amount";
                dgvOfferSubscribersList.Columns[3].Width = 150;

                dgvOfferSubscribersList.Columns[4].HeaderText = "Subscripe Status";
                dgvOfferSubscribersList.Columns[4].Width = 170;
            }

            lblRecordsCount.Text = dgvOfferSubscribersList.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchValue.Visible = (cbFilterBy.Text != "None");

            if (txtSearchValue.Visible)
                txtSearchValue.Focus();
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbFilterBy.Text)
            {
                case "Id":
                    FilterColumn = "Id";
                    break;

                case "Membership Name":
                    FilterColumn = "MembershipName";
                    break;

                case "Subscripe Status":
                    FilterColumn = "SubscripeStatus";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (cbFilterBy.Text == "None" || txtSearchValue.Text.Trim() == string.Empty)
            {
                _dtOfferSubscribersList.DefaultView.RowFilter = string.Empty;
                lblRecordsCount.Text = dgvOfferSubscribersList.Rows.Count.ToString();
                return;
            }

            if (cbFilterBy.Text == "Id")
            {
                _dtOfferSubscribersList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSearchValue.Text.Trim());
            }
            else
            {
                _dtOfferSubscribersList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearchValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvOfferSubscribersList.Rows.Count.ToString();
        }

        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
