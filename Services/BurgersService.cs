using System;
using System.Collections.Generic;
using cs_burger_shack.Interfaces;
using cs_burger_shack.Models;
using cs_burger_shack.Repositories;

namespace cs_burger_shack.Services
{
    public class BurgersService : IService<Burger>
    {

        private readonly BurgersRepository _repo;

        public BurgersService(BurgersRepository repo)
        {
            _repo = repo;
        }



        public IEnumerable<Burger> GetAll()
        {
            return _repo.GetAll();
        }



        public Burger GetById(int id)
        {
            Burger burger = _repo.GetById(id);
            if (burger == null)
            {
                throw new Exception("Invalid Id");
            }
            return burger;
        }



        public Burger Create(Burger data)
        {
            return _repo.Create(data);
        }



        public Burger Update(Burger data)
        {
            if (_repo.Update(data))
            {
                return data;
            }
            throw new Exception("Something has gone wrong...");

        }



        public void Delete(int id)
        {
            if (!_repo.Delete(id))
            {
                throw new Exception("Something has gone wrong...");
            };
        }
    }
}