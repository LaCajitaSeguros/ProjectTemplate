using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class datasett : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "RangoEtario",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "AnioVehiculo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AnioVehiculo",
                columns: new[] { "AnioId", "AnioVehiculoDesde", "AnioVehiculoHasta", "Peso" },
                values: new object[,]
                {
                    { 1, 1, 1989, 0.0007m },
                    { 2, 1990, 1999, 0.0005m },
                    { 3, 2000, 2009, 0.0004m },
                    { 4, 2010, 2019, 0.0003m },
                    { 5, 2020, 2024, 0.0001m }
                });

            migrationBuilder.InsertData(
                table: "GNC",
                columns: new[] { "GNCId", "HasGNC", "Peso" },
                values: new object[,]
                {
                    { 1, true, 0.0001m },
                    { 2, false, 0m }
                });

            migrationBuilder.InsertData(
                table: "Localidad",
                columns: new[] { "LocalidadId", "Nombre", "Peso" },
                values: new object[,]
                {
                    { 1, "Varela", 0.0005m },
                    { 2, "Berazategui", 0.0005m },
                    { 3, "Lanus", 0.0005m },
                    { 4, "Quilmes", 0.0006m },
                    { 5, "Avellaneda", 0.0003m },
                    { 6, "Lomas de Zamora", 0.0002m }
                });

            migrationBuilder.InsertData(
                table: "RangoEtario",
                columns: new[] { "EdadRangoId", "EdadDesde", "EdadHasta", "Peso" },
                values: new object[,]
                {
                    { 1, 18, 40, 0.0005m },
                    { 2, 41, 60, 0.0006m },
                    { 3, 61, 90, 0.0008m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GNC",
                keyColumn: "GNCId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GNC",
                keyColumn: "GNCId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RangoEtario",
                keyColumn: "EdadRangoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RangoEtario",
                keyColumn: "EdadRangoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RangoEtario",
                keyColumn: "EdadRangoId",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "Peso",
                table: "RangoEtario",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Peso",
                table: "AnioVehiculo",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
