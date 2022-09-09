﻿// <auto-generated />
using System;
using Family.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FamilyBudget.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FamilyBudget.Models.Month", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MonthName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Months");
                });

            modelBuilder.Entity("FamilyBudget.Models.PerHeadExpense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Brother")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Children")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Father")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HouseRent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MonthId")
                        .HasColumnType("int");

                    b.Property<decimal>("MonthlyEarning")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Mother")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("PersonInfoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Sister")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Wife")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MonthId");

                    b.HasIndex("PersonInfoId");

                    b.ToTable("PerHeadExpenses");
                });

            modelBuilder.Entity("FamilyBudget.Models.PersonInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonInfos");
                });

            modelBuilder.Entity("FamilyBudget.Models.PerHeadExpense", b =>
                {
                    b.HasOne("FamilyBudget.Models.Month", "MonthName")
                        .WithMany()
                        .HasForeignKey("MonthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyBudget.Models.PersonInfo", "PersonInfo")
                        .WithMany()
                        .HasForeignKey("PersonInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MonthName");

                    b.Navigation("PersonInfo");
                });
#pragma warning restore 612, 618
        }
    }
}