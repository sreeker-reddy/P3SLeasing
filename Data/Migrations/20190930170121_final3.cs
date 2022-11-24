using Microsoft.EntityFrameworkCore.Migrations;

namespace RentQuest.Data.Migrations
{
    public partial class final3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitRequests_TenantClass_TID",
                table: "VisitRequests");

            migrationBuilder.RenameColumn(
                name: "TID",
                table: "VisitRequests",
                newName: "TenID");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRequests_TID",
                table: "VisitRequests",
                newName: "IX_VisitRequests_TenID");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRequests_TenantClass_TenID",
                table: "VisitRequests",
                column: "TenID",
                principalTable: "TenantClass",
                principalColumn: "TID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitRequests_TenantClass_TenID",
                table: "VisitRequests");

            migrationBuilder.RenameColumn(
                name: "TenID",
                table: "VisitRequests",
                newName: "TID");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRequests_TenID",
                table: "VisitRequests",
                newName: "IX_VisitRequests_TID");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRequests_TenantClass_TID",
                table: "VisitRequests",
                column: "TID",
                principalTable: "TenantClass",
                principalColumn: "TID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
