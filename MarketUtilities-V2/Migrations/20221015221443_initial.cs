using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketUtilities_V2.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pasillo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modified_by = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    moified_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasillo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modified_by = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    moified_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pasilloIDid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.id);
                    table.ForeignKey(
                        name: "FK_Categoria_Pasillo_pasilloIDid",
                        column: x => x.pasilloIDid,
                        principalTable: "Pasillo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoDeBarras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoriaIDid = table.Column<int>(type: "int", nullable: false),
                    modified_by = table.Column<int>(type: "int", nullable: false),
                    moified_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.id);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_categoriaIDid",
                        column: x => x.categoriaIDid,
                        principalTable: "Categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_pasilloIDid",
                table: "Categoria",
                column: "pasilloIDid");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_categoriaIDid",
                table: "Producto",
                column: "categoriaIDid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Pasillo");
        }
    }
}
