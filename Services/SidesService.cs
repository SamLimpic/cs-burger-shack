using System;
using System.Collections.Generic;
using cs_burger_shack.Interfaces;
using cs_burger_shack.Models;
using cs_burger_shack.Repositories;

namespace cs_burger_shack.Services
{
    public class SidesService : IService<Side>
    {

        private readonly SidesRepository _repo;

        public SidesService(SidesRepository repo)
        {
            _repo = repo;
        }



        public IEnumerable<Side> GetAll()
        {
            return _repo.GetAll();
        }



        public Side GetById(int id)
        {
            Side side = _repo.GetById(id);
            if (side == null)
            {
                throw new Exception("Invalid Id");
            }
            return side;
        }



        public Side Create(Side data)
        {
            return _repo.Create(data);
        }



        public Side Update(Side data)
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