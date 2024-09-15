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
using GMS_Desktop.Products;

namespace GMS_Desktop
{
    public partial class frmProductsList : Form
    {
        private DataTable _AllproductsList;
        private DataTable _productsList;
        private bool _ShowScreen = false;

        public frmProductsList(bool isAdmin)
        {
            InitializeComponent();
            _ShowScreen = isAdmin;
        }

        private void frmProductsList_Load(object sender, EventArgs e)
        {
            if (!_ShowScreen)
            {
                MessageBox.Show("Access denied!, you haven't permission in this screen Contact your Admin", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            Product product = new Product();

            _AllproductsList = product.get(string.Empty);
            _productsList = _AllproductsList.DefaultView.ToTable(false, "Name", "Quantity", "PriceWithProfit");

            dgvProductsList.DataSource = _productsList;
            lblRecords.Text = dgvProductsList.Rows.Count.ToString();

            if (dgvProductsList.Rows.Count > 0)
            {
                dgvProductsList.Columns[0].HeaderText = "Product Name";
                dgvProductsList.Columns[0].Width = 300;

                dgvProductsList.Columns[1].HeaderText = "Available quantity";
                dgvProductsList.Columns[1].Width = 200;

                dgvProductsList.Columns[2].HeaderText = "Price";
                dgvProductsList.Columns[2].Width = 120;


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            _productsList.DefaultView.RowFilter = string.Format("[Name] LIKE '{0}%'", txtFind.Text.Trim());
            dgvProductsList.DataSource = _productsList.DefaultView.Table;
            lblRecords.Text = dgvProductsList.Rows.Count.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditProduct addProduct = new frmAddEditProduct();
            addProduct.ShowDialog();
            frmProductsList_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Name = (string)dgvProductsList.CurrentRow.Cells[0].Value;

            frmAddEditProduct update = new frmAddEditProduct(Name);
            update.ShowDialog();
            frmProductsList_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Name = (string)dgvProductsList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure want to delete this product?", "Are you sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            Product product = Product.find(Name);

            try
            {
                if (product.delete(product.Id))
                    MessageBox.Show("The product deleted successfully in the system.", "Seccess",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faild deleting " + ex.Message, "Faild",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            frmProductsList_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowProductDetails frm = new frmShowProductDetails(dgvProductsList.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }

        private void dgvProductsList_DoubleClick(object sender, EventArgs e)
        {
            frmShowProductDetails frm = new frmShowProductDetails(dgvProductsList.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }
    }
}
