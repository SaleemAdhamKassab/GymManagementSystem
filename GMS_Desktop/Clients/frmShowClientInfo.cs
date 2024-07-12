using GMS_BusinessLogic;
using GMS_Desktop.Properties;
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
    public partial class frmShowClientInfo : Form
    {
        private int _ClientID = -1;

        public frmShowClientInfo(int clientID)
        {
            InitializeComponent();
            _ClientID = clientID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmShowClientInfo_Load(object sender, EventArgs e)
        {
            Client client = Client.find(_ClientID);

            if (client == null)
            {
                MessageBox.Show($"No client with ID = {_ClientID}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lblName.Text = client.FullName;
            lblGendor.Text = client.Gendor == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = clsFormat.DateToShort(client.DateOfBirth);
            lblAddress.Text = client.Address;
            lblPhone.Text = client.Phone;
            lblEmail.Text = client.Email;
            if (client.ImagePath != null)
                pbImage.ImageLocation = client.ImagePath;
            else
                pbImage.Image = client.Gendor == 0 ? Resources.Male_512 : Resources.Male_512;
        }
    }
}
