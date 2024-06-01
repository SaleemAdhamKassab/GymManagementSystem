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
    public partial class frmShowPurchaseOrder : Form
    {
        private Order _Order;
        private int _OrderID;

        public frmShowPurchaseOrder(int orderID)
        {
            InitializeComponent();
            _OrderID = orderID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmShowPurchaseOrder_Load(object sender, EventArgs e)
        {
            _Order = Order.find(_OrderID);

            if (_Order == null)
            {
                MessageBox.Show("No Order with ID = " + _OrderID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }


            OrderProduct orderProduct = OrderProduct.findByOrderID(_OrderID);

            dgvOrderInfo.DataSource = OrderProduct.getAllOrderProductDetails(_OrderID);

            dgvOrderInfo.Columns[0].HeaderText = "ID";
            dgvOrderInfo.Columns[0].Width = 120;

            dgvOrderInfo.Columns[1].HeaderText = "Products";
            dgvOrderInfo.Columns[1].Width = 200;

            dgvOrderInfo.Columns[2].HeaderText = "Categories";
            dgvOrderInfo.Columns[2].Width = 200;

            dgvOrderInfo.Columns[3].HeaderText = "Quantity";
            dgvOrderInfo.Columns[3].Width = 120;

            dgvOrderInfo.Columns[4].HeaderText = "Price";
            dgvOrderInfo.Columns[4].Width = 100;
            
        }
    }
}
