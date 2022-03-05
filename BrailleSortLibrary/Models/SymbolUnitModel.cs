using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Models
{
    public class SymbolUnitModel
    {
        public int Id { get; set; }
        public int SymbolId { get; set; }
        public string SymbolName { get; set; }
        public int ChangeId { get; set; }
    }
}
