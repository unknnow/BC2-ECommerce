using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_CategoryId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_CategoryId",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Produits");

            migrationBuilder.AddColumn<int>(
                name: "CategoryRefId",
                table: "Produits",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produits_CategoryRefId",
                table: "Produits",
                column: "CategoryRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_CategoryRefId",
                table: "Produits",
                column: "CategoryRefId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_CategoryRefId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_CategoryRefId",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "CategoryRefId",
                table: "Produits");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Produits",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produits_CategoryId",
                table: "Produits",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_CategoryId",
                table: "Produits",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
