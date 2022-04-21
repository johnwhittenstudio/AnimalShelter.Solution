using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 11, 5, "Female", "Yoko", "Cat" },
                    { 38, 7, "Male", "John", "Dog" },
                    { 37, 1, "Male", "Munroe", "Dog" },
                    { 36, 5, "Male", "Dwight", "Dog" },
                    { 35, 5, "Female", "Jolene", "Dog" },
                    { 34, 2, "Female", "Amala", "Dog" },
                    { 33, 7, "Female", "Daniella", "Dog" },
                    { 32, 4, "Female", "Tonie", "Dog" },
                    { 31, 2, "Female", "Venus", "Dog" },
                    { 30, 1, "Male", "Eliot", "Dog" },
                    { 29, 5, "Male", "Kasper", "Dog" },
                    { 28, 12, "Male", "Abrahamster", "Dog" },
                    { 27, 3, "Male", "Ruprecht", "Dog" },
                    { 26, 2, "Male", "Ebeneser", "Dog" },
                    { 25, 7, "Female", "Cleo", "Dog" },
                    { 24, 5, "Female", "Polly", "Dog" },
                    { 23, 3, "Female", "Neko", "Dog" },
                    { 22, 2, "Female", "Dixie", "Dog" },
                    { 21, 3, "Female", "Chloe", "Dog" },
                    { 20, 10, "Male", "Giraldo", "Cat" },
                    { 19, 7, "Male", "Sammie", "Cat" },
                    { 18, 2, "Male", "Benedicto", "Cat" },
                    { 17, 5, "Male", "Arney", "Cat" },
                    { 16, 1, "Male", "Franklin", "Cat" },
                    { 15, 3, "Female", "Selina Kyle", "Cat" },
                    { 14, 12, "Female", "Dido", "Cat" },
                    { 13, 7, "Female", "Dorri", "Cat" },
                    { 12, 2, "Female", "Giselle", "Cat" },
                    { 39, 10, "Male", "Nils", "Dog" },
                    { 40, 8, "Male", "Thom", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 40);
        }
    }
}
