using GMS_BusinessLogic;
using GMS_Desktop.Global;
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
        private Client _Client; 

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
            _Client = Client.find(_ClientID);

            if (_Client == null)
            {
                MessageBox.Show($"No client with ID = {_ClientID}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            ctrlPersonCard1.LoadPersonInfo(_Client.PersonId);
        }
    }
}
