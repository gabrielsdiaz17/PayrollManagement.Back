using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollManagement.Back.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class EntryHourAndExitHourCostCenter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "EntryHourCC",
                table: "CostCenter",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ExitHourCC",
                table: "CostCenter",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntryHourCC",
                table: "CostCenter");

            migrationBuilder.DropColumn(
                name: "ExitHourCC",
                table: "CostCenter");
        }
    }
}
