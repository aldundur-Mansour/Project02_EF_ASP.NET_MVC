using Microsoft.EntityFrameworkCore.Migrations;

namespace Induction.Migrations
{
    public partial class CreateRelationShipChapterChaperChunk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChapterId",
                table: "ChapterChunks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChapterChunks_ChapterId",
                table: "ChapterChunks",
                column: "ChapterId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterChunks_Chapters_ChapterId",
                table: "ChapterChunks",
                column: "ChapterId",
                principalTable: "Chapters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChapterChunks_Chapters_ChapterId",
                table: "ChapterChunks");

            migrationBuilder.DropIndex(
                name: "IX_ChapterChunks_ChapterId",
                table: "ChapterChunks");

            migrationBuilder.DropColumn(
                name: "ChapterId",
                table: "ChapterChunks");
        }
    }
}
