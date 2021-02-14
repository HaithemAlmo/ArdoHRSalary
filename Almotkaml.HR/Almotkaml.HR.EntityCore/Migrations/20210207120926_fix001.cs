using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Almotkaml.HR.EntityCore.Migrations
{
    public partial class fix001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Alimony",
                table: "SalaryInfos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "CourtId",
                table: "SalaryInfos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Courts",
                columns: table => new
                {
                    CourtId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourtName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courts", x => x.CourtId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalaryInfos_CourtId",
                table: "SalaryInfos",
                column: "CourtId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryInfos_Courts_CourtId",
                table: "SalaryInfos",
                column: "CourtId",
                principalTable: "Courts",
                principalColumn: "CourtId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaryInfos_Courts_CourtId",
                table: "SalaryInfos");

            migrationBuilder.DropTable(
                name: "Courts");

            migrationBuilder.DropIndex(
                name: "IX_SalaryInfos_CourtId",
                table: "SalaryInfos");

            migrationBuilder.DropColumn(
                name: "Alimony",
                table: "SalaryInfos");

            migrationBuilder.DropColumn(
                name: "CourtId",
                table: "SalaryInfos");
        }
    }
}
