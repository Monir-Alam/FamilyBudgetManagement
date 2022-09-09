using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyBudget.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerHeadExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Father = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Mother = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sister = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brother = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Wife = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Children = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthlyEarning = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    PersonInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerHeadExpenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerHeadExpenses_Months_MonthId",
                        column: x => x.MonthId,
                        principalTable: "Months",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerHeadExpenses_PersonInfos_PersonInfoId",
                        column: x => x.PersonInfoId,
                        principalTable: "PersonInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerHeadExpenses_MonthId",
                table: "PerHeadExpenses",
                column: "MonthId");

            migrationBuilder.CreateIndex(
                name: "IX_PerHeadExpenses_PersonInfoId",
                table: "PerHeadExpenses",
                column: "PersonInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerHeadExpenses");

            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropTable(
                name: "PersonInfos");
        }
    }
}
