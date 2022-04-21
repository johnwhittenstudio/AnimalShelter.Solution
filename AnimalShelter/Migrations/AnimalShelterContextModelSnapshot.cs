﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 2,
                            Gender = "Female",
                            Name = "Rose",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 2,
                            Gender = "Female",
                            Name = "Doja",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 4,
                            Gender = "Female",
                            Name = "Elfreda",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 5,
                            Gender = "Female",
                            Name = "Monah",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 2,
                            Gender = "Female",
                            Name = "Eiza",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 7,
                            Gender = "Male",
                            Name = "Norm",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 2,
                            Gender = "Male",
                            Name = "George",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 13,
                            Gender = "Male",
                            Name = "Vlad",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 3,
                            Gender = "Male",
                            Name = "Neuman",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 3,
                            Gender = "Male",
                            Name = "Addy",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 11,
                            Age = 5,
                            Gender = "Female",
                            Name = "Yoko",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 12,
                            Age = 2,
                            Gender = "Female",
                            Name = "Giselle",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 13,
                            Age = 7,
                            Gender = "Female",
                            Name = "Dorri",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 14,
                            Age = 12,
                            Gender = "Female",
                            Name = "Dido",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 15,
                            Age = 3,
                            Gender = "Female",
                            Name = "Selina Kyle",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 16,
                            Age = 1,
                            Gender = "Male",
                            Name = "Franklin",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 17,
                            Age = 5,
                            Gender = "Male",
                            Name = "Arney",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 18,
                            Age = 2,
                            Gender = "Male",
                            Name = "Benedicto",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 19,
                            Age = 7,
                            Gender = "Male",
                            Name = "Sammie",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 20,
                            Age = 10,
                            Gender = "Male",
                            Name = "Giraldo",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 21,
                            Age = 3,
                            Gender = "Female",
                            Name = "Chloe",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 22,
                            Age = 2,
                            Gender = "Female",
                            Name = "Dixie",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 23,
                            Age = 3,
                            Gender = "Female",
                            Name = "Neko",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 24,
                            Age = 5,
                            Gender = "Female",
                            Name = "Polly",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 25,
                            Age = 7,
                            Gender = "Female",
                            Name = "Cleo",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 26,
                            Age = 2,
                            Gender = "Male",
                            Name = "Ebeneser",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 27,
                            Age = 3,
                            Gender = "Male",
                            Name = "Ruprecht",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 28,
                            Age = 12,
                            Gender = "Male",
                            Name = "Abrahamster",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 29,
                            Age = 5,
                            Gender = "Male",
                            Name = "Kasper",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 30,
                            Age = 1,
                            Gender = "Male",
                            Name = "Eliot",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 31,
                            Age = 2,
                            Gender = "Female",
                            Name = "Venus",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 32,
                            Age = 4,
                            Gender = "Female",
                            Name = "Tonie",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 33,
                            Age = 7,
                            Gender = "Female",
                            Name = "Daniella",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 34,
                            Age = 2,
                            Gender = "Female",
                            Name = "Amala",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 35,
                            Age = 5,
                            Gender = "Female",
                            Name = "Jolene",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 36,
                            Age = 5,
                            Gender = "Male",
                            Name = "Dwight",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 37,
                            Age = 1,
                            Gender = "Male",
                            Name = "Munroe",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 38,
                            Age = 7,
                            Gender = "Male",
                            Name = "John",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 39,
                            Age = 10,
                            Gender = "Male",
                            Name = "Nils",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 40,
                            Age = 8,
                            Gender = "Male",
                            Name = "Thom",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
