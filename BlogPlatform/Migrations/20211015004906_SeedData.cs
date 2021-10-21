using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CatName" },
                values: new object[] { 1, "Dance Steps" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CatName" },
                values: new object[] { 2, "Music" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CatName" },
                values: new object[] { 3, "Social Dancing" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "Now", "Title" },
                values: new object[,]
                {
                    { 2, "Brandon Bell", "Body body body body body body body body body body body body body body body body body", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Best Dancing Shoes" },
                    { 6, "Donna Doleur", "Body body body body body body body body body body body body body body body body body", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What Is The Hardest Latin Dance To Learn?" },
                    { 3, "Julio Santiago", "Body body body body body body body body body body body body body body body body body", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "90's Bachata" },
                    { 4, "Neil Potbelly", "Body body body body body body body body body body body body body body body body body", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Who Is The Best Salsa Singer Of All Time: Marc Anthony Or Hector Lavoe?" },
                    { 5, "Brittany Rabbit", "Body body body body body body body body body body body body body body body body body", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do You Need To Know Spanish To Appreciate Bachata Music?" },
                    { 8, "Kay Dee", "Body body body body body body body body body body body body body body body body body", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Five Salsa Moves You Should Know" },
                    { 1, "Deserae Florentine", "Body body body body body body body body body body body body body body body body body", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How To Get a Man To Ask You To Dance" },
                    { 7, "Randy Super", "Body body body body body body body body body body body body body body body body body", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dancing Couple's Guide To Navigating Jealousy" },
                    { 9, "Maria Reuben", "Body body body body body body body body body body body body body body body body body", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Important Milonga Etiquette" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
