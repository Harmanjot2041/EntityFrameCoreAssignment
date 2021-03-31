using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace StudentEntities.Entities
{
    public partial class EmployeeDbCOntext : DbContext
    {
        public EmployeeDbCOntext()
        {
        }

        public EmployeeDbCOntext(DbContextOptions<EmployeeDbCOntext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProductOwnerDetails> ProductOwnerDetails { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<StudentsTable> StudentsTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductOwnerDetails>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.Catagory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ProductColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDiscription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StudentsTable>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentsTable>().HasData(
                new StudentsTable { StudentId = 1, StudentName = "Harman", Age = 21 },
                new StudentsTable { StudentId = 2, StudentName = "Harmanjot", Age = 21 },
                new StudentsTable { StudentId = 3, StudentName = "Reema Sandhu", Age = 23 },
                new StudentsTable { StudentId = 4, StudentName = "Happy", Age = 21 }
                );
            OnModelCreatingPartial(modelBuilder);
            
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
