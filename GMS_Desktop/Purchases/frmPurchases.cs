using GMS_BusinessLogic;
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
    public partial class frmPurchases : Form
    {
        private Order _Order;

        public frmPurchases()
        {
            InitializeComponent();
            dgvOrderProducts.RowValidating += dgvOrderProducts_RowValidating;
        }

        private void _ResetDefaultValues()
        {
            _FillComboBoxToSuppliers();

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Product Name";
            comboBoxColumn.Name = "Product";
            comboBoxColumn.Width = 200;


            DataTable products = Product.get();
            foreach (DataRow row in products.Rows)
            {
                comboBoxColumn.Items.Add(row["Name"].ToString());
            }

            dgvOrderProducts.Columns.Add(comboBoxColumn);

            dgvOrderProducts.Columns.Add("Price", "Price");
            dgvOrderProducts.Columns[1].Width = 120;

            dgvOrderProducts.Columns.Add("Quantity", "Quantity");
            dgvOrderProducts.Columns[2].Width = 120;

            dtpOrderDate.MinDate = DateTime.Now;
            dtpOrderDate.Value = dtpOrderDate.MinDate;



        }

        private void _FillComboBoxToSuppliers()
        {
            DataTable dt = Supplier.get();

            foreach (DataRow row in dt.Rows)
            {
                string fullName = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                cbSuppliers.Items.Add(fullName);
            }

        }

        private void frmPurchases_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            _Order = new Order();

            _Order.Date = dtpOrderDate.Value;

            string supplierFullName = cbSuppliers.Text.Trim();
            string supplierFName = supplierFullName.Split(' ')[0];
            string supplierlName = supplierFullName.Split(' ')[1];

            _Order.SupplierId = Supplier.find(supplierFName, supplierlName).Id;
            _Order.UserId = 1;

            List<(int ProductID, decimal Price, int Quantity)> orderProducts = new List<(int, decimal, int)>();

            foreach (DataGridViewRow row in dgvOrderProducts.Rows)
            {
                if (!row.IsNewRow && !row.Selected)
                {
                    string productName = row.Cells[0].Value.ToString();
                    int productId = Product.find(productName).Id;
                    decimal price = Convert.ToDecimal(row.Cells[1].Value);
                    int quantity = Convert.ToInt32(row.Cells[2].Value);

                    orderProducts.Add((productId, price, quantity));
                }

            }

            _Order.Discount = (double)nudDiscount.Value;

            int OrderID = _Order.add(_Order, orderProducts);

            if (OrderID != -1)
            {
                MessageBox.Show("Order added successfully with ID = " + OrderID, "Added Successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faild adding", "Faild",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            dgvOrderProducts.Rows.Add();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOrderProducts.CurrentRow != null && !dgvOrderProducts.CurrentRow.IsNewRow)
            {
                dgvOrderProducts.Rows.Remove(dgvOrderProducts.CurrentRow);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSuppliers_Validating(object sender, CancelEventArgs e)
        {
            if (cbSuppliers.SelectedIndex == -1)
            {
                btnCreateOrder.Enabled = false;
                cbSuppliers.Focus();
                errorProvider1.SetError(cbSuppliers, "Please select a supplier");
            }
            else
            {
                btnCreateOrder.Enabled = true;
                errorProvider1.SetError(cbSuppliers, null);
            }
        }

        private void dgvOrderProducts_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvOrderProducts.CurrentRow != null && dgvOrderProducts.CurrentRow.IsNewRow)
            {
                return;
            }

            DataGridViewRow row = dgvOrderProducts.Rows[e.RowIndex];
            bool isRowValid = true;

            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.OwningColumn.Name == "Product" || cell.OwningColumn.Name == "Price" || cell.OwningColumn.Name == "Quantity")
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        row.ErrorText = "All fields must be filled out.";
                        isRowValid = false;
                        break;
                    }
                }
            }

            if (!isRowValid)
            {
                e.Cancel = true;
            }
            else
            {
                row.ErrorText = string.Empty;
            }
        
    
        }

    }
}
