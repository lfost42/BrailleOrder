using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }

        public string UserModelId { get; set; }
        public UserModel UserModel { get; set; }
    }
}
