using BrailleSortLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Databases
{
    public class AsciiControl // -->>Symbol
    {
        private readonly string _connectionString;
        private SqlDataAccess db = new SqlDataAccess();

        public AsciiControl(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<AsciiModel> GetAllAscii()
        {
            string sql = "select Id, Symbol, ChangeId from dbo.Symbol";
            return db.LoadData<AsciiModel, dynamic>(sql, new { }, _connectionString);
        }

        //create ascii entry
        //read ascii entry
        //update ascii entry
            //create change record

        //delete ascii entry

    }

}
