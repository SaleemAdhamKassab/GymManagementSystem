using System;
using System.Data;
using GMS_BusinessLogic;

namespace GMS_Desktop.Coaches
{
    public partial class frmShowCoachDetails : Form
    {
        private Coach _Coach;
        private int _CoachId = -1;

        public frmShowCoachDetails(int coachId)
        {
            InitializeComponent();
            _CoachId = coachId;
        }

        private void frmShowCoachDetails_Load(object sender, EventArgs e)
        {
            _Coach = Coach.findById(_CoachId);

            if (_Coach == null)
            {
                MessageBox.Show("No coach with Id = " + _CoachId.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            ctrlPersonCard1.LoadPersonInfo(_Coach.PersonId);

            lblAchAndAwards.Text = _Coach.AchievementsAndAwards;
            lblClass.Text = _Coach.ClassTypeInfo.Name;
            lblIsActive.Text = _Coach.IsActive ? "Active" : "In active";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
