﻿// <auto-generated />
using System;
using CongestionTaxCalculator.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CongestionTaxCalculator.Persistence.Migrations
{
    [DbContext(typeof(CongestionTaxDbContext))]
    partial class CongestionTaxDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CongestionTaxCalculator.Domain.Entities.Rule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("TaxValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Rules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Gothenburg",
                            EndTime = new DateTime(1, 1, 1, 6, 29, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified),
                            TaxValue = 8.0
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Gothenburg",
                            EndTime = new DateTime(1, 1, 1, 6, 59, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 6, 30, 0, 0, DateTimeKind.Unspecified),
                            TaxValue = 13.0
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Gothenburg",
                            EndTime = new DateTime(1, 1, 1, 7, 59, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TaxValue = 18.0
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Gothenburg",
                            EndTime = new DateTime(1, 1, 1, 8, 29, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            TaxValue = 13.0
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Gothenburg",
                            EndTime = new DateTime(1, 1, 1, 14, 59, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            TaxValue = 8.0
                        },
                        new
                        {
                            Id = 6,
                            CityName = "Gothenburg",
                            EndTime = new DateTime(1, 1, 1, 15, 29, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            TaxValue = 13.0
                        },
                        new
                        {
                            Id = 7,
                            CityName = "Gothenburg",
                            EndTime = new DateTime(1, 1, 1, 16, 59, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            TaxValue = 18.0
                        },
                        new
                        {
                            Id = 8,
                            CityName = "Gothenburg",
                            EndTime = new DateTime(1, 1, 1, 17, 59, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            TaxValue = 13.0
                        },
                        new
                        {
                            Id = 9,
                            CityName = "Gothenburg",
                            EndTime = new DateTime(1, 1, 1, 18, 29, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            TaxValue = 8.0
                        },
                        new
                        {
                            Id = 10,
                            CityName = "Gothenburg",
                            EndTime = new DateTime(1, 1, 1, 5, 59, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            TaxValue = 0.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
