using System.Collections.Generic;
using System.Data;
using cs_burger_shack.Interfaces;
using cs_burger_shack.Models;
using Dapper;

namespace cs_burger_shack.Repositories
{
    public class BurgersRepository : IRepository<Burger>
    {

        private readonly System.Data.IDbConnection _db;

        public BurgersRepository(IDbConnection db)
        {
            _db = db;
        }



        public IEnumerable<Burger> GetAll()
        {
            string sql = "SELECT * FROM burgers";
            return _db.Query<Burger>(sql);
        }

        public Burger GetById(int id)
        {
            string sql = "SELECT * FROM burgers WHERE id = @id";
            return _db.QueryFirstOrDefault<Burger>(sql, new { id });
        }

        public Burger Create(Burger data)
        {
            string sql = @"
            INSERT INTO burgers
            (name, cost, quantity, modifications, itemType)
            VALUES
            (@Name, @Cost, @Quantity, @Modifications, @ItemType)
            SELECT LAST_INSERT_ID()
            ";
            data.Id = _db.ExecuteScalar<int>(sql, data);
            return data;
        }

        public bool Update(Burger data)
        {
            string sql = @"
            UPDATE burgers
            SET
                name = @Name,
                cost = @Cost,
                quantity = @Quantity,
                modifications = @Modifications,
                itemType = @ItemType
            WHERE id = @id
            ";
            int affectedRows = _db.Execute(sql, data);
            return affectedRows == 1;
        }

        public bool Delete(int id)
        {
            string sql = "DELETE FROM burgers WHERE id = @id LIMIT 1";
            int affectedRows = _db.Execute(sql, new { id });
            return affectedRows == 1;
        }
    }
}
