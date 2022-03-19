using BrailleSortLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Databases
{
    public class SymbolControl // // -->>Symbols
    {
        private readonly string _connectionString;
        private SqlDataAccess db = new SqlDataAccess();

        public SymbolControl(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<SymbolModel> GettAllSymbols()
        {
            string sql = "select Id, SymbolName from dbo.Symbols";
            return db.LoadData<SymbolModel, dynamic>(sql, new { }, _connectionString);
        }

        //create symbol
        //read symbol
        //update symbol
            //create change record

        //delete symbol
    }
}
