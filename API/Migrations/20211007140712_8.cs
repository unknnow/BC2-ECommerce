using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_CategoryRefId",
                table: "Produits");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Users_PurchaserId",
                table: "Produits");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Users_SellerId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_CategoryRefId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_PurchaserId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_SellerId",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "CategoryRefId",
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

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Produits",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Produits");

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

            migrationBuilder.AddColumn<int>(
                name: "CategoryRefId",
                table: "Produits",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produits_CategoryRefId",
                table: "Produits",
                column: "CategoryRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_PurchaserId",
                table: "Produits",
                column: "PurchaserId");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_SellerId",
                table: "Produits",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_CategoryRefId",
                table: "Produits",
                column: "CategoryRefId",
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
    }
}
