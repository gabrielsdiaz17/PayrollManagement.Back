using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PayrollManagement.Back.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class AddScheduleParametrization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_CostCenterId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CostCenter");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EntryHourCCSaturday",
                table: "CostCenter",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ExitHourCCSaturday",
                table: "CostCenter",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.CreateTable(
                name: "ScheduleParametrization",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    WeekWorkingHours = table.Column<double>(type: "double precision", nullable: false),
                    MonthlyWorkingHours = table.Column<double>(type: "double precision", nullable: false),
                    ChargeOvertimeDaily = table.Column<double>(type: "double precision", nullable: false),
                    ChargeOvertimeNightly = table.Column<double>(type: "double precision", nullable: false),
                    ChargeOvertimeHolidayDaily = table.Column<double>(type: "double precision", nullable: false),
                    ChargeOvertimeHolidayNightly = table.Column<double>(type: "double precision", nullable: false),
                    StartNightlyCharge = table.Column<TimeSpan>(type: "interval", nullable: false),
                    EndNightlyCharge = table.Column<TimeSpan>(type: "interval", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleParametrization", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_CostCenterId",
                table: "User",
                column: "CostCenterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleParametrization");

            migrationBuilder.DropIndex(
                name: "IX_User_CostCenterId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "EntryHourCCSaturday",
                table: "CostCenter");

            migrationBuilder.DropColumn(
                name: "ExitHourCCSaturday",
                table: "CostCenter");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "CostCenter",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_CostCenterId",
                table: "User",
                column: "CostCenterId",
                unique: true);
        }
    }
}
