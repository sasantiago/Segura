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
    [Migration("20240911010129_CreateIdentitySchema")]
    partial class CreateIdentitySchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Cliente", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

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

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
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

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Id_Departamento")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Pregunta_Secreta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Respuesta_Secreta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roll")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("clientes_id")
                        .HasColumnType("int");

                    b.Property<string>("customer_NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("customer_fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoID_Departamento");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
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

                    b.Property<string>("ClienteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

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

                    b.HasKey("ID_Reservas");

                    b.HasIndex("ClienteId");

                    b.HasIndex("SedeID_Sedes");

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

            // modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            //     {
            //         b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
            //             .WithMany()
            //             .HasForeignKey("RoleId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();
            //     });

            // modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            //     {
            //         b.HasOne("SEGURA_ASSETMENTS.Models.Cliente", null)
            //             .WithMany()
            //             .HasForeignKey("UserId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();
            //     });

            // modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            //     {
            //         b.HasOne("SEGURA_ASSETMENTS.Models.Cliente", null)
            //             .WithMany()
            //             .HasForeignKey("UserId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();
            //     });

            // modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            //     {
            //         b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
            //             .WithMany()
            //             .HasForeignKey("RoleId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.HasOne("SEGURA_ASSETMENTS.Models.Cliente", null)
            //             .WithMany()
            //             .HasForeignKey("UserId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();
            //     });

            // modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            //     {
            //         b.HasOne("SEGURA_ASSETMENTS.Models.Cliente", null)
            //             .WithMany()
            //             .HasForeignKey("UserId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();
            //     });

            // modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Cliente", b =>
            //     {
            //         b.HasOne("SEGURA_ASSETMENTS.Models.Departamento", "Departamento")
            //             .WithMany("Clientes")
            //             .HasForeignKey("DepartamentoID_Departamento");

            //         b.Navigation("Departamento");
            //     });

            // modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Reserva", b =>
            //     {
            //         b.HasOne("SEGURA_ASSETMENTS.Models.Cliente", "Cliente")
            //             .WithMany()
            //             .HasForeignKey("ClienteId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.HasOne("SEGURA_ASSETMENTS.Models.Sede", "Sede")
            //             .WithMany("Reservas")
            //             .HasForeignKey("SedeID_Sedes")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.Navigation("Cliente");

            //         b.Navigation("Sede");
            //     });

            // modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Sede", b =>
            //     {
            //         b.HasOne("SEGURA_ASSETMENTS.Models.Habitacion", "Habitacion")
            //             .WithMany()
            //             .HasForeignKey("HabitacionId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.Navigation("Habitacion");
            //     });

            // modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Tarifa", b =>
            //     {
            //         b.HasOne("SEGURA_ASSETMENTS.Models.Sede", "Sede")
            //             .WithMany()
            //             .HasForeignKey("SedeID_Sedes")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.Navigation("Sede");
            //     });

            // modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Departamento", b =>
            //     {
            //         b.Navigation("Clientes");
            //     });

            // modelBuilder.Entity("SEGURA_ASSETMENTS.Models.Sede", b =>
            //     {
            //         b.Navigation("Reservas");
            //     });
#pragma warning restore 612, 618
        }
    }
}
