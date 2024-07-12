using System;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class Payment
    {
        private enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode = enMode.AddNew;

        public int Id { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
        public int PaymentMethodId {  get; set; }
        public PaymentMethod PaymentMethodInfo { get; set; }

        public Payment()
        {
            Id = -1;
            Amount = 0.0f;
            Date = DateTime.Now;
            PaymentMethodId = -1;

            _Mode = enMode.AddNew;
        }

        private Payment(int id, float amount, DateTime date, int paymentMethodId)
        {
            Id = id;
            Amount = amount;
            Date = date;
            PaymentMethodId = paymentMethodId;
            PaymentMethodInfo = PaymentMethod.find(PaymentMethodId);

            _Mode = enMode.Update;
        }

        public static Payment find(int Id)
        {
            float amount = 0.0f;
            DateTime date = DateTime.Now;
            int paymentMethodId = -1;

            if (PaymentData.getPaymentInfoById(Id, ref amount, ref date, ref paymentMethodId))
            {
                return new Payment(Id, amount, date, paymentMethodId);
            }
            else return null;
        }

        public int add(Payment obj)
        => obj.Id = PaymentData.add(obj.Amount, obj.Date, obj.PaymentMethodId);

        public bool update(Payment obj)
        => PaymentData.Update(obj.Id, obj.Amount, obj.Date, obj.PaymentMethodId);

        public bool delete(int Id) => PaymentData.delete(Id);

        public DataTable get() => PaymentData.get();
    }
}
