﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductosApp.Data;

namespace ProductosApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201209154638_first-migration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ProductosApp.Models.Productos", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Inventario")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Codigo");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Codigo = 1,
                            Descripcion = "Zapato",
                            Inventario = 25,
                            Precio = 150m
                        },
                        new
                        {
                            Codigo = 2,
                            Descripcion = "Toallas",
                            Inventario = 25,
                            Precio = 165m
                        },
                        new
                        {
                            Codigo = 3,
                            Descripcion = "Celular",
                            Inventario = 25,
                            Precio = 8900m
                        },
                        new
                        {
                            Codigo = 4,
                            Descripcion = "Computadora",
                            Inventario = 25,
                            Precio = 18900m
                        },
                        new
                        {
                            Codigo = 5,
                            Descripcion = "Control Remoto",
                            Inventario = 25,
                            Precio = 80m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
