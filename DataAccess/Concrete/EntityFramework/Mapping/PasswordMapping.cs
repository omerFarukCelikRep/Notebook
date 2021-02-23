using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class PasswordMapping : EntityTypeConfiguration<Password>
    {
        public PasswordMapping()
        {
            ToTable("Passwords")
                .HasKey(k => k.ID);

            Property(p => p.UserPassword)
                .HasMaxLength(16)
        }
    }
}
