using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JBank.Migrations
{
    public partial class UserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserNumber = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbleToTakeLoan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserNumber);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    UserNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountNumber);
                    table.ForeignKey(
                        name: "FK_Account_Users_UserNumber",
                        column: x => x.UserNumber,
                        principalTable: "Users",
                        principalColumn: "UserNumber");
                });

            migrationBuilder.CreateTable(
                name: "Loan",
                columns: table => new
                {
                    LoanNumber = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountLoaned = table.Column<double>(type: "float", nullable: false),
                    AmountPayedBack = table.Column<double>(type: "float", nullable: false),
                    Rent = table.Column<double>(type: "float", nullable: false),
                    LeftToPay = table.Column<double>(type: "float", nullable: false),
                    UserNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.LoanNumber);
                    table.ForeignKey(
                        name: "FK_Loan_Users_UserNumber",
                        column: x => x.UserNumber,
                        principalTable: "Users",
                        principalColumn: "UserNumber");
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromAccount = table.Column<int>(type: "int", nullable: false),
                    ToAccount = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transaction_Account_AccountNumber",
                        column: x => x.AccountNumber,
                        principalTable: "Account",
                        principalColumn: "AccountNumber");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_UserNumber",
                table: "Account",
                column: "UserNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_UserNumber",
                table: "Loan",
                column: "UserNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_AccountNumber",
                table: "Transaction",
                column: "AccountNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loan");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
