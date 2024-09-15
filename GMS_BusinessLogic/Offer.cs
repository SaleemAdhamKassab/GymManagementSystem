using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class Offer
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
        public int Duration {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AddedOn { get; set; }
        public float FeeAfterDicount {  get; set; }
        public int ClassTypeId {  get; set; }
        public ClassType ClassTypeInfo { get; set; }


        public Offer()
        {
            Id = -1;
            Name = string.Empty;
            Discount = 0;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            AddedOn = DateTime.Now;
            FeeAfterDicount = 0.0f;
            ClassTypeId = -1;

            _Mode = enMode.AddNew;
        }

        private Offer(int id, string name, int discount, int duration, DateTime startDate, 
            DateTime endDate, DateTime addedOn, float feeAfterDiscount, int classTypeId)
        {
            Id = id;
            Name = name;
            Discount = discount;
            Duration = duration;
            StartDate = startDate;
            EndDate = endDate;
            AddedOn = addedOn;
            FeeAfterDicount = feeAfterDiscount;
            ClassTypeId = classTypeId;
            ClassTypeInfo = ClassType.find(ClassTypeId);

            _Mode = enMode.Update;
        }

        public static Offer find(int id)
        {
            string name = string.Empty;
            int discount = 0, duration = 0, classTypeId = -1;
            DateTime startDate = DateTime.Now, endDate = DateTime.Now, addedOn = DateTime.Now;
            float feeAfterDiscount = 0.0f;

            if (OfferData.getOfferInfoById(id, ref name, ref discount, ref duration, ref startDate, ref endDate,
                ref addedOn, ref feeAfterDiscount, ref classTypeId))
                return new Offer(id, name, discount, duration, startDate, endDate, addedOn, feeAfterDiscount, classTypeId);
            else
                return null;
        }

        public static Offer find(string name)
        {
            int id = -1, discount = 0, duration = 0, classTypeId = -1;
            DateTime startDate = DateTime.Now, endDate = DateTime.Now, addedOn = DateTime.Now;
            float feeAfterDiscount = 0.0f;

            if (OfferData.getOfferInfoByName(name, ref id, ref discount, ref duration, ref startDate, ref endDate,
                ref addedOn, ref feeAfterDiscount, ref classTypeId))
                return new Offer(id, name, discount, duration, startDate, endDate, addedOn, feeAfterDiscount, classTypeId);
            else
                return null;
        }

        public int add(Offer obj)
        => obj.Id = OfferData.add(obj.Name, obj.Discount, obj.Duration, obj.StartDate,
            obj.EndDate, obj.AddedOn, obj.FeeAfterDicount, obj.ClassTypeId);

        public bool update(Offer obj)
        => OfferData.update(obj.Id, obj.Name, obj.Discount, obj.Duration, 
            obj.StartDate, obj.EndDate, obj.AddedOn, obj.FeeAfterDicount, obj.ClassTypeId);

        public DataTable getOfferByClassName(string className)
        => OfferData.getOfferClassByClassName(className);

        public DataTable get() => OfferData.get();
    }
}
