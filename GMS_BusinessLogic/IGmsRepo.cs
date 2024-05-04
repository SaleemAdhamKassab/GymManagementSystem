using System;
using System.Data;

namespace GMS_BusinessLogic
{
    public interface IGmsRepo<T>
    {
        public DataTable get(string searchString);
        public int add(T obj);
        public bool update(T obj);
        public bool delete(int id);
    }
}
