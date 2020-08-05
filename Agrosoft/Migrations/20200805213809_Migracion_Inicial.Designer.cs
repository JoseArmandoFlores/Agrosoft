﻿// <auto-generated />
using System;
using Agrosoft.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agrosoft.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200805213809_Migracion_Inicial")]
    partial class Migracion_Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Agrosoft.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("LimiteCredito")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Apellidos = "ocasional",
                            Balance = 0m,
                            Cedula = "00000000000",
                            Celular = "0000000000",
                            Direccion = "xxxxxxxxxxxxx",
                            Email = "clienteOcasional@hotmail.com",
                            Fecha = new DateTime(2020, 8, 5, 17, 38, 7, 63, DateTimeKind.Local).AddTicks(841),
                            LimiteCredito = 1m,
                            Nombres = "Cliente",
                            Telefono = "0000000000",
                            UsuarioId = 1
                        });
                });

            modelBuilder.Entity("Agrosoft.Models.Cobros", b =>
                {
                    b.Property<int>("CobroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<decimal>("Deposito")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("CobroId");

                    b.ToTable("Cobros");
                });

            modelBuilder.Entity("Agrosoft.Models.CompraProductos", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("CompraId");

                    b.ToTable("CompraProductos");
                });

            modelBuilder.Entity("Agrosoft.Models.CompraProductosDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.ToTable("CompraProductosDetalle");
                });

            modelBuilder.Entity("Agrosoft.Models.Marcas", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("MarcaId");

                    b.ToTable("Marcas");

                    b.HasData(
                        new
                        {
                            MarcaId = 1,
                            Descripcion = "Fersan",
                            UsuarioId = 0
                        },
                        new
                        {
                            MarcaId = 2,
                            Descripcion = "Ferquido",
                            UsuarioId = 0
                        },
                        new
                        {
                            MarcaId = 3,
                            Descripcion = "Jaragua",
                            UsuarioId = 0
                        },
                        new
                        {
                            MarcaId = 4,
                            Descripcion = "Quisqueya",
                            UsuarioId = 0
                        },
                        new
                        {
                            MarcaId = 5,
                            Descripcion = "Puita",
                            UsuarioId = 0
                        });
                });

            modelBuilder.Entity("Agrosoft.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadExistente")
                        .HasColumnType("int");

                    b.Property<int>("CantidadMinima")
                        .HasColumnType("int");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnidadMedida")
                        .HasColumnType("int");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Agrosoft.Models.Proveedores", b =>
                {
                    b.Property<int>("ProveedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RNC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ProveedorId");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Agrosoft.Models.UnidadesMedida", b =>
                {
                    b.Property<int>("UnidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnidadId");

                    b.ToTable("UnidadesMedida");

                    b.HasData(
                        new
                        {
                            UnidadId = 1,
                            Descripcion = "Cc"
                        },
                        new
                        {
                            UnidadId = 2,
                            Descripcion = "Frasco 10 cc"
                        },
                        new
                        {
                            UnidadId = 3,
                            Descripcion = "Frasco 25 cc"
                        },
                        new
                        {
                            UnidadId = 4,
                            Descripcion = "Frasco 100 cc"
                        },
                        new
                        {
                            UnidadId = 5,
                            Descripcion = "Frasco 250 cc"
                        },
                        new
                        {
                            UnidadId = 6,
                            Descripcion = "Galón 5 litros"
                        },
                        new
                        {
                            UnidadId = 7,
                            Descripcion = "Galón 10 litros"
                        },
                        new
                        {
                            UnidadId = 8,
                            Descripcion = "Galón 20 litros"
                        },
                        new
                        {
                            UnidadId = 9,
                            Descripcion = "Libra(s)"
                        },
                        new
                        {
                            UnidadId = 10,
                            Descripcion = "Litro(s)"
                        },
                        new
                        {
                            UnidadId = 11,
                            Descripcion = "Pinta(s)"
                        },
                        new
                        {
                            UnidadId = 12,
                            Descripcion = "Saco 25 libras"
                        },
                        new
                        {
                            UnidadId = 13,
                            Descripcion = "Saco 50 libras"
                        },
                        new
                        {
                            UnidadId = 14,
                            Descripcion = "Saco 55 libras"
                        },
                        new
                        {
                            UnidadId = 15,
                            Descripcion = "Saco 50 libras"
                        },
                        new
                        {
                            UnidadId = 16,
                            Descripcion = "Saco 100 libras"
                        },
                        new
                        {
                            UnidadId = 17,
                            Descripcion = "Saco 125 libras"
                        });
                });

            modelBuilder.Entity("Agrosoft.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaveConfirmada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaveUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Apellidos = "Admin",
                            Celular = "0123456789",
                            ClaveConfirmada = "admin",
                            ClaveUsuario = "admin",
                            Direccion = "Admin",
                            Email = "Admin@hotmail.com",
                            Fecha = new DateTime(2020, 8, 5, 17, 38, 7, 59, DateTimeKind.Local).AddTicks(7659),
                            NombreUsuario = "Admin",
                            Nombres = "Admin",
                            Telefono = "0123456789",
                            TipoUsuario = "Administrador"
                        });
                });

            modelBuilder.Entity("Agrosoft.Models.VentaProductos", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ITBIS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TipoFactura")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("VentaId");

                    b.ToTable("VentaProductos");
                });

            modelBuilder.Entity("Agrosoft.Models.VentaProductosDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("ITBIS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Importe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VentaId");

                    b.ToTable("VentaProductosDetalle");
                });

            modelBuilder.Entity("Agrosoft.Models.CompraProductosDetalle", b =>
                {
                    b.HasOne("Agrosoft.Models.CompraProductos", null)
                        .WithMany("CompraProductosDetalle")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Agrosoft.Models.VentaProductosDetalle", b =>
                {
                    b.HasOne("Agrosoft.Models.VentaProductos", null)
                        .WithMany("VentaProductosDetalle")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}