using BrailleSortLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Model
{
    public class TicketModel
    {
        public int Id { get; set; }
        public string Ticket { get; set; }

        public int? ChangeModelId { get; set; }

        [Display(Name = "Notes")]
        public virtual ICollection<NoteModel> NoteModels { get; set; } = new HashSet<NoteModel>();

        [Display(Name = "Changes")]
        public virtual ICollection<ChangeModel> ChangeModels { get; set; } = new HashSet<ChangeModel>();

    }
}
