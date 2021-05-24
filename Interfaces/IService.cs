using System.Collections.Generic;

namespace cs_burger_shack.Interfaces
{
    public interface IService<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Create(T data);
        T Update(T data);
        void Delete(int id);
    }
}