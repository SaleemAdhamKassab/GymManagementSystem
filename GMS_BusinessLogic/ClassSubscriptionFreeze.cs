using System;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class ClassSubscriptionFreeze
    {
        private enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode = enMode.AddNew;

        public int Id {  get; set; }
        public DateTime FreezeStartDate { get; set; }
        public DateTime FreezeEndDate { get; set; }
        public int ClassSubscriptionId {  get; set; }
        public ClassSubscription ClassSubscriptionInfo { get; set; }

        private ClassSubscriptionFreeze(int id, DateTime freezeStartDate, DateTime freezeEndDate, int classSubscriptionId)
        {
            Id = id;
            FreezeStartDate = freezeStartDate;
            FreezeEndDate = freezeEndDate;
            ClassSubscriptionId = classSubscriptionId;
            ClassSubscriptionInfo = ClassSubscription.findById(classSubscriptionId);

            _Mode = enMode.Update;
        }

        public ClassSubscriptionFreeze()
        {
            Id = -1;
            FreezeStartDate = DateTime.Now;
            FreezeEndDate = DateTime.Now;
            ClassSubscriptionId = -1;
        }

        public static ClassSubscriptionFreeze find(int id)
        {
            DateTime freezeStartDate = DateTime.Now, freezeEndDate = DateTime.Now;
            int classSubscriptionId = -1;

            if (ClassSubscriptionFreezeData.getClassSubscriptionFreezeInfoById(id, ref freezeStartDate,
                ref freezeEndDate, ref classSubscriptionId))
            {
                return new ClassSubscriptionFreeze(id, freezeStartDate, freezeEndDate, classSubscriptionId);
            }
            else return null;
        }

        public static ClassSubscriptionFreeze findByClassSubscriptionId(int classSubscriptionId)
        {
            int Id = -1;
            DateTime freezeStartDate = DateTime.Now, freezeEndDate = DateTime.Now;

            if (ClassSubscriptionFreezeData.getClassSubscriptionFreezeInfoBySubscriptionId(classSubscriptionId, ref Id,
                ref freezeStartDate, ref freezeEndDate))
                return new ClassSubscriptionFreeze(Id, freezeStartDate, freezeEndDate, classSubscriptionId);
            else return null;
        }

        public int add(ClassSubscriptionFreeze obj)
        => obj.Id = ClassSubscriptionFreezeData.add(obj.FreezeStartDate, FreezeEndDate, obj.ClassSubscriptionId);

        public bool update(ClassSubscriptionFreeze obj)
        => ClassSubscriptionFreezeData.update(obj.Id, obj.FreezeStartDate, obj.FreezeEndDate, obj.ClassSubscriptionId);

        public bool delete(ClassSubscriptionFreeze obj)
        => ClassSubscriptionFreezeData.delete(obj.Id);

        public DataTable get() => ClassSubscriptionFreezeData.get();
    }
}
