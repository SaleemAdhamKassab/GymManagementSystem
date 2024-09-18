using System;
using System.Data;
using GMS_BusinessLogic;
using GMS_Desktop.Properties;

namespace GMS_Desktop.Coaches
{
    public partial class ctrlPersonCard : UserControl
    {
        private Person _Person;
        private int _PersonId = -1;

        public ctrlPersonCard()
        {
            InitializeComponent();
            ResetPersonInfo();
        }

        public int PersonId
        {
            get
            {
                return _PersonId;
            }
        }

        public Person Person
        {
            get
            {
                return _Person;
            }
        }

        public void LoadPersonInfo(int personId)
        {
            _Person = Person.find(personId);

            if (_Person == null)
            {
                MessageBox.Show("No person with Id = " + _PersonId.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetPersonInfo();
                return;
            }

            lblPersonFullName.Text = _Person.FullName;
            lblGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            pbGendor.Image = _Person.Gendor == 0 ? Resources.Man_32 : Resources.Woman_32;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblDateOfBirth.Text = Global.clsFormat.DateToShort(_Person.DateOfBirth);
            lblPhone.Text = _Person.Phone;
            if (_Person.ImagePath != null)
                pbPersonImage.ImageLocation = _Person.ImagePath;
            else
                pbPersonImage.Image = _Person.Gendor == 0 ? Resources.Male_512 : Resources.Female_512;
        }

        public void ResetPersonInfo()
        {
            lblPersonFullName.Text = "[???]";
            lblGendor.Text = "[???]";
            pbGendor.Image = Resources.Man_32;
            lblEmail.Text = "[???]";
            lblAddress.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblPhone.Text = "[???]";
            pbPersonImage.Image = Resources.Male_512;
        }

    }
}
