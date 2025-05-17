using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Precio",
                table: "Vinos",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Precio",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Precio",
                value: 17.5);

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Precio",
                value: 11.199999809265137);

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Precio",
                value: 5.5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Precio",
                table: "Vinos",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Precio",
                value: 10.5f);

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Precio",
                value: 17.5f);

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Precio",
                value: 11.2f);

            migrationBuilder.UpdateData(
                table: "Vinos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Precio",
                value: 5.5f);
        }
    }
}
