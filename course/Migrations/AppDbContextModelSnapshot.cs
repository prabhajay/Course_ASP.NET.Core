﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using course.Data;

#nullable disable

namespace course.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("course.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CourseNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CourseId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseId = 211,
                            CourseDescription = "Accounting Courses detials",
                            CourseName = "Accounting I",
                            CourseNumber = "ACCT"
                        },
                        new
                        {
                            CourseId = 212,
                            CourseDescription = "Accounting Courses details",
                            CourseName = "Accounting II",
                            CourseNumber = "ACCT"
                        },
                        new
                        {
                            CourseId = 220,
                            CourseDescription = "Database and implemetation course details",
                            CourseName = "Database Design and Implementation",
                            CourseNumber = "CIS"
                        },
                        new
                        {
                            CourseId = 261,
                            CourseDescription = "Intro to Statistics details",
                            CourseName = "Intro to Statistics",
                            CourseNumber = "CIS "
                        },
                        new
                        {
                            CourseId = 362,
                            CourseDescription = "Statistical Applications",
                            CourseName = "Statistical Applications",
                            CourseNumber = "CIS"
                        });
                });

            modelBuilder.Entity("course.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CourseTeach")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("InstructorId");

                    b.ToTable("Instructor");

                    b.HasData(
                        new
                        {
                            InstructorId = 103,
                            CourseTeach = "CIS",
                            EmailAddress = "John@gmail.com",
                            FirstName = "John",
                            LastName = "Job"
                        },
                        new
                        {
                            InstructorId = 104,
                            CourseTeach = "ACCT",
                            EmailAddress = "Willam@gmail.com",
                            FirstName = "willam",
                            LastName = "John"
                        },
                        new
                        {
                            InstructorId = 105,
                            CourseTeach = "CIS",
                            EmailAddress = "xxxYYY@gmail.com",
                            FirstName = "xxx",
                            LastName = "yyy"
                        },
                        new
                        {
                            InstructorId = 106,
                            CourseTeach = "ACCT",
                            EmailAddress = "abcdef@gmail.com",
                            FirstName = "abc",
                            LastName = "def"
                        },
                        new
                        {
                            InstructorId = 107,
                            CourseTeach = "CIS",
                            EmailAddress = "pqrstr@gmail.com",
                            FirstName = "pqr",
                            LastName = "stu"
                        });
                });

            modelBuilder.Entity("course.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("courseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("courseId");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            StudentId = 400,
                            Email = "Johu@gmail.com",
                            FirstName = "Johu",
                            LastName = "Job",
                            Phone = "403-222-3222"
                        },
                        new
                        {
                            StudentId = 401,
                            Email = "brewer@gmail.com",
                            FirstName = "Brewer",
                            LastName = "Juliette",
                            Phone = "403-354-2321"
                        },
                        new
                        {
                            StudentId = 402,
                            Email = "john@gmail.com",
                            FirstName = "John",
                            LastName = "Smith",
                            Phone = "403-342-3432"
                        },
                        new
                        {
                            StudentId = 403,
                            Email = "robertson@gmail.com",
                            FirstName = "Robertson",
                            LastName = "Gerald",
                            Phone = "403-322-2322"
                        },
                        new
                        {
                            StudentId = 404,
                            Email = "robertson@gmail.com",
                            FirstName = "Robertson",
                            LastName = "Gerald",
                            Phone = "403-322-2322"
                        });
                });

            modelBuilder.Entity("course.Models.Student", b =>
                {
                    b.HasOne("course.Models.Course", "course")
                        .WithMany()
                        .HasForeignKey("courseId");

                    b.Navigation("course");
                });
#pragma warning restore 612, 618
        }
    }
}
