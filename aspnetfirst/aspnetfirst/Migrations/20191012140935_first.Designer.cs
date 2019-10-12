﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnetfirst.Data;

namespace aspnetfirst.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20191012140935_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("aspnetfirst.Models.Movies.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Genre");

                    b.Property<string>("Name");

                    b.Property<string>("Poster");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}