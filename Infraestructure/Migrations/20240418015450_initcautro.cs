using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class initcautro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModeloId",
                table: "VersionVehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VersionVehiculo_ModeloId",
                table: "VersionVehiculo",
                column: "ModeloId");

            migrationBuilder.AddForeignKey(
                name: "FK_VersionVehiculo_Modelo_ModeloId",
                table: "VersionVehiculo",
                column: "ModeloId",
                principalTable: "Modelo",
                principalColumn: "ModeloId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VersionVehiculo_Modelo_ModeloId",
                table: "VersionVehiculo");

            migrationBuilder.DropIndex(
                name: "IX_VersionVehiculo_ModeloId",
                table: "VersionVehiculo");

            migrationBuilder.DropColumn(
                name: "ModeloId",
                table: "VersionVehiculo");
        }
    }
}
