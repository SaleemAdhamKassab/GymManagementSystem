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
    public partial class frmShowDetails : Form
    {
        private int _OrderId = -1;
        private SalesOrder _SalesOrder;

        public frmShowDetails(int orderId)
        {
            InitializeComponent();
            _OrderId = orderId;
        }

        private void frmShowDetails_Load(object sender, EventArgs e)
        {
            _SalesOrder = new SalesOrder();

            dgvCartDetails.DataSource = _SalesOrder.getOrderProductsDetails(_OrderId);

            if (dgvCartDetails.Rows.Count > 0)
            {
                dgvCartDetails.Columns[0].HeaderText = "Product Name";
                dgvCartDetails.Columns[0].Width = 200;

                dgvCartDetails.Columns[1].HeaderText = "Quantity";
                dgvCartDetails.Columns[1].Width = 120;

                dgvCartDetails.Columns[2].HeaderText = "Price";
                dgvCartDetails.Columns[2].Width = 150;

                dgvCartDetails.Columns[3].HeaderText = "Discount";
                dgvCartDetails.Columns[3].Width = 120;

                dgvCartDetails.Columns[4].HeaderText = "After Discount";
                dgvCartDetails.Columns[4].Width = 120;
            }

            lblItemsCount.Text = dgvCartDetails.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
