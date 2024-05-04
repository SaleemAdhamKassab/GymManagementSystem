using System.Data;

namespace GMS_BusinessLogic
{
	public class User : IGmsRepo<User>
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int PersonId { get; set; }
		public Person Person { get; set; }


		public DataTable get(string searchString)
		{
			throw new NotImplementedException();
		}
		public int add(User obj)
		{
			// Note: generate auto userName
			throw new NotImplementedException();
		}
		public bool update(User obj)
		{
			throw new NotImplementedException();
		}
		public bool delete(int id)
		{
			throw new NotImplementedException();
		}
		public static User find(int id)
		{
			throw new NotImplementedException();
		}
	}
}