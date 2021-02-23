using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            ToTable("Users") // Tablo ismi
                .HasKey(k => k.ID); //Primary Key

            Property(p => p.FirstName)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            HasMany(r => r.Passwords)
                .WithRequired(r => r.User)
                .HasForeignKey(r => r.UserID);

            Map(a => a.MapInheritedProperties());
        }
    }
}
