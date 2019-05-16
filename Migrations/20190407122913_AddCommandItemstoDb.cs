using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cmdApi.Migrations
{
    public partial class AddCommandItemstoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommandsSet");

            migrationBuilder.CreateTable(
                name: "CommandSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Howto = table.Column<string>(nullable: true),
                    Platform = table.Column<string>(nullable: true),
                    CommandLine = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandSet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommandSet");

            migrationBuilder.CreateTable(
                name: "CommandsSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommandLine = table.Column<string>(nullable: true),
                    Howto = table.Column<string>(nullable: true),
                    Platform = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandsSet", x => x.Id);
                });
        }
    }
}
