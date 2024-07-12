using System;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class PaymentMethod
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;

        public int Id { get; set; }
        public string Name { get; set; }

        public PaymentMethod()
        {
            Id = -1;
            Name = string.Empty;

            _Mode = enMode.AddNew;
        }

        private PaymentMethod(int id, string name)
        {
            Id = id;
            Name = name;

            _Mode = enMode.Update;
        }

        public static PaymentMethod find(int id)
        {
            string name = string.Empty;

            if (PaymentMethodData.getPaymentMethodById(id, ref name))
                return new PaymentMethod(id, name);
            else return null;
        }

        public static PaymentMethod find(string name)
        {
            int id = -1;

            if (PaymentMethodData.getPaymentMethodByName(name, ref id))
                return new PaymentMethod(id, name);
            else
                return null;
        }

        public int add(PaymentMethod obj) => obj.Id = PaymentMethodData.add(obj.Name);

        public bool update(PaymentMethod obj) => PaymentMethodData.update(obj.Id, obj.Name);

        public bool delete(PaymentMethod obj) => PaymentMethodData.delete(obj.Id);

        public DataTable get() => PaymentMethodData.get();
    }
}
