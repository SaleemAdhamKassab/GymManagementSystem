using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class OfferClassSubscription
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;

        public int Id { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public float PaidAmount { get; set; }
        public int ClassSubscriptionId { get; set; }
        public int OfferId { get; set; }
        public ClassSubscription ClassSubscriptionInfo { get; set; }
        public Offer OfferInfo { get; set; }

        public OfferClassSubscription()
        {
            Id = -1;
            SubscriptionDate = DateTime.Now;
            PaidAmount = 0.0f;
            ClassSubscriptionId = -1;
            OfferId = -1;

            _Mode = enMode.AddNew;
        }

        private OfferClassSubscription(int id, DateTime subscriptionDate, float paidAmount, int classSubscriptionId, int offerId)
        {
            Id = id;
            SubscriptionDate = subscriptionDate;
            PaidAmount = paidAmount;
            ClassSubscriptionId = classSubscriptionId;
            ClassSubscriptionInfo = ClassSubscription.findById(classSubscriptionId);
            OfferId = offerId;
            OfferInfo = Offer.find(offerId);

            _Mode = enMode.Update;
        }

        public static OfferClassSubscription find(int id)
        {
            DateTime subscripeDate = DateTime.Now;
            float paidAmount = 0.0f;
            int classSubscriptionId = -1, offerId = -1;

            if (OfferClassSubscriptionData.getOfferClassSubscriptionInfoById(id, ref subscripeDate, ref paidAmount,
                ref classSubscriptionId, ref offerId))
            {
                return new OfferClassSubscription(id, subscripeDate, paidAmount, classSubscriptionId, offerId);
            }
            else return null;
        }

        public static OfferClassSubscription findByOfferId(int offerId)
        {
            DateTime subscripeDate = DateTime.Now;
            float paidAmount = 0.0f;
            int classSubscriptionId = -1, id = -1;

            if (OfferClassSubscriptionData.getOfferClassSubscriptionInfoByOfferId(offerId, ref id, ref subscripeDate,
                ref paidAmount, ref classSubscriptionId))
            {
                return new OfferClassSubscription(id, subscripeDate, paidAmount, classSubscriptionId, offerId);
            }
            else return null;
        }

        public int add(OfferClassSubscription obj)
        => obj.Id = OfferClassSubscriptionData.add(obj.SubscriptionDate, obj.PaidAmount, obj.ClassSubscriptionId, obj.OfferId);

        public bool update(OfferClassSubscription obj)
        => OfferClassSubscriptionData.update(obj.Id, obj.SubscriptionDate, obj.PaidAmount,
            obj.ClassSubscriptionId, obj.OfferId);

        public DataTable getOfferSubscripers(OfferClassSubscription obj)
        => OfferClassSubscriptionData.getOfferSubscripers(obj.OfferId);
    }
}
