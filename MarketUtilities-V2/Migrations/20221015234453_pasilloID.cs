using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketUtilities_V2.Migrations
{
    public partial class pasilloID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Pasillo_pasilloIDid",
                table: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Categoria_pasilloIDid",
                table: "Categoria");

            migrationBuilder.RenameColumn(
                name: "pasilloIDid",
                table: "Categoria",
                newName: "pasilloID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pasilloID",
                table: "Categoria",
                newName: "pasilloIDid");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_pasilloIDid",
                table: "Categoria",
                column: "pasilloIDid");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Pasillo_pasilloIDid",
                table: "Categoria",
                column: "pasilloIDid",
                principalTable: "Pasillo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
