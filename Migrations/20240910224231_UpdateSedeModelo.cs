using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEGURA_ASSETMENTS.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSedeModelo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Departamentos_DepartamentoID_Departamento",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_ClienteID_Clientes",
                table: "Reservas");

            migrationBuilder.RenameColumn(
                name: "ClienteID_Clientes",
                table: "Reservas",
                newName: "clientes_id");

            migrationBuilder.RenameIndex(
                name: "IX_Reservas_ClienteID_Clientes",
                table: "Reservas",
                newName: "IX_Reservas_clientes_id");

            migrationBuilder.RenameColumn(
                name: "ID_Departamento",
                table: "Clientes",
                newName: "Id_Departamento");

            migrationBuilder.RenameColumn(
                name: "RespuestaSecreta",
                table: "Clientes",
                newName: "customer_NombreCompleto");

            migrationBuilder.RenameColumn(
                name: "PreguntaSecreta",
                table: "Clientes",
                newName: "Respuesta_Secreta");

            migrationBuilder.RenameColumn(
                name: "NombreCompleto",
                table: "Clientes",
                newName: "Pregunta_Secreta");

            migrationBuilder.RenameColumn(
                name: "FechaNacimiento",
                table: "Clientes",
                newName: "customer_fechaNacimiento");

            migrationBuilder.RenameColumn(
                name: "AuthCorreo",
                table: "Clientes",
                newName: "Auth_Correo");

            migrationBuilder.RenameColumn(
                name: "AuthCelular",
                table: "Clientes",
                newName: "Auth_Celular");

            migrationBuilder.RenameColumn(
                name: "ID_Clientes",
                table: "Clientes",
                newName: "clientes_id");

            migrationBuilder.AlterColumn<int>(
                name: "DepartamentoID_Departamento",
                table: "Clientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Departamentos_DepartamentoID_Departamento",
                table: "Clientes",
                column: "DepartamentoID_Departamento",
                principalTable: "Departamentos",
                principalColumn: "ID_Departamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_clientes_id",
                table: "Reservas",
                column: "clientes_id",
                principalTable: "Clientes",
                principalColumn: "clientes_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Departamentos_DepartamentoID_Departamento",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_clientes_id",
                table: "Reservas");

            migrationBuilder.RenameColumn(
                name: "clientes_id",
                table: "Reservas",
                newName: "ClienteID_Clientes");

            migrationBuilder.RenameIndex(
                name: "IX_Reservas_clientes_id",
                table: "Reservas",
                newName: "IX_Reservas_ClienteID_Clientes");

            migrationBuilder.RenameColumn(
                name: "Id_Departamento",
                table: "Clientes",
                newName: "ID_Departamento");

            migrationBuilder.RenameColumn(
                name: "customer_fechaNacimiento",
                table: "Clientes",
                newName: "FechaNacimiento");

            migrationBuilder.RenameColumn(
                name: "customer_NombreCompleto",
                table: "Clientes",
                newName: "RespuestaSecreta");

            migrationBuilder.RenameColumn(
                name: "Respuesta_Secreta",
                table: "Clientes",
                newName: "PreguntaSecreta");

            migrationBuilder.RenameColumn(
                name: "Pregunta_Secreta",
                table: "Clientes",
                newName: "NombreCompleto");

            migrationBuilder.RenameColumn(
                name: "Auth_Correo",
                table: "Clientes",
                newName: "AuthCorreo");

            migrationBuilder.RenameColumn(
                name: "Auth_Celular",
                table: "Clientes",
                newName: "AuthCelular");

            migrationBuilder.RenameColumn(
                name: "clientes_id",
                table: "Clientes",
                newName: "ID_Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "DepartamentoID_Departamento",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Departamentos_DepartamentoID_Departamento",
                table: "Clientes",
                column: "DepartamentoID_Departamento",
                principalTable: "Departamentos",
                principalColumn: "ID_Departamento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_ClienteID_Clientes",
                table: "Reservas",
                column: "ClienteID_Clientes",
                principalTable: "Clientes",
                principalColumn: "ID_Clientes",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
