﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210323210425_SeedDataAdded")]
    partial class SeedDataAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("StarRating")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Leaf rake with 48-inch wooden handle.",
                            ImageUrl = "../assets/images/leaf_rake.png",
                            Price = 19.949999999999999,
                            ProductCode = "GDN-0011",
                            ProductName = "Leaf Rake",
                            ReleaseDate = "March 19, 2019",
                            StarRating = 3.2000000000000002
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "15 gallon capacity rolling garden cart",
                            ImageUrl = "../assets/images/garden_cart.png",
                            Price = 32.990000000000002,
                            ProductCode = "GDN-0023",
                            ProductName = "Garden Cart",
                            ReleaseDate = "March 18, 2019",
                            StarRating = 4.2000000000000002
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "Curved claw steel hammer",
                            ImageUrl = "../assets/images/hammer.png",
                            Price = 8.9000000000000004,
                            ProductCode = "TBX-0048",
                            ProductName = "Hammer",
                            ReleaseDate = "May 21, 2019",
                            StarRating = 4.7999999999999998
                        },
                        new
                        {
                            ProductId = 8,
                            Description = "15-inch steel blade hand saw",
                            ImageUrl = "../assets/images/saw.png",
                            Price = 11.550000000000001,
                            ProductCode = "TBX-0022",
                            ProductName = "Saw",
                            ReleaseDate = "May 15, 2019",
                            StarRating = 3.7000000000000002
                        },
                        new
                        {
                            ProductId = 10,
                            Description = "Standard two-button video game controller",
                            ImageUrl = "../assets/images/xbox-controller.png",
                            Price = 35.950000000000003,
                            ProductCode = "GMG-0042",
                            ProductName = "Video Game Controller",
                            ReleaseDate = "October 15, 2018",
                            StarRating = 4.5999999999999996
                        });
                });
#pragma warning restore 612, 618
        }
    }
}