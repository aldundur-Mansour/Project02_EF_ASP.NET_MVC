using Microsoft.EntityFrameworkCore.Migrations;

namespace Induction.Migrations
{
    public partial class CreateRelationShipsUSerFacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Facts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Facts_UserId",
                table: "Facts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facts_Users_UserId",
                table: "Facts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facts_Users_UserId",
                table: "Facts");

            migrationBuilder.DropIndex(
                name: "IX_Facts_UserId",
                table: "Facts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Facts");
        }
    }
}
