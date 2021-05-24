using System.Collections.Generic;
using System.Data;
using cs_burger_shack.Interfaces;
using cs_burger_shack.Models;
using Dapper;

namespace cs_burger_shack.Repositories
{
    public class SidesRepository : IRepository<Side>
    {

        private readonly System.Data.IDbConnection _db;

        public SidesRepository(IDbConnection db)
        {
            _db = db;
        }



        public IEnumerable<Side> GetAll()
        {
            string sql = "SELECT * FROM sides";
            return _db.Query<Side>(sql);
        }

        public Side GetById(int id)
        {
            string sql = "SELECT * FROM sides WHERE id = @id";
            return _db.QueryFirstOrDefault<Side>(sql, new { id });
        }

        public Side Create(Side data)
        {
            string sql = @"
            INSERT INTO sides
            (name, cost, quantity, modifications, itemType)
            VALUES
            (@Name, @Cost, @Quantity, @Modifications, @ItemType)
            SELECT LAST_INSERT_ID()
            ";
            data.Id = _db.ExecuteScalar<int>(sql, data);
            return data;
        }

        public bool Update(Side data)
        {
            string sql = @"
            UPDATE sides
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
            string sql = "DELETE FROM sides WHERE id = @id LIMIT 1";
            int affectedRows = _db.Execute(sql, new { id });
            return affectedRows == 1;
        }
    }
}
