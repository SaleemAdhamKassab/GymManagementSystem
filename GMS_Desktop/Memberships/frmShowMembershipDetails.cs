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
    public partial class frmShowMembershipDetails : Form
    {
        private Membership _Membership;
        private int _MembershipId = -1;
        private ClassSubscription _ClassSubscription;
        private int _ClassSubscriptionId = -1;

        public frmShowMembershipDetails(Membership membership)
        {
            InitializeComponent();
            _Membership = membership;
            _MembershipId = membership.Id;
        }

        private void frmShowMembershipDetails_Load(object sender, EventArgs e)
        {
            dgvShowSubscribstions.DataSource = _Membership.getDetailsOfClassSubscriptionsByMembershipId(_Membership);

            if (dgvShowSubscribstions.Rows.Count > 0)
            {
                dgvShowSubscribstions.Columns[0].HeaderText = "Id";
                dgvShowSubscribstions.Columns[0].Width = 90;

                dgvShowSubscribstions.Columns[1].HeaderText = "Class Name";
                dgvShowSubscribstions.Columns[1].Width = 200;

                dgvShowSubscribstions.Columns[2].HeaderText = "Coach";
                dgvShowSubscribstions.Columns[2].Width = 300;

                dgvShowSubscribstions.Columns[3].HeaderText = "Start Date";
                dgvShowSubscribstions.Columns[3].Width = 150;

                dgvShowSubscribstions.Columns[4].HeaderText = "Expire Date";
                dgvShowSubscribstions.Columns[4].Width = 150;

                dgvShowSubscribstions.Columns[5].HeaderText = "Status";
                dgvShowSubscribstions.Columns[5].Width = 120;
            }

            lblRecordsCounts.Text = dgvShowSubscribstions.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void renewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ClassSubscriptionId = (int)dgvShowSubscribstions.CurrentRow.Cells[0].Value;
            _ClassSubscription = ClassSubscription.findById(_ClassSubscriptionId);

            if (!_ClassSubscription.isExpired(_ClassSubscription))
            {
                MessageBox.Show("The subscription is not expired yet!", "Not Expired Yet",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmRenew renew = new frmRenew(_ClassSubscriptionId);
            renew.ShowDialog();
        }
    }
}
