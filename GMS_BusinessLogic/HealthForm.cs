using System;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class HealthForm
    {
        private enum enMode { AddNew  = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;

        public int Id { get; set; }
        public string HealthIssue {  get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactPhone {  get; set; }
        public DateTime DateFilled { get; set; }
        public int MembershipId {  get; set; }
        public Membership MembershipInfo { get; set; }

        public HealthForm()
        {
            Id = -1;
            HealthIssue = string.Empty;
            EmergencyContactName = string.Empty;
            EmergencyContactPhone = string.Empty;
            DateFilled = DateTime.Now;
            MembershipId = -1;

            _Mode = enMode.AddNew;
        }

        private HealthForm(int id, string healthIssue, string? emergencyContactName,
            string? emergencyContactPhone, DateTime dateFilled, int membershipId)
        {
            Id = id;
            HealthIssue = healthIssue;
            EmergencyContactName = emergencyContactName;
            EmergencyContactPhone = emergencyContactPhone;
            DateFilled = dateFilled;
            MembershipId = membershipId;
            MembershipInfo = Membership.find(MembershipId);

            _Mode = enMode.Update;
        }

        public static HealthForm find(int Id)
        {
            string healthIssue = string.Empty;
            string? emergencyContactName = string.Empty, emergencyContactPhone = string.Empty;
            DateTime dateFilled = DateTime.Now;
            int membershipId = -1;

            if (HealthFormData.getHealthFormInfoById(Id, ref healthIssue, ref emergencyContactName, ref emergencyContactPhone,
                ref dateFilled, ref membershipId))

                return new HealthForm(Id, healthIssue, emergencyContactName, emergencyContactPhone, dateFilled, membershipId);
            else return null;
        }

        public int add(HealthForm obj)
        => obj.Id = HealthFormData.add(obj.HealthIssue, obj.EmergencyContactName, obj.EmergencyContactPhone,
            obj.DateFilled, obj.MembershipId);

        public bool update(HealthForm obj)
        => HealthFormData.update(obj.Id, obj.HealthIssue, obj.EmergencyContactName, obj.EmergencyContactPhone,
            obj.DateFilled, obj.MembershipId);

        public DataTable get() => HealthFormData.get();

        public bool delete(HealthForm obj) => HealthFormData.delete(obj.Id);
    }
}
