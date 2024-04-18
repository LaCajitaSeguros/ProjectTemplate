using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class inittres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VersionId",
                table: "Vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "VersionVehiculo",
                columns: table => new
                {
                    VersionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioBase = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionVehiculo", x => x.VersionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_VersionId",
                table: "Vehiculo",
                column: "VersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_VersionVehiculo_VersionId",
                table: "Vehiculo",
                column: "VersionId",
                principalTable: "VersionVehiculo",
                principalColumn: "VersionId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_VersionVehiculo_VersionId",
                table: "Vehiculo");

            migrationBuilder.DropTable(
                name: "VersionVehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_VersionId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "VersionId",
                table: "Vehiculo");
        }
    }
}
