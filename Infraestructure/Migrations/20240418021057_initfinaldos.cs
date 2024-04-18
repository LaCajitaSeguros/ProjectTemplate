using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class initfinaldos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_VersionVehiculo_VersionId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_VersionVehiculo_Modelo_ModeloId",
                table: "VersionVehiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VersionVehiculo",
                table: "VersionVehiculo");

            migrationBuilder.RenameTable(
                name: "VersionVehiculo",
                newName: "Version");

            migrationBuilder.RenameIndex(
                name: "IX_VersionVehiculo_ModeloId",
                table: "Version",
                newName: "IX_Version_ModeloId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Version",
                table: "Version",
                column: "VersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Version_VersionId",
                table: "Vehiculo",
                column: "VersionId",
                principalTable: "Version",
                principalColumn: "VersionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Version_Modelo_ModeloId",
                table: "Version",
                column: "ModeloId",
                principalTable: "Modelo",
                principalColumn: "ModeloId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Version_VersionId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Version_Modelo_ModeloId",
                table: "Version");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Version",
                table: "Version");

            migrationBuilder.RenameTable(
                name: "Version",
                newName: "VersionVehiculo");

            migrationBuilder.RenameIndex(
                name: "IX_Version_ModeloId",
                table: "VersionVehiculo",
                newName: "IX_VersionVehiculo_ModeloId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VersionVehiculo",
                table: "VersionVehiculo",
                column: "VersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_VersionVehiculo_VersionId",
                table: "Vehiculo",
                column: "VersionId",
                principalTable: "VersionVehiculo",
                principalColumn: "VersionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VersionVehiculo_Modelo_ModeloId",
                table: "VersionVehiculo",
                column: "ModeloId",
                principalTable: "Modelo",
                principalColumn: "ModeloId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
