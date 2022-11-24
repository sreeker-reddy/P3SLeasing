using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentQuest.Data.Migrations
{
    public partial class final1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TID",
                table: "VisitRequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TenantClass",
                columns: table => new
                {
                    TID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TName = table.Column<string>(maxLength: 10, nullable: false),
                    TPwd = table.Column<string>(nullable: false),
                    TRePwd = table.Column<string>(nullable: false),
                    TEmail = table.Column<string>(nullable: false),
                    TPhone = table.Column<string>(maxLength: 15, nullable: false),
                    TGender = table.Column<string>(nullable: false),
                    TDOB = table.Column<DateTime>(nullable: false),
                    TImg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantClass", x => x.TID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisitRequests_TID",
                table: "VisitRequests",
                column: "TID");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRequests_TenantClass_TID",
                table: "VisitRequests",
                column: "TID",
                principalTable: "TenantClass",
                principalColumn: "TID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitRequests_TenantClass_TID",
                table: "VisitRequests");

            migrationBuilder.DropTable(
                name: "TenantClass");

            migrationBuilder.DropIndex(
                name: "IX_VisitRequests_TID",
                table: "VisitRequests");

            migrationBuilder.DropColumn(
                name: "TID",
                table: "VisitRequests");
        }
    }
}
