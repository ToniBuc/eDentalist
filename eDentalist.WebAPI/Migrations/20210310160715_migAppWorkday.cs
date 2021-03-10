using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentalist.WebAPI.Migrations
{
    public partial class migAppWorkday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Appointment");

            migrationBuilder.AddColumn<int>(
                name: "WorkdayID",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_WorkdayID",
                table: "Appointment",
                column: "WorkdayID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Workday_WorkdayID",
                table: "Appointment",
                column: "WorkdayID",
                principalTable: "Workday",
                principalColumn: "WorkdayID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Workday_WorkdayID",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_WorkdayID",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "WorkdayID",
                table: "Appointment");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
