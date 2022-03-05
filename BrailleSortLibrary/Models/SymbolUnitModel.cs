using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Models
{
    public class SymbolUnitModel
    {
        public int Id { get; set; }
        public string SymbolName { get; set; }

        public int SymbolModel { get; set; }

        [Display(Name = "Changes")]
        public virtual ICollection<ChangeModel> ChangeModels { get; set; } = new HashSet<ChangeModel>();
    }
}
