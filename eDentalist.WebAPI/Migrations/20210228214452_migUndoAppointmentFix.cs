using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentalist.WebAPI.Migrations
{
    public partial class migUndoAppointmentFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_UserWorkday_UserWorkdayID",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "UserWorkdayID",
                table: "Appointment",
                newName: "DentistID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_UserWorkdayID",
                table: "Appointment",
                newName: "IX_Appointment_DentistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_User_DentistID",
                table: "Appointment",
                column: "DentistID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_User_DentistID",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "DentistID",
                table: "Appointment",
                newName: "UserWorkdayID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_DentistID",
                table: "Appointment",
                newName: "IX_Appointment_UserWorkdayID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_UserWorkday_UserWorkdayID",
                table: "Appointment",
                column: "UserWorkdayID",
                principalTable: "UserWorkday",
                principalColumn: "UserWorkdayID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
