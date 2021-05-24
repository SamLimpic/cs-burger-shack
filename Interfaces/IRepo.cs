using System.Collections.Generic;

namespace cs_burger_shack.Interfaces
{
    public interface IRepo<T>
    // NOTE Generic Repository template for all repositories EXCEPT Auth0
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Create(T data);
        T Update(T data);
        T Delete(int id);
    }
}