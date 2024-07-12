using GMS_DataAccess;
using System.Data;

namespace GMS_BusinessLogic
{
	public class User : IGmsRepo<User>
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int PersonId { get; set; }
		public Person PersonInfo { get; set; }

		public User()
		{

		}

		private User(int id, string userName, string password, int personId)
		{
			Id = id;
			UserName = userName;
			Password = password;
			PersonId = personId;
			PersonInfo = Person.find(personId);
		}

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
			int personId = -1;
			string userName = string.Empty, password = string.Empty;

			if (UserData.GetUserInfoById(id, ref userName, ref password, ref personId))
				return new User(id, userName, password, personId);
			else return null;
		}
	}
}