﻿// <auto-generated />
using System;
using CarWashApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarWashApp.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231029133511_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarWashApp.Entity.Concrete.DirtinessLevel", b =>
                {
                    b.Property<int>("DirtinessLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DirtinessLevelId"));

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DirtinessLevelId");

                    b.ToTable("DirtinessLevels");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.LoginDetail", b =>
                {
                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelId");

                    b.ToTable("LoginDetails");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Personel", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelId"));

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<int>("LeaveNum")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<int>("ShifTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelId");

                    b.HasIndex("ShifTypeId");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.PersonelLeave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DayCount")
                        .HasColumnType("int");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("PersonelLeaves");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("WarningStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Shift", b =>
                {
                    b.Property<int>("ShiftTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShiftTypeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShiftTypeId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleId"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleOwnerId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("VehicleId");

                    b.HasIndex("VehicleOwnerId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.VehicleOwner", b =>
                {
                    b.Property<int>("VehicleOwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleOwnerId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleOwnerId");

                    b.ToTable("VehicleOwners");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.VehicleType", b =>
                {
                    b.Property<int>("VehicleTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleTypeId"));

                    b.Property<int>("PriceMultiplier")
                        .HasColumnType("int");

                    b.Property<string>("VehicleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleTypeId");

                    b.ToTable("VehicleTypes");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Wash", b =>
                {
                    b.Property<int>("WashId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WashId"));

                    b.Property<int>("DirtinessLevelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int>("WashTypeId")
                        .HasColumnType("int");

                    b.HasKey("WashId");

                    b.HasIndex("DirtinessLevelId");

                    b.HasIndex("VehicleId");

                    b.HasIndex("WashTypeId");

                    b.ToTable("Washes");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.WashType", b =>
                {
                    b.Property<int>("WashTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WashTypeId"));

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("WashTypeId");

                    b.ToTable("WashTypes");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.WashTypeProduct", b =>
                {
                    b.Property<int>("WashTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("WashTypeId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("WashTypeProducts");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.LoginDetail", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.Personel", "Personel")
                        .WithOne()
                        .HasForeignKey("CarWashApp.Entity.Concrete.LoginDetail", "PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Personel", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShifTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.PersonelLeave", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Vehicle", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.VehicleOwner", "VehicleOwner")
                        .WithMany()
                        .HasForeignKey("VehicleOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarWashApp.Entity.Concrete.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleOwner");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Wash", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.DirtinessLevel", "DirtinessLevel")
                        .WithMany()
                        .HasForeignKey("DirtinessLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarWashApp.Entity.Concrete.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarWashApp.Entity.Concrete.WashType", "WashType")
                        .WithMany()
                        .HasForeignKey("WashTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DirtinessLevel");

                    b.Navigation("Vehicle");

                    b.Navigation("WashType");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.WashTypeProduct", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarWashApp.Entity.Concrete.WashType", "WashType")
                        .WithMany()
                        .HasForeignKey("WashTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("WashType");
                });
#pragma warning restore 612, 618
        }
    }
}
