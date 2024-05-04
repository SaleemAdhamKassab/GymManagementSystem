using System.Data;

namespace GMS_BusinessLogic
{
	public class Client : IGmsRepo<Client>
	{
		public int Id { get; set; }
		public int PersonId { get; set; }
		public Person Person { get; set; }


		public DataTable get(string searchString)
		{
			throw new NotImplementedException();
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