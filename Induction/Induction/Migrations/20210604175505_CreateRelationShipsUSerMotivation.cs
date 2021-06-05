using Microsoft.EntityFrameworkCore.Migrations;

namespace Induction.Migrations
{
    public partial class CreateRelationShipsUSerMotivation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Motivations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Motivations_UserId",
                table: "Motivations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Motivations_Users_UserId",
                table: "Motivations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motivations_Users_UserId",
                table: "Motivations");

            migrationBuilder.DropIndex(
                name: "IX_Motivations_UserId",
                table: "Motivations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Motivations");
        }
    }
}
