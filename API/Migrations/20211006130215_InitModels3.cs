using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class InitModels3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "Produits",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "Produits");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");
        }
    }
}
