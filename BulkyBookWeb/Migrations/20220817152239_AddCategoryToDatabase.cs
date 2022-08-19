using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBookWeb.Migrations
{
    public partial class AddCategoryToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) // Insert Migration
        {
            migrationBuilder.CreateTable(
                name: "Categories", // Category class'taki Property ile aynı.
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"), // 1'er 1 artacak.
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id); // Primary Key 
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) // Delete Migration
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
