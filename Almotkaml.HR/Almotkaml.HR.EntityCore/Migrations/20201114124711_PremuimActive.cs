using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Almotkaml.HR.EntityCore.Migrations
{
    public partial class PremuimActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PremiumActive",
                table: "SalaryInfos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "PremiumIsActive",
                table: "SalaryInfos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Differences",
                table: "Salaries",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumActive",
                table: "Salaries",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PremiumActive",
                table: "SalaryInfos");

            migrationBuilder.DropColumn(
                name: "PremiumIsActive",
                table: "SalaryInfos");

            migrationBuilder.DropColumn(
                name: "Differences",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "PremiumActive",
                table: "Salaries");
        }
    }
}
