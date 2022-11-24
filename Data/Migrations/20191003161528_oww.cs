using Microsoft.EntityFrameworkCore.Migrations;

namespace RentQuest.Data.Migrations
{
    public partial class oww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HEmail",
                table: "Circulations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HEmail",
                table: "Circulations");
        }
    }
}
