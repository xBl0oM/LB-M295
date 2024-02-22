using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Floorballer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Player_first_name = table.Column<string>(type: "TEXT", nullable: false),
                    Player_last_name = table.Column<string>(type: "TEXT", nullable: false),
                    Player_age = table.Column<int>(type: "INTEGER", nullable: false),
                    Player_shirt_number = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Team_name = table.Column<string>(type: "TEXT", nullable: false),
                    Team_slogan = table.Column<string>(type: "TEXT", nullable: false),
                    Team_native_country = table.Column<string>(type: "TEXT", nullable: false),
                    Team_founded_in = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
