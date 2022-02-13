using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class UserControl
    {
        private readonly string _connectionString;
        private SqlDataAccess db = new SqlDataAccess();

        public UserControl(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<UserModel> GetAllUsers()
        {
            string sql = "select Id, FirstName, LastName from dbo.Users";

            return db.LoadData<UserModel, dynamic>(sql, new { }, _connectionString);
        }
    }
}
