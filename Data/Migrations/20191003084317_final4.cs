using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentQuest.Data.Migrations
{
    public partial class final4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tenants",
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
                    table.PrimaryKey("PK_Tenants", x => x.TID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tenants");
        }
    }
}
