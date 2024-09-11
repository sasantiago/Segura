﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEGURA_ASSETMENTS.Data;

#nullable disable

namespace SEGURA_ASSETMENTS.Migrations
{
    [DbContext(typeof(SEGURA_ASSETMENTSContext))]
    [Migration("20240910224231_UpdateSedeModelo")]
    partial class UpdateSedeModelo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Cliente", b =>
                {
                    b.Property<int>("clientes_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("clientes_id"));

                    b.Property<string>("Auth_Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Auth_Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Barrio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartamentoID_Departamento")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Departamento")
                        .HasColumnType("int");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pregunta_Secreta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Respuesta_Secreta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roll")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("customer_fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.HasKey("clientes_id");

                    b.HasIndex("DepartamentoID_Departamento");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Departamento", b =>
                {
                    b.Property<int>("ID_Departamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Departamento"));

                    b.Property<string>("NombreDepartamento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Departamento");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Habitacion", b =>
                {
                    b.Property<int>("Id_Habitaciones")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Habitaciones"));

                    b.Property<string>("Bano")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CamasDobles")
                        .HasColumnType("int");

                    b.Property<int>("CamasSencillas")
                        .HasColumnType("int");

                    b.Property<string>("Cocina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("SalaConSofa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Televisor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Terraza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Habitaciones");

                    b.ToTable("Habitaciones");
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Reserva", b =>
                {
                    b.Property<int>("ID_Reservas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Reservas"));

                    b.Property<DateTime>("FechaLlegada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaReserva")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSalida")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_Cliente")
                        .HasColumnType("int");

                    b.Property<int>("ID_Sede")
                        .HasColumnType("int");

                    b.Property<string>("Lavanderia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroNoches")
                        .HasColumnType("int");

                    b.Property<int>("NumeroPersonas")
                        .HasColumnType("int");

                    b.Property<int>("SedeID_Sedes")
                        .HasColumnType("int");

                    b.Property<int>("clientes_id")
                        .HasColumnType("int");

                    b.HasKey("ID_Reservas");

                    b.HasIndex("SedeID_Sedes");

                    b.HasIndex("clientes_id");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Sede", b =>
                {
                    b.Property<int>("ID_Sedes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Sedes"));

                    b.Property<int>("CapacidadSede")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HabitacionId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_sede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumHabitaciones")
                        .HasColumnType("int");

                    b.Property<string>("ServiciosSede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Sedes");

                    b.HasIndex("HabitacionId");

                    b.ToTable("Sedes");
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Tarifa", b =>
                {
                    b.Property<int>("ID_Tarifa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Tarifa"));

                    b.Property<int>("ID_Sede")
                        .HasColumnType("int");

                    b.Property<int>("NumeroHabitaciones")
                        .HasColumnType("int");

                    b.Property<int>("NumeroPersonas")
                        .HasColumnType("int");

                    b.Property<int>("SedeID_Sedes")
                        .HasColumnType("int");

                    b.Property<int>("Tarifas")
                        .HasColumnType("int");

                    b.Property<string>("TipoAlojamiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Tarifa");

                    b.HasIndex("SedeID_Sedes");

                    b.ToTable("Tarifas");
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Cliente", b =>
                {
                    b.HasOne("SEGURA_ASSETMENTS.Models.Departamento", "Departamento")
                        .WithMany("Clientes")
                        .HasForeignKey("DepartamentoID_Departamento");

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Reserva", b =>
                {
                    b.HasOne("SEGURA_ASSETMENTS.Models.Sede", "Sede")
                        .WithMany("Reservas")
                        .HasForeignKey("SedeID_Sedes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SEGURA_ASSETMENTS.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("clientes_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Sede", b =>
                {
                    b.HasOne("SEGURA_ASSETMENTS.Models.Habitacion", "Habitacion")
                        .WithMany()
                        .HasForeignKey("HabitacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habitacion");
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Tarifa", b =>
                {
                    b.HasOne("SEGURA_ASSETMENTS.Models.Sede", "Sede")
                        .WithMany()
                        .HasForeignKey("SedeID_Sedes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Departamento", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Sede", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
