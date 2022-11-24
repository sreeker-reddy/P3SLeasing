using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentQuest.Data.Migrations
{
    public partial class addcirculationmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Circulations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    MRent = table.Column<decimal>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    CircColor = table.Column<string>(nullable: true),
                    isAvailable = table.Column<bool>(nullable: false),
                    CircTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circulations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Circulations_CircTypes_CircTypeId",
                        column: x => x.CircTypeId,
                        principalTable: "CircTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Circulations_CircTypeId",
                table: "Circulations",
                column: "CircTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Circulations");
        }
    }
}
