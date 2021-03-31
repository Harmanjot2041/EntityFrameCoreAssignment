﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentEntities.Entities;

namespace StudentEntities.Migrations
{
    [DbContext(typeof(EmployeeDbCOntext))]
    [Migration("20210323065729_DataSeed")]
    partial class DataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentEntities.Entities.ProductOwnerDetails", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OwnerAge")
                        .HasColumnType("int");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.HasKey("ProductId");

                    b.ToTable("ProductOwnerDetails");
                });

            modelBuilder.Entity("StudentEntities.Entities.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Catagory")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("date");

                    b.Property<long>("NoOfProducts")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductColor")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ProductDiscription")
                        .IsRequired()
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.Property<long>("ProductPrice")
                        .HasColumnType("bigint");

                    b.Property<bool>("ShippingAllowed")
                        .HasColumnType("bit");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StudentEntities.Entities.StudentsTable", b =>
                {
                    b.Property<long>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StudentID")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("StudentId");

                    b.ToTable("StudentsTable");

                    b.HasData(
                        new
                        {
                            StudentId = 1L,
                            Age = 21,
                            StudentName = "Harman"
                        },
                        new
                        {
                            StudentId = 2L,
                            Age = 21,
                            StudentName = "Harmanjot"
                        },
                        new
                        {
                            StudentId = 3L,
                            Age = 23,
                            StudentName = "Reema Sandhu"
                        },
                        new
                        {
                            StudentId = 4L,
                            Age = 21,
                            StudentName = "Happy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
