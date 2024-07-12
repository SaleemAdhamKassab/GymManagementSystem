using System;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class Membership
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;

        public int Id { get; set; }
        public DateTime DateOfBelong {  get; set; }
        public bool IsActive {  get; set; }
        public int ClientId {  get; set; }
        public Client ClientInfo { get; set; }

        public Membership()
        {
            Id = -1;
            DateOfBelong = DateTime.Now;
            IsActive = true;
            ClientId = -1;
        }

        private Membership(int id, DateTime dateOfBelong, bool isActive, int clientId)
        {
            Id = id;
            DateOfBelong = dateOfBelong;
            IsActive = isActive;
            ClientId = clientId;
            ClientInfo = Client.find(ClientId);
        }

        public static Membership find(int Id)
        {
            DateTime dateOfBelong = DateTime.Now;
            bool isActive = false;
            int clientId = -1;

            if (MembershipData.getMembershipInfoById(Id, ref dateOfBelong, ref isActive, ref clientId))
                return new Membership(Id, dateOfBelong, isActive, clientId);
            else return null;
        }

        public static Membership findByClientId(int clientId)
        {
            DateTime dateOfBelong = DateTime.Now;
            bool isActive = false;
            int Id = -1;

            if (MembershipData.getMembershipInfoByClientId(clientId, ref Id, ref dateOfBelong, ref isActive))
                return new Membership(Id, dateOfBelong, isActive, clientId);
            else return null;
        }

        public int add(Membership obj)
        => obj.Id = MembershipData.add(obj.DateOfBelong, obj.ClientId);

        public bool update(Membership obj)
        => MembershipData.update(obj.Id, obj.DateOfBelong, obj.IsActive);

        public bool activatie()
        => MembershipData.activate(this.Id);

        public bool deactive()
        => MembershipData.deactivate(this.Id);

        public bool delete(Membership obj)
        => MembershipData.delete(obj.Id);

        public DataTable get() => MembershipData.get();
    }
}
