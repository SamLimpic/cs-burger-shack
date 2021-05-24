using cs_burger_shack.Enums;

namespace cs_burger_shack.Interfaces
{
    public interface IMenuItem
    {

        int Id { get; set; }

        string Name { get; set; }

        decimal Cost { get; set; }

        int Quantity { get; set; }

        string Modifications { get; set; }

        ItemType ItemType { get; }
        // NOTE You don't want to "set" this value, as it is dynamically-generated

    }
}