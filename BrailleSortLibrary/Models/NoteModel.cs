using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Models
{
    public class NoteModel
    {
        public int Id { get; set; }
        public string NoteTitle { get; set; }

        public string Description { get; set; }

        public int AuthorId { get; set; }

        public int TicketId { get; set; }


        [Display(Name = "Changes")]
        public virtual ICollection<ChangeModel> ChangeModels { get; set; } = new HashSet<ChangeModel>();
    }
}
