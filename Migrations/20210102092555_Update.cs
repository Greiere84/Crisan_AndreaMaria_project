using Microsoft.EntityFrameworkCore.Migrations;

namespace Crisan_AndreaMaria_project.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Star");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "Star",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
