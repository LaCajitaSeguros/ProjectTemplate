using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class datasettfik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Peso",
                table: "RangoEtario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,4)");

            migrationBuilder.AlterColumn<string>(
                name: "Peso",
                table: "Localidad",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,4)");

            migrationBuilder.AlterColumn<string>(
                name: "Peso",
                table: "GNC",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,4)");

            migrationBuilder.AlterColumn<string>(
                name: "Peso",
                table: "AnioVehiculo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,4)");

            migrationBuilder.UpdateData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 1,
                column: "Peso",
                value: "0.0007");

            migrationBuilder.UpdateData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 2,
                column: "Peso",
                value: "0.0005");

            migrationBuilder.UpdateData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 3,
                column: "Peso",
                value: "0.0004");

            migrationBuilder.UpdateData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 4,
                column: "Peso",
                value: "0.0003");

            migrationBuilder.UpdateData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 5,
                column: "Peso",
                value: "0.0001");

            migrationBuilder.UpdateData(
                table: "GNC",
                keyColumn: "GNCId",
                keyValue: 1,
                column: "Peso",
                value: "0.0001");

            migrationBuilder.UpdateData(
                table: "GNC",
                keyColumn: "GNCId",
                keyValue: 2,
                column: "Peso",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 1,
                column: "Peso",
                value: "0.0005");

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 2,
                column: "Peso",
                value: "0.0005");

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 3,
                column: "Peso",
                value: "0.0005");

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 4,
                column: "Peso",
                value: "0.0006");

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 5,
                column: "Peso",
                value: "0.0003");

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 6,
                column: "Peso",
                value: "0.0002");

            migrationBuilder.UpdateData(
                table: "RangoEtario",
                keyColumn: "EdadRangoId",
                keyValue: 1,
                column: "Peso",
                value: "0.0005");

            migrationBuilder.UpdateData(
                table: "RangoEtario",
                keyColumn: "EdadRangoId",
                keyValue: 2,
                column: "Peso",
                value: "0.0006");

            migrationBuilder.UpdateData(
                table: "RangoEtario",
                keyColumn: "EdadRangoId",
                keyValue: 3,
                column: "Peso",
                value: "0.0008");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "RangoEtario",
                type: "decimal(6,4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "Localidad",
                type: "decimal(6,4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "GNC",
                type: "decimal(6,4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "AnioVehiculo",
                type: "decimal(6,4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 1,
                column: "Peso",
                value: 0.0007m);

            migrationBuilder.UpdateData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 2,
                column: "Peso",
                value: 0.0005m);

            migrationBuilder.UpdateData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 3,
                column: "Peso",
                value: 0.0004m);

            migrationBuilder.UpdateData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 4,
                column: "Peso",
                value: 0.0003m);

            migrationBuilder.UpdateData(
                table: "AnioVehiculo",
                keyColumn: "AnioId",
                keyValue: 5,
                column: "Peso",
                value: 0.0001m);

            migrationBuilder.UpdateData(
                table: "GNC",
                keyColumn: "GNCId",
                keyValue: 1,
                column: "Peso",
                value: 0.0001m);

            migrationBuilder.UpdateData(
                table: "GNC",
                keyColumn: "GNCId",
                keyValue: 2,
                column: "Peso",
                value: 0.0m);

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 1,
                column: "Peso",
                value: 0.0005m);

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 2,
                column: "Peso",
                value: 0.0005m);

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 3,
                column: "Peso",
                value: 0.0005m);

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 4,
                column: "Peso",
                value: 0.0006m);

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 5,
                column: "Peso",
                value: 0.0003m);

            migrationBuilder.UpdateData(
                table: "Localidad",
                keyColumn: "LocalidadId",
                keyValue: 6,
                column: "Peso",
                value: 0.0002m);

            migrationBuilder.UpdateData(
                table: "RangoEtario",
                keyColumn: "EdadRangoId",
                keyValue: 1,
                column: "Peso",
                value: 0.0005m);

            migrationBuilder.UpdateData(
                table: "RangoEtario",
                keyColumn: "EdadRangoId",
                keyValue: 2,
                column: "Peso",
                value: 0.0006m);

            migrationBuilder.UpdateData(
                table: "RangoEtario",
                keyColumn: "EdadRangoId",
                keyValue: 3,
                column: "Peso",
                value: 0.0008m);
        }
    }
}
