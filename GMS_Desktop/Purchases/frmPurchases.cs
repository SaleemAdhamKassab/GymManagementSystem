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
        private DataTable _dtOrdersList;
        private Order _Order;
        private int _OrderID;
        private OrderProduct _OrderProduct;
        private int _OrderProductID;

        public frmPurchases()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            _FillComboBoxToSuppliers();

            dgvOrderProducts.Columns.Add("ProductId", "Product ID");
            dgvOrderProducts.Columns[0].Width = 120;

            dgvOrderProducts.Columns.Add("Price", "Price"); ;
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
            _Order.SupplierId = 1;
            _Order.UserId = 1;

            List<(int ProductID, decimal Price, int Quantity)> orderProducts = new List<(int, decimal, int)>();

            foreach (DataGridViewRow row in dgvOrderProducts.Rows)
            {
                if (!row.IsNewRow && !row.Selected)
                {
                    int productId = Convert.ToInt32(row.Cells[0].Value);
                    decimal price = Convert.ToDecimal(row.Cells[1].Value);
                    int quantity = Convert.ToInt32(row.Cells[2].Value);

                    orderProducts.Add((productId, price, quantity));
                }

            }

            if (_Order.add(_Order, orderProducts) != -1)
            {
                MessageBox.Show("Order added successfully.", "Added Successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faild adding", "Faild",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrderProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvOrderProducts.Rows.Count > 1)
            //{
            //    dgvOrderProducts.Enabled = false;
            //    dgvOrderProducts.ReadOnly = true;
            //}
        }

        private void dgvOrderProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvOrderProducts.Rows.Count > 1)
            //{
            //    dgvOrderProducts.Enabled = false;
            //    dgvOrderProducts.ReadOnly = true;
            //}
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            dgvOrderProducts.Rows.Add();

        }

        private void dgvOrderProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DataGridViewRow lastRow = dgvOrderProducts.Rows[dgvOrderProducts.Rows.Count - 1];

            //if (!lastRow.IsNewRow)
            //{
            //    dgvOrderProducts.Rows.RemoveAt(dgvOrderProducts.Rows.Count - 1);
            //}
            //else
            //{
            //    // Handle the case where the last row is a new row
            //    // This could be showing a message to the user or performing some other action
            //    MessageBox.Show("Cannot delete uncommitted new row.");
            //}
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOrderProducts.Rows.Count > 0)
            {
                dgvOrderProducts.Rows.Remove(dgvOrderProducts.SelectedRows[0]);
                
            }
            
        }
    }
}
