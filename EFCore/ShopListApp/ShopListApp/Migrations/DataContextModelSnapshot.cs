﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopListApp.Data;

namespace ShopListApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopListApp.Models.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Skudurynas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Krautuve"
                        });
                });

            modelBuilder.Entity("ShopListApp.Models.ShopItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ShopItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpiryDate = new DateTime(2021, 12, 16, 16, 47, 49, 708, DateTimeKind.Utc).AddTicks(9915),
                            Name = "Kepure",
                            ShopId = 1
                        },
                        new
                        {
                            Id = 2,
                            ExpiryDate = new DateTime(2021, 12, 16, 16, 47, 49, 709, DateTimeKind.Utc).AddTicks(255),
                            Name = "Batai",
                            ShopId = 1
                        },
                        new
                        {
                            Id = 3,
                            ExpiryDate = new DateTime(2021, 12, 16, 16, 47, 49, 709, DateTimeKind.Utc).AddTicks(257),
                            Name = "Bulves",
                            ShopId = 2
                        },
                        new
                        {
                            Id = 4,
                            ExpiryDate = new DateTime(2021, 12, 16, 16, 47, 49, 709, DateTimeKind.Utc).AddTicks(260),
                            Name = "Morkos",
                            ShopId = 2
                        },
                        new
                        {
                            Id = 5,
                            ExpiryDate = new DateTime(2021, 12, 16, 16, 47, 49, 709, DateTimeKind.Utc).AddTicks(262),
                            Name = "Svogunai",
                            ShopId = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
