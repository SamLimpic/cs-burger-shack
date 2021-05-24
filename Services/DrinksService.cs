using System;
using System.Collections.Generic;
using cs_burger_shack.Interfaces;
using cs_burger_shack.Models;
using cs_burger_shack.Repositories;

namespace cs_burger_shack.Services
{
    public class DrinksService : IService<Drink>
    {

        private readonly DrinksRepository _repo;

        public DrinksService(DrinksRepository repo)
        {
            _repo = repo;
        }



        public IEnumerable<Drink> GetAll()
        {
            return _repo.GetAll();
        }



        public Drink GetById(int id)
        {
            Drink drink = _repo.GetById(id);
            if (drink == null)
            {
                throw new Exception("Invalid Id");
            }
            return drink;
        }



        public Drink Create(Drink data)
        {
            return _repo.Create(data);
        }



        public Drink Update(Drink data)
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