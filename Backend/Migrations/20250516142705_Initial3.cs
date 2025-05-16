using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Graduacion",
                table: "Vinos",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Graduacion",
                value: 15.5);

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Graduacion",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Graduacion", "Precio" },
                values: new object[] { 9.5, 11.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Graduacion",
                value: 8.5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Graduacion",
                table: "Vinos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Graduacion",
                value: 15.5m);

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Graduacion",
                value: 10.5m);

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Graduacion", "Precio" },
                values: new object[] { 9.5m, 11.199999809265137 });

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Graduacion",
                value: 8.5m);
        }
    }
}
