using GMS_DataAccess;
using System.Data;

namespace GMS_BusinessLogic
{
	public class User : Person
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }
		public bool IsAdmin {  get; set; }
		public int PersonId { get; set; }
		public User() : base()
		{
            Id = -1;
            UserName = string.Empty;
            Password = string.Empty;
			IsAdmin = false;
            IsActive = false;
            PersonId = -1;
        }

		private User(int id, string fName, string sName, string thName, string lName,
			byte gendor, DateTime DOF, string address, string phone, string email, string imagePath, int roleId,
			string userName, string password, bool isAdmin, bool isActive, int personId) : 
			base(personId, fName, sName, thName, lName, gendor, DOF, address, phone, email, imagePath, roleId)
		{
			Id = id;
			UserName = userName;
			Password = password;
			IsAdmin = isAdmin;
			IsActive = isActive;
			PersonId = personId;
		}

		public DataTable get()
		=> UserData.get();

		public int add(User obj)
		=> obj.Id = UserData.add(obj.FirstName, obj.SecondName, obj.ThirdName, obj.LastName, obj.Gendor,
		obj.DateOfBirth, obj.Address, obj.Phone, obj.Email,
		obj.ImagePath, obj.UserName, obj.Password, obj.IsAdmin, obj.IsActive);

		public bool update(User obj)
		=> UserData.update(obj.Id, obj.FirstName, obj.SecondName, obj.ThirdName, obj.LastName,
		obj.Gendor, obj.DateOfBirth, obj.Address, obj.Phone, obj.Email, obj.ImagePath, obj.UserName,
		obj.Password, obj.IsAdmin, obj.IsActive, obj.PersonId);
		
		public bool delete(User obj)
		=> UserData.Delete(obj.Id);
		
		public static User findByUserId(int id)
		{
			int personId = -1;
			string userName = string.Empty, password = string.Empty;
			bool isActive = false, isAdmin = false;

			if (UserData.GetUserInfoById(id, ref userName, ref password, ref isAdmin, ref isActive, ref personId))
			{
				Person person = Person.find(personId);

				if (person == null) return null;

				return new User(id ,person.FirstName, person.SecondName, person.ThirdName, person.LastName, person.Gendor, 
					person.DateOfBirth, person.Address, person.Phone, person.Email, person.ImagePath, person.RoleId,
					userName, password, isAdmin, isActive, personId);
			}

			else return null;
		}

		public static User findByPersonId(int personId)
		{
			int Id = -1;
			string userName = string.Empty, password = string.Empty;
			bool isActive = false, isAdmin = false;

			Person person = Person.find(personId);
			if (person == null) return null;

			if (UserData.getUserInfoByPersonId(personId, ref Id, ref userName, ref isAdmin, ref password, ref isActive))
				return new User(Id, person.FirstName, person.SecondName, person.ThirdName, person.LastName, person.Gendor,
                    person.DateOfBirth, person.Address, person.Phone,
					person.Email, person.ImagePath, person.RoleId,
					userName, password, isAdmin, isActive, personId);

			return null;
		}

		public static User findByUserNameAndPassword(string userName, string password)
		{
			int id = -1, personId = -1;
			bool isActive = false, isAdmin = false;


            if (UserData.getUserByUserNameAndPassword(userName, password, ref id, ref isAdmin, ref isActive, ref personId))
			{
				Person person = Person.find(personId);
				if (person == null) return null;

				return new User(id, person.FirstName, person.SecondName, person.ThirdName, person.LastName, person.Gendor,
                    person.DateOfBirth, person.Address, person.Phone,
                    person.Email, person.ImagePath, person.RoleId,
                    userName, password, isAdmin, isActive, personId);
            }

			return null;
		}
	}
}