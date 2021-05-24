using System.Collections.Generic;
using System.Data;
using cs_burger_shack.Interfaces;
using cs_burger_shack.Models;
using Dapper;

namespace cs_burger_shack.Repositories
{
    public class DrinksRepository : IRepository<Drink>
    {

        private readonly System.Data.IDbConnection _db;

        public DrinksRepository(IDbConnection db)
        {
            _db = db;
        }



        public IEnumerable<Drink> GetAll()
        {
            string sql = "SELECT * FROM drinks";
            return _db.Query<Drink>(sql);
        }

        public Drink GetById(int id)
        {
            string sql = "SELECT * FROM drinks WHERE id = @id";
            return _db.QueryFirstOrDefault<Drink>(sql, new { id });
        }

        public Drink Create(Drink data)
        {
            string sql = @"
            INSERT INTO drinks
            (name, cost, quantity, modifications, itemType)
            VALUES
            (@Name, @Cost, @Quantity, @Modifications, @ItemType)
            SELECT LAST_INSERT_ID()
            ";
            data.Id = _db.ExecuteScalar<int>(sql, data);
            return data;
        }

        public bool Update(Drink data)
        {
            string sql = @"
            UPDATE drinks
            SET
                name = @Name,
                cost = @Cost,
                quantity = @Quantity,
                modifications = @Modifications,
                itemType = @ItemType
            ";
            int affectedRows = _db.Execute(sql, data);
            return affectedRows == 1;
        }

        public bool Delete(int id)
        {
            string sql = "DELETE FROM drinks WHERE id = @id LIMIT 1";
            int affectedRows = _db.Execute(sql, new { id });
            return affectedRows == 1;
        }
    }
}
