using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Models
{
    public class ChangeModel
    {
        public int Id { get; set; }

        [DisplayName("Item")]
        public string UpdatedItem { get; set; }
        public string Description { get; set; }

        [DisplayName("Previous Value")]
        public string PreviousValue { get; set; }

        [DisplayName("Current Value")]
        public string CurrentValue { get; set; }

        [DisplayName("Date Modified")]
        public DateTimeOffset DateModified { get; set; }

    }
}
