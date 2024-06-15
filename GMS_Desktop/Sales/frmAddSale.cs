using GMS_Desktop.Properties;
using System.ComponentModel;
using System.Data;
using GMS_BusinessLogic;
using GMS_BusinessLogic.Categories;
using System.Diagnostics;
using static GMS_BusinessLogic.ViewModels.SharedViewModels;

namespace GMS_Desktop
{
    public partial class frmSales : Form
    {
        SalesOrder _SaleOrder;

        private double _PriceAfterDiscount = 0;
        private int _Quantity = 0;
        private int _Discount = 0;
        private double _OrignalPrice = 0;
        private double _Price = 0;
        private string _ProductName = string.Empty;
        private double _TotalAmount = 0;
        private string _TotalAmountString = string.Empty;
        private double _TotalAmountAfterDiscount = 0;
        private int _ClientId = -1;

        public frmSales()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _FillComboBoxWithClientNames()
        {
            Client client = new Client();

            DataTable dt = client.get(string.Empty);

            foreach (DataRow row in dt.Rows)
            {
                cbClients.Items.Add(row["FullName"]);
            }
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

        Product _Product = new Product();
        private void _FillComboBoxWithProducts(int categogryId)
        {
            DataTable dt = _Product.getProductsByItem(categogryId);

            foreach (DataRow row in dt.Rows)
            {
                cbProducts.Items.Add(row["Name"]);
            }
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            _FillComboBoxWithClientNames();
            _FillComboBoxWithCategories();
            _ResetDefaultValues();
            InitializeDataGridView();
        }


        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCategories.Enabled = true;
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategories.Text == string.Empty)
                return;


            cbProducts.SelectedIndex = -1;


            int categoryId = Category.find(cbCategories.Text).Id;

            cbProducts.Enabled = true;
            cbProducts.Items.Clear();
            _FillComboBoxWithProducts(categoryId);
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducts.Text == string.Empty)
                return;

            nudQuantity.Enabled = true;

            nudQuantity.Value = 0;

            _ProductName = cbProducts.Text;

            _Product = Product.find(_ProductName);

            pbProductImage.ImageLocation = _Product.ImagePath;

            if (_Product.Quantity < 1)
            {
                MessageBox.Show("This product is not found now", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbProductImage.ImageLocation = _Product.ImagePath;
                nudQuantity.Enabled = false;
                return;
            }

            _OrignalPrice = _Product.PriceWithProfit;
            lblOriginalPrice.Text = _OrignalPrice.ToString() + "$";
            nudQuantity.Value = 0;
            nudQuantity.Maximum = _Product.Quantity;
        }


        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            nudDiscount.Enabled = nudQuantity.Value > 0;
            btnAddToCart.Enabled = nudQuantity.Value > 0;
            _Quantity = (int)nudQuantity.Value;

            _Price = _Quantity * _OrignalPrice;

            double totalAmount = _Quantity * _OrignalPrice;

            lblTotalAmountAfterDiscount.Text = (_TotalAmountAfterDiscount + totalAmount).ToString() + "$";
            nudDiscount.Value = 0;

            totalAmount += _TotalAmount;

            _TotalAmountString = totalAmount.ToString();
            lblTotalAmount.Text = _TotalAmountString + "$";

            pnlProductPriceInfo.Visible = true;
            lblTotalPriceAfterDiscount.Visible = false;
            lblTotalPriceAfterDiscountVal.Visible = false;

