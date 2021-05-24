using cs_burger_shack.Enums;
using cs_burger_shack.Interfaces;

namespace cs_burger_shack.Models
{
    public class Burger : IMenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public string Modifications { get; set; }
        public ItemType ItemType { get => ItemType.Burger; }
    }
}