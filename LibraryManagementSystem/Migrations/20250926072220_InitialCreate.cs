using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationYear = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedDate", "ISBN", "IsAvailable", "PublicationYear", "Publisher", "Quantity", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Robert C. Martin", new DateTime(2025, 9, 26, 12, 52, 18, 270, DateTimeKind.Local).AddTicks(8994), "978-0132350884", true, 2008, "Prentice Hall", 5, "Clean Code", null },
                    { 2, "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", new DateTime(2025, 9, 26, 12, 52, 18, 270, DateTimeKind.Local).AddTicks(9035), "978-0201633610", true, 1994, "Addison-Wesley Professional", 3, "Design Patterns", null },
                    { 3, "Andrew Hunt, David Thomas", new DateTime(2025, 9, 26, 12, 52, 18, 270, DateTimeKind.Local).AddTicks(9039), "978-0201616224", true, 1999, "Addison-Wesley Professional", 2, "The Pragmatic Programmer", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
