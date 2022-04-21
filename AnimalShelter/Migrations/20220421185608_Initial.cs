using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Species = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 2, "Female", "Rose", "Cat" },
                    { 2, 2, "Female", "Doja", "Cat" },
                    { 3, 4, "Female", "Elfreda", "Cat" },
                    { 4, 5, "Female", "Monah", "Cat" },
                    { 5, 2, "Female", "Eiza", "Cat" },
                    { 6, 7, "Male", "Norm", "Cat" },
                    { 7, 2, "Male", "George", "Cat" },
                    { 8, 13, "Male", "Vlad", "Cat" },
                    { 9, 3, "Male", "Neuman", "Cat" },
                    { 10, 3, "Male", "Addy", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
