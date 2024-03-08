using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollManagement.Back.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class AddProcessedFileToNovelties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DaysPayment",
                table: "PayrollType",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<bool>(
                name: "ProcessedInFile",
                table: "PayrollNovelty",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcessedInFile",
                table: "PayrollNovelty");

            migrationBuilder.AlterColumn<int>(
                name: "DaysPayment",
                table: "PayrollType",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
