using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace classmaster.Model
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB7")
        {
        }

        public virtual DbSet<ClassEvents> ClassEvents { get; set; }
        public virtual DbSet<ClassroomLessons> ClassroomLessons { get; set; }
        public virtual DbSet<HealthCard> HealthCard { get; set; }
        public virtual DbSet<Parents> Parents { get; set; }
        public virtual DbSet<Skips> Skips { get; set; }
        public virtual DbSet<Sobytiya> Sobytiya { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Сatering> Сatering { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parents>()
                .Property(e => e.ParentsId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Parents>()
                .Property(e => e.FathersPhone)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Parents>()
                .Property(e => e.AdopterPhone)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Parents>()
                .Property(e => e.NumberOfChildren)
                .IsFixedLength();

            modelBuilder.Entity<Students>()
                .Property(e => e.Phone)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Students>()
                .HasOptional(e => e.HealthCard)
                .WithRequired(e => e.Students);

            modelBuilder.Entity<Students>()
                .HasOptional(e => e.Parents)
                .WithRequired(e => e.Students);

            modelBuilder.Entity<Students>()
                .HasOptional(e => e.Сatering)
                .WithRequired(e => e.Students);

            modelBuilder.Entity<Subjects>()
                .HasMany(e => e.Teachers)
                .WithRequired(e => e.Subjects)
                .HasForeignKey(e => e.SubjectId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сatering>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
