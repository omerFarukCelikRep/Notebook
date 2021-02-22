using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Note : IEntity
    {
        public int NoteID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string NoteHeader { get; set; }
        public string NoteDetails { get; set; }

    }
}
