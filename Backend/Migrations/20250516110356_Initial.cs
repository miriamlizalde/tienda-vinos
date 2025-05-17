using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ecologica = table.Column<bool>(type: "bit", nullable: false),
                    Localizacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vinos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodegaId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Año = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Graduacion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    NombreBodega = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vinos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bodegas",
                columns: new[] { "Id", "Activa", "Ecologica", "Localizacion", "Nombre" },
                values: new object[,]
                {
                    { 1, true, true, "Toledo", "Lavero" },
                    { 2, true, false, "Rioja", "CincoVillas" },
                    { 3, true, true, "Zaragoza", "Zierzo" }
                });

            migrationBuilder.InsertData(
                table: "Vinos",
                columns: new[] { "Id", "Año", "BodegaId", "Graduacion", "Nombre", "NombreBodega", "Precio", "Stock", "Tipo" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15.5m, "Ramon Bilbo", "CincoVillas", 10.5f, 100, "Tinto" },
                    { 2, new DateTime(2018, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10.5m, "Rosetti", "Lavero", 17.5f, 50, "Rosado" },
                    { 3, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 9.5m, "Nieves", "Zierzo", 11.2f, 80, "Blanco" },
                    { 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8.5m, "Swarser", "Lavero", 5.5f, 150, "Espumoso" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bodegas");

            migrationBuilder.DropTable(
                name: "Vinos");
        }
    }
}
