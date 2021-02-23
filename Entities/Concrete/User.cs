using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public enum UserRole
    {
        Admin = 1,
        User
    }
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public UserRole Role { get; set; }
        public ICollection<Password> Passwords { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
