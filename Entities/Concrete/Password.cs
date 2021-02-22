using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Password : IEntity
    {
        public int PasswordID { get; set; }
        public int UserID { get; set; }
        public string UserPassword { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
