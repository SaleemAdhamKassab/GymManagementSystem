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
    public partial class frmCategoriesList : Form
    {
        private DataTable _dtCategoriesList;
        public frmCategoriesList()
        {
            InitializeComponent();
        }

        private void frmCategoriesList_Load(object sender, EventArgs e)
        {
            //_dtCategoriesList = Category.categoriesList();

            //cbFilter.SelectedIndex = 0;

            //dgvCategoriesList.DataSource = _dtCategoriesList;
            //lblNumberOfCategories.Text = dgvCategoriesList.Rows.Count.ToString();

            //if (dgvCategoriesList.Rows.Count > 0)
            //{
            //    dgvCategoriesList.Columns[0].HeaderText = "Catrgory ID";
            //    dgvCategoriesList.Columns[0].Width = 120;

            //    dgvCategoriesList.Columns[1].HeaderText = "Category Name";
            //    dgvCategoriesList.Columns[1].Width = 250;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindNow()
        {
            //switch (cbFilter.Text)
            //{
            //    case "ID":

            //        if (int.TryParse(txtFindByID_Name.Text, out int id))
            //        {
            //            Category category1 = Category.find(id);
            //            if (category1 != null)
            //            {
            //                dgvCategoriesList.DataSource = category1;
            //            }

            //        }
            //        break;

            //        //case "Name":
            //        //    txtFindByID_Name.Visible = true;

            //}
        }

        private void txtFindByID_Name_TextChanged(object sender, EventArgs e)
        {
            string FilterCloumn = "";
            switch (cbFilter.Text)
            {
                case "ID":
                    FilterCloumn = "ID";
                    break;

                case "Name":
                    FilterCloumn = "Name";
                    break;

                default:
                    FilterCloumn = "None";
                    break;
            }

            if (FilterCloumn == "ID" || txtFindByID_Name.Text != "")
            {
                _dtCategoriesList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterCloumn, txtFindByID_Name.Text.Trim());
            }
            else if (FilterCloumn == "Name")
            {
                _dtCategoriesList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterCloumn, txtFindByID_Name.Text.Trim());
            }
            else
            {
                frmCategoriesList_Load(null, null);
            }

            lblNumberOfCategories.Text = _dtCategoriesList.Rows.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text != "None")
            {
                txtFindByID_Name.Visible = true;
                txtFindByID_Name.Focus();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindNow();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmAddNewCategory frm = new frmAddNewCategory();
            frm.ShowDialog();
            frmCategoriesList_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int categoryID = (int)dgvCategoriesList.CurrentRow.Cells[0].Value;

            frmAddNewCategory frm = new frmAddNewCategory(categoryID);
            frm.ShowDialog();
            frmCategoriesList_Load(null, null);
        }

        private void txtFindByID_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
