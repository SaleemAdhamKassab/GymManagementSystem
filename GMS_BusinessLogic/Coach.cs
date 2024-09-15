using System;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class Coach : Person
    {

        private enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode = enMode.AddNew;

        public int Id { get; set; }
        public string AchievementsAndAwards { get; set; }
        public bool IsActive {  get; set; }
        public int PersonId { get; set; }
        public int ClassTypeId { get; set; }
        public ClassType ClassTypeInfo { get; set; }

        public Coach() : base()
        {
            Id = -1;
            AchievementsAndAwards = string.Empty;
            IsActive = false;
            PersonId = -1;
            ClassTypeId = -1;

            _Mode = enMode.AddNew;
        }

        public Coach(int id, string achievementsAndAwards, bool isActive, int personId, int classTypeId,
            string fName, string sName, string thName, string lName, byte gendor,
            DateTime DOF, string address, string phone, string? email, string? imagePath, int roleId) :
        base(personId, fName, sName, thName, lName, gendor, DOF, address, phone, email, imagePath, roleId)
        {
            Id = id;
            AchievementsAndAwards = achievementsAndAwards;
            IsActive = isActive;
            PersonId = personId;
            ClassTypeId = classTypeId;
            ClassTypeInfo = ClassType.find(classTypeId);

            _Mode = enMode.Update;
        }

        public static Coach findById(int id)
        {
            int personId = -1, classTypeId = -1;
            string achivementAndAwards = string.Empty;
            bool isAvtive = false;

            if (CoachData.getCoachInfoById(id, ref achivementAndAwards, ref isAvtive, ref personId, ref classTypeId))
            {
                Person person = Person.find(personId);
                if (person == null) return null;

                return new Coach(id, achivementAndAwards, isAvtive, personId, classTypeId, person.FirstName,
                person.SecondName, person.ThirdName, person.LastName, person.Gendor,
                person.DateOfBirth, person.Address, person.Phone, person.Email, person.ImagePath, person.RoleId);
            }

            return null;
        }

        public static Coach findByPersonId(int personId)
        {
            int Id = -1, classTypeId = -1;
            string achivementAndAwards = string.Empty;
            bool isActvie = false;

            Person person = Person.find(personId);
            if (person == null) return null;

            if (CoachData.getCoachInfoByPersonId(personId, ref Id, ref achivementAndAwards, ref isActvie, ref classTypeId))

                return new Coach(Id, achivementAndAwards, isActvie, personId, classTypeId, person.FirstName,
                person.SecondName, person.ThirdName, person.LastName, person.Gendor, person.DateOfBirth,
                person.Address, person.Phone, person.Email, person.ImagePath, person.RoleId);

            return null;
        }

        public static Coach findByFullName(string fName, string sName, string thName, string lName)
        {
            byte gendor = 0;
            DateTime DOF = DateTime.Now;
            string address = string.Empty, phone = string.Empty, email = string.Empty, imagePath = string.Empty, acheAndAward = string.Empty;
            int id = -1, personId = -1, classTypeId = -1, roleId = -1;
            bool isActvie = false;

            if (CoachData.getCoachInfoByFullName(fName, sName, thName, lName, ref gendor, ref DOF,
                ref address, ref phone, ref email, ref imagePath, ref roleId, ref id, ref acheAndAward, ref isActvie,
                ref personId, ref classTypeId))

                return new Coach(id, acheAndAward, isActvie, personId, classTypeId, fName, sName, thName, lName, gendor,
                    DOF, address, phone, email, imagePath, roleId);

            return null;
        }

        public int add(Coach obj)
        => obj.Id = CoachData.add(obj.FirstName, obj.SecondName, obj.ThirdName, obj.LastName,
            obj.Gendor, obj.DateOfBirth, obj.Address, obj.Phone, obj.Email, obj.ImagePath, obj.AchievementsAndAwards,
            obj.IsActive, obj.ClassTypeId);

        public bool update(Coach obj)
        => CoachData.update(obj.Id, obj.FirstName, obj.SecondName, obj.ThirdName, obj.LastName,
            obj.Gendor, obj.DateOfBirth, obj.Address, obj.Phone, obj.Email, obj.ImagePath, obj.AchievementsAndAwards,
            obj.IsActive, obj.ClassTypeId, obj.PersonId);

        public DataTable get()
        => CoachData.get();

        public DataTable getCoachClassesbyPersonId(int personId)
        => CoachData.getCoachClassesInfoByPersonId(personId);

        public DataTable getAllCoachesWithOneClassByClassName(string className)
        => CoachData.getAllCoachWithOneClassByClassName(className.Trim());
    }
}