            lblTotalPrice.Visible = nudQuantity.Value > 1;
            lblTotalPriceVal.Visible = nudQuantity.Value > 1;
            lblTotalPriceVal.Text = _Price.ToString() + "$";
        }

        bool _IsDiscount = false;
        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            _IsDiscount = true;
            _PriceAfterDiscount = 0;

            lblAfterDiscount.Visible = nudDiscount.Value > 0;
            lblTotalAmountAfterDiscount.Visible = nudDiscount.Value > 0;
            lblPriceAfterDiscountTxt.Visible = nudDiscount.Value > 0;
            lblPriceAterDiscountVal.Visible = nudDiscount.Value > 0;


            lblTotalPriceAfterDiscount.Visible = nudQuantity.Value > 1 && nudDiscount.Value > 0;
            lblTotalPriceAfterDiscountVal.Visible = nudQuantity.Value > 1 && nudDiscount.Value > 0;

            _Discount = (int)nudDiscount.Value;
            lblPriceAterDiscountVal.Text = (_OrignalPrice * (100 - _Discount) / 100).ToString() + "$";
            if (_Discount > 0)
            {
                _PriceAfterDiscount = _OrignalPrice * _Quantity * (100 - _Discount) / 100;

                lblTotalPriceAfterDiscountVal.Text = _PriceAfterDiscount.ToString() + "$";

                lblTotalAmountAfterDiscount.Text = (_TotalAmountAfterDiscount + _PriceAfterDiscount).ToString() + "$";
            }
            else
            {
                _IsDiscount = false;
                lblTotalAmountAfterDiscount.Text = (_TotalAmountAfterDiscount + _Price).ToString() + "$";
            }

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!_IsSameProduct(_ProductName))
            {
                MessageBox.Show("The product is already added to the cart, Please select another product", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(cbCategories.Text) || string.IsNullOrEmpty(cbProducts.Text) ||
                (nudQuantity.Value == 0))
            {
                MessageBox.Show("Please fill the required field(s).\nYou have to fill the client, category, product, and quantity before.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbClients.Enabled = false;

            _TotalAmount += _Quantity * _OrignalPrice;

            lblTotalAmount.Text = _TotalAmount.ToString() + "$";
            _TotalAmountString = lblTotalAmount.Text;

            double price = 0;
            price = _IsDiscount ? _PriceAfterDiscount : _Price;
            string discountFormat = _Discount.ToString() + "%";
            dgvCartDetails.Rows.Add(_ProductName, _Quantity, _Price / _Quantity, discountFormat, price / _Quantity);
            _TotalAmountAfterDiscount += price;
            lblTotalAmountAfterDiscount.Text = _TotalAmountAfterDiscount.ToString() + "$";
            lblRecordsCount.Text = dgvCartDetails.Rows.Count.ToString();
            _ResetAfterAddToCart();
            lblTotalAmountCart.Text = lblTotalAmount.Text;
            lblAfterDiscountCart.Text = lblTotalAmountAfterDiscount.Text;
        }

        private void _ResetAfterAddToCart()
        {
            cbCategories.SelectedIndex = -1;
            cbProducts.Items.Clear();
            nudQuantity.Value = 0;
            nudDiscount.Value = 0;
            pbProductImage.Image = Resources.Add_category;
            lblOriginalPrice.Text = "0$";
            pnlProductPriceInfo.Visible = false;
        }

        private bool _IsSameProduct(string productName)
        {
            foreach (DataGridViewRow row in dgvCartDetails.Rows)
            {
                if (row.Cells["ProductName"].Value != null && row.Cells["ProductName"].Value.ToString() == productName)
                { return false; }
            }

            return true;
        }

        private void InitializeDataGridView()
        {
            dgvCartDetails.Columns.Add("ProductName", "Product Name");
            dgvCartDetails.Columns.Add("Quantity", "Quantity");
            dgvCartDetails.Columns.Add("Price", "Price");
            dgvCartDetails.Columns.Add("Discount", "Discount");
            dgvCartDetails.Columns.Add("AfterDiscount", "After Discount");

            dgvCartDetails.Columns["ProductName"].Width = 190;
            dgvCartDetails.Columns["Quantity"].Width = 90;
            dgvCartDetails.Columns["Price"].Width = 90;
            dgvCartDetails.Columns["Discount"].Width = 105;
            dgvCartDetails.Columns["AfterDiscount"].Width = 140;
        }

        private List<(double, int, int, int?)> _LoadProductFromDataGridView()
        {
            List<(double, int, int, int?)> products = new List<(double, int, int, int?)>();

            foreach (DataGridViewRow row in dgvCartDetails.Rows)
            {
                if (row.Cells["ProductName"].Value != null &&
                    row.Cells["Quantity"].Value != null &&
                    row.Cells["Price"].Value != null &&
                    row.Cells["Discount"].Value != null &&
                    row.Cells["AfterDiscount"].Value != null)
                {
                    double price = Convert.ToDouble(row.Cells["Price"].Value);
                    string productName = row.Cells["ProductName"].Value.ToString();
                    Product product = Product.find(productName);

                    if (product == null)
                    {
                        MessageBox.Show($"Product {productName} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    int productId = product.Id;
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                    string discountFormat = row.Cells["Discount"].Value != null ? row.Cells["Discount"].Value.ToString().Replace("%", string.Empty) : string.Empty;
                    int discountValue = 0;
                    if (int.TryParse(discountFormat.Trim(), out discountValue))
                        products.Add((price, productId, quantity, discountValue));
                    //int? discount = row.Cells["Discount"].Value != null ? (int?)Convert.ToInt32(row.Cells["Discount"].Value) : null;
                }
            }

            return products;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCartDetails.CurrentRow != null)
            {
                _TotalAmount -= ((double)dgvCartDetails.CurrentRow.Cells[2].Value * (int)dgvCartDetails.CurrentRow.Cells[1].Value);
                lblTotalAmount.Text = _TotalAmount.ToString() + "$";
                _TotalAmountAfterDiscount -= ((double)dgvCartDetails.CurrentRow.Cells[4].Value * (int)dgvCartDetails.CurrentRow.Cells[1].Value);
                lblTotalAmountAfterDiscount.Text = _TotalAmountAfterDiscount.ToString() + "$";
                dgvCartDetails.Rows.Remove(dgvCartDetails.CurrentRow);

                _ResetAfterDeleted();
            }
        }

        private void _ResetAfterDeleted()
        {
            nudDiscount.Value = 0;
            nudQuantity.Value = 0;
            cbProducts.SelectedIndex = -1;
            cbCategories.SelectedIndex = -1;
            pbProductImage.Image = Resources.Add_category;
            lblOriginalPrice.Text = "0$";
            lblPriceAfterDiscountTxt.Visible = false;
            lblPriceAterDiscountVal.Text = "0$";
            lblPriceAterDiscountVal.Visible = false;
            _PriceAfterDiscount = 0;
            _Quantity = 0;
            _Discount = 0;
            _OrignalPrice = 0;
            _Price = 0;
            _IsDiscount = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field(s) are required, put your mouse on the red icon to see the error.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (MessageBox.Show("Are you sure you want to save order?", "Are You Sure?",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            _SaleOrder = new SalesOrder();

            _SaleOrder.Amount = _TotalAmount;

            string fullName = cbClients.Text.Trim();
            string firstName = fullName.Split(' ')[0];
            string lastName = fullName.Split(' ')[1];

            Client client = Client.find(firstName, lastName);
            if (client == null)
            {
                MessageBox.Show("The client is not found!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ClientId = client.Id;
            _SaleOrder.ClientId = _ClientId;
            _SaleOrder.UserId = 1;
            _SaleOrder.AmountAfterDiscount = _TotalAmountAfterDiscount;

            List<(double, int, int, int?)> saleOrderProducts = _LoadProductFromDataGridView();

            if (saleOrderProducts.Count == 0)
            {
                MessageBox.Show("There is no products in the cart to add order.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //int saleOrderId = _SaleOrder.add(_SaleOrder, saleOrderProducts);
            AddSaleOrderViewModel saleOrderViewModel = _SaleOrder.add(_SaleOrder, saleOrderProducts);

            if (saleOrderViewModel.CreatedSaleOrderId != -1)
            {
                MessageBox.Show("Order saved successfully with Id = " + saleOrderViewModel.CreatedSaleOrderId.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (saleOrderViewModel.OutOfStockProducts.Count > 0)
                {
                    string product = string.Empty;
                    
                    foreach(string productName in  saleOrderViewModel.OutOfStockProducts)
                    {
                        product = string.Join(",", saleOrderViewModel.OutOfStockProducts);
                    }

                    MessageBox.Show($"The following product(s) are currently out of stock: {product}. Please contact Admin.", "Out Of Stock Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                _ResetDefaultValues();
            }
            else
                MessageBox.Show("Failed to save the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _ResetDefaultValues()
        {
            cbClients.SelectedIndex = -1;
            cbCategories.SelectedIndex = -1;
            cbProducts.SelectedIndex = -1;
            nudQuantity.Value = 0;
            nudDiscount.Value = 0;
            pbProductImage.Image = Resources.Add_category;
            lblRecordsCount.Text = "0";
            lblTotalAmountAfterDiscount.Text = "0$";
            lblTotalAmountAfterDiscount.Visible = false;
            lblPriceAterDiscountVal.Text = "0$";
            lblTotalAmountCart.Text = "0$";
            lblAfterDiscountCart.Text = "0$";
            lblPriceAterDiscountVal.Visible = false;
            lblTotalAmount.Text = "0$";
            lblOriginalPrice.Text = "0$";
            lblAfterDiscount.Visible = false;
            lblPriceAfterDiscountTxt.Visible = false;
            btnAddToCart.Enabled = false;
            dgvCartDetails.Rows.Clear();
            cbClients.Enabled = true;
            _TotalAmount = 0;
            _TotalAmountAfterDiscount = 0;
        }

        private void cbClients_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbClients.Text))
            {
                e.Cancel = true;
                cbClients.Focus();
                errorProvider1.SetError(cbClients, "Select Client");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbClients, null);
            }
        }

        private void cbCategories_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbCategories.Text) && dgvCartDetails.Rows.Count == 0)
            {
                e.Cancel = true;
                cbCategories.Focus();
                errorProvider1.SetError(cbCategories, "Select category");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbCategories, null);
            }
        }

        private void cbProducts_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbProducts.Text) && dgvCartDetails.Rows.Count == 0)
            {
                e.Cancel = true;
                cbProducts.Focus();
                errorProvider1.SetError(cbProducts, "Select product");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbProducts, null);
            }
        }

        private void nudQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (nudQuantity.Value == 0 && dgvCartDetails.Rows.Count == 0)
            {
                e.Cancel = true;
                nudQuantity.Focus();
                errorProvider1.SetError(nudQuantity, "Please set the quantity value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nudQuantity, null);
            }
        }
    }
}
