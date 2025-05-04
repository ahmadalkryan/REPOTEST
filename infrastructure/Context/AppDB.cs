using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Context
{
      public class AppDB : DbContext
    {
        public AppDB(DbContextOptions<AppDB> options) : base(options)
        {

        }


        public virtual DbSet<Room> rooms { get; set; }
        public virtual DbSet<Student> students { get; set; }

        public virtual DbSet<Specialty> specialtys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Room>(
                r =>
                {
                    r.ToTable("Roms");
                    r.Property(r => r.Name);
                    r.HasKey(r => r.RoomId);
                    r.HasOne(s => s._Student).WithOne(r => r._Room).HasForeignKey<Room>(s => s.studentId)
                    .OnDelete(DeleteBehavior.Cascade);


                }

                );
            modelBuilder.Entity<Student>(r =>
            {

                r.ToTable("Students");
                r.Property(s => s.StudentName);
                r.Property(s => s.StudentAge);
                r.HasKey(r => r.StudentId);
                r.HasOne(r => r._Specialty).WithOne(r => r._Student).HasForeignKey<Specialty>(r => r._studentId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Specialty>(r =>
            {
                r.ToTable("Specialtys");
                r.HasKey(r => r.SpecialtyId);
                r.Property(r => r.SpecialtyName);

            });



        }
    }
}
