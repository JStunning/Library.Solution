using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class PatronCopy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CopyId",
                table: "BookAuthor",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_CopyId",
                table: "BookAuthor",
                column: "CopyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Copys_CopyId",
                table: "BookAuthor",
                column: "CopyId",
                principalTable: "Copys",
                principalColumn: "CopyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Copys_CopyId",
                table: "BookAuthor");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthor_CopyId",
                table: "BookAuthor");

            migrationBuilder.DropColumn(
                name: "CopyId",
                table: "BookAuthor");
        }
    }
}
