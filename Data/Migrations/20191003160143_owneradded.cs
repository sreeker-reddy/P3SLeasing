using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentQuest.Data.Migrations
{
    public partial class owneradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    H_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HName = table.Column<string>(maxLength: 10, nullable: false),
                    HPwd = table.Column<string>(nullable: false),
                    HRePwd = table.Column<string>(nullable: true),
                    HEmail = table.Column<string>(nullable: false),
                    HPhone = table.Column<string>(maxLength: 15, nullable: false),
                    HGender = table.Column<string>(nullable: false),
                    HDOB = table.Column<DateTime>(nullable: false),
                    HImg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.H_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
