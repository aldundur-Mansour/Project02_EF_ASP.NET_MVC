using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Induction.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "C# in Depth, Fourth Edition", "https://www.oreilly.com/library/view/c-in-depth/9781617294532/" },
                    { 2, "Head First C#, 4th Editio", "https://www.oreilly.com/library/view/head-first-c/9781491976692/" }
                });

            migrationBuilder.InsertData(
                table: "FlashCards",
                columns: new[] { "id", "Answer", "Question" },
                values: new object[,]
                {
                    { 1, "The abstract keyword enables you to create classes and class members that are incomplete and must be implemented in a derived class. ", "What is an abstract Keyword?" },
                    { 2, "A delegate is a reference type that can be used to encapsulate a named or an anonymous method.", "Delegate " }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Body" },
                values: new object[,]
                {
                    { 1, "Stay Focused" },
                    { 2, "Keep it going" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "Mansoviic@gmail.com", "Mansovic", "P@assWord123" },
                    { 2, "Mansoviic2@gmail.com", "Mansovic2", "P@assWord1232" }
                });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "BookId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Introduction" },
                    { 2, 1, "Deep Coding" }
                });

            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "Id", "Attachment", "Body", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { 2, "https://edu.rsc.org/resources/tyndall-effect-why-the-sky-is-blue/1877.article", "Tyndall effect- why the sky is blue", new DateTime(2021, 6, 4, 22, 47, 42, 434, DateTimeKind.Local).AddTicks(3743), 1 },
                    { 1, "https://www.w3schools.com/cs/cs_oop.asp", "C# is OOP", new DateTime(2021, 6, 4, 22, 47, 42, 434, DateTimeKind.Local).AddTicks(3221), 2 }
                });

            migrationBuilder.InsertData(
                table: "Motivations",
                columns: new[] { "id", "Body", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { 2, "If you really want the key to success, start by doing the opposite of what everyone else is doing. —Brad Szollose", new DateTime(2021, 6, 4, 22, 47, 42, 434, DateTimeKind.Local).AddTicks(2169), 1 },
                    { 1, "Too many of us are not living our dreams because we are living our fears. —Les Brown", new DateTime(2021, 6, 4, 22, 47, 42, 433, DateTimeKind.Local).AddTicks(4512), 2 }
                });

            migrationBuilder.InsertData(
                table: "ChapterChunks",
                columns: new[] { "Id", "Body", "ChapterId", "CreatedAt", "CurrentPage", "Title" },
                values: new object[] { 2, "a small intro ", 1, new DateTime(2021, 6, 4, 22, 47, 42, 434, DateTimeKind.Local).AddTicks(9011), 12, "intro" });

            migrationBuilder.InsertData(
                table: "ChapterChunks",
                columns: new[] { "Id", "Body", "ChapterId", "CreatedAt", "CurrentPage", "Title" },
                values: new object[] { 1, "what is deep coding and why", 2, new DateTime(2021, 6, 4, 22, 47, 42, 434, DateTimeKind.Local).AddTicks(8554), 23, "Deep Coding" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChapterChunks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChapterChunks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlashCards",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlashCards",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Motivations",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Motivations",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
