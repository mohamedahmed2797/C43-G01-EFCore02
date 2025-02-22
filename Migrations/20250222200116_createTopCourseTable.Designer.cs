﻿// <auto-generated />
using System;
using C43_G01_EFCore02.AssignmentContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace C43_G01_EFCore02.Migrations
{
    [DbContext(typeof(ItiContext))]
    [Migration("20250222200116_createTopCourseTable")]
    partial class createTopCourseTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("C43_G01_EFCore02.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("EmpName");

                    b.Property<int>("Top_IdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Top_IdId");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("C43_G01_EFCore02.Course_Inst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<string>("evaluate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("inst_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Course_Insts");
                });

            modelBuilder.Entity("C43_G01_EFCore02.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("HiringDate")
                        .HasColumnType("date");

                    b.Property<int>("Ins_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("C43_G01_EFCore02.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Bouns")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Dept_IdId")
                        .HasColumnType("int");

                    b.Property<int>("HourRate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Dept_IdId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("C43_G01_EFCore02.Stud_Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("Stud_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stud_Courses");
                });

            modelBuilder.Entity("C43_G01_EFCore02.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Dept_IdId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.HasKey("Id");

                    b.HasIndex("Dept_IdId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("C43_G01_EFCore02.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Topic_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Topic_Name");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("C43_G01_EFCore02.Course", b =>
                {
                    b.HasOne("C43_G01_EFCore02.Topic", "Top_Id")
                        .WithMany("courses")
                        .HasForeignKey("Top_IdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Top_Id");
                });

            modelBuilder.Entity("C43_G01_EFCore02.Instructor", b =>
                {
                    b.HasOne("C43_G01_EFCore02.Department", "Dept_Id")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_IdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dept_Id");
                });

            modelBuilder.Entity("C43_G01_EFCore02.Student", b =>
                {
                    b.HasOne("C43_G01_EFCore02.Department", "Dept_Id")
                        .WithMany("Students")
                        .HasForeignKey("Dept_IdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dept_Id");
                });

            modelBuilder.Entity("C43_G01_EFCore02.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("C43_G01_EFCore02.Topic", b =>
                {
                    b.Navigation("courses");
                });
#pragma warning restore 612, 618
        }
    }
}
