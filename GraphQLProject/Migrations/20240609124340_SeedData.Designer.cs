﻿// <auto-generated />
using System;
using GraphQLProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQLProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240609124340_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GraphQLProject.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://example.com/categories/appetizers.jpg",
                            Name = "Appetizers"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://example.com/categories/main-course.jpg",
                            Name = "Main Course"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://example.com/categories/desserts.jpg",
                            Name = "Desserts"
                        });
                });

            modelBuilder.Entity("GraphQLProject.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Spicy chicken wings served with blue cheese dip.",
                            ImageUrl = "https://example.com/menus/chicken-wings.jpg",
                            Name = "Chicken Wings",
                            Price = 9.9900000000000002
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Grilled steak with mashed potatoes and vegetables.",
                            ImageUrl = "https://example.com/menus/steak.jpg",
                            Name = "Steak",
                            Price = 24.5
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Decadent chocolate cake with a scoop of vanilla ice cream.",
                            ImageUrl = "https://example.com/menus/chocolate-cake.jpg",
                            Name = "Chocolate Cake",
                            Price = 6.9500000000000002
                        });
                });

            modelBuilder.Entity("GraphQLProject.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartySize")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialRequest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerName = "John Doe",
                            Email = "johndoe@example.com",
                            PartySize = 2,
                            PhoneNumber = "555-123-4567",
                            ReservationDate = new DateTime(2024, 6, 16, 13, 43, 40, 131, DateTimeKind.Local).AddTicks(8099),
                            SpecialRequest = "No nuts in the dishes, please."
                        },
                        new
                        {
                            Id = 2,
                            CustomerName = "Jane Smith",
                            Email = "janesmith@example.com",
                            PartySize = 4,
                            PhoneNumber = "555-987-6543",
                            ReservationDate = new DateTime(2024, 6, 19, 13, 43, 40, 131, DateTimeKind.Local).AddTicks(8116),
                            SpecialRequest = "Gluten-free options required."
                        },
                        new
                        {
                            Id = 3,
                            CustomerName = "Michael Johnson",
                            Email = "michaeljohnson@example.com",
                            PartySize = 6,
                            PhoneNumber = "555-789-0123",
                            ReservationDate = new DateTime(2024, 6, 23, 13, 43, 40, 131, DateTimeKind.Local).AddTicks(8117),
                            SpecialRequest = "Celebrating a birthday."
                        });
                });

            modelBuilder.Entity("GraphQLProject.Models.Menu", b =>
                {
                    b.HasOne("GraphQLProject.Models.Category", null)
                        .WithMany("Menus")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GraphQLProject.Models.Category", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}
