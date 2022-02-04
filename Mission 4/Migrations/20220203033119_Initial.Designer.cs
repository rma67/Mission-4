﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission_4.Models;

namespace Mission_4.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20220203033119_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission_4.Models.AddResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 1,
                            Director = "Akiva Schaffer",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Hot Rod",
                            Year = (ushort)2007
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 1,
                            Director = "Jared Hess",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Napoleon Dynamite",
                            Year = (ushort)2004
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 1,
                            Director = "Byron Howard, Rich Moore",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Zootopia",
                            Year = (ushort)2016
                        });
                });

            modelBuilder.Entity("Mission_4.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Mystery"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Western"
                        });
                });

            modelBuilder.Entity("Mission_4.Models.AddResponse", b =>
                {
                    b.HasOne("Mission_4.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}