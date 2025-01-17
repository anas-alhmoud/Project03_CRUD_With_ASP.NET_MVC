﻿// <auto-generated />
using CRUD_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_Project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CRUD_Project.Models.BookModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("ImageSrc")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Kenneth S Krane",
                            ImageSrc = "https://m.media-amazon.com/images/I/41QiRwidJJL.jpg",
                            Name = "Introductory Nuclear Physics"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Douglas Comer",
                            ImageSrc = "https://images-na.ssl-images-amazon.com/images/I/513ShlaCsTL._SX384_BO1,204,203,200_.jpg",
                            Name = "Essentials of Computer Architecture 2nd Edition"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Kyle Simpson",
                            ImageSrc = "https://images-na.ssl-images-amazon.com/images/I/41vNUw5VbPL._SX398_BO1,204,203,200_.jpg",
                            Name = "You Don't Know JS Yet: Get Started"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Jeffrey Richter",
                            ImageSrc = "https://images-na.ssl-images-amazon.com/images/I/41IgijxpDhL._SX408_BO1,204,203,200_.jpg",
                            Name = "CLR via C#"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
