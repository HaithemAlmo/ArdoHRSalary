using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Almotkaml.HR.EntityCore.Migrations
{
    public partial class AddClipboardBanking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClipboardBankings",
                columns: table => new
                {
                    ClipboardBankingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BankBranchID = table.Column<int>(nullable: false),
                    InstrumentNumber = table.Column<string>(nullable: true),
                    IsDelivered = table.Column<bool>(nullable: false),
                    SalaryMonth = table.Column<DateTime>(nullable: false),
                    TotalSalaries = table.Column<decimal>(nullable: false),
                    _CreatedBy = table.Column<int>(nullable: false),
                    _DateCreated = table.Column<DateTime>(nullable: false),
                    _DateModified = table.Column<DateTime>(nullable: false),
                    _ModifiedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClipboardBankings", x => x.ClipboardBankingId);
                    table.ForeignKey(
                        name: "FK_ClipboardBankings_BankBranches_BankBranchID",
                        column: x => x.BankBranchID,
                        principalTable: "BankBranches",
                        principalColumn: "BankBranchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClipboardBankings_BankBranchID",
                table: "ClipboardBankings",
                column: "BankBranchID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClipboardBankings");
        }
    }
}
