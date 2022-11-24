using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentQuest.Data.Migrations
{
    public partial class firstone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitRequests_TenantClass_TenID",
                table: "VisitRequests");

            migrationBuilder.DropTable(
                name: "TenantClass");

            migrationBuilder.DropIndex(
                name: "IX_VisitRequests_TenID",
                table: "VisitRequests");

            migrationBuilder.DropColumn(
                name: "TenID",
                table: "VisitRequests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenID",
                table: "VisitRequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TenantClass",
                columns: table => new
                {
                    TID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TDOB = table.Column<DateTime>(nullable: false),
                    TEmail = table.Column<string>(nullable: false),
                    TGender = table.Column<string>(nullable: false),
                    TImg = table.Column<string>(nullable: true),
                    TName = table.Column<string>(maxLength: 10, nullable: false),
                    TPhone = table.Column<string>(maxLength: 15, nullable: false),
                    TPwd = table.Column<string>(nullable: false),
                    TRePwd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantClass", x => x.TID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisitRequests_TenID",
                table: "VisitRequests",
                column: "TenID");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRequests_TenantClass_TenID",
                table: "VisitRequests",
                column: "TenID",
                principalTable: "TenantClass",
                principalColumn: "TID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
