using System.Collections.Generic;
using cs_burger_shack.Interfaces;
using cs_burger_shack.Models;

namespace cs_burger_shack.Repositories
{
    public class BurgersRepository : IRepo<Burger>
    {

        public IEnumerable<Burger> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Burger GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Burger Create(Burger data)
        {
            throw new System.NotImplementedException();
        }

        public Burger Update(Burger data)
        {
            throw new System.NotImplementedException();
        }

        public Burger Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
