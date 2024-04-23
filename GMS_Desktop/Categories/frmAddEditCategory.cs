using GMS_BusinessLogic.Categories;
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
	public partial class frmAddEditCategory : Form
	{
		private enum enMode { addNew = 1, update = 2 }
		private enMode _mode = enMode.addNew;

		private Category _category;

		public frmAddEditCategory(Category category)
		{
			InitializeComponent();
			_category = category;
			_mode = enMode.update;
		}

		public frmAddEditCategory()
		{
			InitializeComponent();
			_mode = enMode.addNew;
		}

		private void _ResetForm()
		{
			if (_mode == enMode.addNew)
			{
				lblTitle.Text = "Add New Category";
				this.Text = "Add New Category";
			}
			else
			{
				lblTitle.Text = "Update Category";
				this.Text = "Update Category";
				txtName.Text = _category.Name;
			}
		}

		private void frmAddNewCategory_Load(object sender, EventArgs e)
		{
			_ResetForm();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			switch (_mode)
			{
				case enMode.addNew:

					_category = new Category();
					int insertedCategoryId = _category.add(_category);

					if (insertedCategoryId != -1)
					{
						_category.Id = insertedCategoryId;
						_category.Name = txtName.Text;

						lblID.Text = _category.Id.ToString();

						MessageBox.Show($"Category data saved successfully in the system with ID = {_category.Id}", "Success",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
						MessageBox.Show("Faild saved", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;

				case enMode.update:

					_category.Name = txtName.Text;
					if (_category.update(_category))
					{
						lblID.Text = _category.Id.ToString();

						MessageBox.Show($"Category data saved successfully in the system with ID = {_category.Id}", "Success",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("This category not Found in the system!", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
			}

			this.Close();
		}

		private void txtName_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				btnSave.Enabled = false;
				txtName.Focus();
				errorProvider1.SetError(txtName, "You have to set the category's name.");
			}
			else
			{
				btnSave.Enabled = true;
				errorProvider1.SetError(txtName, null);
			}
		}
	}
}
