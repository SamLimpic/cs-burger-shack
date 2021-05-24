using System.Collections.Generic;

namespace cs_burger_shack.Interfaces
{
    public interface IRepository<T>
    // NOTE Generic Repository template for all repositories EXCEPT Auth0
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Create(T data);
        bool Update(T data);
        bool Delete(int id);
    }
}