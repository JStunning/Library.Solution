using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class ModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Copys_Books_BookId",
                table: "Copys");

            migrationBuilder.DropIndex(
                name: "IX_Copys_BookId",
                table: "Copys");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Checkout",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_BookId",
                table: "Checkout",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkout_Books_BookId",
                table: "Checkout",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkout_Books_BookId",
                table: "Checkout");

            migrationBuilder.DropIndex(
                name: "IX_Checkout_BookId",
                table: "Checkout");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Checkout");

            migrationBuilder.CreateIndex(
                name: "IX_Copys_BookId",
                table: "Copys",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Copys_Books_BookId",
                table: "Copys",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
