using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketUtilities_V2.Migrations
{
    public partial class productosCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Categoria_categoriaIDid",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_categoriaIDid",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "categoriaIDid",
                table: "Producto");

            migrationBuilder.AddColumn<string>(
                name: "categoriaID",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoriaID",
                table: "Producto");

            migrationBuilder.AddColumn<int>(
                name: "categoriaIDid",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_categoriaIDid",
                table: "Producto",
                column: "categoriaIDid");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Categoria_categoriaIDid",
                table: "Producto",
                column: "categoriaIDid",
                principalTable: "Categoria",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
