using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JBank.Migrations
{
    public partial class AddedalltoDBSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Users_UserNumber",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Loan_Users_UserNumber",
                table: "Loan");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Account_AccountNumber",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loan",
                table: "Loan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transactions");

            migrationBuilder.RenameTable(
                name: "Loan",
                newName: "Loans");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "Accounts");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_AccountNumber",
                table: "Transactions",
                newName: "IX_Transactions_AccountNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Loan_UserNumber",
                table: "Loans",
                newName: "IX_Loans_UserNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Account_UserNumber",
                table: "Accounts",
                newName: "IX_Accounts_UserNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "TransactionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loans",
                table: "Loans",
                column: "LoanNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "AccountNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_UserNumber",
                table: "Accounts",
                column: "UserNumber",
                principalTable: "Users",
                principalColumn: "UserNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Users_UserNumber",
                table: "Loans",
                column: "UserNumber",
                principalTable: "Users",
                principalColumn: "UserNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_AccountNumber",
                table: "Transactions",
                column: "AccountNumber",
                principalTable: "Accounts",
                principalColumn: "AccountNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_UserNumber",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Users_UserNumber",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_AccountNumber",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loans",
                table: "Loans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaction");

            migrationBuilder.RenameTable(
                name: "Loans",
                newName: "Loan");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "Account");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_AccountNumber",
                table: "Transaction",
                newName: "IX_Transaction_AccountNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_UserNumber",
                table: "Loan",
                newName: "IX_Loan_UserNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_UserNumber",
                table: "Account",
                newName: "IX_Account_UserNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "TransactionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loan",
                table: "Loan",
                column: "LoanNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "AccountNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Users_UserNumber",
                table: "Account",
                column: "UserNumber",
                principalTable: "Users",
                principalColumn: "UserNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_Users_UserNumber",
                table: "Loan",
                column: "UserNumber",
                principalTable: "Users",
                principalColumn: "UserNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Account_AccountNumber",
                table: "Transaction",
                column: "AccountNumber",
                principalTable: "Account",
                principalColumn: "AccountNumber");
        }
    }
}
