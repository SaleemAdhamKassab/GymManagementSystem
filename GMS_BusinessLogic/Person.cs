using System;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
	public class Person : IGmsRepo<Person>
	{
		private enum enMode { AddNew = 1, Update = 2 };
		private enMode _Mode = enMode.AddNew;

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName
		{
			get
			{
				return FirstName + " " + LastName;
			}
		}
		public string Address { get; set; }
		public string Phone { get; set; }
		public int RoleId { get; set; }
		public Role PersonRole { get; set; }

		public Person()
		{
			this.Id = -1;
			this.FirstName = string.Empty;
			this.LastName = string.Empty;
			this.Address = string.Empty;
			this.Phone = string.Empty;
			this.RoleId = -1;

			_Mode = enMode.AddNew;
		}

		private Person(int id, string firstName, string lastName, string address, string phone, int roleId)
		{
			this.Id = id;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Address = address;
			this.Phone = phone;
			this.RoleId = roleId;
			this.PersonRole = Role.find(this.RoleId);

			_Mode = enMode.Update;
		}

		public static Person find(int id)
		{
			string firstName = "", lastName = "", address = "", phone = "";
			int roleId = -1;

			if (PersonData.getPersonDataById(id, ref firstName, ref lastName, ref address, ref phone, ref roleId))
				return new Person(id, firstName, lastName, address, phone, roleId);
			else return null;
		}
		public int add(Person person) => person.Id = PersonData.add(person.FirstName, person.LastName, person.Address, person.Phone, person.RoleId);
		public bool update(Person person) => PersonData.update(person.Id, person.FirstName, person.LastName, person.Address, person.Phone, person.RoleId);
		public DataTable get(string searchString) => throw new NotImplementedException();
		public static DataTable get() => PersonData.getPersonList();
		public bool delete(int id) => PersonData.deletePerson(id);
		public static bool isExist(int id) => PersonData.isPersonExist(id);
	}
}
