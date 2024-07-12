using System;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
	public class Person : IGmsRepo<Person>
	{
		private enum enMode { AddNew = 1, Update = 2 };
		private enMode _Mode = enMode.AddNew;

		public int PersonId { get; set; }
		public string FirstName { get; set; }
		public string SecondName {  get; set; }
		public string ThirdName {  get; set; }
		public string LastName { get; set; }
		public byte Gendor {  get; set; }
		public DateTime DateOfBirth { get; set; }
		public string FullName
		{
			get
			{
				return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
			}
		}
		public string Address { get; set; }
		public string Phone { get; set; }
		public string? Email {  get; set; }
		public int RoleId { get; set; }
		public Role PersonRole { get; set; }
		public string? ImagePath {  get; set; }

		public Person()
		{
			this.PersonId = -1;
			this.FirstName = string.Empty;
			this.SecondName = string.Empty;
			this.ThirdName = string.Empty;
			this.LastName = string.Empty;
			this.Gendor = 0;
			this.DateOfBirth = DateTime.Now;
			this.Address = string.Empty;
			this.Phone = string.Empty;
			this.Email = string.Empty;
			this.ImagePath = string.Empty;
			this.RoleId = -1;

			_Mode = enMode.AddNew;
		}

		protected Person(int id, string firstName, string secName, string thirdName
			, string lastName, byte gendor, DateTime dateOfBirth, string address, string phone, string? email, string? imagePath, int roleId)
		{
			this.PersonId = id;
			this.FirstName = firstName;
			this.SecondName = secName;
			this.ThirdName = thirdName;
			this.LastName = lastName;
			this.Gendor = gendor;
			this.DateOfBirth = dateOfBirth;
			this.Address = address;
			this.Phone = phone;
			this.Email = email;
			this.RoleId = roleId;
			this.PersonRole = Role.find(this.RoleId);
			this.ImagePath = imagePath;

			_Mode = enMode.Update;
		}

		public static Person find(int id)
		{
			string firstName = "", secName = "", thirdName = "", lastName = "", address = "", phone = ""; 
			string? email = "", imagePath = "";
			int roleId = -1;
			byte gendor = 0;
			DateTime dateOfBirth = DateTime.Now;

			if (PersonData.getPersonDataById(id, ref firstName, ref secName, ref thirdName,
				ref lastName, ref gendor, ref dateOfBirth, ref address, ref email, ref phone, ref imagePath, ref roleId))
				return new Person(id, firstName, secName, thirdName, lastName, gendor, dateOfBirth, address, phone, email, imagePath, roleId);
			else return null;
		}
		public int add(Person person) => person.PersonId = PersonData.add(person.FirstName, person.SecondName, person.ThirdName, person.LastName,
			person.Gendor, person.DateOfBirth, person.Address, person.Phone, person.Email, person.ImagePath, person.RoleId);
		public bool update(Person person) => PersonData.update(person.PersonId, person.FirstName, person.SecondName, person.ThirdName, person.LastName,
			person.Gendor, person.DateOfBirth, person.Address, person.Phone, person.Email, person.ImagePath, person.RoleId);
		public DataTable get(string searchString) => throw new NotImplementedException();
		public static DataTable get() => PersonData.getPersonList();
		public bool delete(int id) => PersonData.deletePerson(id);
		public static bool isExist(int id) => PersonData.isPersonExist(id);
	}
}
