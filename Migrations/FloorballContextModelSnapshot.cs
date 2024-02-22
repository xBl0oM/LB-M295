﻿// <auto-generated />
using Floorballer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Floorballer.Migrations
{
    [DbContext(typeof(FloorballContext))]
    partial class FloorballContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Floorballer.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Player_age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Player_first_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Player_last_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Player_shirt_number")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Floorballer.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Team_founded_in")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Team_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Team_native_country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Team_slogan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
