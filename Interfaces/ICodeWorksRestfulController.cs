using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace cs_burger_shack.Interfaces
{
    public interface ICodeWorksRestfulController<T>
    {
        ActionResult<IEnumerable<T>> Get();
        ActionResult<T> GetOne();
        ActionResult<T> Create();
        ActionResult<T> Update();
        ActionResult<T> Delete();

    }
}