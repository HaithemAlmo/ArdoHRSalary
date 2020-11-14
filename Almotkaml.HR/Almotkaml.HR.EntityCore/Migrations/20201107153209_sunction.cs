﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Almotkaml.HR.EntityCore.Migrations
{
    public partial class sunction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeaderSalaryHeadDepartment_11To15",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "LeaderSalaryHeadDepartment_16To20",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "LeaderSalaryHeadDepartment_1To5",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "LeaderSalaryHeadDepartment_6To10",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "LeaderSalaryHeadDepartment_UpTo21",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "LeaderSalaryOfficeHeads_11To15",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "LeaderSalaryOfficeHeads_16To20",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "LeaderSalaryOfficeHeads_1To5",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "LeaderSalaryOfficeHeads_6To10",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "LeaderSalaryOfficeHeads_UpTo21",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "PremiumValue1",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "PremiumValue2",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "PremiumValue3",
                table: "SalaryUnits");

            migrationBuilder.DropColumn(
                name: "PremiumValue4",
                table: "SalaryUnits");

            migrationBuilder.AddColumn<int>(
                name: "DeductionMonth",
                table: "Sanctions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeductionMonth",
                table: "Sanctions");

            migrationBuilder.AddColumn<decimal>(
                name: "LeaderSalaryHeadDepartment_11To15",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaderSalaryHeadDepartment_16To20",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaderSalaryHeadDepartment_1To5",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaderSalaryHeadDepartment_6To10",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaderSalaryHeadDepartment_UpTo21",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaderSalaryOfficeHeads_11To15",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaderSalaryOfficeHeads_16To20",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaderSalaryOfficeHeads_1To5",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaderSalaryOfficeHeads_6To10",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaderSalaryOfficeHeads_UpTo21",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumValue1",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumValue2",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumValue3",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumValue4",
                table: "SalaryUnits",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
