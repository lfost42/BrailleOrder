using BrailleSortLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Databases
{
    public class TicketControl
    {
        private readonly string _connectionString;
        private SqlDataAccess db = new SqlDataAccess();

        public TicketControl(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<TicketModel> GetAllTickets()
        {
            string sql = "select Id, TicketSubject, StatusClosed, TicketCreated, TicketUpdated from dbo.Tickets";

            return db.LoadData<TicketModel, dynamic>(sql, new { }, _connectionString);
        }

        //create ticket
        //read ticket
            //read list of attached notes

        //update ticket
            //create change record

        //delete ticket *owner only
    }
}
