﻿// <auto-generated />
using CesarWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CesarWeb.Migrations
{
    [DbContext(typeof(CesarWebContext))]
    [Migration("20210219085533_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CesarWeb.Models.CesarNum", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Conversion")
                        .HasColumnType("string");

                    b.Property<int>("Nummer")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("CesarNum");
                });
#pragma warning restore 612, 618
        }
    }
}
