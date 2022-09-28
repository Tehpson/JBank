using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JBank.Migrations
{
    public partial class ChangeaccountnumbertobestringandaddedareaCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaCode",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "Transactions",
                type: "nvarchar(12)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "Accounts",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,0)",
                oldMaxLength: 12)
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaCode",
                table: "Users");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccountNumber",
                table: "Transactions",
                type: "decimal(20,0)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AccountNumber",
                table: "Accounts",
                type: "decimal(20,0)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12)
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
