using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace cs_burger_shack.Interfaces
{
    public interface IController<T>
    {
        ActionResult<IEnumerable<T>> GetAll();
        ActionResult<T> GetById(int id);
        ActionResult<T> Create(T data);
        ActionResult<T> Update(T data);
        ActionResult<T> Delete(int id);

    }
}