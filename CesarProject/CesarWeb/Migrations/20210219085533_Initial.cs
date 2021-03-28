using Microsoft.EntityFrameworkCore.Migrations;

namespace CesarWeb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CesarNum",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nummer = table.Column<int>(type: "int", nullable: false),
                    Conversion = table.Column<string>(type: "string", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CesarNum", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CesarNum");
        }
    }
}
