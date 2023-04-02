﻿// <auto-generated />
using System;
using EnterpriseApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnterpriseApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230402110550_SeedEnterpriseTable")]
    partial class SeedEnterpriseTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnterpriseApi.Models.Enterprise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enterprises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "DELL G5",
                            CreatedDate = new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1559),
                            Description = "unning as admin worked for me after experiencing the same issue.",
                            Name = "Angular Blue Boot",
                            PictureUrl = "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/",
                            Price = 19000L,
                            QuantityInStock = 100,
                            Type = "Angular"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "DELL G5",
                            CreatedDate = new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1585),
                            Description = "unning as admin worked for me after experiencing the same issue.",
                            Name = "Angular Blue Boot",
                            PictureUrl = "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/",
                            Price = 19000L,
                            QuantityInStock = 100,
                            Type = "Angular"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Redis",
                            CreatedDate = new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1590),
                            Description = "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen",
                            Name = "Core Red Boot",
                            PictureUrl = "https://www.pexels.com/photo/palm-trees-at-night-258154/",
                            Price = 18999L,
                            QuantityInStock = 100,
                            Type = "Boot"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Net Core",
                            CreatedDate = new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1595),
                            Description = "Running as admin worked for me after experiencing the same issue.",
                            Name = "Core Purple Boot",
                            PictureUrl = "ihttps://www.pexels.com/photo/palm-trees-at-night-258154/",
                            Price = 17990L,
                            QuantityInStock = 100,
                            Type = "Boot"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "DELL G5",
                            CreatedDate = new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1600),
                            Description = "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen",
                            Name = "Angular Blue Boot",
                            PictureUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/",
                            Price = 430000L,
                            QuantityInStock = 100,
                            Type = "Angular"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Net Core",
                            CreatedDate = new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1604),
                            Description = "Running as admin worked for me after experiencing the same issue.",
                            Name = "Core Purple Boot",
                            PictureUrl = "https://www.pexels.com/photo/palm-trees-at-night-258154/",
                            Price = 17990L,
                            QuantityInStock = 100,
                            Type = "Boot"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "DELL G5",
                            CreatedDate = new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1609),
                            Description = "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen",
                            Name = "Angular Blue Boot",
                            PictureUrl = "https://www.pexels.com/photo/palm-trees-at-night-258154/",
                            Price = 430000L,
                            QuantityInStock = 100,
                            Type = "Angular"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Net Core",
                            CreatedDate = new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1614),
                            Description = "Running as admin worked for me after experiencing the same issue.",
                            Name = "Core Purple Boot",
                            PictureUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/",
                            Price = 17990L,
                            QuantityInStock = 100,
                            Type = "Boot"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Net Core",
                            CreatedDate = new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1619),
                            Description = "Running as admin worked for me after experiencing the same issue.",
                            Name = "Core Purple Boot",
                            PictureUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/\"",
                            Price = 17990L,
                            QuantityInStock = 100,
                            Type = "Boot"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "Net Core",
                            CreatedDate = new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1624),
                            Description = "Running as admin worked for me after experiencing the same issue.",
                            Name = "Core Purple Boot",
                            PictureUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/",
                            Price = 17990L,
                            QuantityInStock = 100,
                            Type = "Boot"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
