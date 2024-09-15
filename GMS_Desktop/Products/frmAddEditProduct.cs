using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using GMS_BusinessLogic;
using GMS_BusinessLogic.Categories;
using GMS_Desktop.Properties;

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
            DataTable dt = category.get(string.Empty);

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


                txtName.Text = _product.Name;
                nudPriceWithProfit.Value = (decimal)_product.PriceWithProfit;
                if (_product.ImagePath != null)
                {
                    pbProductImage.ImageLocation = _product.ImagePath;
                    llRemove.Visible = true;
                }
                else
                {
                    pbProductImage.Image = Resources.Add_new_item;
                    llRemove.Visible = false;
                }
            }
        }

        private void _AddNew()
        {
            if (Product.find(txtName.Text) != null)
            {
                MessageBox.Show($"The product with {txtName.Text} is already exists", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _product = new Product();
            _product.Name = txtName.Text;
            _product.PriceWithProfit = (double)nudPriceWithProfit.Value;
            _product.CategoryId = Category.find(cbCategories.Text).Id;

            if (pbProductImage.Image == Resources.Add_new_item)
            {
                _product.ImagePath = null;
            }
            else
            {
                _product.ImagePath = pbProductImage.ImageLocation;
            }

            _product.add(_product);

            if (_product != null)
            {
                MessageBox.Show($"The product saved successfully in the system with Id = {_product.Id}", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            if (MessageBox.Show("Are you sure want to update this product ?", "Are you Sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            _product.Name = txtName.Text;
            _product.CategoryId = Category.find(cbCategories.Text).Id;
            _product.PriceWithProfit = (double)nudPriceWithProfit.Value;

            if (pbProductImage.Image == Resources.Add_new_item)
            {
                _product.ImagePath = null;
            }
            else
            {
                _product.ImagePath = pbProductImage.ImageLocation;
            }

            if (_product.update(_product))
            {
                MessageBox.Show($"The product saved successfully in the system with Id = {_product.Id}", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void nudPriceWithProfit_Validating(object sender, CancelEventArgs e)
        {
            if (_product != null && (double)nudPriceWithProfit.Value < _product.Price)
            {
                System.Media.SystemSounds.Beep.Play();
                nudPriceWithProfit.Focus();
                e.Cancel = true;
                errorProvider1.SetError(nudPriceWithProfit, "The product price should be greater than original price.");

            }
            else
            {
                btnSave.Enabled = true;
                e.Cancel = false;
                errorProvider1.SetError(nudPriceWithProfit, null);
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbProductImage.Load(selectedFilePath);
                llRemove.Visible = true;
            }

        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbProductImage.Image = Resources.Add_new_item;
            llRemove.Visible = false;
        }
    }
}
