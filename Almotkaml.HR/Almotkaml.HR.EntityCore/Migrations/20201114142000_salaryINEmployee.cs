using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Almotkaml.HR.EntityCore.Migrations
{
    public partial class salaryINEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Differences",
                table: "SalaryInfos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "SalaryId",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SalaryId",
                table: "Employees",
                column: "SalaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Salaries_SalaryId",
                table: "Employees",
                column: "SalaryId",
                principalTable: "Salaries",
                principalColumn: "SalaryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Salaries_SalaryId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SalaryId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Differences",
                table: "SalaryInfos");

            migrationBuilder.DropColumn(
                name: "SalaryId",
                table: "Employees");
        }
    }
}
