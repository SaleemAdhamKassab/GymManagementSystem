using System;
using System.Data;
using System.Runtime.CompilerServices;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class ClassSubscription
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;

        public enum enSubscripeStatus { New = 1, Renew = 2, Freeze = 3, Expired = 4, ExpireSoon = 5 };
        
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public ClassSubscription.enSubscripeStatus SubscripeStatus { get; set; }
        public bool IsFrozen {  get; set; }
        public int PaymentId {  get; set; }
        public Payment PaymentInfo { get; set; }
        public int ClassTypeId {  get; set; }
        public ClassType ClassTypeInfo { get; set; }
        public int MembershipId {  get; set; }
        public Membership MembershipInfo {  get; set; }
        

        public ClassSubscription()
        {
            Id = -1;
            StartDate = DateTime.Now;
            ExpireDate = DateTime.Now;
            SubscripeStatus = enSubscripeStatus.New;
            IsFrozen = false;
            PaymentId = -1;
            ClassTypeId = -1;
            MembershipId = -1;
        }

        private ClassSubscription(int id, DateTime startDate, DateTime expireDate, 
            enSubscripeStatus subscripeMode, bool isFrozen, int paymentId,
            int classTypeId, int membershipId)
        {
            Id = id;
            StartDate = startDate;
            ExpireDate = expireDate;
            SubscripeStatus = subscripeMode;
            IsFrozen = isFrozen;
            PaymentId = paymentId;
            PaymentInfo = Payment.find(PaymentId);
            ClassTypeId = classTypeId;
            ClassTypeInfo = ClassType.find(ClassTypeId);
            MembershipId = membershipId;
            MembershipInfo = Membership.find(MembershipId);
        }

        public static ClassSubscription find(int id)
        {
            DateTime startDate = DateTime.Now, expireDate = DateTime.Now;
            byte subscribeStatus = 1;
            bool isFrozen = false;
            int paymentId = -1, classTypeId = -1, membershipId = -1;

            if (ClassSubscriptionData.getClassSubscriptionInfoById(id, ref startDate, ref expireDate,
                ref subscribeStatus, ref isFrozen, ref paymentId, ref classTypeId, ref membershipId))
            {
                return new ClassSubscription(id, startDate, expireDate, (enSubscripeStatus)subscribeStatus, isFrozen, paymentId, classTypeId,
                    membershipId);
            }

            else return null;
        }

        public bool deactiveMembership()
        {
            if (ClassSubscriptionData.checkActivationClassesForMembership(this.MembershipInfo.Id))
                if( MembershipInfo.deactive())
                    return true;
            return false;
        }

        public int add(ClassSubscription obj)
        => obj.Id = ClassSubscriptionData.add(obj.StartDate, obj.ExpireDate,
            obj.PaymentId, obj.ClassTypeId, obj.MembershipId);

        public bool update(ClassSubscription obj)
        => ClassSubscriptionData.update(obj.Id, obj.StartDate, obj.ExpireDate, (byte)obj.SubscripeStatus,
            obj.IsFrozen, obj.PaymentId, obj.ClassTypeId, obj.MembershipId);

        public bool renew(ClassSubscription obj)
        => ClassSubscriptionData.renew(obj.Id);

        public bool takeFreeze(ClassSubscription obj)
        => ClassSubscriptionData.takeFreeze(obj.Id);

        

        public DataTable getExpiredSoonList() => ClassSubscriptionData.getExpiredSoonList();


    }
}
