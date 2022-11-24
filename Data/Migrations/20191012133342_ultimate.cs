using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentQuest.Data.Migrations
{
    public partial class ultimate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "VisitRequests");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "VisitRequests");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "VisitRequests");

            migrationBuilder.DropColumn(
                name: "TenID",
                table: "VisitRequests");

            migrationBuilder.DropColumn(
                name: "Votes",
                table: "Circulations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "VisitRequests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "VisitRequests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "VisitRequests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenID",
                table: "VisitRequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Votes",
                table: "Circulations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    R_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SectionId = table.Column<int>(nullable: false),
                    Vote = table.Column<int>(nullable: false),
                    active = table.Column<bool>(nullable: false),
                    c_Id = table.Column<int>(nullable: false),
                    temail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.R_Id);
                });
        }
    }
}
