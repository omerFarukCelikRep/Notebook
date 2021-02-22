using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NotebookContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Note> Notes { get; set; }
        public NotebookContext() : base("name=notebookConnString")
        {
            Database.SetInitializer<NotebookContext>(new CreateDatabaseIfNotExists<NotebookContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasKey(s => s.UserID);
            //modelBuilder.Entity<Password>().HasKey(s => s.PasswordID);
            //modelBuilder.Entity<Note>().HasKey(s => s.NoteID);
            //modelBuilder.Entity<User>().Map(m =>
            //{
            //    m.Properties(p => new { p.UserID, p.PasswordID, p.NoteID, p.UserName, p.FirstName, p.LastName, p.IsActive });
            //    m.ToTable("Users");
            //});


            
        }
    }
}
