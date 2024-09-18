using System;
using System.Data;
using GMS_BusinessLogic;
using GMS_Desktop.Properties;

namespace GMS_Desktop.Products
{
    public partial class frmShowProductDetails : Form
    {
        private Product _Product;
        string _ProductName;
        public frmShowProductDetails(string productName)
        {
            InitializeComponent();
            _ProductName = productName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmShowProductDetails_Load(object sender, EventArgs e)
        {
            _Product = Product.find(_ProductName);

            if (_Product == null)
            {
                MessageBox.Show("No product with Id = " + _ProductName.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultData();
                return;
            }

            lblProductName.Text = _Product.Name;
            lblCategoryName.Text = _Product.Category.Name;
            lblQuantity.Text = _Product.Quantity.ToString() + " Piece.";
            lblOriginalPrice.Text = _Product.Price.ToString() + "$";
            lblPriceWithProfit.Text = _Product.PriceWithProfit.ToString() + "$";
            if (_Product.ImagePath != null)
                pbProductImage.ImageLocation = _Product.ImagePath;
            else
                pbProductImage.Image = Resources.cateogry_Default;
        }

        private void _ResetDefaultData()
        {
            lblProductName.Text = "[???]";
            lblCategoryName.Text = "[???]";
            lblQuantity.Text = "[???]";
            lblOriginalPrice.Text = "0.0$";
            lblPriceWithProfit.Text = "0.0$";
            pbProductImage.Image = Resources.cateogry_Default;
        }

    }
}
