using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEGURA_ASSETMENTS.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSedeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    ID_Departamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDepartamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.ID_Departamento);
                });

            migrationBuilder.CreateTable(
                name: "Habitaciones",
                columns: table => new
                {
                    Id_Habitaciones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CamasSencillas = table.Column<int>(type: "int", nullable: false),
                    CamasDobles = table.Column<int>(type: "int", nullable: false),
                    Bano = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Televisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Terraza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cocina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalaConSofa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitaciones", x => x.Id_Habitaciones);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID_Clientes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Roll = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_Departamento = table.Column<int>(type: "int", nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barrio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreguntaSecreta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RespuestaSecreta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthCorreo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthCelular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoID_Departamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID_Clientes);
                    table.ForeignKey(
                        name: "FK_Clientes_Departamentos_DepartamentoID_Departamento",
                        column: x => x.DepartamentoID_Departamento,
                        principalTable: "Departamentos",
                        principalColumn: "ID_Departamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    ID_Sedes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_sede = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapacidadSede = table.Column<int>(type: "int", nullable: false),
                    NumHabitaciones = table.Column<int>(type: "int", nullable: false),
                    HabitacionId = table.Column<int>(type: "int", nullable: false),
                    ServiciosSede = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.ID_Sedes);
                    table.ForeignKey(
                        name: "FK_Sedes_Habitaciones_HabitacionId",
                        column: x => x.HabitacionId,
                        principalTable: "Habitaciones",
                        principalColumn: "Id_Habitaciones",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ID_Reservas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaLlegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroPersonas = table.Column<int>(type: "int", nullable: false),
                    NumeroNoches = table.Column<int>(type: "int", nullable: false),
                    Lavanderia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_Sede = table.Column<int>(type: "int", nullable: false),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    SedeID_Sedes = table.Column<int>(type: "int", nullable: false),
                    ClienteID_Clientes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ID_Reservas);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_ClienteID_Clientes",
                        column: x => x.ClienteID_Clientes,
                        principalTable: "Clientes",
                        principalColumn: "ID_Clientes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Sedes_SedeID_Sedes",
                        column: x => x.SedeID_Sedes,
                        principalTable: "Sedes",
                        principalColumn: "ID_Sedes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarifas",
                columns: table => new
                {
                    ID_Tarifa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Sede = table.Column<int>(type: "int", nullable: false),
                    NumeroPersonas = table.Column<int>(type: "int", nullable: false),
                    NumeroHabitaciones = table.Column<int>(type: "int", nullable: false),
                    TipoAlojamiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarifas = table.Column<int>(type: "int", nullable: false),
                    SedeID_Sedes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifas", x => x.ID_Tarifa);
                    table.ForeignKey(
                        name: "FK_Tarifas_Sedes_SedeID_Sedes",
                        column: x => x.SedeID_Sedes,
                        principalTable: "Sedes",
                        principalColumn: "ID_Sedes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DepartamentoID_Departamento",
                table: "Clientes",
                column: "DepartamentoID_Departamento");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClienteID_Clientes",
                table: "Reservas",
                column: "ClienteID_Clientes");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_SedeID_Sedes",
                table: "Reservas",
                column: "SedeID_Sedes");

            migrationBuilder.CreateIndex(
                name: "IX_Sedes_HabitacionId",
                table: "Sedes",
                column: "HabitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarifas_SedeID_Sedes",
                table: "Tarifas",
                column: "SedeID_Sedes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Tarifas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Sedes");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Habitaciones");
        }
    }
}
