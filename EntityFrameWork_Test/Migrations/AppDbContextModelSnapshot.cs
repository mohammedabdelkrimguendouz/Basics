﻿// <auto-generated />
using System;
using EntityFrameWork_Test;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameWork_Test.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameWork_Test.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryID"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CountryID");

                    b.HasIndex("CountryName")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("EntityFrameWork_Test.Models.Cours", b =>
                {
                    b.Property<int>("CoursID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoursID"));

                    b.Property<string>("CoursName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoursID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EntityFrameWork_Test.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EntityFrameWork_Test.Models.Grade", b =>
                {
                    b.Property<int>("GradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeID"));

                    b.Property<decimal>("Algorithm")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DataBase")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("React")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("GradeID");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("EntityFrameWork_Test.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint");

                    b.Property<int>("GradeID")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("StudentID");

                    b.HasIndex("CountryID");

                    b.HasIndex("GradeID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EntityFrameWork_Test.Models.StudentCours", b =>
                {
                    b.Property<int>("StudentCoursID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentCoursID"));

                    b.Property<int>("CoursID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("StudentCoursID");

                    b.HasIndex("CoursID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentsCourses");
                });

            modelBuilder.Entity("EntityFrameWork_Test.Models.Student", b =>
                {
                    b.HasOne("EntityFrameWork_Test.Models.Country", "CountryInfo")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork_Test.Models.Grade", "GradeInfo")
                        .WithMany()
                        .HasForeignKey("GradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CountryInfo");

                    b.Navigation("GradeInfo");
                });

            modelBuilder.Entity("EntityFrameWork_Test.Models.StudentCours", b =>
                {
                    b.HasOne("EntityFrameWork_Test.Models.Cours", "CoursInfo")
                        .WithMany()
                        .HasForeignKey("CoursID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork_Test.Models.Student", "StudentInfo")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoursInfo");

                    b.Navigation("StudentInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
