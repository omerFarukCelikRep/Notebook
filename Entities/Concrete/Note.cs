using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Note : BaseEntity
    {
        public string Title { get; set; }
        public string NoteDetails { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }

    }
}
