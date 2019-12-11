using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokemon_DB.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Pokemon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Pokemon",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Pokemon",
                nullable: true);
        }
    }
}
