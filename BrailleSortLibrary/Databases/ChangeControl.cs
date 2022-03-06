using BrailleSortLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Databases
{
    public  class ChangeControl
    {
        private readonly string _connectionString;
        private SqlDataAccess db = new SqlDataAccess();

        public ChangeControl(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ChangeModel> GetAllChanges()
        {
            string sql = "select Id, UpdatedItem, Description, PreviousValue, CurrentValue, DateModified from dbo.Changes";

            return db.LoadData<ChangeModel, dynamic>(sql, new { }, _connectionString);
        }


        //create change
        //read change

        //no delete or modify
    }
}
