using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class datasettfi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "RangoEtario",
                type: "decimal(6,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "Localidad",
                type: "decimal(6,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "GNC",
                type: "decimal(6,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "AnioVehiculo",
                type: "decimal(6,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,5)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "RangoEtario",
                type: "decimal(5,5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "Localidad",
                type: "decimal(5,5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "GNC",
                type: "decimal(5,5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "AnioVehiculo",
                type: "decimal(5,5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,4)");
        }
    }
}
