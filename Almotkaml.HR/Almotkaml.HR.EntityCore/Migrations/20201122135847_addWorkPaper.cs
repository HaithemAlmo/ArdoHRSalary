using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Almotkaml.HR.EntityCore.Migrations
{
    public partial class addWorkPaper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkTimePapers",
                columns: table => new
                {
                    WorkTimePaperId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DayWork = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    Friday = table.Column<bool>(nullable: false),
                    Monday = table.Column<bool>(nullable: false),
                    Saturday = table.Column<bool>(nullable: false),
                    Sunday = table.Column<bool>(nullable: false),
                    ThisMonth = table.Column<int>(nullable: false),
                    ThisYear = table.Column<int>(nullable: false),
                    Thursday = table.Column<bool>(nullable: false),
                    Tuesday = table.Column<bool>(nullable: false),
                    Wednesday = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTimePapers", x => x.WorkTimePaperId);
                    table.ForeignKey(
                        name: "FK_WorkTimePapers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimePapers_EmployeeId",
                table: "WorkTimePapers",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkTimePapers");
        }
    }
}
