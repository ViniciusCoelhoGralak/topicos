﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20250403125319_NovaTabelaModelo")]
    partial class NovaTabelaModelo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("API.Models.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ModeloId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ModeloId");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("API.Models.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Modelos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hatch"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Suv"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sedan"
                        });
                });

            modelBuilder.Entity("API.Models.Carro", b =>
                {
                    b.HasOne("API.Models.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId");

                    b.Navigation("Modelo");
                });
#pragma warning restore 612, 618
        }
    }
}
