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
    public partial class frmCategoriesList : Form
    {
        private DataTable _dtCategoriesList;

        public frmCategoriesList()
        {
            InitializeComponent();
        }

        private void frmCategoriesList_Load(object sender, EventArgs e)
        {
            Category category = new Category();

            _dtCategoriesList = category.get(string.Empty);

            dgvCategoriesList.DataSource = _dtCategoriesList.DefaultView.ToTable(false, "Name");
            lblNumberOfCategories.Text = dgvCategoriesList.Rows.Count.ToString();

            if (dgvCategoriesList.Rows.Count > 0)
            {
                dgvCategoriesList.Columns[0].HeaderText = "Category Name";
                dgvCategoriesList.Columns[0].Width = 250;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFindByID_Name_TextChanged(object sender, EventArgs e)
        {

            _dtCategoriesList.DefaultView.RowFilter = string.Format("[Name] LIKE '{0}%'", txtFindByID_Name.Text.Trim());
            dgvCategoriesList.DataSource = _dtCategoriesList.DefaultView.ToTable(false, "Name");
            lblNumberOfCategories.Text = _dtCategoriesList.DefaultView.Count.ToString();

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmAddEditCategory frm = new frmAddEditCategory();
            frm.ShowDialog();
            frmCategoriesList_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string categoryName = (string)dgvCategoriesList.CurrentRow.Cells[0].Value;

            Category category = Category.find(categoryName);
            if (category != null)
            {
                frmAddEditCategory frm = new frmAddEditCategory(category);
                frm.ShowDialog();
                frmCategoriesList_Load(null, null);
            }


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string categoryName = (string)dgvCategoriesList.CurrentRow.Cells[0].Value;

            Category category = Category.find(categoryName);

            if (category != null)
            {
                if (MessageBox.Show("Are you sure delete this category?", "Are you sure?",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (category.delete(category.Id))
                    {
                        MessageBox.Show("The category deleted successfully in the system.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmCategoriesList_Load(null, null);
                    }
                    else
                        MessageBox.Show("Faild deleting category.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The category already not Found in the system", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
