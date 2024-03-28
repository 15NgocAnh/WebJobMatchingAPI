﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebJobMatchingAPI.Data;

#nullable disable

namespace WebJobMatchingAPI.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20240327091720_u")]
    partial class u
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebJobMatchingAPI.DTO.UsersViewModel", b =>
                {
                    b.Property<DateOnly>("BirthDay")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("UsersViewModel", (string)null);
                });

            modelBuilder.Entity("WebJobMatchingAPI.Entities.Jobs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RequiredSkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TypeOfWork")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("jobs", (string)null);
                });

            modelBuilder.Entity("WebJobMatchingAPI.Entities.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = 2
                        });
                });

            modelBuilder.Entity("WebJobMatchingAPI.Entities.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("UsersID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsersID");

                    b.ToTable("skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "BACKEND"
                        },
                        new
                        {
                            Id = 2,
                            Name = "FONTEND"
                        });
                });

            modelBuilder.Entity("WebJobMatchingAPI.Entities.User_Role", b =>
                {
                    b.Property<Guid>("User_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Role_id")
                        .HasColumnType("int");

                    b.HasKey("User_id", "Role_id");

                    b.HasIndex("Role_id");

                    b.ToTable("user_role", (string)null);
                });

            modelBuilder.Entity("WebJobMatchingAPI.Entities.Users", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("BirthDay")
                        .HasColumnType("date");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMale")
                        .HasColumnType("bit");

                    b.Property<Guid?>("JobsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("JobsId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            ID = new Guid("91e0d5bd-87c9-4817-b978-e6af904b01b6"),
                            BirthDay = new DateOnly(1990, 1, 1),
                            Education = "Bachelor's Degree",
                            Email = "johndoe@example.com",
                            Experience = "1 years as a Fontend Dev",
                            FirstName = "John",
                            IsDeleted = false,
                            IsEmailConfirmed = false,
                            IsLocked = false,
                            IsMale = true,
                            LastName = "Doe",
                            Location = "New York",
                            Password = "John123@doe",
                            PhoneNumber = "+1 123-456-7890",
                            UserName = "johndoe"
                        },
                        new
                        {
                            ID = new Guid("2570645d-ca3a-4922-a194-95d12030ecfc"),
                            BirthDay = new DateOnly(2002, 1, 15),
                            Education = "Hue University",
                            Email = "nguyenvana@gmail.com",
                            Experience = "3 years as a Backend Developer",
                            FirstName = "A",
                            IsDeleted = false,
                            IsEmailConfirmed = false,
                            IsLocked = false,
                            IsMale = true,
                            LastName = "Nguyen Van",
                            Location = "Hue, Viet Nam",
                            Password = "12345NguyenA@",
                            PhoneNumber = "086 3458 471",
                            UserName = "nguyena123"
                        },
                        new
                        {
                            ID = new Guid("d3372ccd-298c-4fd8-9aed-745c61d85264"),
                            BirthDay = new DateOnly(2002, 1, 15),
                            Education = "Hue University",
                            Email = "nguyenthib123@gmail.com",
                            Experience = "4 years as a Backend Developer",
                            FirstName = "B",
                            IsDeleted = false,
                            IsEmailConfirmed = false,
                            IsLocked = false,
                            IsMale = false,
                            LastName = "Nguyen Thi",
                            Location = "Hue, Viet Nam",
                            Password = "12345ThiB@",
                            PhoneNumber = "086 3643 874",
                            UserName = "nguyenthib123"
                        });
                });

            modelBuilder.Entity("WebJobMatchingAPI.Entities.Skills", b =>
                {
                    b.HasOne("WebJobMatchingAPI.Entities.Users", null)
                        .WithMany("Skills")
                        .HasForeignKey("UsersID");
                });

            modelBuilder.Entity("WebJobMatchingAPI.Entities.User_Role", b =>
                {
                    b.HasOne("WebJobMatchingAPI.Entities.Roles", "role")
                        .WithMany("Users")
                        .HasForeignKey("Role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Role");

                    b.HasOne("WebJobMatchingAPI.Entities.Users", "user")
                        .WithMany("Roles")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_User");

                    b.Navigation("role");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WebJobMatchingAPI.Entities.Users", b =>
                {
                    b.HasOne("WebJobMatchingAPI.Entities.Jobs", null)
                        .WithMany("Applicants")
                        .HasForeignKey("JobsId");
                });

            modelBuilder.Entity("WebJobMatchingAPI.Entities.Jobs", b =>
                {
                    b.Navigation("Applicants");
                });

            modelBuilder.Entity("WebJobMatchingAPI.Entities.Roles", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebJobMatchingAPI.Entities.Users", b =>
                {
                    b.Navigation("Roles");

                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
