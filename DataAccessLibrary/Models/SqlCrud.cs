using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqlCrud
    {
        private readonly string _connectionString;
        private SqlDataAccess db = new SqlDataAccess();

        public SqlCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<BasicUserModel> GetAllUsers()
        {
            string sql = "select Id, FirstName, LastName from dbo.Users";

            return db.LoadData<BasicUserModel, dynamic>(sql, new { }, _connectionString);
        }
    }
}
