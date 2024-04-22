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
using GMS_BusinessLogic.Categories;

namespace GMS_Desktop
{
    public partial class frmAddEditProduct : Form
    {
        enum enMode { addNew = 1, update = 2 }
        enMode _Mode = enMode.addNew;

        Product _product;
        Category _category;
        string _productName;
        int _categoryID = -1;
        public frmAddEditProduct()
        {
            InitializeComponent();
            _Mode = enMode.addNew;
        }

        public frmAddEditProduct(string name)
        {
            InitializeComponent();
            _productName = name;
            _Mode = enMode.update;
        }
        private void _ResetForm()
        {
            _FillComboBoxWithCategories();
            switch (_Mode)
            {
                case enMode.addNew:
                    lblTitle.Text = "Add New Product";
                    this.Text = "Add New Product";
                    break;

                case enMode.update:
                    lblTitle.Text = "Edit Product Info";
                    this.Text = "Edit Product Info";
                    break;
            }
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.update)
                _LoadProductsInfo();
            else
                _ResetForm();

        }

        private void _FillComboBoxWithCategories()
        {
            Category category = new Category();
            DataTable dt = category.get();

            foreach (DataRow row in dt.Rows)
            {
                cbCategories.Items.Add(row["Name"]);
            }
        }

        private void _LoadProductsInfo()
        {
            _ResetForm();

            _product = Product.find(_productName);

            if (_product == null)
            {
                MessageBox.Show("This Product is not found in the system!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_Mode == enMode.update)
            {
                _category = Category.find(_product.CategoryId);

                if (_category != null)
                    cbCategories.SelectedIndex = cbCategories.FindString(_category.Name);


                lblProductID.Text = _product.Id.ToString();
                txtName.Text = _product.Name;
                nudQuantity.Value = _product.Quantity;
            }
        }

        private void _AddNew()
        {
            _product = new Product();
            _product.Name = txtName.Text;
            _product.CategoryId = Category.find(cbCategories.Text).Id;
            _product.Quantity = (short)nudQuantity.Value;

            _product.add(_product);

            if (_product != null)
            {
                MessageBox.Show($"The product saved successfully in the system with Id = {_product.Id}", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblProductID.Text = _product.Id.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Faild saving product", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void _Edit()
        {
            _product.Name = txtName.Text; 
            _product.CategoryId = Category.find(cbCategories.Text).Id;
            _product.Quantity = (short)nudQuantity.Value;

            if (_product.update(_product))
            {
                MessageBox.Show($"The product saved successfully in the system with Id = {_product.Id}", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblProductID.Text = _product.Id.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Faild saving product", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            switch (_Mode)
            {
                case enMode.update:
                    _Edit();
                    break;

                case enMode.addNew:
                    _AddNew();
                    break;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                System.Media.SystemSounds.Beep.Play();
                txtName.Focus();
                e.Cancel = true;
                errorProvider1.SetError(txtName, "This field is required.");
            }
            else
            {
                btnSave.Enabled = true;
                e.Cancel = false;
                errorProvider1.SetError(txtName, null);
            }
        }

        private void cbCategories_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbCategories.Text))
            {
                System.Media.SystemSounds.Beep.Play();
                cbCategories.Focus();
                e.Cancel = true;
                errorProvider1.SetError(cbCategories, "This field is required.");
            }
            else
            {
                btnSave.Enabled = true;
                e.Cancel = false;
                errorProvider1.SetError(cbCategories, null);
            }
        }

        private void nudQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (nudQuantity.Value < 1)
            {
                System.Media.SystemSounds.Beep.Play();
                nudQuantity.Focus();
                e.Cancel = true;
                errorProvider1.SetError(nudQuantity, "The product quintity should be one or more.");
            }
            else
            {
                btnSave.Enabled = true;
                e.Cancel = false;
                errorProvider1.SetError(nudQuantity, null);
            }
        }
    }
}
