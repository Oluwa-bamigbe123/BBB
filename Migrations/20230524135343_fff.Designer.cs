﻿// <auto-generated />
using System;
using LocalBetBiga.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBetBiga.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230524135343_fff")]
    partial class fff
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBetBiga.Models.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(72)")
                        .HasMaxLength(72);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.AdminEquipmentDistribution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAssigned")
                        .HasColumnType("datetime");

                    b.Property<int>("EquipmentsId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfEquipmentAssigned")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("EquipmentsId");

                    b.HasIndex("ManagerId");

                    b.ToTable("AdminEquipmentDistribution");
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.Equipments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("EquipmentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberInStore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(72)")
                        .HasMaxLength(72);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.ManagerEquipmentDistribution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAssigned")
                        .HasColumnType("datetime");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("NameOfAgentAssignedTo")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfEquipmentAssigned")
                        .HasColumnType("int");

                    b.Property<string>("ShopAddress")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("ManagerId");

                    b.ToTable("ManagerEquipmentDistribution");
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.Retrival", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRetrieved")
                        .HasColumnType("datetime");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("NameOfAgent")
                        .HasColumnType("text");

                    b.Property<string>("NameOfAgentReassignedTo")
                        .HasColumnType("text");

                    b.Property<string>("NameOfEquipmentRetrieved")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Retrivals");
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.Sales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ActualSales")
                        .HasColumnType("text");

                    b.Property<string>("Commission")
                        .HasColumnType("text");

                    b.Property<string>("NGR")
                        .HasColumnType("text");

                    b.Property<string>("PecentageOfSalesComparedToProjectedSales")
                        .HasColumnType("text");

                    b.Property<string>("ProjectedSales")
                        .HasColumnType("text");

                    b.Property<string>("TotalGGR")
                        .HasColumnType("text");

                    b.Property<string>("TotalSales")
                        .HasColumnType("text");

                    b.Property<string>("TotalWinnings")
                        .HasColumnType("text");

                    b.Property<int>("adminId")
                        .HasColumnType("int");

                    b.Property<int>("managerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("adminId");

                    b.HasIndex("managerId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.AdminEquipmentDistribution", b =>
                {
                    b.HasOne("LocalBetBiga.Models.Entities.Admin", "Admin")
                        .WithMany("EquipmentDistribution")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocalBetBiga.Models.Entities.Equipments", "Equipments")
                        .WithMany()
                        .HasForeignKey("EquipmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocalBetBiga.Models.Entities.Manager", "Manager")
                        .WithMany("AdminEquipmentDistribution")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.Equipments", b =>
                {
                    b.HasOne("LocalBetBiga.Models.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.ManagerEquipmentDistribution", b =>
                {
                    b.HasOne("LocalBetBiga.Models.Entities.Equipments", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocalBetBiga.Models.Entities.Manager", "Manager")
                        .WithMany("ManagerEquipmentDistribution")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.Retrival", b =>
                {
                    b.HasOne("LocalBetBiga.Models.Entities.Manager", "Manager")
                        .WithMany("Retrivals")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocalBetBiga.Models.Entities.Sales", b =>
                {
                    b.HasOne("LocalBetBiga.Models.Entities.Admin", "admin")
                        .WithMany()
                        .HasForeignKey("adminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocalBetBiga.Models.Entities.Manager", "manager")
                        .WithMany()
                        .HasForeignKey("managerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
