using System;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class ClassCategory
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;

        public ClassCategory() 
        {
            Id = -1;
            Name = string.Empty;

            _Mode = enMode.AddNew;
        }

        private ClassCategory(int id, string name)
        {
            Id = id;
            Name = name;

            _Mode = enMode.Update;
        }

        public int Id {  get; set; }
        public string Name { get; set; }

        public static ClassCategory find(int id)
        {
            string name = string.Empty;

            if (ClassCategoriesData.getCategoryClassInfoById(id, ref name))
            {
                return new ClassCategory(id, name);
            }

            else return null;
        }

        public static ClassCategory find(string name)
        {
            int id = -1;

            if (ClassCategoriesData.getCategoryClassInfoByName(ref id, name))
            {
                return new ClassCategory(id, name);
            }

            else return null;
        }

        public int add(ClassCategory classCategory) 
        => classCategory.Id = ClassCategoriesData.add(classCategory.Name);

        public bool update(ClassCategory classCategory) => ClassCategoriesData.update(classCategory.Id, classCategory.Name);

        public bool delete(int Id) => ClassCategoriesData.delete(Id);

        public DataTable get() => ClassCategoriesData.get();

        public DataTable getClassTypesByClassCategoryName(string categoryName)
        => ClassCategoriesData.getClassTypesByClassCategorName(categoryName);
    }
}
