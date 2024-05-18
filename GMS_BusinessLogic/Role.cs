using System;
using System.Data;
using System.Data.SqlClient;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class Role : IGmsRepo<Role>
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public Role()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        private Role(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int add(Role role) => role.Id = RoleData.add(role.Name);
        public static DataTable get() => RoleData.get();
        public bool update(Role role) => RoleData.update(role.Id, role.Name);
        public DataTable get(string searchString) => throw new NotImplementedException();
        public bool delete(int  id) => RoleData.delete(id);
        public static Role find(int Id)
        {
            string name = string.Empty;

            if (RoleData.findById(Id, ref name))
                return new Role(Id, name);
            else
                return null;
        }
        public static Role find(string name) 
        {
            int id = -1;

            if (RoleData.findByName(ref id, name))
                return new Role(id, name);
            else
                return null;
        }
    }
}
