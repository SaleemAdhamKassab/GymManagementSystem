using GMS_DataAccess;
using System.Data;

namespace GMS_BusinessLogic
{
	public class Client : Person
	{
		private enum enMode { AddNew = 1, Update = 2 }
		private enMode _Mode = enMode.AddNew;

		public int ClientId { get; set; }
		public int PersonId { get; set; }

		public Client() : base() 
		{
			ClientId = -1;
			PersonId = -1;

			_Mode = enMode.AddNew;
		}

		private Client(int clientId, int personId, string firstName, string secName, string thirdName, string lastName,
			byte gendor, DateTime dateOfBirth, string address, string phone, string? email, string? imagePath, int roleId) : 
			base(personId, firstName, secName, thirdName, lastName, gendor, dateOfBirth, address,
				phone, email, imagePath, roleId)
		{
			this.ClientId = clientId;
			this.PersonId = personId;

			Person person = Person.find(personId);
			if (person == null)
				return;

			this.FirstName = person.FirstName;
			this.SecondName = person.SecondName;
			this.ThirdName = person.ThirdName;
			this.LastName = person.LastName;
			this.Gendor = person.Gendor;
			this.DateOfBirth = person.DateOfBirth;
			this.Address = person.Address;
			this.Phone = person.Phone;
			this.Email = person.Email;
			this.ImagePath = person.ImagePath;
			this.RoleId = person.RoleId;

			_Mode = enMode.Update;
		}

		public DataTable get(string searchString) => ClientData.getClientsList();

		public static Client find(int id)
		{
			int personId = -1, roleId = -1;
			string firstName = "", secName = "", thirdName = "", lastName = "", address = "", phone = "";
			string? email = "", imagePath = "";
			byte gendor = 0;
			DateTime dateOfBirth = DateTime.Now;

			if (ClientData.GetClientDataById(id, ref personId))

				return new Client(id, personId, firstName, secName, thirdName, lastName,
					gendor, dateOfBirth, address, phone, email, imagePath, roleId);

			else return null;
		}

		public static Client find(string fullName)
		{
			int clientId = -1, personId = -1, roleId = -1;
			string? imagePath = "", email = "";
			string phone = "", address = "", firstName = fullName.Split(' ')[0], secondName = fullName.Split(' ')[1],
			thirdName = fullName.Split(' ')[2], lastName = fullName.Split(' ')[3];
			byte gendor = 0;
			DateTime dateOfBirth = DateTime.Now;

			if (ClientData.getClientInfoByFullName(fullName, ref phone,
				ref address, ref email, ref imagePath, ref roleId ,ref personId, ref clientId))

				return new Client(clientId, personId, firstName, secondName, thirdName, lastName, gendor,
					dateOfBirth, address, phone, email, imagePath, roleId);

			else
				return null;
		}

		public int add(Client obj)
		{
			int clientId = -1;

			clientId = ClientData.add(obj.FirstName, obj.SecondName, obj.ThirdName, obj.LastName,
				obj.Gendor, obj.DateOfBirth, obj.Address, obj.Phone, obj.Email, obj.ImagePath, obj.RoleId, obj.PersonId);

			return clientId;
		}

		public bool update(Client obj) =>
		ClientData.update(obj.ClientId, obj.FirstName, obj.SecondName, obj.ThirdName, obj.LastName,
			obj.Gendor, obj.DateOfBirth, obj.Address,
			obj.Phone, obj.Email, obj.ImagePath, obj.RoleId, obj.PersonId);
		public static bool delete(Client obj)
		=> ClientData.delete(obj.ClientId, obj.PersonId);

	}
}