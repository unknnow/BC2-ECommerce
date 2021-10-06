using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class InitModels4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "Produits",
                newName: "Price");

            migrationBuilder.AddColumn<string>(
                name: "img",
                table: "Produits",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "img",
                table: "Produits");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Produits",
                newName: "price");
        }
    }
}
