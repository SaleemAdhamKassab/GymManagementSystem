using GMS_DataAccess;
using System.Data;

namespace GMS_BusinessLogic
{
	public class Supplier : IGmsRepo<Supplier>
	{
		private enum enMode { AddNew = 1, Update = 2 };
		private enMode _Mode = enMode.AddNew;

		public int Id { get; set; }
		public int PersonId { get; set; }
		public Person Person { get; set; }

		public Supplier() 
		{
			this.Id = -1;
			this.PersonId = -1;

			_Mode = enMode.AddNew;
		}

		private Supplier(int id, int personId)
		{
			this.Id = id;
			this.PersonId = personId;
			this.Person = Person.find(this.PersonId);

			_Mode = enMode.Update;
		}

		public static Supplier find(int id)
		{
			int personId = -1;

			if (SupplierData.getSupplierDataByPSupplierId(id, ref personId))
				return new Supplier(id, personId);
			else return null;
		}

		public static Supplier find(string firstName, string lastName)
		{
			int id = -1, personId = -1;

			if (SupplierData.getSupplierDataByFirstNameAndLastName(firstName, lastName, ref id, ref personId))
				return new Supplier(id, personId);
			else
				return null;
		}

		public int add(Supplier supplier) => supplier.Id = SupplierData.addSupplier(this.PersonId);

		public bool update(Supplier supplier) => SupplierData.updateSupplier(supplier.Id, supplier.PersonId);

		public DataTable get(string searchString) => throw new NotImplementedException();

		public bool delete(int id) => SupplierData.deleteSupplier(id);

		public static DataTable get() => SupplierData.get();

		public static bool isExist(int id) => SupplierData.isSupplierExist(id);
	}
}
