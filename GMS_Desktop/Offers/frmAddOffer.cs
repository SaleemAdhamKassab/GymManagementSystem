using GMS_BusinessLogic;
using GMS_BusinessLogic.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS_Desktop
{
    public partial class frmAddOffer : Form
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;

        private Offer _Offer;
        private int _OfferId = -1;
        private ClassCategory _ClassCategory;
        private ClassType _ClassType;
        private float _FeesAfterDiscount = 0.0f;

        public frmAddOffer()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddOffer(int offerId)
        {
            InitializeComponent();
            _OfferId = offerId;

            _Mode = enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void _LoadOfferInfo()
        {
            _Offer = Offer.find(_OfferId);

            if (_Offer == null)
            {
                MessageBox.Show("No Offer with Id = " + _OfferId.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
                return;
            }

            txtOfferName.Text = _Offer.Name;
            cbCategories.SelectedIndex = cbCategories.FindString(_Offer.ClassTypeInfo.CategoryInfo.Name);
            cbClassTypes.SelectedIndex = cbClassTypes.FindString(_Offer.ClassTypeInfo.Name);
            dtpStartDate.Value = _Offer.StartDate;
            dtpEndDate.Value = _Offer.EndDate;
            nudDiscount.Value = _Offer.Discount;
            nudDuration.Value = _Offer.Duration;
            pbClassImage.ImageLocation = _Offer.ClassTypeInfo.ImagePath;
            lblOriginalPrice.Text = _Offer.ClassTypeInfo.Fees.ToString();
            lblAfterDiscount.Text = _Offer.FeeAfterDicount.ToString();
        }

        private void frmAddOffer_Load(object sender, EventArgs e)
        {
            _FillComboBoxWithCategories();

            if (_Mode == enMode.AddNew)
            {
                _Offer = new Offer();
                Text = "Add New Offer";
                lblTitle.Text = Text;

            }
            else
            {

                Text = "Edit Offer";
                lblTitle.Text = Text;
                _LoadOfferInfo();
            }
        }
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategories.SelectedIndex == -1) return;

            cbClassTypes.Enabled = cbCategories.SelectedIndex != -1;
            cbClassTypes.Items.Clear();

            DataTable dt = _ClassCategory.getClassTypesByClassCategoryName(cbCategories.Text);

            foreach (DataRow row in dt.Rows)
            {
                cbClassTypes.Items.Add(row["Name"]);
            }
        }
        private void cbClassTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClassTypes.SelectedIndex == -1) return;

            _ClassType = ClassType.find(cbClassTypes.Text);

            if (_ClassType == null)
            {
                MessageBox.Show("No Class with name " + cbClassTypes.Text, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pbClassImage.ImageLocation = _ClassType.ImagePath;
            lblOriginalPrice.Text = _ClassType.Fees.ToString() + "$";
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            if (nudDiscount.Value == 0) return;

            _FeesAfterDiscount = _ClassType.Fees * (100 - (int)nudDiscount.Value) / 100;
            _FeesAfterDiscount *= (int)nudDuration.Value;
            lblAfterDiscount.Text = _FeesAfterDiscount.ToString() + "$";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field(s) are requeired, put the mouse on the red icon to show the error.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to perform this operation ?", "Are You Sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            bool isSaved = false;

            _Offer.Name = txtOfferName.Text;
            _Offer.Discount = (int)nudDiscount.Value;
            _Offer.Duration = (int)nudDuration.Value;
            _Offer.StartDate = DateTime.Now;
            _Offer.EndDate = DateTime.Now.AddMonths((int)nudDuration.Value);
            _Offer.AddedOn = DateTime.Now;
            _Offer.FeeAfterDicount = _FeesAfterDiscount;
            _Offer.ClassTypeId = _ClassType.Id;

            if (_Mode == enMode.AddNew)
            {
                _Offer.add(_Offer);
                isSaved = _Offer.Id != -1;
            }
            else
            {
                isSaved = _Offer.update(_Offer);
            }

            if (isSaved)
            {
                MessageBox.Show($"The date has been saved successfully in the system with Id = {_Offer.Id}", "Saved Successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show($"Filed saving data", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtOfferName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOfferName.Text))
            {
                e.Cancel = true;
                txtOfferName.Focus();
                errorProvider1.SetError(txtOfferName, "This field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtOfferName, null);
            }
        }

        private void ComboBoxes_Validating(object sender, CancelEventArgs e)
        {
            ComboBox temp = (ComboBox)sender;

            if (string.IsNullOrEmpty(temp.Text))
            {
                e.Cancel = true;
                temp.Focus();
                errorProvider1.SetError(temp, "This field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(temp, null);
            }
        }

        private void nudDuration_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
