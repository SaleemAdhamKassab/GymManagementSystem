using System;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class ClassType
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;

        public int Id {  get; set; }
        public string Name { get; set; }
        public float Fees {  get; set; }
        public bool AllowFreeze {  get; set; }
        public string? ImagePath {  get; set; }
        public int CoachId {  get; set; }
        public int CategoryId { get; set; }
        public ClassCategory CategoryInfo {  get; set; }

        public ClassType()
        {
            Id = -1;
            Name = string.Empty;
            Fees = 0.0f;
            AllowFreeze = false;
            ImagePath = string.Empty;
            CoachId = -1;
            CategoryId = -1;
        }

        private ClassType(int id, string name, float fees,
            bool allowFreeze, string? imagePath, int coachId, int categoryId)
        {
            Id = id;
            Name = name;
            Fees = fees;
            AllowFreeze = allowFreeze;
            ImagePath = imagePath;
            CoachId = coachId;
            CategoryId = categoryId;
            CategoryInfo = ClassCategory.find(CategoryId);
        }

        public static ClassType find(int id)
        {
            int coachId = -1, categoryId = -1;
            bool allowFreeze = false; 
            float fees = 0.0f;
            string name = string.Empty;
            string ? imagePath = string.Empty;

            if (ClassTypesData.getClassDataTypesById(id, ref name, ref fees,
                ref allowFreeze, ref imagePath, ref coachId, ref categoryId))

                return new ClassType(id, name, fees, allowFreeze, imagePath, coachId, categoryId);

            else return null;
        }

        public static ClassType find(string name)
        {
            int id = -1, coachId = -1, categoryId = -1;
            bool allowFreeze = false;
            float fees = 0.0f;
            string? imagePath = string.Empty;

            if (ClassTypesData.getClassTypeInfoByName(name, ref id, ref fees,
                ref allowFreeze, ref imagePath, ref coachId, ref categoryId))

                return new ClassType(id, name, fees, allowFreeze, imagePath, coachId, categoryId);

            else return null;
        }

        public int add(ClassType obj)
        => obj.Id = ClassTypesData.add(obj.Name, obj.Fees, obj.AllowFreeze, obj.ImagePath, obj.CoachId, obj.CategoryId);

        public bool update(ClassType obj)
        => ClassTypesData.update(obj.Id, obj.Name, obj.Fees, obj.AllowFreeze, obj.ImagePath, obj.CoachId, obj.CategoryId);

        public bool delete(ClassType obj) => ClassTypesData.delete(obj.Id);

        public DataTable get() => ClassTypesData.get();

    }
}
