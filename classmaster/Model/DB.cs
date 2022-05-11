using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace classmaster.Model
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<HealthCard> HealthCard { get; set; }
        public virtual DbSet<Parents> Parents { get; set; }
        public virtual DbSet<Skips> Skips { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Сatering> Сatering { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HealthCard>()
                .Property(e => e.StudentCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Parents>()
                .Property(e => e.ParentCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Parents>()
                .Property(e => e.StudentCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Parents>()
                .Property(e => e.MothersPhone)
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

            modelBuilder.Entity<Skips>()
                .Property(e => e.StudentCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Skips>()
                .Property(e => e.Total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Students>()
                .Property(e => e.StudentCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Students>()
                .Property(e => e.Phone)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Students>()
                .Property(e => e.Sex)
                .IsFixedLength();

            modelBuilder.Entity<Students>()
                .HasOptional(e => e.HealthCard)
                .WithRequired(e => e.Students);

            modelBuilder.Entity<Students>()
                .HasOptional(e => e.Parents)
                .WithRequired(e => e.Students);

            modelBuilder.Entity<Students>()
                .HasOptional(e => e.Skips)
                .WithRequired(e => e.Students);

            modelBuilder.Entity<Students>()
                .HasOptional(e => e.Сatering)
                .WithRequired(e => e.Students);

            modelBuilder.Entity<Subjects>()
                .Property(e => e.SubjectCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Subjects>()
                .HasOptional(e => e.Teachers)
                .WithRequired(e => e.Subjects);

            modelBuilder.Entity<Teachers>()
                .Property(e => e.TeacherCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Teachers>()
                .Property(e => e.SubjectCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Сatering>()
                .Property(e => e.StudentCode)
                .HasPrecision(18, 0);
        }
    }
}
