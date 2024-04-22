using System;
using System.Data;

namespace GMS_BusinessLogic
{
    public interface IGmsRepo<T>
    {// public T add(T obj)
        public int add(T obj);
        public DataTable get();
        public bool update(T obj);
        public bool delete(int id);
    }
}
