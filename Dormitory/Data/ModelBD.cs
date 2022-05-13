using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Dormitory.Data
{
    public partial class ModelBD : DbContext
    {
        public ModelBD()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<TParents> TParents { get; set; }
        public virtual DbSet<TParentsStudents> TParentsStudents { get; set; }
        public virtual DbSet<TRooms> TRooms { get; set; }
        public virtual DbSet<TStudents> TStudents { get; set; }
        public virtual DbSet<TStudentsRooms> TStudentsRooms { get; set; }
        public virtual DbSet<TUsers> TUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TParents>()
                .HasMany(e => e.TParentsStudents)
                .WithRequired(e => e.TParents)
                .HasForeignKey(e => e.IdParents);

            modelBuilder.Entity<TRooms>()
                .HasMany(e => e.TStudentsRooms)
                .WithRequired(e => e.TRooms)
                .HasForeignKey(e => e.IdRooms);

            modelBuilder.Entity<TStudents>()
                .HasMany(e => e.TParentsStudents)
                .WithRequired(e => e.TStudents)
                .HasForeignKey(e => e.IdStudents);

            modelBuilder.Entity<TStudents>()
                .HasMany(e => e.TStudentsRooms)
                .WithRequired(e => e.TStudents)
                .HasForeignKey(e => e.IdStudents);
        }
    }
}
