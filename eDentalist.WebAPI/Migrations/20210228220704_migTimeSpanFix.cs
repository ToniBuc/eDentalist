using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentalist.WebAPI.Migrations
{
    public partial class migTimeSpanFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "To",
                table: "Shift",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "From",
                table: "Shift",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            //migrationBuilder.AlterColumn<TimeSpan>(
            //    name: "Duration",
            //    table: "Procedure",
            //    type: "time",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "To",
                table: "Appointment",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "From",
                table: "Appointment",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "To",
                table: "Shift",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "From",
                table: "Shift",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Duration",
            //    table: "Procedure",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(TimeSpan),
            //    oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "To",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "From",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }
    }
}
