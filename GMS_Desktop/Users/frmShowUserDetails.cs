using System;
using GMS_BusinessLogic;

namespace GMS_Desktop.Users
{
    public partial class frmShowUserDetails : Form
    {
        private User _User;
        private int _UserId;
        public frmShowUserDetails(int userId)
        {
            InitializeComponent();
            _UserId = userId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            _User = User.findByUserId(_UserId);

            if (_User == null)
            {
                MessageBox.Show("No User with Id = " + _UserId.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            ctrlPersonCard1.LoadPersonInfo(_User.PersonId);
            lblUserName.Text = _User.UserName;
            lblRole.Text = _User.IsAdmin ? "Admin" : "User";
            lblIsActive.Text = _User.IsActive ? "Active" : "In Active";
        }
    }
}
