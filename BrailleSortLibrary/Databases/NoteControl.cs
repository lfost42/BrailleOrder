using BrailleSortLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Databases
{
    public class NoteControl
    {
        private readonly string _connectionString;
        private SqlDataAccess db = new SqlDataAccess();

        public NoteControl(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<NoteModel> GetAllNotes()
        {
            string sql = "select Id, Note, NoteCreated, from dbo.Notes";

            return db.LoadData<NoteModel, dynamic>(sql, new { }, _connectionString);
        }

        //create notes
        //read note
        //update note
            //create change record

        //close note
        //delete note >> admin only
    }
}
