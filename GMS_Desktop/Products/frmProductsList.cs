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
    public partial class frmProductsList : Form
    {
        private DataTable _AllproductsList;
        private DataTable _productsList;

        public frmProductsList()
        {
            InitializeComponent();
        }

        private void frmProductsList_Load(object sender, EventArgs e)
        {
            Product product = new Product();

            _AllproductsList = product.get(string.Empty);
            _productsList = _AllproductsList.DefaultView.ToTable(false, "Name", "Quantity");

            dgvProductsList.DataSource = _productsList;
            lblRecords.Text = dgvProductsList.Rows.Count.ToString();

            if (dgvProductsList.Rows.Count > 0)
            {
                dgvProductsList.Columns[0].HeaderText = "Product Name";
                dgvProductsList.Columns[0].Width = 250;

                dgvProductsList.Columns[1].HeaderText = "Product quantity";
                dgvProductsList.Columns[1].Width = 140;
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
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Product product = Product.find(Name);

                if (product.delete(product.Id))
                    MessageBox.Show("The product deleted successfully in the system.", "Seccess",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Faild deleting.", "Faild",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            frmProductsList_Load(null, null);
        }
    }
}
