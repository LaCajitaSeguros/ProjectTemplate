﻿// <auto-generated />
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240418032446_datasettfi")]
    partial class datasettfi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.AnioVehiculo", b =>
                {
                    b.Property<int>("AnioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnioId"));

                    b.Property<int>("AnioVehiculoDesde")
                        .HasColumnType("int");

                    b.Property<int>("AnioVehiculoHasta")
                        .HasColumnType("int");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(6, 4)");

                    b.HasKey("AnioId");

                    b.ToTable("AnioVehiculo");

                    b.HasData(
                        new
                        {
                            AnioId = 1,
                            AnioVehiculoDesde = 1,
                            AnioVehiculoHasta = 1989,
                            Peso = 0.0007m
                        },
                        new
                        {
                            AnioId = 2,
                            AnioVehiculoDesde = 1990,
                            AnioVehiculoHasta = 1999,
                            Peso = 0.0005m
                        },
                        new
                        {
                            AnioId = 3,
                            AnioVehiculoDesde = 2000,
                            AnioVehiculoHasta = 2009,
                            Peso = 0.0004m
                        },
                        new
                        {
                            AnioId = 4,
                            AnioVehiculoDesde = 2010,
                            AnioVehiculoHasta = 2019,
                            Peso = 0.0003m
                        },
                        new
                        {
                            AnioId = 5,
                            AnioVehiculoDesde = 2020,
                            AnioVehiculoHasta = 2024,
                            Peso = 0.0001m
                        });
                });

            modelBuilder.Entity("Domain.Entities.GNC", b =>
                {
                    b.Property<int>("GNCId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GNCId"));

                    b.Property<bool>("HasGNC")
                        .HasColumnType("bit");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(6, 4)");

                    b.HasKey("GNCId");

                    b.ToTable("GNC");

                    b.HasData(
                        new
                        {
                            GNCId = 1,
                            HasGNC = true,
                            Peso = 0.0001m
                        },
                        new
                        {
                            GNCId = 2,
                            HasGNC = false,
                            Peso = 0.0m
                        });
                });

            modelBuilder.Entity("Domain.Entities.Localidad", b =>
                {
                    b.Property<int>("LocalidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocalidadId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(6, 4)");

                    b.HasKey("LocalidadId");

                    b.ToTable("Localidad");

                    b.HasData(
                        new
                        {
                            LocalidadId = 1,
                            Nombre = "Varela",
                            Peso = 0.0005m
                        },
                        new
                        {
                            LocalidadId = 2,
                            Nombre = "Berazategui",
                            Peso = 0.0005m
                        },
                        new
                        {
                            LocalidadId = 3,
                            Nombre = "Lanus",
                            Peso = 0.0005m
                        },
                        new
                        {
                            LocalidadId = 4,
                            Nombre = "Quilmes",
                            Peso = 0.0006m
                        },
                        new
                        {
                            LocalidadId = 5,
                            Nombre = "Avellaneda",
                            Peso = 0.0003m
                        },
                        new
                        {
                            LocalidadId = 6,
                            Nombre = "Lomas de Zamora",
                            Peso = 0.0002m
                        });
                });

            modelBuilder.Entity("Domain.Entities.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcaId"));

                    b.Property<string>("NombreMarca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("Domain.Entities.Modelo", b =>
                {
                    b.Property<int>("ModeloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModeloId"));

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("NombreModelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModeloId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("Domain.Entities.RangoEtario", b =>
                {
                    b.Property<int>("EdadRangoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EdadRangoId"));

                    b.Property<int>("EdadDesde")
                        .HasColumnType("int");

                    b.Property<int>("EdadHasta")
                        .HasColumnType("int");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(6, 4)");

                    b.HasKey("EdadRangoId");

                    b.ToTable("RangoEtario");

                    b.HasData(
                        new
                        {
                            EdadRangoId = 1,
                            EdadDesde = 18,
                            EdadHasta = 40,
                            Peso = 0.0005m
                        },
                        new
                        {
                            EdadRangoId = 2,
                            EdadDesde = 41,
                            EdadHasta = 60,
                            Peso = 0.0006m
                        },
                        new
                        {
                            EdadRangoId = 3,
                            EdadDesde = 61,
                            EdadHasta = 90,
                            Peso = 0.0008m
                        });
                });

            modelBuilder.Entity("Domain.Entities.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehiculoId"));

                    b.Property<int>("AnioVehiculo")
                        .HasColumnType("int");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<int>("ModeloId")
                        .HasColumnType("int");

                    b.Property<int>("VersionId")
                        .HasColumnType("int");

                    b.HasKey("VehiculoId");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ModeloId");

                    b.HasIndex("VersionId");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("Domain.Entities.VersionVehiculo", b =>
                {
                    b.Property<int>("VersionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VersionId"));

                    b.Property<int>("ModeloId")
                        .HasColumnType("int");

                    b.Property<string>("NombreVersion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioBase")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("VersionId");

                    b.HasIndex("ModeloId");

                    b.ToTable("Version");
                });

            modelBuilder.Entity("Domain.Entities.Modelo", b =>
                {
                    b.HasOne("Domain.Entities.Marca", "Marca")
                        .WithMany("Modelos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("Domain.Entities.Vehiculo", b =>
                {
                    b.HasOne("Domain.Entities.Marca", "Marca")
                        .WithMany("Vehiculos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Modelo", "Modelo")
                        .WithMany("Vehiculos")
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VersionVehiculo", "VersionVehiculo")
                        .WithMany("Vehiculos")
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Marca");

                    b.Navigation("Modelo");

                    b.Navigation("VersionVehiculo");
                });

            modelBuilder.Entity("Domain.Entities.VersionVehiculo", b =>
                {
                    b.HasOne("Domain.Entities.Modelo", "Modelo")
                        .WithMany("vehiculoVersiones")
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("Domain.Entities.Marca", b =>
                {
                    b.Navigation("Modelos");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Domain.Entities.Modelo", b =>
                {
                    b.Navigation("Vehiculos");

                    b.Navigation("vehiculoVersiones");
                });

            modelBuilder.Entity("Domain.Entities.VersionVehiculo", b =>
                {
                    b.Navigation("Vehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
