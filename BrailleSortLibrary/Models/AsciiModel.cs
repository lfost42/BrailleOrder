using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Models
{
    public class AsciiModel
    {
        public int Id { get; set; }

        [StringLength(10, ErrorMessage = "The {0} must be atleast {2} and at most {1} characters.", MinimumLength = 3)]
        public string Symbol { get; set; }

        //Navigation

        [Display(Name = "Symbol Names")]
        public virtual ICollection<SymbolModel> SymbolModels { get; set; } = new HashSet<SymbolModel>();
        
        [Display(Name = "Changes")]
        public virtual ICollection<ChangeModel> ChangeModels { get; set; } = new HashSet<ChangeModel>();
    }
}
