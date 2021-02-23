﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Password : BaseEntity
    {
        public string UserPassword { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
