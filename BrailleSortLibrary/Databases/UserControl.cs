using BrailleSortLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary
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

        //Create user
        //Read user
        //Update User
            //create change record

        //Delete User
    }
}
