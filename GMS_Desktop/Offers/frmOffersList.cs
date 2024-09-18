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
    public partial class frmOffersList : Form
    {
        private Offer _Offer;
        private DataTable _dtOfferList;
        private bool _ShowScreen = true;

        public frmOffersList(bool isAdmin)
        {
            InitializeComponent();
            _ShowScreen = isAdmin;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOffersList_Load(object sender, EventArgs e)
        {
            if (!_ShowScreen)
            {
                MessageBox.Show("Access denied!, you haven't permission in this screen Contact your Admin", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            cbFilterBy.SelectedIndex = 0;

            _Offer = new Offer();

            _dtOfferList = _Offer.get();
            dgvOffersList.DataSource = _dtOfferList;

            if (dgvOffersList.Rows.Count > 0)
            {
                dgvOffersList.Columns[0].HeaderText = "Id";
                dgvOffersList.Columns[0].Width = 90;

                dgvOffersList.Columns[1].HeaderText = "Offer Name";
                dgvOffersList.Columns[1].Width = 250;

                dgvOffersList.Columns[2].HeaderText = "Class Name";
                dgvOffersList.Columns[2].Width = 180;

                dgvOffersList.Columns[3].HeaderText = "Discount";
                dgvOffersList.Columns[3].Width = 100;

                dgvOffersList.Columns[4].HeaderText = "Duration";
                dgvOffersList.Columns[4].Width = 100;

                dgvOffersList.Columns[5].HeaderText = "Start Date";
                dgvOffersList.Columns[5].Width = 135;

                dgvOffersList.Columns[6].HeaderText = "End Date";
                dgvOffersList.Columns[6].Width = 135;

                dgvOffersList.Columns[7].HeaderText = "Added On";
                dgvOffersList.Columns[7].Width = 135;

                dgvOffersList.Columns[8].HeaderText = "After Discount";
                dgvOffersList.Columns[8].Width = 140;
            }

            lblRecordsCount.Text = dgvOffersList.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (cbFilterBy.Visible)
                txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbFilterBy.Text)
            {
                case "Id":
                    FilterColumn = "Id";
                    break;

                case "Offer Name":
                    FilterColumn = "OfferName";
                    break;

                case "Class Name":
                    FilterColumn = "ClassName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (FilterColumn == "None" || txtFilterValue.Text.Trim() == string.Empty)
            {
                _dtOfferList.DefaultView.RowFilter = string.Empty;
                lblRecordsCount.Text = dgvOffersList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Id")
            {
                _dtOfferList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            }

            else
            {
                _dtOfferList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvOffersList.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddOffer_Click(object sender, EventArgs e)
        {
            frmAddOffer frm = new frmAddOffer();
            frm.ShowDialog();
            frmOffersList_Load(null, null);
        }

        private void editOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOffer frm = new frmAddOffer((int)dgvOffersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmOffersList_Load(null, null);
        }

        private void showOfferSubscripersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOfferSubscripersList frm = new frmOfferSubscripersList((int)dgvOffersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dgvOffersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOfferSubscripersList frm = new frmOfferSubscripersList((int)dgvOffersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
