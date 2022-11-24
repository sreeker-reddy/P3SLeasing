using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentQuest.Data.Migrations
{
    public partial class addedVisReqAndReqDetailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MRent",
                table: "Circulations",
                newName: "Monthly_Rent");

            migrationBuilder.RenameColumn(
                name: "CircColor",
                table: "Circulations",
                newName: "Location");

            migrationBuilder.CreateTable(
                name: "VisitRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReqNo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    PhoneNo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    ReqDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReqDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReqId = table.Column<int>(nullable: false),
                    C_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReqDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReqDetails_Circulations_C_Id",
                        column: x => x.C_Id,
                        principalTable: "Circulations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReqDetails_VisitRequests_ReqId",
                        column: x => x.ReqId,
                        principalTable: "VisitRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReqDetails_C_Id",
                table: "ReqDetails",
                column: "C_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ReqDetails_ReqId",
                table: "ReqDetails",
                column: "ReqId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReqDetails");

            migrationBuilder.DropTable(
                name: "VisitRequests");

            migrationBuilder.RenameColumn(
                name: "Monthly_Rent",
                table: "Circulations",
                newName: "MRent");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Circulations",
                newName: "CircColor");
        }
    }
}
