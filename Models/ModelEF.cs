using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NormDiplom.Models
{
    public partial class ModelEF : DbContext
    {
        public ModelEF()
            : base("name=ModelEF")
        {
        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Disciplines> Disciplines { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Employee)
                .WithOptional(e => e.Book)
                .HasForeignKey(e => e.ReservedBookID);

            modelBuilder.Entity<Disciplines>()
                .HasMany(e => e.Book)
                .WithOptional(e => e.Disciplines1)
                .HasForeignKey(e => e.Disciplines);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Author)
                .WithOptional(e => e.Gender1)
                .HasForeignKey(e => e.Gender);
        }
    }
}
