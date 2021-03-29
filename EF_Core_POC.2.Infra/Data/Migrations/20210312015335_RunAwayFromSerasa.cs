using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_POC._2.Infra.Data.Migrations
{
    public partial class RunAwayFromSerasa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Accounts",
                table => new
                {
                    Guid = table.Column<byte[]>("varbinary(16)", nullable: false),
                    Owner = table.Column<string>("text", nullable: false),
                    Balance = table.Column<long>("bigint", nullable: false, defaultValue: 0L),
                    CreatedAt = table.Column<DateTime>("datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>("datetime", nullable: false),
                    Deleted = table.Column<bool>("tinyint(1)", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Accounts", x => x.Guid); });

            migrationBuilder.CreateTable(
                "Transactions",
                table => new
                {
                    Guid = table.Column<byte[]>("varbinary(16)", nullable: false),
                    AccountId = table.Column<byte[]>("varbinary(16)", nullable: false),
                    Amount = table.Column<long>("bigint", nullable: false),
                    Type = table.Column<int>("int", nullable: false),
                    IsPlanned = table.Column<bool>("tinyint(1)", nullable: true),
                    CreatedAt = table.Column<DateTime>("datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>("datetime", nullable: false),
                    Deleted = table.Column<bool>("tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Guid);
                    table.ForeignKey(
                        "FK_Transactions_Accounts_AccountId",
                        x => x.AccountId,
                        "Accounts",
                        "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_Transactions_AccountId",
                "Transactions",
                "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Transactions");

            migrationBuilder.DropTable(
                "Accounts");
        }
    }
}