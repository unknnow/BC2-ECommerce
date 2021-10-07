using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Produits",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "PurchaserId",
                table: "Produits",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Produits",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_CategoryId",
                table: "Produits",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_PurchaserId",
                table: "Produits",
                column: "PurchaserId");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_SellerId",
                table: "Produits",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_CategoryId",
                table: "Produits",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Users_PurchaserId",
                table: "Produits",
                column: "PurchaserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Users_SellerId",
                table: "Produits",
                column: "SellerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_CategoryId",
                table: "Produits");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Users_PurchaserId",
                table: "Produits");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Users_SellerId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_CategoryId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_PurchaserId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_SellerId",
                table: "Produits");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Produits",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PurchaserId",
                table: "Produits",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Produits",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
