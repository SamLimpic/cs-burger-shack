using System.Collections.Generic;
using System.Linq;

namespace cs_burger_shack.Interfaces
{
    public interface IOrder
    {

        int Id { get; set; }

        string CustomerName { get; set; }

        List<IMenuItem> Items { get; set; }

        decimal Total { get => Items.Sum(i => i.Cost); }

    }
}