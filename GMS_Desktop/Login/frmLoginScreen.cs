using GMS_BusinessLogic;
using GMS_Desktop.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS_Desktop.Login
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _SetDate()
        {
            lblDay.Text = DateTime.Now.Date.DayOfWeek.ToString();
            lblDate.Text = clsFormat.DateToShort(DateTime.Now);
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            _SetDate();

            string userName = string.Empty, password = string.Empty;

            if (clsGlobal.getStoredCredential(ref userName, ref password))
            {
                txtUserName.Text = userName;
                txtPassword.Text = password;

                ckbRemainderMe.Checked = true;
            }
            else
                ckbRemainderMe.Checked = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = User.findByUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (user != null)
            {
                if (ckbRemainderMe.Checked)
                    clsGlobal.RememberUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                else
                    clsGlobal.RememberUserNameAndPassword(string.Empty, string.Empty);

                if (!user.IsActive)
                {
                    MessageBox.Show("Your account is not active, contact your admin.", "In Active Account",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.currentUser = user;
                frmMain frm = new frmMain();
                frm.Show();
                Hide();
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid UserName/Password.", "Wrong Credintionals",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
