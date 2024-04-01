using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YtBookStore.Migrations
{
    /// <summary>
    /// Represents the initial migration class for setting up the database schema.
    /// </summary>
    public partial class init : Migration
    {
        /// <inheritdoc />
        /// <summary>
        /// Applies changes to the database schema during the migration.
        /// </summary>
        /// <param name="migrationBuilder">The migration builder.</param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Creates the Author table
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    // Column definitions for the Author table
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            // Creates the Book table
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    // Column definitions for the Book table
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isbn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPages = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PubhlisherId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            // Creates the Genre table
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    // Column definitions for the Genre table
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            // Creates the Publisher table
            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    // Column definitions for the Publisher table
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });
        }

        /// <inheritdoc />
        /// <summary>
        /// Reverts the changes applied in the Up method, undoing the migration.
        /// </summary>
        /// <param name="migrationBuilder">The migration builder.</param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drops the Author table
            migrationBuilder.DropTable(
                name: "Author");

            // Drops the Book table
            migrationBuilder.DropTable(
                name: "Book");

            // Drops the Genre table
            migrationBuilder.DropTable(
                name: "Genre");

            // Drops the Publisher table
            migrationBuilder.DropTable(
                name: "Publisher");
        }
    }
}
