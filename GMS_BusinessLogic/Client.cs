using GMS_DataAccess;
using System.Data;

namespace GMS_BusinessLogic
{
	public class Client : IGmsRepo<Client>
	{
		private enum enMode { AddNew = 1, Update = 2 }
		private enMode _Mode = enMode.AddNew;

		public int Id { get; set; }
		public int PersonId { get; set; }
		public Person Person { get; set; }

		public Client() 
		{
			Id = -1;
			PersonId = -1;

			_Mode = enMode.AddNew;
		}

		private Client(int id, int personId)
		{
			Id = id;
			PersonId = personId;
			Person = Person.find(PersonId);

			_Mode = enMode.Update;
		}

		public DataTable get(string searchString) => ClientData.getClientsList();

		public static Client find(int id)
		{
			int personId = -1;

			if (ClientData.GetClientDataById(id, ref personId))

				return new Client(id, personId);

			else return null;
		}

		public static Client find(string firstName, string lastName)
		{
			int id = -1, personId = -1;

			if (ClientData.getClientInfoByFullName(firstName, lastName, ref id, ref personId))

				return new Client(id, personId);

			else
				return null;
		}

		public int add(Client obj)
		{
			throw new NotImplementedException();
		}
		public bool update(Client obj)
		{
			throw new NotImplementedException();
		}
		public bool delete(int id)
		{
			throw new NotImplementedException();
		}

	}
}