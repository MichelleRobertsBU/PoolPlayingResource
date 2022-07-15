using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoolPlayingResource.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    VenueId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VenueName = table.Column<string>(type: "TEXT", nullable: false),
                    NumberTables = table.Column<int>(type: "INTEGER", nullable: true),
                    VenueAddress = table.Column<string>(type: "TEXT", nullable: false),
                    TableFee = table.Column<string>(type: "TEXT", nullable: false),
                    TableSize = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.VenueId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venues");
        }
    }
}
