using Microsoft.EntityFrameworkCore.Migrations;

namespace RentQuest.Data.Migrations
{
    public partial class circnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cdetails",
                table: "Circulations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Flat_No",
                table: "Circulations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "House_No",
                table: "Circulations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "SizeSQFT",
                table: "Circulations",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "num_bath",
                table: "Circulations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "num_bed",
                table: "Circulations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cdetails",
                table: "Circulations");

            migrationBuilder.DropColumn(
                name: "Flat_No",
                table: "Circulations");

            migrationBuilder.DropColumn(
                name: "House_No",
                table: "Circulations");

            migrationBuilder.DropColumn(
                name: "SizeSQFT",
                table: "Circulations");

            migrationBuilder.DropColumn(
                name: "num_bath",
                table: "Circulations");

            migrationBuilder.DropColumn(
                name: "num_bed",
                table: "Circulations");
        }
    }
}
