using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Models
{
    public class SymbolModel
    {
        public int Id { get; set; }
        public string Symbol { get; set; }

        [Display(Name = "Symbol Names")]
        public virtual ICollection<SymbolUnitModel> SymbolUnitModels { get; set; } = new HashSet<SymbolUnitModel>();
        
        [Display(Name = "Changes")]
        public virtual ICollection<ChangeModel> ChangeModels { get; set; } = new HashSet<ChangeModel>();
    }
}
