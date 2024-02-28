﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistrationApi.Data;

namespace RegistrationApi.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20240228175533_EditingUsers")]
    partial class EditingUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("RegistrationApi.Entities.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("BarCode")
                        .HasColumnType("bigint");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("RegistrationApi.Entities.Token", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Token");
                });

            modelBuilder.Entity("RegistrationApi.Entities.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RegistrationApi.Entities.Products.Cleaning", b =>
                {
                    b.HasBaseType("RegistrationApi.Entities.Products.Product");

                    b.Property<string>("Fragrance")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surface")
                        .HasColumnType("longtext");

                    b.Property<string>("UsagePrecautions")
                        .HasColumnType("longtext");

                    b.ToTable("Cleaning");
                });

            modelBuilder.Entity("RegistrationApi.Entities.Products.Drink", b =>
                {
                    b.HasBaseType("RegistrationApi.Entities.Products.Product");

                    b.Property<double>("AlcoholContent")
                        .HasColumnType("double");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.ToTable("Drink");
                });

            modelBuilder.Entity("RegistrationApi.Entities.Products.Food", b =>
                {
                    b.HasBaseType("RegistrationApi.Entities.Products.Product");

                    b.Property<string>("Allergens")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("RegistrationApi.Entities.Users.Customer", b =>
                {
                    b.HasBaseType("RegistrationApi.Entities.Users.User");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("TotalAmountSpent")
                        .HasColumnType("double");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("RegistrationApi.Entities.Users.Employee", b =>
                {
                    b.HasBaseType("RegistrationApi.Entities.Users.User");

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime(6)");

                    b.Property<TimeSpan>("OvertimeWorked")
                        .HasColumnType("time(6)");

                    b.Property<double>("Salary")
                        .HasColumnType("double");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("RegistrationApi.Entities.Token", b =>
                {
                    b.HasOne("RegistrationApi.Entities.Users.User", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RegistrationApi.Entities.Products.Cleaning", b =>
                {
                    b.HasOne("RegistrationApi.Entities.Products.Product", null)
                        .WithOne()
                        .HasForeignKey("RegistrationApi.Entities.Products.Cleaning", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistrationApi.Entities.Products.Drink", b =>
                {
                    b.HasOne("RegistrationApi.Entities.Products.Product", null)
                        .WithOne()
                        .HasForeignKey("RegistrationApi.Entities.Products.Drink", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistrationApi.Entities.Products.Food", b =>
                {
                    b.HasOne("RegistrationApi.Entities.Products.Product", null)
                        .WithOne()
                        .HasForeignKey("RegistrationApi.Entities.Products.Food", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistrationApi.Entities.Users.Customer", b =>
                {
                    b.HasOne("RegistrationApi.Entities.Users.User", null)
                        .WithOne()
                        .HasForeignKey("RegistrationApi.Entities.Users.Customer", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistrationApi.Entities.Users.Employee", b =>
                {
                    b.HasOne("RegistrationApi.Entities.Users.User", null)
                        .WithOne()
                        .HasForeignKey("RegistrationApi.Entities.Users.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistrationApi.Entities.Users.User", b =>
                {
                    b.Navigation("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}
